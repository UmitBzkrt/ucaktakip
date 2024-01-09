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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ucaktakip
{
    public partial class personel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public personel()
        {
            InitializeComponent();
        }
        private void personellistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from personel", baglanti);
            adtr.Fill(daset, "personel");
            dataGridView1.DataSource = daset.Tables["personel"];
            baglanti.Close();
        }
        private void personel_Load(object sender, EventArgs e)
        {
            personellistele();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personel(ucakkod,pilot,yardımcıpilot,kabinmemuru) values(@ucakkod,@pilot,@yardımcıpilot,@kabinmemuru)", baglanti);
            komut.Parameters.AddWithValue("@ucakkod", txtucakkod.Text);
            komut.Parameters.AddWithValue("@pilot", txtpilot.Text);
            komut.Parameters.AddWithValue("@yardımcıpilot", txtyardımcıpilot.Text);
            komut.Parameters.AddWithValue("@kabinmemuru", txtkabinmemuru.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
            daset.Tables["personel"].Clear();
            personellistele();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                   
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update personel set pilot=@pilot,yardımcıpilot=@yardımcıpilot,kabinmemuru=@kabinmemuru where ucakkod=@ucakkod", baglanti);
            komut.Parameters.AddWithValue("@ucakkod", txtucakkod.Text);
            komut.Parameters.AddWithValue("@pilot", txtpilot.Text);
            komut.Parameters.AddWithValue("@yardımcıpilot", txtyardımcıpilot.Text);
            komut.Parameters.AddWithValue("@kabinmemuru", txtkabinmemuru.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("güncelleme Yapıldı");
            daset.Tables["personel"].Clear();
            personellistele() ;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personel where ucakkod='" + dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Silindi");
            daset.Tables["personel"].Clear();
            baglanti.Close();
            personellistele();
        }

        private void txtpersonelid_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel where ucakkod like '" + txtucakkod.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {

                txtpilot.Text = rd["pilot"].ToString();
                txtyardımcıpilot.Text= rd["yardımcıpilot"].ToString();
               txtkabinmemuru.Text = rd["kabinmemuru"].ToString();
                

            }
            baglanti.Close();
        }
    }
}
