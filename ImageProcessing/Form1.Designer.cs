namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCopy = new Button();
            btnInvert = new Button();
            label2 = new Label();
            btnHistogram = new Button();
            btnGreyscale = new Button();
            btnSepia = new Button();
            btnSubtract = new Button();
            btnCamera = new Button();
            btnUploadImg = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
<<<<<<< HEAD
            cbVideoSrc = new ComboBox();
=======
            cbCameraOpts = new ComboBox();
>>>>>>> 9b84581eadb7aa2a8be1599ac0d8c8ccd6c5f6e6
            lblCamera = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            pbInput = new PictureBox();
            pbOutput = new PictureBox();
            btnBackground = new Button();
            pbBackground = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label7 = new Label();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 240);
            label3.Name = "label3";
            label3.Size = new Size(237, 21);
            label3.TabIndex = 6;
            label3.Text = "Subtraction Background Image";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnCopy, 0, 1);
            tableLayoutPanel4.Controls.Add(btnInvert, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(btnHistogram, 1, 2);
            tableLayoutPanel4.Controls.Add(btnGreyscale, 1, 1);
            tableLayoutPanel4.Controls.Add(btnSepia, 0, 3);
            tableLayoutPanel4.Controls.Add(btnSubtract, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(579, 93);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 4);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222271F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(344, 388);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // btnCopy
            // 
            btnCopy.Dock = DockStyle.Fill;
            btnCopy.Enabled = false;
            btnCopy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(3, 33);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(166, 73);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnInvert
            // 
            btnInvert.Dock = DockStyle.Fill;
            btnInvert.Enabled = false;
            btnInvert.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvert.Location = new Point(3, 112);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(166, 73);
            btnInvert.TabIndex = 4;
            btnInvert.Text = "Invert";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(label2, 2);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 5;
            label2.Text = "Processing Options";
            // 
            // btnHistogram
            // 
            btnHistogram.Dock = DockStyle.Fill;
            btnHistogram.Enabled = false;
            btnHistogram.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistogram.Location = new Point(175, 112);
            btnHistogram.Name = "btnHistogram";
            btnHistogram.Size = new Size(166, 73);
            btnHistogram.TabIndex = 1;
            btnHistogram.Text = "Histogram";
            btnHistogram.UseVisualStyleBackColor = true;
            btnHistogram.Click += btnHistogram_Click;
            // 
            // btnGreyscale
            // 
            btnGreyscale.Dock = DockStyle.Fill;
            btnGreyscale.Enabled = false;
            btnGreyscale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGreyscale.Location = new Point(175, 33);
            btnGreyscale.Name = "btnGreyscale";
            btnGreyscale.Size = new Size(166, 73);
            btnGreyscale.TabIndex = 3;
            btnGreyscale.Text = "Greyscale";
            btnGreyscale.UseVisualStyleBackColor = true;
            btnGreyscale.Click += btnGreyscale_Click;
            // 
            // btnSepia
            // 
            btnSepia.Dock = DockStyle.Fill;
            btnSepia.Enabled = false;
            btnSepia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSepia.Location = new Point(3, 191);
            btnSepia.Name = "btnSepia";
            btnSepia.Size = new Size(166, 73);
            btnSepia.TabIndex = 6;
            btnSepia.Text = "Sepia";
            btnSepia.UseVisualStyleBackColor = true;
            btnSepia.Click += btnSepia_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Enabled = false;
            btnSubtract.Font = new Font("Segoe UI", 11.25F);
            btnSubtract.Location = new Point(175, 191);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(166, 73);
            btnSubtract.TabIndex = 14;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnCamera
            // 
            btnCamera.Dock = DockStyle.Fill;
            btnCamera.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCamera.Location = new Point(225, 3);
            btnCamera.Name = "btnCamera";
            btnCamera.Size = new Size(116, 49);
            btnCamera.TabIndex = 1;
            btnCamera.Text = "Use Camera";
            btnCamera.UseVisualStyleBackColor = true;
            btnCamera.Click += btnCamera_Click;
            // 
            // btnUploadImg
            // 
            btnUploadImg.Dock = DockStyle.Fill;
            btnUploadImg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadImg.Location = new Point(103, 3);
            btnUploadImg.Name = "btnUploadImg";
            btnUploadImg.Size = new Size(116, 49);
            btnUploadImg.TabIndex = 0;
            btnUploadImg.Text = "Upload image";
            btnUploadImg.UseVisualStyleBackColor = true;
            btnUploadImg.Click += btnUploadImg_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCamera, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnUploadImg, 1, 0);
<<<<<<< HEAD
            tableLayoutPanel2.Controls.Add(cbVideoSrc, 1, 1);
=======
            tableLayoutPanel2.Controls.Add(cbCameraOpts, 1, 1);
>>>>>>> 9b84581eadb7aa2a8be1599ac0d8c8ccd6c5f6e6
            tableLayoutPanel2.Controls.Add(lblCamera, 0, 1);
            tableLayoutPanel2.Location = new Point(579, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(344, 84);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "Source";
            // 
<<<<<<< HEAD
            // cbVideoSrc
            // 
            tableLayoutPanel2.SetColumnSpan(cbVideoSrc, 2);
            cbVideoSrc.Dock = DockStyle.Fill;
            cbVideoSrc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVideoSrc.FormattingEnabled = true;
            cbVideoSrc.Location = new Point(103, 58);
            cbVideoSrc.Name = "cbVideoSrc";
            cbVideoSrc.Size = new Size(238, 23);
            cbVideoSrc.TabIndex = 2;
            cbVideoSrc.SelectedIndexChanged += cbVideoSrc_SelectedIndexChanged;
=======
            // cbCameraOpts
            // 
            tableLayoutPanel2.SetColumnSpan(cbCameraOpts, 2);
            cbCameraOpts.Dock = DockStyle.Fill;
            cbCameraOpts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCameraOpts.FormattingEnabled = true;
            cbCameraOpts.Location = new Point(103, 58);
            cbCameraOpts.Name = "cbCameraOpts";
            cbCameraOpts.Size = new Size(238, 23);
            cbCameraOpts.TabIndex = 2;
            cbCameraOpts.SelectedIndexChanged += cbCameraOpts_SelectedIndexChanged;
>>>>>>> 9b84581eadb7aa2a8be1599ac0d8c8ccd6c5f6e6
            // 
            // lblCamera
            // 
            lblCamera.Anchor = AnchorStyles.Left;
            lblCamera.AutoSize = true;
            lblCamera.Font = new Font("Segoe UI", 11F);
            lblCamera.Location = new Point(3, 59);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(60, 20);
            lblCamera.TabIndex = 3;
            lblCamera.Text = "Camera";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82639F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17361F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(pbInput, 0, 1);
            tableLayoutPanel1.Controls.Add(pbOutput, 1, 1);
            tableLayoutPanel1.Controls.Add(btnBackground, 0, 5);
            tableLayoutPanel1.Controls.Add(pbBackground, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.1785736F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1071434F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tableLayoutPanel1.Size = new Size(926, 484);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(290, 447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(283, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save Output Image";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 11);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 7;
            label4.Text = "Input";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(400, 11);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 8;
            label5.Text = "Output";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbInput
            // 
            pbInput.BorderStyle = BorderStyle.FixedSingle;
            pbInput.Dock = DockStyle.Fill;
            pbInput.Location = new Point(3, 47);
            pbInput.Name = "pbInput";
            tableLayoutPanel1.SetRowSpan(pbInput, 2);
            pbInput.Size = new Size(281, 185);
            pbInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbInput.TabIndex = 9;
            pbInput.TabStop = false;
            // 
            // pbOutput
            // 
            pbOutput.BorderStyle = BorderStyle.FixedSingle;
            pbOutput.Dock = DockStyle.Fill;
            pbOutput.Location = new Point(290, 47);
            pbOutput.Name = "pbOutput";
            tableLayoutPanel1.SetRowSpan(pbOutput, 4);
            pbOutput.Size = new Size(283, 394);
            pbOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbOutput.TabIndex = 10;
            pbOutput.TabStop = false;
            pbOutput.Paint += pbOutput_Paint;
            // 
            // btnBackground
            // 
            btnBackground.Dock = DockStyle.Fill;
            btnBackground.Enabled = false;
            btnBackground.Font = new Font("Segoe UI", 12F);
            btnBackground.Location = new Point(3, 447);
            btnBackground.Name = "btnBackground";
            btnBackground.Size = new Size(281, 34);
            btnBackground.TabIndex = 0;
            btnBackground.Text = "Upload Background";
            btnBackground.UseVisualStyleBackColor = true;
            btnBackground.Click += btnBackground_Click;
            // 
            // pbBackground
            // 
            pbBackground.BorderStyle = BorderStyle.FixedSingle;
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Location = new Point(3, 269);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(281, 172);
            pbBackground.SizeMode = PictureBoxSizeMode.Zoom;
            pbBackground.TabIndex = 11;
            pbBackground.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel5.Controls.Add(button2, 2, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(button3, 1, 0);
            tableLayoutPanel5.Location = new Point(-123, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(321, 94);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(212, 3);
            button2.Name = "button2";
            button2.Size = new Size(99, 88);
            button2.TabIndex = 1;
            button2.Text = "Use Camera";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 36);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 1;
            label6.Text = "Source";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(94, 3);
            button3.Name = "button3";
            button3.Size = new Size(104, 88);
            button3.TabIndex = 0;
            button3.Text = "Upload  image";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(button4, 0, 6);
            tableLayoutPanel6.Controls.Add(button5, 0, 1);
            tableLayoutPanel6.Controls.Add(button6, 0, 2);
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(button7, 1, 2);
            tableLayoutPanel6.Controls.Add(button9, 1, 1);
            tableLayoutPanel6.Controls.Add(button10, 0, 3);
            tableLayoutPanel6.Controls.Add(button11, 1, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(-123, 84);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 7;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(321, 397);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel6.SetColumnSpan(button4, 2);
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(97, 358);
            button4.Name = "button4";
            button4.Size = new Size(127, 36);
            button4.TabIndex = 15;
            button4.Text = "Load Background";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 33);
            button5.Name = "button5";
            button5.Size = new Size(154, 43);
            button5.TabIndex = 2;
            button5.Text = "Copy";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(3, 82);
            button6.Name = "button6";
            button6.Size = new Size(154, 43);
            button6.TabIndex = 4;
            button6.Text = "Invert";
            button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            tableLayoutPanel6.SetColumnSpan(label7, 2);
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(151, 21);
            label7.TabIndex = 5;
            label7.Text = "Processing Options";
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(163, 82);
            button7.Name = "button7";
            button7.Size = new Size(155, 43);
            button7.TabIndex = 1;
            button7.Text = "Histogram";
            button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(163, 33);
            button9.Name = "button9";
            button9.Size = new Size(155, 43);
            button9.TabIndex = 3;
            button9.Text = "Greyscale";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(3, 131);
            button10.Name = "button10";
            button10.Size = new Size(154, 43);
            button10.TabIndex = 6;
            button10.Text = "Sepia";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Font = new Font("Segoe UI", 11.25F);
            button11.Location = new Point(163, 131);
            button11.Name = "button11";
            button11.Size = new Size(155, 43);
            button11.TabIndex = 14;
            button11.Text = "Subtract";
            button11.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 484);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "ImageProcessing";
            FormClosing += Form1_FormClosing;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCopy;
        private Button btnInvert;
        private Label label2;
        private Button btnHistogram;
        private Button btnGreyscale;
        private Button btnSepia;
        private Button btnCamera;
        private Button btnUploadImg;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label5;
        private PictureBox pbInput;
        private PictureBox pbOutput;
        private Button btnBackground;
        private PictureBox pbBackground;
        private Button btnSubtract;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button2;
        private Label label6;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label7;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
<<<<<<< HEAD
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbVideoSrc;
=======
        private ComboBox cbCameraOpts;
>>>>>>> 9b84581eadb7aa2a8be1599ac0d8c8ccd6c5f6e6
        private Label lblCamera;
    }
}
