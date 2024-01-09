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
    public partial class arayuzadmin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public arayuzadmin()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button1.Text = strings.s1;
            button2.Text = strings.s2;
            button5.Text = strings.s34;
            button3.Text = strings.s4;
            button4.Text = strings.s3;

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
        private void button5_Click(object sender, EventArgs e)
        {
            giris gecis = new giris();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sefer gecis = new sefer();
            gecis.Show();
           
        }

        private void arayuzadmin_Load(object sender, EventArgs e)
        {
            MesajGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yolcu gecis = new yolcu();
            gecis.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gelirgider gecis = new gelirgider();
            gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcıeklesil gecis = new kullanıcıeklesil();
            gecis.Show();
            this.Hide();
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arsiv gecis = new arsiv();
            gecis.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iptalolanseferler gecis=new iptalolanseferler();
            gecis.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ucakbilgisi gecis = new ucakbilgisi();
            gecis.Show();

        }
    }
}
