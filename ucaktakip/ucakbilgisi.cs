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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ucaktakip
{
    public partial class ucakbilgisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public ucakbilgisi()
        {
            InitializeComponent();
        }
        private void ucakbilgilistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ucakbilgi", baglanti);
            adtr.Fill(daset, "ucakbilgi");
            dataGridView1.DataSource = daset.Tables["ucakbilgi"];
            baglanti.Close();
        }
        private void ucakbilgisi_Load(object sender, EventArgs e)
        {
            ucakbilgilistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ucakbilgi(ucakkod,kalvarnokta,kalkissaati,varissaati) values(@ucakkod,@kalvarnokta,@kalkissaati,@varissaati)", baglanti);
            komut.Parameters.AddWithValue("@ucakkod", txtucakkod.Text);
            komut.Parameters.AddWithValue("@kalvarnokta", txtkalvarnokta.Text);
            komut.Parameters.AddWithValue("@kalkissaati", txtkalsaat.Text);
            komut.Parameters.AddWithValue("@varissaati", txtvarsaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uçak Bilgisi Eklendi");
            daset.Tables["ucakbilgi"].Clear();
            ucakbilgilistele();
            txtucakkod.Clear();
            txtkalvarnokta.Clear();
            txtkalsaat.Clear();
            txtvarsaat.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ucakbilgi set kalvarnokta=@kalvarnokta,kalkissaati=@kalkissaati,varissaati=@varissaati where ucakkod=@ucakkod", baglanti);
            komut.Parameters.AddWithValue("@ucakkod", txtucakkod.Text);
            komut.Parameters.AddWithValue("@kalvarnokta", txtkalvarnokta.Text);
            komut.Parameters.AddWithValue("@kalkissaati", txtkalsaat.Text);
            komut.Parameters.AddWithValue("@varissaati", txtvarsaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("güncelleme Yapıldı");
            daset.Tables["ucakbilgi"].Clear();
            ucakbilgilistele();
            txtkalvarnokta.Text = "";
            txtucakkod.Text = "";
            txtkalsaat.Clear();
            txtvarsaat.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ucakbilgi where ucakkod='" + dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uçak Bilgisi Silindi");
            daset.Tables["ucakbilgi"].Clear();
            baglanti.Close();
            ucakbilgilistele();
        }

        private void txtucakkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ucakbilgi where ucakkod like '" + txtucakkod.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {

                txtkalvarnokta.Text = rd["kalvarnokta"].ToString();
                txtkalsaat.Text = rd["kalkissaati"].ToString();
                txtvarsaat.Text = rd["varissaati"].ToString();
                


            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
