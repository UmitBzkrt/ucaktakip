﻿namespace ucaktakip
{
    partial class ucakbilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucakbilgisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkalvarnokta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtucakkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkalsaat = new System.Windows.Forms.TextBox();
            this.txtvarsaat = new System.Windows.Forms.TextBox();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uçak Kod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kalkış-Varış Noktası:";
            // 
            // txtkalvarnokta
            // 
            this.txtkalvarnokta.Location = new System.Drawing.Point(154, 207);
            this.txtkalvarnokta.Name = "txtkalvarnokta";
            this.txtkalvarnokta.Size = new System.Drawing.Size(118, 22);
            this.txtkalvarnokta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 189);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtucakkod
            // 
            this.txtucakkod.Location = new System.Drawing.Point(154, 173);
            this.txtucakkod.Name = "txtucakkod";
            this.txtucakkod.Size = new System.Drawing.Size(118, 22);
            this.txtucakkod.TabIndex = 1;
            this.txtucakkod.TextChanged += new System.EventHandler(this.txtucakkod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalkış Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Varış Saati:";
            // 
            // txtkalsaat
            // 
            this.txtkalsaat.Location = new System.Drawing.Point(154, 243);
            this.txtkalsaat.Name = "txtkalsaat";
            this.txtkalsaat.Size = new System.Drawing.Size(118, 22);
            this.txtkalsaat.TabIndex = 5;
            // 
            // txtvarsaat
            // 
            this.txtvarsaat.Location = new System.Drawing.Point(154, 280);
            this.txtvarsaat.Name = "txtvarsaat";
            this.txtvarsaat.Size = new System.Drawing.Size(118, 22);
            this.txtvarsaat.TabIndex = 5;
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(744, 12);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(44, 23);
            this.btnen.TabIndex = 13;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            // 
            // btntr
            // 
            this.btntr.Location = new System.Drawing.Point(689, 12);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(44, 23);
            this.btntr.TabIndex = 14;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            // 
            // ucakbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.txtvarsaat);
            this.Controls.Add(this.txtkalsaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtucakkod);
            this.Controls.Add(this.txtkalvarnokta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucakbilgisi";
            this.Text = "ucakbilgisi";
            this.Load += new System.EventHandler(this.ucakbilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkalvarnokta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtucakkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkalsaat;
        private System.Windows.Forms.TextBox txtvarsaat;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}