using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TextBox = System.Windows.Forms.TextBox;

namespace ucaktakip
{
    public partial class sefer : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ucaktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void seferlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sefer", baglanti);
            adtr.Fill(daset, "sefer");
            dataGridView1.DataSource = daset.Tables["sefer"];
            baglanti.Close();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label4.Text = strings.s21;
            label5.Text = strings.s22;
            label6.Text = strings.s23;
            label7.Text = strings.s24;
            label9.Text = strings.s25;
            label1.Text = strings.s9;
            btngüncelle.Text = strings.s19;
            btnekle.Text = strings.s12;
            btnseferiptal.Text = strings.s26;
            btnsil.Text = strings.s16;
            txtyalcusayisi.Text = strings.s35;
            txtyardımcıpilot.Text = strings.s36;
            txtkabinmemuru.Text = strings.s37;
            comboBox1.Text=strings.s38;
            button1.Text=strings.s39;
            button2.Text=strings.s40;

        }
        public sefer()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void sefer_Load(object sender, EventArgs e)
        {
            seferlistele();

           
            {
                SqlCommand komut = new SqlCommand("select * from gecikme", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Rötar"]);
                }
                baglanti.Close();
            }
            {
                SqlCommand komut = new SqlCommand("select * from ucakbilgi", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    cmbucakkod.Items.Add(dr["ucakkod"]);
                }
                baglanti.Close();
            }



        }

        private void txtucakkod_TextChanged(object sender, EventArgs e)
        {
            
        }

        bool durum;
        private void ucakkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sefer ", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                if (cmbucakkod.Text == rdr["ucakkod"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ucakkodkontrol();
            int donusum = Convert.ToInt32(txtyalcusayisi.Text);
            if (donusum <= 120)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sefer(seferid,ucakkod,tarih,kalkisvaris,kalkissaati,varissaati,kazanc,pilot,yardımcıpilot,kabinmemuru,yolcusayisi,rotar,rotarkalksaat,rotarvarsaat) values(@seferid,@ucakkod,@tarih,@kalkisvaris,@kalkissaati,@varissaati,@kazanc,@pilot,@yardımcıpilot,@kabinmemuru,@yolcusayisi,@rotar,@rotarkalksaat,@rotarvarsaat)", baglanti);

                komut.Parameters.AddWithValue("@seferid", txtseferid.Text);
                komut.Parameters.AddWithValue("@ucakkod", cmbucakkod.Text);
                komut.Parameters.AddWithValue("@kalkisvaris", (txtkalvar.Text));
                komut.Parameters.AddWithValue("@kalkissaati", txtkalkis.Text);
                komut.Parameters.AddWithValue("@varissaati", txtvaris.Text);
                komut.Parameters.AddWithValue("@yolcusayisi", txtyalcusayisi.Text);
                komut.Parameters.AddWithValue("@pilot", txtpilot.Text);
                komut.Parameters.AddWithValue("@yardımcıpilot", txtyardımcıpilot.Text);
                komut.Parameters.AddWithValue("@kabinmemuru", txtkabinmemuru.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("@kazanc", txtkazanc.Text);
                komut.Parameters.AddWithValue("@rotar", comboBox1.Text);
                komut.Parameters.AddWithValue("@rotarkalksaat", textBox1.Text);
                komut.Parameters.AddWithValue("@rotarvarsaat", txtrötarvar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sefer Eklendi");
                daset.Tables["sefer"].Clear();
                seferlistele();
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                        comboBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Yolcu Sayısı Kapasiteyi Aşıyor!");
            }


        
        } private void btnsil_Click(object sender, EventArgs e)
            {       
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sefer where seferid='" + dataGridView1.CurrentRow.Cells["seferid"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                
                MessageBox.Show("Sefer İptal Edildi");
                daset.Tables["sefer"].Clear();
                baglanti.Close();
                seferlistele();
            }
        
        private void btnseferekle_Click(object sender, EventArgs e)
        {
            
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update sefer set ucakkod=@ucakkod,kalkisvaris=@kalkisvaris,kalkissaati=@kalkissaati,varissaati=@varissaati,tarih=@tarih,kazanc=@kazanc,pilot=@pilot,yardımcıpilot=@yardımcıpilot,kabinmemuru=@kabinmemuru,yolcusayisi=@yolcusayisi,rotar=@rotar,rotarkalksaat=@rotarkalksaat,rotarvarsaat=@rotarvarsaat where seferid=@seferid", baglanti);
                komut.Parameters.AddWithValue("@seferid", txtseferid.Text);
                komut.Parameters.AddWithValue("@ucakkod", cmbucakkod.Text);
                komut.Parameters.AddWithValue("@kalkisvaris", (txtkalvar.Text));
                komut.Parameters.AddWithValue("@kalkissaati", txtkalkis.Text);
                komut.Parameters.AddWithValue("@varissaati", txtvaris.Text);
                komut.Parameters.AddWithValue("@yolcusayisi", txtyalcusayisi.Text);
                komut.Parameters.AddWithValue("@pilot", txtpilot.Text);
                komut.Parameters.AddWithValue("@yardımcıpilot", txtyardımcıpilot.Text);
                komut.Parameters.AddWithValue("@kabinmemuru", txtkabinmemuru.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("@kazanc", txtkazanc.Text);
                komut.Parameters.AddWithValue("@rotar", comboBox1.Text);
                komut.Parameters.AddWithValue("@rotarkalksaat", textBox1.Text);
                komut.Parameters.AddWithValue("@rotarvarsaat", txtrötarvar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("güncelleme Yapıldı");
                daset.Tables["sefer"].Clear();
                seferlistele();

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        comboBox1.Text = "";
                        
                    }
                }


            }
           
        }
        private void groupBox2_Enter(object sender, EventArgs e)
                {

                }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            }

        private void btnseferiptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into iptalolanseferler(seferid,ucakkod,kalkisvaris,kalkissaati,varissaati,tarih,kazanc,yolcusayisi,rotar,rotarkalksaat,rotarvarsaat,pilot,kabinmemuru,yardımcıpilot) values (@seferid,@ucakkod,@kalkisvaris,@kalkissaati,@varissaati,@tarih,@kazanc,@yolcusayisi,@rotar,@rotarkalksaat,@rotarvarsaat,@pilot,@yardımcıpilot,@kabinmemuru)", baglanti);
            komut2.Parameters.AddWithValue("@seferid", txtseferid.Text);
            komut2.Parameters.AddWithValue("@ucakkod", cmbucakkod.Text);
            komut2.Parameters.AddWithValue("@kalkisvaris", (txtkalvar.Text));
            komut2.Parameters.AddWithValue("@kalkissaati", txtkalkis.Text);
            komut2.Parameters.AddWithValue("@varissaati", txtvaris.Text);
            komut2.Parameters.AddWithValue("@yolcusayisi", txtyalcusayisi.Text);
            komut2.Parameters.AddWithValue("@pilot", txtpilot.Text);
            komut2.Parameters.AddWithValue("@yardımcıpilot", txtyardımcıpilot.Text);
            komut2.Parameters.AddWithValue("@kabinmemuru", txtkabinmemuru.Text);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut2.Parameters.AddWithValue("@kazanc", txtkazanc.Text);
            komut2.Parameters.AddWithValue("@rotar", comboBox1.Text);
            komut2.Parameters.AddWithValue("@rotarkalksaat", textBox1.Text);
            komut2.Parameters.AddWithValue("@rotarvarsaat", txtrötarvar.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sefer where seferid='" + dataGridView1.CurrentRow.Cells["seferid"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            
            MessageBox.Show("Sefer İptal Edildi");
            daset.Tables["sefer"].Clear();
            baglanti.Close();
            seferlistele();
        }

        private void sefer_DoubleClick(object sender, EventArgs e)
        {

        }

        private void sefer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtseferid.Text = dataGridView1.CurrentRow.Cells["seferid"].Value.ToString();
            cmbucakkod.Text = dataGridView1.CurrentRow.Cells["ucakkod"].Value.ToString();
            txtkalvar.Text = dataGridView1.CurrentRow.Cells["kalkisvaris"].Value.ToString();
            txtkalkis.Text = dataGridView1.CurrentRow.Cells["kalkissaati"].Value.ToString();
            txtvaris.Text = dataGridView1.CurrentRow.Cells["varissaati"].Value.ToString();
            txtpilot.Text = dataGridView1.CurrentRow.Cells["pilot"].Value.ToString();
            txtyardımcıpilot.Text = dataGridView1.CurrentRow.Cells["yardımcıpilot"].Value.ToString();
            txtkabinmemuru.Text = dataGridView1.CurrentRow.Cells["kabinmemuru"].Value.ToString();
            txttarih.Text = dataGridView1.CurrentRow.Cells["tarih"].Value.ToString();
            txtkazanc.Text = dataGridView1.CurrentRow.Cells["kazanc"].Value.ToString();
        }

        private void btntr_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void cmbucakkod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from ucakbilgi where ucakkod like'" + cmbucakkod.Text + "'", baglanti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    txtkalvar.Text = read2["kalvarnokta"].ToString();
                    txtkalkis.Text = read2["kalkissaati"].ToString();
                    txtvaris.Text = read2["varissaati"].ToString();

                }
                baglanti.Close();
            }
            if (cmbucakkod.Text == "")
            {
                txtpilot.Text = "";
                txtyardımcıpilot.Text = "";
                txtkabinmemuru.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel where ucakkod like'" + cmbucakkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtpilot.Text = read["pilot"].ToString();
                txtyardımcıpilot.Text = read["yardımcıpilot"].ToString();
                txtkabinmemuru.Text = read["kabinmemuru"].ToString();
            }
            baglanti.Close();
            
            

            
        }
       


        private void cmbucakkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           


        }

        private void cmbrötar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "VAR       ")
            {
                textBox1.Visible = true;
                txtrötarvar.Visible = true;
                lblrotarkal.Visible = true;
                lblrotarvar.Visible = true;
            }

            else
            {
                textBox1.Visible = false;
                txtrötarvar.Visible = false;
                lblrotarkal.Visible = false;
                lblrotarvar.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtseferid_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sefer where seferid like '" + txtseferid.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                cmbucakkod.Text = rd["ucakkod"].ToString();
                txtkalvar.Text = rd["kalkisvaris"].ToString();
                txtkalkis.Text = rd["kalkissaati"].ToString();
                txtvaris.Text = rd["varissaati"].ToString();
                txtyalcusayisi.Text = rd["yolcusayisi"].ToString();
                txtpilot.Text = rd["pilot"].ToString();
                txtyardımcıpilot.Text = rd["yardımcıpilot"].ToString();
                txtkabinmemuru.Text = rd["kabinmemuru"].ToString();
                txttarih.Text = rd["tarih"].ToString();              
                txtkazanc.Text = rd["kazanc"].ToString();
                comboBox1.Text = rd["rotar"].ToString();

            }
            baglanti.Close();
        }

        private void cmbucakkod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void txtucakkod_TextChanged_1(object sender, EventArgs e)
        {
            
           
           
        }

        private void cmbucakkod_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from ucakbilgi where ucakkod like'" + cmbucakkod.Text + "'", baglanti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    txtkalvar.Text = read2["kalvarnokta"].ToString();
                    txtkalkis.Text = read2["kalkissaati"].ToString();
                    txtvaris.Text = read2["varissaati"].ToString();

                }
                baglanti.Close();
                if (cmbucakkod.Text == "")
                {
                    txtpilot.Text = "";
                    txtyardımcıpilot.Text = "";
                    txtkabinmemuru.Text = "";
                }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from personel where ucakkod like'" + cmbucakkod.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtpilot.Text = read["pilot"].ToString();
                    txtyardımcıpilot.Text = read["yardımcıpilot"].ToString();
                    txtkabinmemuru.Text = read["kabinmemuru"].ToString();
                }
                baglanti.Close();


            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pilot gecis = new pilot();
            gecis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rotar gecis = new rotar();
            gecis.Show();
            this.Hide();
        }

        private void cmbucakkod_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
    } 
