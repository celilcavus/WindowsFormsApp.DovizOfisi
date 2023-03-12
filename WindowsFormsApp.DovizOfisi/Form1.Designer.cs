namespace WindowsFormsApp.DovizOfisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.MaskedTextBox();
            this.txtTutar = new System.Windows.Forms.MaskedTextBox();
            this.txtKur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dolar Alış :";
            this.label1.Click += new System.EventHandler(this.lblDolarAlis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Euro Alış :";
            this.label2.Click += new System.EventHandler(this.lblEuroAlis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Euro Satış :";
            this.label3.Click += new System.EventHandler(this.lblEuroSatis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dolar Satış :";
            this.label4.Click += new System.EventHandler(this.lblDolarSatis_Click);
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.ForeColor = System.Drawing.Color.Black;
            this.lblEuroSatis.Location = new System.Drawing.Point(126, 152);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(19, 20);
            this.lblEuroSatis.TabIndex = 7;
            this.lblEuroSatis.Text = "0";
            this.lblEuroSatis.Click += new System.EventHandler(this.lblEuroSatis_Click);
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.ForeColor = System.Drawing.Color.Black;
            this.lblDolarSatis.Location = new System.Drawing.Point(126, 120);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(19, 20);
            this.lblDolarSatis.TabIndex = 8;
            this.lblDolarSatis.Text = "0";
            this.lblDolarSatis.Click += new System.EventHandler(this.lblDolarSatis_Click);
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.ForeColor = System.Drawing.Color.Black;
            this.lblEuroAlis.Location = new System.Drawing.Point(126, 80);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(19, 20);
            this.lblEuroAlis.TabIndex = 9;
            this.lblEuroAlis.Text = "0";
            this.lblEuroAlis.Click += new System.EventHandler(this.lblEuroAlis_Click);
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.ForeColor = System.Drawing.Color.Black;
            this.lblDolarAlis.Location = new System.Drawing.Point(126, 49);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(19, 20);
            this.lblDolarAlis.TabIndex = 10;
            this.lblDolarAlis.Text = "0";
            this.lblDolarAlis.Click += new System.EventHandler(this.lblDolarAlis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.btnSatis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(545, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 460);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kur :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Miktar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tutar :";
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(96, 140);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(224, 33);
            this.btnSatis.TabIndex = 11;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(96, 75);
            this.txtMiktar.Mask = "0000000000";
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(224, 26);
            this.txtMiktar.TabIndex = 13;
            this.txtMiktar.ValidatingType = typeof(int);
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(96, 108);
            this.txtTutar.Mask = "0000000000";
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(224, 26);
            this.txtTutar.TabIndex = 14;
            this.txtTutar.ValidatingType = typeof(int);
            // 
            // txtKur
            // 
            this.txtKur.Enabled = false;
            this.txtKur.Location = new System.Drawing.Point(96, 40);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(224, 26);
            this.txtKur.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTutar;
        private System.Windows.Forms.MaskedTextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKur;
    }
}

