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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Globalization;
using System.Threading;
using System.Reflection.Emit;

namespace ucaktakip
{
    public partial class gelirgider : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        public gelirgider()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = strings.s7;
            label2.Text = strings.s8;
            label3.Text = strings.s9;
            button1.Text = strings.s6;
            button2.Text = strings.s20;

        }
        int gelir,topla;
        private void gelirgider_Load(object sender, EventArgs e)
        {

            hesapla();
            giderlistele();
            toplam();
            int fark = gelir - topla;
            lblkazanc.Text = fark.ToString();
           
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select kazanc from sefer", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["Kazanç"].Points.AddY(dr[0].ToString());
                }
                baglanti.Close();
            }
                {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select yakit,bakım from gider", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chart2.Series["Yakıt"].Points.AddXY(dr[0].ToString(), dr[0]);
                    chart2.Series["Bakım"].Points.AddY(dr[1]);
                }
                baglanti.Close();
            }
        }
        private void hesapla()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kazanc) from sefer", baglanti);
            lblgelir.Text = komut.ExecuteScalar() + " TL";
            gelir = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
        }
        private void giderlistele()
        {
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select yakit,bakım from gider", baglanti);
                adtr.Fill(daset, "gider");
                dtgrw.DataSource = daset.Tables["gider"];
                baglanti.Close();
            }
        }
        private void toplam()
        {
           

                ;
                for (int i = 0; i < dtgrw.Rows.Count; ++i)
                {

                    topla += Convert.ToInt32(dtgrw.Rows[i].Cells[0].Value);
                    topla += Convert.ToInt32(dtgrw.Rows[i].Cells[1].Value);
                }
                lblgider.Text = Convert.ToString(topla + " TL");
            }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void dtgrw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            giderekle gecis = new giderekle();
            gecis.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
