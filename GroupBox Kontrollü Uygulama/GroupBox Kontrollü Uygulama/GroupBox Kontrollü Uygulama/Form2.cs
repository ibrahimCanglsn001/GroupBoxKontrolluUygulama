using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Kontrollü_Uygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            int toplam2 = 0;

            // Ana Kart Fiyatı Hesaplama

            int anaKartFiyat = 0;

            if (rbAtx.Checked)
                anaKartFiyat = 5000;

            else if (rbMicroAtx.Checked)
                anaKartFiyat = 3000;

            else if (rbMiniAtx.Checked)
                anaKartFiyat = 1000;
            toplam2 += anaKartFiyat;

            // Monitör Fiyatı Hesaplama


            int monitörFiyat = 0;

            if (rbAsusMonitör.Checked)
                monitörFiyat = 9000;

            if (rbMsıMonitör.Checked)
                monitörFiyat = 5000;

            if (rbHpMonitör.Checked)
                monitörFiyat = 3000;
            toplam2 += monitörFiyat;

            // Klavye Fiyatı Hesaplama  

            int klavyeFiyat = 0;

            if (rbAsusKlavye.Checked)
                klavyeFiyat = 3500;

            if (rbLogitechKlavye.Checked)
                klavyeFiyat = 2000;

            if (rbRazerKlavye.Checked)
                klavyeFiyat = 1300;
            toplam2 += klavyeFiyat;

            // Mouse Fiyatı Hesaplama 

            int mouseFiyat = 0;

            if (rbAsusMouse.Checked)
                mouseFiyat = 2000;

            if (rbLogitechMouse.Checked)
                mouseFiyat = 1000;

            if (rbRazerMouse.Checked)
                mouseFiyat = 500;
            toplam2 += mouseFiyat;

            // Soğutucu Fiyat Hesaplama

            int sogutucuFiyat = 0;

            if (rbAdısson.Checked)
                sogutucuFiyat = 300;

            if (rbCollerMaster.Checked)
                sogutucuFiyat = 400;

            if (rbThermaltake.Checked)
                sogutucuFiyat = 250;

            toplam2 += sogutucuFiyat;

            //Ses Kartı Fiyat Hesaplama

            int seskartıFiyat = 0;

            if (rbKeeproSesKart.Checked)
                seskartıFiyat = 700;

            if (rbMüzikResyonuseskartı.Checked)
                seskartıFiyat += 500;

            if (rbPlatoonSesKartları.Checked)
                seskartıFiyat += 100;

            toplam2 += seskartıFiyat;



            label2.Text = Convert.ToString(toplam2);
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
