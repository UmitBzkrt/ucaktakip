using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucaktakip
{
    public partial class arayuz : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public arayuz()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button1.Text = strings.s1;
            button2.Text = strings.s2;
            button4.Text = strings.s34;
            
        }
        private void MesajGoster()
        {
            DialogResult Soru;

            Soru = MessageBox.Show("İptal olan seferleri görmek istermisiniz ?", "DİKKAT",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Soru == DialogResult.Yes)
            {
                iptalolanseferler gecis = new iptalolanseferler();
                gecis.Show();
                this.Close();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            giris gecis = new giris();
            gecis.Show();
            this.Hide();
        }

        private void arayuz_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sefer gecis = new sefer();
            gecis.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yolcu gecis = new yolcu();
            gecis.Show();
           
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
