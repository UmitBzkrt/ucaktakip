namespace ucaktakip
{
    partial class sefer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sefer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbucakkod = new System.Windows.Forms.ComboBox();
            this.txtseferid = new System.Windows.Forms.TextBox();
            this.txtkalvar = new System.Windows.Forms.TextBox();
            this.txtyalcusayisi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.txtkazanc = new System.Windows.Forms.TextBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.txtkabinmemuru = new System.Windows.Forms.TextBox();
            this.txtyardımcıpilot = new System.Windows.Forms.TextBox();
            this.txtpilot = new System.Windows.Forms.TextBox();
            this.txtrötarvar = new System.Windows.Forms.TextBox();
            this.txtvaris = new System.Windows.Forms.TextBox();
            this.txtkalkis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrotarvar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrotarkal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnseferiptal = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbucakkod);
            this.groupBox2.Controls.Add(this.txtseferid);
            this.groupBox2.Controls.Add(this.txtkalvar);
            this.groupBox2.Controls.Add(this.txtyalcusayisi);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnekle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.txtkazanc);
            this.groupBox2.Controls.Add(this.txttarih);
            this.groupBox2.Controls.Add(this.txtkabinmemuru);
            this.groupBox2.Controls.Add(this.txtyardımcıpilot);
            this.groupBox2.Controls.Add(this.txtpilot);
            this.groupBox2.Controls.Add(this.txtrötarvar);
            this.groupBox2.Controls.Add(this.txtvaris);
            this.groupBox2.Controls.Add(this.txtkalkis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblrotarvar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblrotarkal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(81, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 669);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbucakkod
            // 
            this.cmbucakkod.FormattingEnabled = true;
            this.cmbucakkod.Location = new System.Drawing.Point(253, 87);
            this.cmbucakkod.Name = "cmbucakkod";
            this.cmbucakkod.Size = new System.Drawing.Size(141, 24);
            this.cmbucakkod.TabIndex = 15;
            this.cmbucakkod.SelectedIndexChanged += new System.EventHandler(this.cmbucakkod_SelectedIndexChanged_2);
            this.cmbucakkod.SelectionChangeCommitted += new System.EventHandler(this.cmbucakkod_SelectionChangeCommitted_1);
            // 
            // txtseferid
            // 
            this.txtseferid.Location = new System.Drawing.Point(253, 37);
            this.txtseferid.Name = "txtseferid";
            this.txtseferid.Size = new System.Drawing.Size(141, 22);
            this.txtseferid.TabIndex = 14;
            this.txtseferid.TextChanged += new System.EventHandler(this.txtseferid_TextChanged);
            // 
            // txtkalvar
            // 
            this.txtkalvar.Location = new System.Drawing.Point(253, 136);
            this.txtkalvar.Name = "txtkalvar";
            this.txtkalvar.Size = new System.Drawing.Size(140, 22);
            this.txtkalvar.TabIndex = 13;
            // 
            // txtyalcusayisi
            // 
            this.txtyalcusayisi.Location = new System.Drawing.Point(253, 270);
            this.txtyalcusayisi.Name = "txtyalcusayisi";
            this.txtyalcusayisi.Size = new System.Drawing.Size(140, 22);
            this.txtyalcusayisi.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 549);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 510);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnekle
            // 
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(155, 630);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(96, 36);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.ForeColor = System.Drawing.Color.Black;
            this.btngüncelle.Location = new System.Drawing.Point(278, 630);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(96, 36);
            this.btngüncelle.TabIndex = 8;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btnseferekle_Click);
            // 
            // txtkazanc
            // 
            this.txtkazanc.Location = new System.Drawing.Point(253, 469);
            this.txtkazanc.Name = "txtkazanc";
            this.txtkazanc.Size = new System.Drawing.Size(140, 22);
            this.txtkazanc.TabIndex = 6;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(253, 429);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(140, 22);
            this.txttarih.TabIndex = 5;
            // 
            // txtkabinmemuru
            // 
            this.txtkabinmemuru.Location = new System.Drawing.Point(253, 387);
            this.txtkabinmemuru.Name = "txtkabinmemuru";
            this.txtkabinmemuru.Size = new System.Drawing.Size(140, 22);
            this.txtkabinmemuru.TabIndex = 4;
            // 
            // txtyardımcıpilot
            // 
            this.txtyardımcıpilot.Location = new System.Drawing.Point(253, 349);
            this.txtyardımcıpilot.Name = "txtyardımcıpilot";
            this.txtyardımcıpilot.Size = new System.Drawing.Size(140, 22);
            this.txtyardımcıpilot.TabIndex = 4;
            // 
            // txtpilot
            // 
            this.txtpilot.Location = new System.Drawing.Point(253, 309);
            this.txtpilot.Name = "txtpilot";
            this.txtpilot.Size = new System.Drawing.Size(140, 22);
            this.txtpilot.TabIndex = 4;
            // 
            // txtrötarvar
            // 
            this.txtrötarvar.Location = new System.Drawing.Point(253, 595);
            this.txtrötarvar.Name = "txtrötarvar";
            this.txtrötarvar.Size = new System.Drawing.Size(140, 22);
            this.txtrötarvar.TabIndex = 4;
            this.txtrötarvar.Visible = false;
            // 
            // txtvaris
            // 
            this.txtvaris.Location = new System.Drawing.Point(253, 226);
            this.txtvaris.Name = "txtvaris";
            this.txtvaris.Size = new System.Drawing.Size(140, 22);
            this.txtvaris.TabIndex = 4;
            // 
            // txtkalkis
            // 
            this.txtkalkis.Location = new System.Drawing.Point(253, 182);
            this.txtkalkis.Name = "txtkalkis";
            this.txtkalkis.Size = new System.Drawing.Size(140, 22);
            this.txtkalkis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kazanç:";
            // 
            // lblrotarvar
            // 
            this.lblrotarvar.AutoSize = true;
            this.lblrotarvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrotarvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrotarvar.Location = new System.Drawing.Point(25, 591);
            this.lblrotarvar.Name = "lblrotarvar";
            this.lblrotarvar.Size = new System.Drawing.Size(192, 25);
            this.lblrotarvar.TabIndex = 0;
            this.lblrotarvar.Text = "Rötarlı Varış Saati:";
            this.lblrotarvar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(148, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(79, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yolcu Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(92, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Varış Saati:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(58, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kabin Memuru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(67, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yardımcı Pilot:";
            // 
            // lblrotarkal
            // 
            this.lblrotarkal.AutoSize = true;
            this.lblrotarkal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrotarkal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrotarkal.Location = new System.Drawing.Point(16, 547);
            this.lblrotarkal.Name = "lblrotarkal";
            this.lblrotarkal.Size = new System.Drawing.Size(201, 25);
            this.lblrotarkal.TabIndex = 0;
            this.lblrotarkal.Text = "Rötarlı Kalkış Saati:";
            this.lblrotarkal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(156, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pilot:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(83, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kalkış Saati:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(147, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rötar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kalkış-Varış Noktası:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(122, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sefer İd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(92, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Uçak Kodu:";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1135, 344);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 33);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnseferiptal
            // 
            this.btnseferiptal.Location = new System.Drawing.Point(1024, 344);
            this.btnseferiptal.Name = "btnseferiptal";
            this.btnseferiptal.Size = new System.Drawing.Size(90, 33);
            this.btnseferiptal.TabIndex = 10;
            this.btnseferiptal.Text = "Seferi İptal Et";
            this.btnseferiptal.UseVisualStyleBackColor = true;
            this.btnseferiptal.Click += new System.EventHandler(this.btnseferiptal_Click);
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(1207, 12);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(44, 23);
            this.btnen.TabIndex = 11;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Location = new System.Drawing.Point(1152, 12);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(44, 23);
            this.btntr.TabIndex = 12;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(526, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 117);
            this.button1.TabIndex = 13;
            this.button1.Text = "En Çok Sefere Çıkan Pilot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(681, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 117);
            this.button2.TabIndex = 13;
            this.button2.Text = "En Çok Rötar Yapan Uçak";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 746);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.btnseferiptal);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sefer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sefer";
            this.Load += new System.EventHandler(this.sefer_Load);
            this.DoubleClick += new System.EventHandler(this.sefer_DoubleClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sefer_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtvaris;
        private System.Windows.Forms.TextBox txtkalkis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtkazanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnseferiptal;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkabinmemuru;
        private System.Windows.Forms.TextBox txtyardımcıpilot;
        private System.Windows.Forms.TextBox txtpilot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrötarvar;
        private System.Windows.Forms.Label lblrotarvar;
        private System.Windows.Forms.Label lblrotarkal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtyalcusayisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtkalvar;
        private System.Windows.Forms.TextBox txtseferid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbucakkod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}