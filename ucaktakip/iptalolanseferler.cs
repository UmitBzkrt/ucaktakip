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
    public partial class iptalolanseferler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public iptalolanseferler()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button1.Text = strings.s16;
            button2.Text = strings.s20;
            

        }
        private void sefererlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from iptalolanseferler", baglanti);
            adtr.Fill(daset, "iptalolanseferler");
            dataGridView1.DataSource = daset.Tables["iptalolanseferler"];
            baglanti.Close();
        }
        private void iptalolanseferler_Load(object sender, EventArgs e)
        {
            sefererlistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from iptalolanseferler where ucakkod='" + dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("sefer silindi");
            
            daset.Tables["iptalolanseferler"].Clear();
            sefererlistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris gecis = new giris();
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
    }
}
