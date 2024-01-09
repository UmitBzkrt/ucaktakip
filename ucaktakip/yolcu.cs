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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;
using System.Threading;

namespace ucaktakip
{
    public partial class yolcu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = strings.s28;
            label2.Text = strings.s29;
            label3.Text = strings.s30;
            label4.Text = strings.s31;
            label5.Text = strings.s32;
            label6.Text = strings.s33;
            label7.Text = strings.s22;
            button2.Text = strings.s19;
            button1.Text = strings.s12;
            button3.Text = strings.s16;

        }
        private void yolculistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from yolcu", baglanti);
            adtr.Fill(daset, "yolcu");
            dataGridView1.DataSource = daset.Tables["yolcu"];
            baglanti.Close();
        }
        public yolcu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void yolcu_Load(object sender, EventArgs e)
        {
            {
                yolculistele();
                SqlCommand komut = new SqlCommand("select * from cinsiyetbilgi", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    cmbcinsiyet.Items.Add(dr["cinsiyet"]);
                }
                baglanti.Close();
            }
            {
                SqlCommand komut2 = new SqlCommand("select ucakkod,kalvarnokta from ucakbilgi", baglanti);
                baglanti.Open();
                SqlDataReader dr2 = komut2.ExecuteReader();


                while (dr2.Read())
                {
                    cmbucakkod.Items.Add(dr2["ucakkod"]);
                }
                baglanti.Close();
            }

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from yolcu where tc like '" + txttc.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {

                txtad.Text = rd["ad"].ToString();
                txtsoyad.Text = rd["soyad"].ToString();
                txttelefon.Text = rd["telefon"].ToString();
                txtdtarih.Text = rd["dtarih"].ToString();
                cmbcinsiyet.Text = rd["cinsiyet"].ToString();
                cmbucakkod.Text = rd["ucakkod"].ToString();
                txtkalvar.Text = rd["kalvar"].ToString();


            }
            baglanti.Close();
        }
        bool durum;
        private void tckontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from yolcu ", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                if (txttc.Text == rdr["tc"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update yolcu set ad=@ad,soyad=@soyad,telefon=@telefon,dtarih=@dtarih,cinsiyet=@cinsiyet,kalvar=@kalvar,ucakkod=@ucakkod where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@dtarih", txtdtarih.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@ucakkod", cmbucakkod.Text);
            komut.Parameters.AddWithValue("@kalvar", txtkalvar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("güncelleme Yapıldı");
            daset.Tables["yolcu"].Clear();
            yolculistele();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    cmbcinsiyet.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tckontrol();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into yolcu(tc,ad,soyad,telefon,dtarih,cinsiyet,kalvar,ucakkod) values(@tc,@ad,@soyad,@telefon,@dtarih,@cinsiyet,@kalvar,@ucakkod)", baglanti);

                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@ad", (txtad.Text));
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@dtarih", DateTime.Now);
                komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
                komut.Parameters.AddWithValue("@ucakkod", cmbucakkod.Text);
                komut.Parameters.AddWithValue("@kalvar", txtkalvar.Text);                
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yolcu Eklendi");
                daset.Tables["yolcu"].Clear();
                yolculistele();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        cmbcinsiyet.Text = "";
                        cmbucakkod.Text = "";
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from yolcu where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Kaydı Silindi");
            daset.Tables["yolcu"].Clear();
            baglanti.Close();
            yolculistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbucakkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from ucakbilgi where ucakkod like'" + cmbucakkod.Text + "'", baglanti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    txtkalvar.Text = read2["kalvarnokta"].ToString();
                   

                }
                baglanti.Close();
            }
        }
    }
}
