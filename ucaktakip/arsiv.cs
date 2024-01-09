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
    public partial class arsiv : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public arsiv()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button1.Text = strings.s20;
            label1.Text = strings.s5;
            

        }

        private void arsivlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arsiv", baglanti);
            adtr.Fill(daset, "arsiv");
            dataGridView1.DataSource = daset.Tables["arsiv"];
            baglanti.Close();
        }
        private void arsiv_Load(object sender, EventArgs e)
        {
            arsivlistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arayuzadmin gecis = new arayuzadmin();
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

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from arsiv where ucakkod='" + dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Arşivden Silindi");
            daset.Tables["arsiv"].Clear();
            baglanti.Close();
            arsivlistele();
        }
    }
}
