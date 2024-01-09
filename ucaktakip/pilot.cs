using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucaktakip
{
    public partial class pilot : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public pilot()
        {
            InitializeComponent();
        }

        private void pilot_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sefer", baglanti);
            adtr.Fill(daset, "sefer");
            dataGridView1.DataSource = daset.Tables["sefer"];
            baglanti.Close();
            SqlCommand komut2 = new SqlCommand("SELECT TOP 1 pilot FROM sefer GROUP BY pilot ORDER BY COUNT(*) DESC", baglanti);
            baglanti.Open();
            SqlDataReader reader = komut2.ExecuteReader();
            if (reader.Read())
            {
                string encokcıkanpilot = reader["pilot"].ToString();
                label1.Text = ("En Çok Sefere Çıkan Pilot " + encokcıkanpilot);

            }
            else
            {
                label1.Text = "sefer bulunamadı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sefer gecis = new sefer();
            gecis.Show();
            this.Hide();
        }
    }
}
