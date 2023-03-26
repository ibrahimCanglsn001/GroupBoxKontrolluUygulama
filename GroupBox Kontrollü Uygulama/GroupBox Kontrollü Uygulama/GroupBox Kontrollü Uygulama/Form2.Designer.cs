namespace GroupBox_Kontrollü_Uygulama
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            geriDon = new Button();
            btnHesapla2 = new Button();
            gbMouse = new GroupBox();
            rbRazerMouse = new RadioButton();
            rbAsusMouse = new RadioButton();
            rbLogitechMouse = new RadioButton();
            gbKlavye = new GroupBox();
            rbAsusKlavye = new RadioButton();
            rbRazerKlavye = new RadioButton();
            rbLogitechKlavye = new RadioButton();
            gbMonitör = new GroupBox();
            rbHpMonitör = new RadioButton();
            rbMsıMonitör = new RadioButton();
            rbAsusMonitör = new RadioButton();
            gbAnaKart = new GroupBox();
            rbMiniAtx = new RadioButton();
            rbMicroAtx = new RadioButton();
            rbAtx = new RadioButton();
            groupBox1 = new GroupBox();
            rbThermaltake = new RadioButton();
            rbCollerMaster = new RadioButton();
            rbAdısson = new RadioButton();
            gbSesKartı = new GroupBox();
            rbPlatoonSesKartları = new RadioButton();
            rbKeeproSesKart = new RadioButton();
            rbMüzikResyonuseskartı = new RadioButton();
            gbMouse.SuspendLayout();
            gbKlavye.SuspendLayout();
            gbMonitör.SuspendLayout();
            gbAnaKart.SuspendLayout();
            groupBox1.SuspendLayout();
            gbSesKartı.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(683, 382);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 20;
            label2.Text = "Sonuç";
            // 
            // geriDon
            // 
            geriDon.BackColor = SystemColors.ActiveCaption;
            geriDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            geriDon.Location = new Point(662, 12);
            geriDon.Name = "geriDon";
            geriDon.Size = new Size(154, 51);
            geriDon.TabIndex = 18;
            geriDon.Text = "Geri Gel";
            geriDon.UseVisualStyleBackColor = false;
            geriDon.Click += geriDon_Click;
            // 
            // btnHesapla2
            // 
            btnHesapla2.BackColor = SystemColors.ActiveCaption;
            btnHesapla2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla2.Location = new Point(637, 314);
            btnHesapla2.Name = "btnHesapla2";
            btnHesapla2.Size = new Size(154, 51);
            btnHesapla2.TabIndex = 19;
            btnHesapla2.Text = "Hesapla";
            btnHesapla2.UseVisualStyleBackColor = false;
            btnHesapla2.Click += btnHesapla2_Click;
            // 
            // gbMouse
            // 
            gbMouse.Controls.Add(rbRazerMouse);
            gbMouse.Controls.Add(rbAsusMouse);
            gbMouse.Controls.Add(rbLogitechMouse);
            gbMouse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMouse.Location = new Point(195, 231);
            gbMouse.Name = "gbMouse";
            gbMouse.Size = new Size(177, 225);
            gbMouse.TabIndex = 16;
            gbMouse.TabStop = false;
            gbMouse.Text = "Mouse";
            // 
            // rbRazerMouse
            // 
            rbRazerMouse.AutoSize = true;
            rbRazerMouse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbRazerMouse.Location = new Point(6, 95);
            rbRazerMouse.Name = "rbRazerMouse";
            rbRazerMouse.Size = new Size(128, 27);
            rbRazerMouse.TabIndex = 0;
            rbRazerMouse.TabStop = true;
            rbRazerMouse.Text = "Razer Mouse";
            rbRazerMouse.UseVisualStyleBackColor = true;
            // 
            // rbAsusMouse
            // 
            rbAsusMouse.AutoSize = true;
            rbAsusMouse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAsusMouse.Location = new Point(6, 62);
            rbAsusMouse.Name = "rbAsusMouse";
            rbAsusMouse.Size = new Size(120, 27);
            rbAsusMouse.TabIndex = 0;
            rbAsusMouse.TabStop = true;
            rbAsusMouse.Text = "Asus Mouse";
            rbAsusMouse.UseVisualStyleBackColor = true;
            // 
            // rbLogitechMouse
            // 
            rbLogitechMouse.AutoSize = true;
            rbLogitechMouse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbLogitechMouse.Location = new Point(6, 29);
            rbLogitechMouse.Name = "rbLogitechMouse";
            rbLogitechMouse.Size = new Size(150, 27);
            rbLogitechMouse.TabIndex = 0;
            rbLogitechMouse.TabStop = true;
            rbLogitechMouse.Text = "Logitech Mouse";
            rbLogitechMouse.UseVisualStyleBackColor = true;
            // 
            // gbKlavye
            // 
            gbKlavye.Controls.Add(rbAsusKlavye);
            gbKlavye.Controls.Add(rbRazerKlavye);
            gbKlavye.Controls.Add(rbLogitechKlavye);
            gbKlavye.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbKlavye.Location = new Point(12, 231);
            gbKlavye.Name = "gbKlavye";
            gbKlavye.Size = new Size(177, 225);
            gbKlavye.TabIndex = 17;
            gbKlavye.TabStop = false;
            gbKlavye.Text = "Klavye";
            // 
            // rbAsusKlavye
            // 
            rbAsusKlavye.AutoSize = true;
            rbAsusKlavye.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAsusKlavye.Location = new Point(6, 94);
            rbAsusKlavye.Name = "rbAsusKlavye";
            rbAsusKlavye.Size = new Size(124, 27);
            rbAsusKlavye.TabIndex = 0;
            rbAsusKlavye.TabStop = true;
            rbAsusKlavye.Text = "Asus Klavye";
            rbAsusKlavye.UseVisualStyleBackColor = true;
            // 
            // rbRazerKlavye
            // 
            rbRazerKlavye.AutoSize = true;
            rbRazerKlavye.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbRazerKlavye.Location = new Point(6, 62);
            rbRazerKlavye.Name = "rbRazerKlavye";
            rbRazerKlavye.Size = new Size(132, 27);
            rbRazerKlavye.TabIndex = 0;
            rbRazerKlavye.TabStop = true;
            rbRazerKlavye.Text = "Razer Klavye";
            rbRazerKlavye.UseVisualStyleBackColor = true;
            // 
            // rbLogitechKlavye
            // 
            rbLogitechKlavye.AutoSize = true;
            rbLogitechKlavye.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbLogitechKlavye.Location = new Point(6, 29);
            rbLogitechKlavye.Name = "rbLogitechKlavye";
            rbLogitechKlavye.Size = new Size(154, 27);
            rbLogitechKlavye.TabIndex = 0;
            rbLogitechKlavye.TabStop = true;
            rbLogitechKlavye.Text = "Logitech Klavye";
            rbLogitechKlavye.UseVisualStyleBackColor = true;
            // 
            // gbMonitör
            // 
            gbMonitör.Controls.Add(rbHpMonitör);
            gbMonitör.Controls.Add(rbMsıMonitör);
            gbMonitör.Controls.Add(rbAsusMonitör);
            gbMonitör.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMonitör.Location = new Point(195, 0);
            gbMonitör.Name = "gbMonitör";
            gbMonitör.Size = new Size(177, 225);
            gbMonitör.TabIndex = 14;
            gbMonitör.TabStop = false;
            gbMonitör.Text = "Monitör";
            // 
            // rbHpMonitör
            // 
            rbHpMonitör.AutoSize = true;
            rbHpMonitör.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHpMonitör.Location = new Point(6, 95);
            rbHpMonitör.Name = "rbHpMonitör";
            rbHpMonitör.Size = new Size(118, 27);
            rbHpMonitör.TabIndex = 0;
            rbHpMonitör.TabStop = true;
            rbHpMonitör.Text = "HP Monitör";
            rbHpMonitör.UseVisualStyleBackColor = true;
            // 
            // rbMsıMonitör
            // 
            rbMsıMonitör.AutoSize = true;
            rbMsıMonitör.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMsıMonitör.Location = new Point(6, 62);
            rbMsıMonitör.Name = "rbMsıMonitör";
            rbMsıMonitör.Size = new Size(123, 27);
            rbMsıMonitör.TabIndex = 0;
            rbMsıMonitör.TabStop = true;
            rbMsıMonitör.Text = "MSI Monitör";
            rbMsıMonitör.UseVisualStyleBackColor = true;
            // 
            // rbAsusMonitör
            // 
            rbAsusMonitör.AutoSize = true;
            rbAsusMonitör.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAsusMonitör.Location = new Point(6, 29);
            rbAsusMonitör.Name = "rbAsusMonitör";
            rbAsusMonitör.Size = new Size(130, 27);
            rbAsusMonitör.TabIndex = 0;
            rbAsusMonitör.TabStop = true;
            rbAsusMonitör.Text = "Asus Monitör";
            rbAsusMonitör.UseVisualStyleBackColor = true;
            // 
            // gbAnaKart
            // 
            gbAnaKart.Controls.Add(rbMiniAtx);
            gbAnaKart.Controls.Add(rbMicroAtx);
            gbAnaKart.Controls.Add(rbAtx);
            gbAnaKart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbAnaKart.Location = new Point(12, 0);
            gbAnaKart.Name = "gbAnaKart";
            gbAnaKart.Size = new Size(177, 225);
            gbAnaKart.TabIndex = 15;
            gbAnaKart.TabStop = false;
            gbAnaKart.Text = "Ana Kart";
            // 
            // rbMiniAtx
            // 
            rbMiniAtx.AutoSize = true;
            rbMiniAtx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMiniAtx.Location = new Point(6, 94);
            rbMiniAtx.Name = "rbMiniAtx";
            rbMiniAtx.Size = new Size(95, 27);
            rbMiniAtx.TabIndex = 0;
            rbMiniAtx.TabStop = true;
            rbMiniAtx.Text = "Mini ITX";
            rbMiniAtx.UseVisualStyleBackColor = true;
            // 
            // rbMicroAtx
            // 
            rbMicroAtx.AutoSize = true;
            rbMicroAtx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMicroAtx.Location = new Point(6, 62);
            rbMicroAtx.Name = "rbMicroAtx";
            rbMicroAtx.Size = new Size(109, 27);
            rbMicroAtx.TabIndex = 0;
            rbMicroAtx.TabStop = true;
            rbMicroAtx.Text = "Micro ATX";
            rbMicroAtx.UseVisualStyleBackColor = true;
            // 
            // rbAtx
            // 
            rbAtx.AutoSize = true;
            rbAtx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAtx.Location = new Point(6, 29);
            rbAtx.Name = "rbAtx";
            rbAtx.Size = new Size(62, 27);
            rbAtx.TabIndex = 0;
            rbAtx.TabStop = true;
            rbAtx.Text = "ATX";
            rbAtx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbThermaltake);
            groupBox1.Controls.Add(rbCollerMaster);
            groupBox1.Controls.Add(rbAdısson);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(378, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 225);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Soğutucu";
            // 
            // rbThermaltake
            // 
            rbThermaltake.AutoSize = true;
            rbThermaltake.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbThermaltake.Location = new Point(6, 95);
            rbThermaltake.Name = "rbThermaltake";
            rbThermaltake.Size = new Size(145, 27);
            rbThermaltake.TabIndex = 0;
            rbThermaltake.TabStop = true;
            rbThermaltake.Text = "THERMALTAKE";
            rbThermaltake.UseVisualStyleBackColor = true;
            // 
            // rbCollerMaster
            // 
            rbCollerMaster.AutoSize = true;
            rbCollerMaster.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCollerMaster.Location = new Point(6, 62);
            rbCollerMaster.Name = "rbCollerMaster";
            rbCollerMaster.Size = new Size(167, 27);
            rbCollerMaster.TabIndex = 0;
            rbCollerMaster.TabStop = true;
            rbCollerMaster.Text = "COOLER MASTER ";
            rbCollerMaster.UseVisualStyleBackColor = true;
            // 
            // rbAdısson
            // 
            rbAdısson.AutoSize = true;
            rbAdısson.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAdısson.Location = new Point(6, 29);
            rbAdısson.Name = "rbAdısson";
            rbAdısson.Size = new Size(111, 27);
            rbAdısson.TabIndex = 0;
            rbAdısson.TabStop = true;
            rbAdısson.Text = "ADDISON ";
            rbAdısson.UseVisualStyleBackColor = true;
            // 
            // gbSesKartı
            // 
            gbSesKartı.Controls.Add(rbPlatoonSesKartları);
            gbSesKartı.Controls.Add(rbKeeproSesKart);
            gbSesKartı.Controls.Add(rbMüzikResyonuseskartı);
            gbSesKartı.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbSesKartı.Location = new Point(378, 231);
            gbSesKartı.Name = "gbSesKartı";
            gbSesKartı.Size = new Size(231, 225);
            gbSesKartı.TabIndex = 14;
            gbSesKartı.TabStop = false;
            gbSesKartı.Text = "Ses Kart";
            // 
            // rbPlatoonSesKartları
            // 
            rbPlatoonSesKartları.AutoSize = true;
            rbPlatoonSesKartları.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbPlatoonSesKartları.Location = new Point(6, 95);
            rbPlatoonSesKartları.Name = "rbPlatoonSesKartları";
            rbPlatoonSesKartları.Size = new Size(163, 27);
            rbPlatoonSesKartları.TabIndex = 0;
            rbPlatoonSesKartları.TabStop = true;
            rbPlatoonSesKartları.Text = "Platoon Ses Kartı";
            rbPlatoonSesKartları.UseVisualStyleBackColor = true;
            // 
            // rbKeeproSesKart
            // 
            rbKeeproSesKart.AutoSize = true;
            rbKeeproSesKart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbKeeproSesKart.Location = new Point(6, 62);
            rbKeeproSesKart.Name = "rbKeeproSesKart";
            rbKeeproSesKart.Size = new Size(158, 27);
            rbKeeproSesKart.TabIndex = 0;
            rbKeeproSesKart.TabStop = true;
            rbKeeproSesKart.Text = "Keepro Ses Kartı";
            rbKeeproSesKart.UseVisualStyleBackColor = true;
            // 
            // rbMüzikResyonuseskartı
            // 
            rbMüzikResyonuseskartı.AutoSize = true;
            rbMüzikResyonuseskartı.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMüzikResyonuseskartı.Location = new Point(6, 29);
            rbMüzikResyonuseskartı.Name = "rbMüzikResyonuseskartı";
            rbMüzikResyonuseskartı.Size = new Size(212, 27);
            rbMüzikResyonuseskartı.TabIndex = 0;
            rbMüzikResyonuseskartı.TabStop = true;
            rbMüzikResyonuseskartı.Text = "Müzik Reyonu Ses Kartı";
            rbMüzikResyonuseskartı.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(828, 476);
            Controls.Add(label2);
            Controls.Add(geriDon);
            Controls.Add(btnHesapla2);
            Controls.Add(gbMouse);
            Controls.Add(gbKlavye);
            Controls.Add(gbSesKartı);
            Controls.Add(groupBox1);
            Controls.Add(gbMonitör);
            Controls.Add(gbAnaKart);
            Name = "Form2";
            Text = "PC TOPLAMA";
            gbMouse.ResumeLayout(false);
            gbMouse.PerformLayout();
            gbKlavye.ResumeLayout(false);
            gbKlavye.PerformLayout();
            gbMonitör.ResumeLayout(false);
            gbMonitör.PerformLayout();
            gbAnaKart.ResumeLayout(false);
            gbAnaKart.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbSesKartı.ResumeLayout(false);
            gbSesKartı.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button geriDon;
        private Button btnHesapla2;
        private GroupBox gbMouse;
        private RadioButton rbRazerMouse;
        private RadioButton rbAsusMouse;
        private RadioButton rbLogitechMouse;
        private GroupBox gbKlavye;
        private RadioButton rbAsusKlavye;
        private RadioButton rbRazerKlavye;
        private RadioButton rbLogitechKlavye;
        private GroupBox gbMonitör;
        private RadioButton rbHpMonitör;
        private RadioButton rbMsıMonitör;
        private RadioButton rbAsusMonitör;
        private GroupBox gbAnaKart;
        private RadioButton rbMiniAtx;
        private RadioButton rbMicroAtx;
        private RadioButton rbAtx;
        private GroupBox groupBox1;
        private RadioButton rbThermaltake;
        private RadioButton rbCollerMaster;
        private RadioButton rbAdısson;
        private GroupBox gbSesKartı;
        private RadioButton rbPlatoonSesKartları;
        private RadioButton rbKeeproSesKart;
        private RadioButton rbMüzikResyonuseskartı;
    }
}