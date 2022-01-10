namespace _1a_b181210015_odev3
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
            this.textBox_islem = new System.Windows.Forms.TextBox();
            this.textBox_sonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_islem
            // 
            this.textBox_islem.Location = new System.Drawing.Point(109, 154);
            this.textBox_islem.Name = "textBox_islem";
            this.textBox_islem.Size = new System.Drawing.Size(187, 22);
            this.textBox_islem.TabIndex = 0;
            // 
            // textBox_sonuc
            // 
            this.textBox_sonuc.Location = new System.Drawing.Point(109, 224);
            this.textBox_sonuc.Name = "textBox_sonuc";
            this.textBox_sonuc.Size = new System.Drawing.Size(187, 22);
            this.textBox_sonuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsleminizi Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sonuc:";
            // 
            // button_hesapla
            // 
            this.button_hesapla.Location = new System.Drawing.Point(109, 268);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(84, 23);
            this.button_hesapla.TabIndex = 4;
            this.button_hesapla.Text = "Hesapla";
            this.button_hesapla.UseVisualStyleBackColor = true;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(214, 268);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(82, 23);
            this.button_sil.TabIndex = 5;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 354);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_hesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sonuc);
            this.Controls.Add(this.textBox_islem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_islem;
        private System.Windows.Forms.TextBox textBox_sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.Button button_sil;
    }
}

