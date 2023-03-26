namespace GroupBox_Kontrollü_Uygulama
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
            gbİslemciler = new GroupBox();
            rbCpuR3 = new RadioButton();
            rbCpuR5 = new RadioButton();
            rbCpuI3 = new RadioButton();
            rbCpuI5 = new RadioButton();
            rbCpuI7 = new RadioButton();
            gbRambellek = new GroupBox();
            rbRam4 = new RadioButton();
            rbRam8 = new RadioButton();
            rbRam16 = new RadioButton();
            gbSabitDisk = new GroupBox();
            rbHdd320 = new RadioButton();
            rbHdd500 = new RadioButton();
            rbHdd1000 = new RadioButton();
            gbEkDonanımlar = new GroupBox();
            cbWifi = new CheckBox();
            cbWebCam = new CheckBox();
            cbDvd = new CheckBox();
            btnHesapla = new Button();
            label1 = new Label();
            btnPcTopla = new Button();
            gbİslemciler.SuspendLayout();
            gbRambellek.SuspendLayout();
            gbSabitDisk.SuspendLayout();
            gbEkDonanımlar.SuspendLayout();
            SuspendLayout();
            // 
            // gbİslemciler
            // 
            gbİslemciler.Controls.Add(rbCpuR3);
            gbİslemciler.Controls.Add(rbCpuR5);
            gbİslemciler.Controls.Add(rbCpuI3);
            gbİslemciler.Controls.Add(rbCpuI5);
            gbİslemciler.Controls.Add(rbCpuI7);
            gbİslemciler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbİslemciler.Location = new Point(12, 12);
            gbİslemciler.Name = "gbİslemciler";
            gbİslemciler.Size = new Size(177, 225);
            gbİslemciler.TabIndex = 0;
            gbİslemciler.TabStop = false;
            gbİslemciler.Text = "İşlemciler";
            // 
            // rbCpuR3
            // 
            rbCpuR3.AutoSize = true;
            rbCpuR3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCpuR3.Location = new Point(6, 161);
            rbCpuR3.Name = "rbCpuR3";
            rbCpuR3.Size = new Size(132, 27);
            rbCpuR3.TabIndex = 0;
            rbCpuR3.TabStop = true;
            rbCpuR3.Text = "AMD Ryzen 3";
            rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            rbCpuR5.AutoSize = true;
            rbCpuR5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCpuR5.Location = new Point(6, 128);
            rbCpuR5.Name = "rbCpuR5";
            rbCpuR5.Size = new Size(132, 27);
            rbCpuR5.TabIndex = 0;
            rbCpuR5.TabStop = true;
            rbCpuR5.Text = "AMD Ryzen 5";
            rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI3
            // 
            rbCpuI3.AutoSize = true;
            rbCpuI3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCpuI3.Location = new Point(6, 95);
            rbCpuI3.Name = "rbCpuI3";
            rbCpuI3.Size = new Size(124, 27);
            rbCpuI3.TabIndex = 0;
            rbCpuI3.TabStop = true;
            rbCpuI3.Text = "Intel Core I3";
            rbCpuI3.UseVisualStyleBackColor = true;
            // 
            // rbCpuI5
            // 
            rbCpuI5.AutoSize = true;
            rbCpuI5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCpuI5.Location = new Point(6, 62);
            rbCpuI5.Name = "rbCpuI5";
            rbCpuI5.Size = new Size(124, 27);
            rbCpuI5.TabIndex = 0;
            rbCpuI5.TabStop = true;
            rbCpuI5.Text = "Intel Core I5";
            rbCpuI5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI7
            // 
            rbCpuI7.AutoSize = true;
            rbCpuI7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCpuI7.Location = new Point(6, 29);
            rbCpuI7.Name = "rbCpuI7";
            rbCpuI7.Size = new Size(125, 27);
            rbCpuI7.TabIndex = 0;
            rbCpuI7.TabStop = true;
            rbCpuI7.Text = "Intel Core I7";
            rbCpuI7.UseVisualStyleBackColor = true;
            // 
            // gbRambellek
            // 
            gbRambellek.Controls.Add(rbRam4);
            gbRambellek.Controls.Add(rbRam8);
            gbRambellek.Controls.Add(rbRam16);
            gbRambellek.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbRambellek.Location = new Point(195, 12);
            gbRambellek.Name = "gbRambellek";
            gbRambellek.Size = new Size(177, 225);
            gbRambellek.TabIndex = 0;
            gbRambellek.TabStop = false;
            gbRambellek.Text = "Ram Bellek";
            // 
            // rbRam4
            // 
            rbRam4.AutoSize = true;
            rbRam4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbRam4.Location = new Point(6, 94);
            rbRam4.Name = "rbRam4";
            rbRam4.Size = new Size(68, 27);
            rbRam4.TabIndex = 0;
            rbRam4.TabStop = true;
            rbRam4.Text = "4 GB";
            rbRam4.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            rbRam8.AutoSize = true;
            rbRam8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbRam8.Location = new Point(6, 62);
            rbRam8.Name = "rbRam8";
            rbRam8.Size = new Size(67, 27);
            rbRam8.TabIndex = 0;
            rbRam8.TabStop = true;
            rbRam8.Text = "8 GB";
            rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            rbRam16.AutoSize = true;
            rbRam16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbRam16.Location = new Point(6, 29);
            rbRam16.Name = "rbRam16";
            rbRam16.Size = new Size(74, 27);
            rbRam16.TabIndex = 0;
            rbRam16.TabStop = true;
            rbRam16.Text = "16 GB";
            rbRam16.UseVisualStyleBackColor = true;
            // 
            // gbSabitDisk
            // 
            gbSabitDisk.Controls.Add(rbHdd320);
            gbSabitDisk.Controls.Add(rbHdd500);
            gbSabitDisk.Controls.Add(rbHdd1000);
            gbSabitDisk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbSabitDisk.Location = new Point(12, 245);
            gbSabitDisk.Name = "gbSabitDisk";
            gbSabitDisk.Size = new Size(177, 225);
            gbSabitDisk.TabIndex = 0;
            gbSabitDisk.TabStop = false;
            gbSabitDisk.Text = "Sabit Disk";
            // 
            // rbHdd320
            // 
            rbHdd320.AutoSize = true;
            rbHdd320.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHdd320.Location = new Point(6, 95);
            rbHdd320.Name = "rbHdd320";
            rbHdd320.Size = new Size(85, 27);
            rbHdd320.TabIndex = 0;
            rbHdd320.TabStop = true;
            rbHdd320.Text = "320 GB";
            rbHdd320.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            rbHdd500.AutoSize = true;
            rbHdd500.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHdd500.Location = new Point(6, 62);
            rbHdd500.Name = "rbHdd500";
            rbHdd500.Size = new Size(86, 27);
            rbHdd500.TabIndex = 0;
            rbHdd500.TabStop = true;
            rbHdd500.Text = "500 GB";
            rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd1000
            // 
            rbHdd1000.AutoSize = true;
            rbHdd1000.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHdd1000.Location = new Point(6, 29);
            rbHdd1000.Name = "rbHdd1000";
            rbHdd1000.Size = new Size(62, 27);
            rbHdd1000.TabIndex = 0;
            rbHdd1000.TabStop = true;
            rbHdd1000.Text = "1 TB";
            rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // gbEkDonanımlar
            // 
            gbEkDonanımlar.Controls.Add(cbWifi);
            gbEkDonanımlar.Controls.Add(cbWebCam);
            gbEkDonanımlar.Controls.Add(cbDvd);
            gbEkDonanımlar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbEkDonanımlar.Location = new Point(195, 245);
            gbEkDonanımlar.Name = "gbEkDonanımlar";
            gbEkDonanımlar.Size = new Size(177, 225);
            gbEkDonanımlar.TabIndex = 0;
            gbEkDonanımlar.TabStop = false;
            gbEkDonanımlar.Text = "Ek Donanımlar";
            // 
            // cbWifi
            // 
            cbWifi.AutoSize = true;
            cbWifi.Location = new Point(6, 95);
            cbWifi.Name = "cbWifi";
            cbWifi.Size = new Size(137, 27);
            cbWifi.TabIndex = 0;
            cbWifi.Text = "Wireless Kart";
            cbWifi.UseVisualStyleBackColor = true;
            // 
            // cbWebCam
            // 
            cbWebCam.AutoSize = true;
            cbWebCam.Location = new Point(6, 62);
            cbWebCam.Name = "cbWebCam";
            cbWebCam.Size = new Size(110, 27);
            cbWebCam.TabIndex = 0;
            cbWebCam.Text = "Web Cam";
            cbWebCam.UseVisualStyleBackColor = true;
            // 
            // cbDvd
            // 
            cbDvd.AutoSize = true;
            cbDvd.Location = new Point(6, 30);
            cbDvd.Name = "cbDvd";
            cbDvd.Size = new Size(102, 27);
            cbDvd.TabIndex = 0;
            cbDvd.Text = "DVD RW";
            cbDvd.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = SystemColors.ActiveCaption;
            btnHesapla.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.Location = new Point(378, 198);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(154, 51);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(556, 212);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 2;
            label1.Text = "Sonuç";
            // 
            // btnPcTopla
            // 
            btnPcTopla.BackColor = SystemColors.ActiveCaption;
            btnPcTopla.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPcTopla.Location = new Point(378, 257);
            btnPcTopla.Name = "btnPcTopla";
            btnPcTopla.Size = new Size(154, 52);
            btnPcTopla.TabIndex = 3;
            btnPcTopla.Text = "PC Topla";
            btnPcTopla.UseVisualStyleBackColor = false;
            btnPcTopla.Click += btnPcTopla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(827, 517);
            Controls.Add(btnPcTopla);
            Controls.Add(label1);
            Controls.Add(btnHesapla);
            Controls.Add(gbEkDonanımlar);
            Controls.Add(gbSabitDisk);
            Controls.Add(gbRambellek);
            Controls.Add(gbİslemciler);
            Name = "Form1";
            Text = "PC TOPLAMA";
            gbİslemciler.ResumeLayout(false);
            gbİslemciler.PerformLayout();
            gbRambellek.ResumeLayout(false);
            gbRambellek.PerformLayout();
            gbSabitDisk.ResumeLayout(false);
            gbSabitDisk.PerformLayout();
            gbEkDonanımlar.ResumeLayout(false);
            gbEkDonanımlar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbİslemciler;
        private RadioButton rbCpuR3;
        private RadioButton rbCpuR5;
        private RadioButton rbCpuI3;
        private RadioButton rbCpuI5;
        private RadioButton rbCpuI7;
        private GroupBox gbRambellek;
        private RadioButton rbRam4;
        private RadioButton rbRam8;
        private RadioButton rbRam16;
        private GroupBox gbSabitDisk;
        private RadioButton rbHdd320;
        private RadioButton rbHdd500;
        private RadioButton rbHdd1000;
        private GroupBox gbEkDonanımlar;
        private CheckBox cbWifi;
        private CheckBox cbWebCam;
        private CheckBox cbDvd;
        private Button btnHesapla;
        private Label label1;
        private Button btnPcTopla;
    }
}