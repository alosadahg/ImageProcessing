using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;
using HNUDIP;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        string path;
        Bitmap loaded;
        Bitmap background;
        Bitmap processed;
        Bitmap colorgreen;
        Boolean isCamera;
        Device selectedDevice;
        Device[] devices;
        public Form1()
        {
            InitializeComponent();
            lblCamera.Visible = false;
            cbCameraOpts.Visible = false;
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            if(selectedDevice!=null)
            selectedDevice.Stop();
            lblCamera.Visible = false;
            cbCameraOpts.Visible = false;
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            try
            {
                path = open.FileName;
                if (path != null)
                {
                    loaded = new Bitmap(path);
                    setImage(loaded, pbInput);
                    processed = new Bitmap(loaded.Width, loaded.Height);
                    btnBackground.Enabled = true;
                    btnCopy.Enabled = true;
                    btnGreyscale.Enabled = true;
                    btnHistogram.Enabled = true;
                    btnSepia.Enabled = true;
                    btnInvert.Enabled = true;
                }
                isCamera = false;
            }
            catch
            {
                MessageBox.Show("No image uploaded.", "Image not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }
            setImage(processed, pbOutput);
        }

        private void btnGreyscale_Click(object sender, EventArgs e)
        {
            processed = getGreyscale(loaded);
            setImage(processed, pbOutput);
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;
                    processed.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            setImage(processed, pbOutput);
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            processed = getGreyscale(processed);
            int[] histData = new int[256];
            for (int x = 0; x < processed.Width; x++)
            {
                for (int y = 0; y < processed.Height; y++)
                {
                    Color sample = processed.GetPixel(x, y);
                    histData[sample.R]++;
                }
            }
            int h = processed.Height;
            Bitmap histograph = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    histograph.SetPixel(x, y, Color.White);
                }
            }
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 10, 800); y++)
                {
                    histograph.SetPixel(x, 799 - y, Color.Black);
                }
            }
            pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOutput.Image = histograph;
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    int newR = Math.Min((int)(0.393 * (pixel.R) + 0.769 * (pixel.G) + 0.189 * (pixel.B)), 255);
                    int newG = Math.Min((int)(0.349 * (pixel.R) + 0.686 * (pixel.G) + 0.168 * (pixel.B)), 255);
                    int newB = Math.Min((int)(0.272 * (pixel.R) + 0.534 * (pixel.G) + 0.131 * (pixel.B)), 255);
                    processed.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }
            setImage(processed, pbOutput);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // ImageProcess.Subtract(ref loaded, ref background, ref processed, 100);
            Color mygreen = loaded.GetPixel(0,0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    Color backpixel = background.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue > threshold)
                    {
                        processed.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        processed.SetPixel(x, y, backpixel);
                    }
                }
            }
            setImage(processed, pbOutput);
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            try
            {
                path = open.FileName;
                if (path != null)
                {
                    background = new Bitmap(path);
                    setImage(background, pbBackground);
                    btnSubtract.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("No image uploaded.", "Image not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            try
            {
                path = save.FileName;
                if (path != null)
                    processed.Save(path);
            }
            catch
            {
                MessageBox.Show("Image not saved.", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private Bitmap getGreyscale(Bitmap source)
        {
            Color pixel;
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    int grey = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    processed.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            return processed;
        }

        private void setImage(Bitmap processed, PictureBox pb)
        {
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = processed;
        }

        private void pbOutput_Paint(object sender, PaintEventArgs e)
        {
            if (pbOutput.Image != null)
                btnSave.Enabled = true;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            lblCamera.Visible = true;
            cbCameraOpts.Visible = true;
            devices = DeviceManager.GetAllDevices();
            if(devices.Length > 0)
            {
                selectedDevice = DeviceManager.GetDevice(0);
                selectedDevice.ShowWindow(pbInput);
            }
            
        }

      /*  private void timer1_Tick(object sender, EventArgs e)
        {            
            
        }*/

        private void cbCameraOpts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDevice = DeviceManager.GetDevice(cbCameraOpts.SelectedIndex);
            selectedDevice.Init(pbInput.Height, pbInput.Width, pbInput.Handle.ToInt32());
            timer1.Enabled = true;
            btnBackground.Enabled = true;
        }
    }
}
