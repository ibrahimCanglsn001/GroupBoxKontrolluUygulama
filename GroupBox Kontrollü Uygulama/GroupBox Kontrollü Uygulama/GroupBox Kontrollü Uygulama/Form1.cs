namespace GroupBox_Kontrollü_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;


            // İşlemci Fiyat Hesaplama

            int cpuFiyat = 0;

            if (rbCpuI7.Checked)
                cpuFiyat = 10000;

            else if (rbCpuI5.Checked)
                cpuFiyat = 5500;

            else if (rbCpuI3.Checked)
                cpuFiyat = 2500;

            else if (rbCpuR5.Checked)
                cpuFiyat = 3700;

            else if (rbCpuR3.Checked)
                cpuFiyat = 2500;

            toplam += cpuFiyat;

            // Ram Bellek Fiyat Hesaplama

            int ramFiyat = 0;

            if (rbRam16.Checked)
                ramFiyat = 470;

            if (rbRam8.Checked)
                ramFiyat = 455;

            if (rbRam4.Checked)
                ramFiyat = 215;

            toplam += ramFiyat;

            // Sabit Disk Fiyat Hesaplama

            int sabitDiskFiyat = 0;

            if (rbHdd1000.Checked)
                sabitDiskFiyat = 800;

            if (rbHdd500.Checked)
                sabitDiskFiyat = 370;

            if (rbHdd320.Checked)
                sabitDiskFiyat = 195;

            toplam += sabitDiskFiyat;

            // Ek Donanım Fiyat Hesaplama

            int ekDonanımFiyat = 0;

            if (cbDvd.Checked)
                ekDonanımFiyat = 815;

            if (cbWebCam.Checked)
                ekDonanımFiyat += 3000;

            if (cbWifi.Checked)
                ekDonanımFiyat += 870;

            toplam += ekDonanımFiyat;

            label1.Text = Convert.ToString(toplam);


        }

        private void btnPcTopla_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }
    }
}