namespace ucaktakip
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.lblpersonelad = new System.Windows.Forms.Label();
            this.lblpersonelsoyad = new System.Windows.Forms.Label();
            this.lblpersonelpozisyon = new System.Windows.Forms.Label();
            this.txtpilot = new System.Windows.Forms.TextBox();
            this.txtyardımcıpilot = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtucakkod = new System.Windows.Forms.TextBox();
            this.txtkabinmemuru = new System.Windows.Forms.TextBox();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpersonelad
            // 
            this.lblpersonelad.AutoSize = true;
            this.lblpersonelad.Location = new System.Drawing.Point(82, 173);
            this.lblpersonelad.Name = "lblpersonelad";
            this.lblpersonelad.Size = new System.Drawing.Size(36, 16);
            this.lblpersonelad.TabIndex = 0;
            this.lblpersonelad.Text = "Pilot:";
            // 
            // lblpersonelsoyad
            // 
            this.lblpersonelsoyad.AutoSize = true;
            this.lblpersonelsoyad.Location = new System.Drawing.Point(26, 211);
            this.lblpersonelsoyad.Name = "lblpersonelsoyad";
            this.lblpersonelsoyad.Size = new System.Drawing.Size(92, 16);
            this.lblpersonelsoyad.TabIndex = 0;
            this.lblpersonelsoyad.Text = "Yardımcı Pilot:";
            // 
            // lblpersonelpozisyon
            // 
            this.lblpersonelpozisyon.AutoSize = true;
            this.lblpersonelpozisyon.Location = new System.Drawing.Point(23, 253);
            this.lblpersonelpozisyon.Name = "lblpersonelpozisyon";
            this.lblpersonelpozisyon.Size = new System.Drawing.Size(95, 16);
            this.lblpersonelpozisyon.TabIndex = 0;
            this.lblpersonelpozisyon.Text = "Kabin Memuru:";
            // 
            // txtpilot
            // 
            this.txtpilot.Location = new System.Drawing.Point(163, 170);
            this.txtpilot.Name = "txtpilot";
            this.txtpilot.Size = new System.Drawing.Size(100, 22);
            this.txtpilot.TabIndex = 1;
            // 
            // txtyardımcıpilot
            // 
            this.txtyardımcıpilot.Location = new System.Drawing.Point(163, 208);
            this.txtyardımcıpilot.Name = "txtyardımcıpilot";
            this.txtyardımcıpilot.Size = new System.Drawing.Size(100, 22);
            this.txtyardımcıpilot.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 171);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Uçak Kod:";
            // 
            // txtucakkod
            // 
            this.txtucakkod.Location = new System.Drawing.Point(163, 130);
            this.txtucakkod.Name = "txtucakkod";
            this.txtucakkod.Size = new System.Drawing.Size(100, 22);
            this.txtucakkod.TabIndex = 7;
            this.txtucakkod.TextChanged += new System.EventHandler(this.txtpersonelid_TextChanged);
            // 
            // txtkabinmemuru
            // 
            this.txtkabinmemuru.Location = new System.Drawing.Point(163, 250);
            this.txtkabinmemuru.Name = "txtkabinmemuru";
            this.txtkabinmemuru.Size = new System.Drawing.Size(100, 22);
            this.txtkabinmemuru.TabIndex = 1;
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(744, 12);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(44, 23);
            this.btnen.TabIndex = 11;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            // 
            // btntr
            // 
            this.btntr.Location = new System.Drawing.Point(692, 12);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(44, 23);
            this.btntr.TabIndex = 12;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.txtucakkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkabinmemuru);
            this.Controls.Add(this.txtyardımcıpilot);
            this.Controls.Add(this.txtpilot);
            this.Controls.Add(this.lblpersonelpozisyon);
            this.Controls.Add(this.lblpersonelsoyad);
            this.Controls.Add(this.lblpersonelad);
            this.Name = "personel";
            this.Text = "personel";
            this.Load += new System.EventHandler(this.personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpersonelad;
        private System.Windows.Forms.Label lblpersonelsoyad;
        private System.Windows.Forms.Label lblpersonelpozisyon;
        private System.Windows.Forms.TextBox txtpilot;
        private System.Windows.Forms.TextBox txtyardımcıpilot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtucakkod;
        private System.Windows.Forms.TextBox txtkabinmemuru;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}