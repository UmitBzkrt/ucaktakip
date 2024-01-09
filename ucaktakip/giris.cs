using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace ucaktakip
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=kullanicigiris;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            btngiris.Text = strings.s15;
            label3.Text = strings.s15;
            label2.Text = strings.s14;
            label1.Text = strings.s13;
            

        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            string user = kad.Text;
            string password = sifre.Text;
            string ktipi;


            con.Open();
            SqlCommand com = new SqlCommand("Select  kullanicitipi from kullanici where kullanici_adı='" + kad.Text + "' and sifre='" + sifre.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                ktipi = dr[0].ToString();
                if (ktipi == "admin")
                {
                    arayuzadmin gecis = new arayuzadmin();
                    gecis.Show();
                    this.Hide();
                }
                else if (ktipi == "kullanici")
                {
                    arayuz gecis = new arayuz();
                    gecis.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("hatalı kullanici adi veya sifre");
            }
            con.Close();
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
