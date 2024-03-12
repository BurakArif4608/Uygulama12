namespace Uygulama12
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAraEkle = new System.Windows.Forms.Button();
            this.btnGunelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.listeSehirler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehirler = new System.Windows.Forms.TextBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(45, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAraEkle
            // 
            this.btnAraEkle.Location = new System.Drawing.Point(158, 143);
            this.btnAraEkle.Name = "btnAraEkle";
            this.btnAraEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAraEkle.TabIndex = 1;
            this.btnAraEkle.Text = "Araya Ekle";
            this.btnAraEkle.UseVisualStyleBackColor = true;
            this.btnAraEkle.Click += new System.EventHandler(this.btnAraEkle_Click);
            // 
            // btnGunelle
            // 
            this.btnGunelle.Location = new System.Drawing.Point(264, 143);
            this.btnGunelle.Name = "btnGunelle";
            this.btnGunelle.Size = new System.Drawing.Size(75, 23);
            this.btnGunelle.TabIndex = 2;
            this.btnGunelle.Text = "Güncelle";
            this.btnGunelle.UseVisualStyleBackColor = true;
            this.btnGunelle.Click += new System.EventHandler(this.btnGunelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(359, 143);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(458, 143);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // listeSehirler
            // 
            this.listeSehirler.FormattingEnabled = true;
            this.listeSehirler.Location = new System.Drawing.Point(581, 128);
            this.listeSehirler.Name = "listeSehirler";
            this.listeSehirler.Size = new System.Drawing.Size(120, 199);
            this.listeSehirler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehirler";
            // 
            // txtSehirler
            // 
            this.txtSehirler.Location = new System.Drawing.Point(113, 74);
            this.txtSehirler.Name = "txtSehirler";
            this.txtSehirler.Size = new System.Drawing.Size(100, 20);
            this.txtSehirler.TabIndex = 7;
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(365, 230);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(38, 13);
            this.labelDurum.TabIndex = 8;
            this.labelDurum.Text = "Durum";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(508, 348);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(699, 348);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.txtSehirler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeSehirler);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGunelle);
            this.Controls.Add(this.btnAraEkle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAraEkle;
        private System.Windows.Forms.Button btnGunelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox listeSehirler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehirler;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSort;
    }
}

