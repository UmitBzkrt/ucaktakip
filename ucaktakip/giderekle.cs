using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;
using System.Threading;

namespace ucaktakip
{
    public partial class giderekle : Form
    {
        public giderekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = strings.s10;
            label2.Text = strings.s11;
            button1.Text = strings.s12;
            button2.Text = strings.s20;
            

        }
        private void giderlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gider", baglanti);
            adtr.Fill(daset, "gider");
            dataGridView1.DataSource = daset.Tables["gider"];
            baglanti.Close();
        }
        private void giderekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gider", baglanti);
            adtr.Fill(daset, "gider");
            dataGridView1.DataSource = daset.Tables["gider"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into gider(yakit,bakım,ucakkod) values(@yakit,@bakım,@ucakkod)", baglanti);

                komut.Parameters.AddWithValue("@yakit", txtyakit.Text);
                komut.Parameters.AddWithValue("@bakım", txtbakim.Text);
                komut.Parameters.AddWithValue("@ucakkod", txtucakkod.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Giderler Eklendi");
                daset.Tables["gider"].Clear();
                giderlistele();
                txtbakim.Clear();
                txtyakit.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelirgider gecis = new gelirgider();
            gecis.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntr_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from gider where ucakkod='" + dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gider Silindi");
            daset.Tables["Gider"].Clear();
            baglanti.Close();
            giderlistele();
        }
    }
}
