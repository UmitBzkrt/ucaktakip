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
    public partial class rotar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public rotar()
        {
            InitializeComponent();
        }
        private void seferlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sefer", baglanti);
            adtr.Fill(daset, "sefer");
            dataGridView1.DataSource = daset.Tables["sefer"];
            baglanti.Close();
        }
        private void rotar_Load(object sender, EventArgs e)
        {
            seferlistele();
            SqlCommand komut = new SqlCommand("SELECT ucakkod FROM sefer WHERE rotar = 'VAR       ' GROUP BY ucakkod ORDER BY COUNT(*) DESC", baglanti);
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                string encokrotarucakkod = reader["ucakkod"].ToString();


                label1.Text = "En Çok Rötar Yapan Uçak Kodu: " + encokrotarucakkod;

            }
            else
            {
                label1.Text = "Rötar Yaşanan Uçak Bulunamadı";
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sefer gecis = new sefer();
            gecis.Show();
            this.Hide();
        }
    }
}
