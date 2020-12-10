namespace DövizUygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDovizAl = new System.Windows.Forms.Button();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDolarAl = new System.Windows.Forms.Button();
            this.btnDolarSat = new System.Windows.Forms.Button();
            this.btnEuroAl = new System.Windows.Forms.Button();
            this.btnEuroSat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış :";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.Location = new System.Drawing.Point(106, 53);
            this.lblDolarAlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(18, 20);
            this.lblDolarAlis.TabIndex = 1;
            this.lblDolarAlis.Text = "0";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.Location = new System.Drawing.Point(106, 86);
            this.lblDolarSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(18, 20);
            this.lblDolarSatis.TabIndex = 3;
            this.lblDolarSatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış :";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.Location = new System.Drawing.Point(106, 122);
            this.lblEuroAlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(18, 20);
            this.lblEuroAlis.TabIndex = 5;
            this.lblEuroAlis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Euro Alış :";
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.Location = new System.Drawing.Point(106, 161);
            this.lblEuroSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(18, 20);
            this.lblEuroSatis.TabIndex = 7;
            this.lblEuroSatis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Euro Satış :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnDovizAl);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 245);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Paran Kadar Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDovizAl
            // 
            this.btnDovizAl.Location = new System.Drawing.Point(19, 195);
            this.btnDovizAl.Name = "btnDovizAl";
            this.btnDovizAl.Size = new System.Drawing.Size(93, 44);
            this.btnDovizAl.TabIndex = 8;
            this.btnDovizAl.Text = "Döviz Al";
            this.btnDovizAl.UseVisualStyleBackColor = true;
            this.btnDovizAl.Click += new System.EventHandler(this.btnDovizAl_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(73, 122);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(168, 26);
            this.txtKalan.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kalan :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(73, 92);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(168, 26);
            this.txtTutar.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tutar :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(73, 56);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(168, 26);
            this.txtMiktar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Miktar :";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(73, 23);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(168, 26);
            this.txtKur.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur :";
            // 
            // btnDolarAl
            // 
            this.btnDolarAl.Location = new System.Drawing.Point(142, 49);
            this.btnDolarAl.Name = "btnDolarAl";
            this.btnDolarAl.Size = new System.Drawing.Size(56, 24);
            this.btnDolarAl.TabIndex = 9;
            this.btnDolarAl.Text = "Al";
            this.btnDolarAl.UseVisualStyleBackColor = true;
            this.btnDolarAl.Click += new System.EventHandler(this.btnDolarAl_Click);
            // 
            // btnDolarSat
            // 
            this.btnDolarSat.Location = new System.Drawing.Point(142, 86);
            this.btnDolarSat.Name = "btnDolarSat";
            this.btnDolarSat.Size = new System.Drawing.Size(56, 24);
            this.btnDolarSat.TabIndex = 10;
            this.btnDolarSat.Text = "Sat";
            this.btnDolarSat.UseVisualStyleBackColor = true;
            this.btnDolarSat.Click += new System.EventHandler(this.btnDolarSat_Click);
            // 
            // btnEuroAl
            // 
            this.btnEuroAl.Location = new System.Drawing.Point(142, 122);
            this.btnEuroAl.Name = "btnEuroAl";
            this.btnEuroAl.Size = new System.Drawing.Size(56, 24);
            this.btnEuroAl.TabIndex = 11;
            this.btnEuroAl.Text = "Al";
            this.btnEuroAl.UseVisualStyleBackColor = true;
            this.btnEuroAl.Click += new System.EventHandler(this.btnEuroAl_Click);
            // 
            // btnEuroSat
            // 
            this.btnEuroSat.Location = new System.Drawing.Point(142, 157);
            this.btnEuroSat.Name = "btnEuroSat";
            this.btnEuroSat.Size = new System.Drawing.Size(56, 24);
            this.btnEuroSat.TabIndex = 12;
            this.btnEuroSat.Text = "Sat";
            this.btnEuroSat.UseVisualStyleBackColor = true;
            this.btnEuroSat.Click += new System.EventHandler(this.btnEuroSat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(663, 458);
            this.Controls.Add(this.btnEuroSat);
            this.Controls.Add(this.btnEuroAl);
            this.Controls.Add(this.btnDolarSat);
            this.Controls.Add(this.btnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDovizAl;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDolarAl;
        private System.Windows.Forms.Button btnDolarSat;
        private System.Windows.Forms.Button btnEuroAl;
        private System.Windows.Forms.Button btnEuroSat;
    }
}

