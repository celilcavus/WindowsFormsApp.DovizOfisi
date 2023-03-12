using System;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp.DovizOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nowDate = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlFile = new XmlDocument();
            xmlFile.Load(nowDate);

            string dolarAlis = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteBuying").InnerXml;
            string dolarSatis = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml;

            string EuroAlis = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteBuying").InnerXml;
            string EuroSatis = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml;

            lblDolarAlis.Text = dolarAlis;
            lblDolarSatis.Text = dolarSatis;

            lblEuroAlis.Text = EuroAlis;
            lblEuroSatis.Text = EuroSatis;
        }

        private void lblDolarAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
        }

        private void lblEuroAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
        }

        private void lblDolarSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
        }

        private void lblEuroSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
        }
        
        
        double kur, miktar, tutar;
        private void btnSatis_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
                KUR = {kur}        
                MİKTAR = {miktar}        
                TUTAR = {tutar}
                ","İşlem Başarılı");

        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
           
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }
    }
}
