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
    public partial class kullanıcıeklesil : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=kullanicigiris;Integrated Security=True");
        DataSet daset = new DataSet();
        public kullanıcıeklesil()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = strings.s17;
            lblkad.Text = strings.s13;
            lblsifre.Text = strings.s14;
            lblktipi.Text = strings.s18;
            btnekle.Text = strings.s12;
            btnguncelle.Text = strings.s19;
            btnsil.Text = strings.s16;
            button1.Text = strings.s20;

        }
        private void kullanicilistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
        }

        private void kullanıcıeklesil_Load(object sender, EventArgs e)
        {
            kullanicilistele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into kullanici(id,kullanici_adı,sifre,kullanicitipi) values(@id,@kullanici_adı,@sifre,@kullanicitipi)", baglanti);
            komut.Parameters.AddWithValue("@id", txtkid.Text);
            komut.Parameters.AddWithValue("@kullanici_adı", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@kullanicitipi", txtkullanicitipi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kullanıcı kaydı eklendi");
            daset.Tables["kullanici"].Clear();
            kullanicilistele();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kullanici set kullanici_adı=@kullanici_adı,sifre=@sifre,kullanicitipi=@kullanicitipi where id=@id", baglanti);
            komut.Parameters.AddWithValue("@kullanicitipi", txtkullanicitipi.Text);
            komut.Parameters.AddWithValue("@kullanici_adı", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@id",txtkid.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
            MessageBox.Show("kullanıcı kaydı güncellendi");
            daset.Tables["kullanici"].Clear();
            kullanicilistele();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kullanici where kullanici_adı='" + dataGridView1.CurrentRow.Cells["kullanici_adı"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
            daset.Tables["kullanici"].Clear();
            kullanicilistele();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtkullanicitipi.Text = dataGridView1.CurrentRow.Cells["kullanicitipi"].Value.ToString();
            txtkullaniciadi.Text = dataGridView1.CurrentRow.Cells["kullanici_adı"].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
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
    }
}
