namespace B181210015_1.ODEV_1A
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox_bilgiler = new System.Windows.Forms.RichTextBox();
            this.button_dosyasec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_yası = new System.Windows.Forms.Label();
            this.label_calismasure = new System.Windows.Forms.Label();
            this.label_medenihal = new System.Windows.Forms.Label();
            this.label_calisiyormu = new System.Windows.Forms.Label();
            this.label_cocuksayisi = new System.Windows.Forms.Label();
            this.label_tabanmaas = new System.Windows.Forms.Label();
            this.label_makamtazminati = new System.Windows.Forms.Label();
            this.label_idarigrvtazmnt = new System.Windows.Forms.Label();
            this.label_fazlamesaisa = new System.Windows.Forms.Label();
            this.label_fazlamesaiucr = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_vergimatrahi = new System.Windows.Forms.Label();
            this.button_ara = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_burutmaas = new System.Windows.Forms.Label();
            this.label_damgavergisi = new System.Windows.Forms.Label();
            this.label_gelirvergisi = new System.Windows.Forms.Label();
            this.label_netmaas = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_emeklikesintisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_bilgiler
            // 
            this.richTextBox_bilgiler.Enabled = false;
            this.richTextBox_bilgiler.Location = new System.Drawing.Point(32, 413);
            this.richTextBox_bilgiler.Name = "richTextBox_bilgiler";
            this.richTextBox_bilgiler.Size = new System.Drawing.Size(788, 201);
            this.richTextBox_bilgiler.TabIndex = 0;
            this.richTextBox_bilgiler.Text = "";
            // 
            // button_dosyasec
            // 
            this.button_dosyasec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dosyasec.Location = new System.Drawing.Point(662, 346);
            this.button_dosyasec.Name = "button_dosyasec";
            this.button_dosyasec.Size = new System.Drawing.Size(121, 43);
            this.button_dosyasec.TabIndex = 1;
            this.button_dosyasec.Text = "Dosya";
            this.button_dosyasec.UseVisualStyleBackColor = true;
            this.button_dosyasec.Click += new System.EventHandler(this.button_dosyasec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calısma Süresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Medeni Hali:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Esi Calısıyor mu?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cocuk Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Taban Maas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Makam Tazminatı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "İdari Görev Tazminatı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fazla Mesai Saati:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Fazla Mesai Ucreti:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(659, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Personel Resmi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(662, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(92, 27);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(123, 22);
            this.textBox_tc.TabIndex = 17;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(94, 67);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(13, 17);
            this.label_ad.TabIndex = 18;
            this.label_ad.Text = "-";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(116, 104);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(13, 17);
            this.label_soyad.TabIndex = 19;
            this.label_soyad.Text = "-";
            // 
            // label_yası
            // 
            this.label_yası.AutoSize = true;
            this.label_yası.Location = new System.Drawing.Point(106, 143);
            this.label_yası.Name = "label_yası";
            this.label_yası.Size = new System.Drawing.Size(13, 17);
            this.label_yası.TabIndex = 20;
            this.label_yası.Text = "-";
            // 
            // label_calismasure
            // 
            this.label_calismasure.AutoSize = true;
            this.label_calismasure.Location = new System.Drawing.Point(166, 181);
            this.label_calismasure.Name = "label_calismasure";
            this.label_calismasure.Size = new System.Drawing.Size(13, 17);
            this.label_calismasure.TabIndex = 21;
            this.label_calismasure.Text = "-";
            // 
            // label_medenihal
            // 
            this.label_medenihal.AutoSize = true;
            this.label_medenihal.Location = new System.Drawing.Point(147, 221);
            this.label_medenihal.Name = "label_medenihal";
            this.label_medenihal.Size = new System.Drawing.Size(13, 17);
            this.label_medenihal.TabIndex = 22;
            this.label_medenihal.Text = "-";
            // 
            // label_calisiyormu
            // 
            this.label_calisiyormu.AutoSize = true;
            this.label_calisiyormu.Location = new System.Drawing.Point(176, 259);
            this.label_calisiyormu.Name = "label_calisiyormu";
            this.label_calisiyormu.Size = new System.Drawing.Size(13, 17);
            this.label_calisiyormu.TabIndex = 23;
            this.label_calisiyormu.Text = "-";
            // 
            // label_cocuksayisi
            // 
            this.label_cocuksayisi.AutoSize = true;
            this.label_cocuksayisi.Location = new System.Drawing.Point(161, 293);
            this.label_cocuksayisi.Name = "label_cocuksayisi";
            this.label_cocuksayisi.Size = new System.Drawing.Size(13, 17);
            this.label_cocuksayisi.TabIndex = 24;
            this.label_cocuksayisi.Text = "-";
            // 
            // label_tabanmaas
            // 
            this.label_tabanmaas.AutoSize = true;
            this.label_tabanmaas.Location = new System.Drawing.Point(152, 333);
            this.label_tabanmaas.Name = "label_tabanmaas";
            this.label_tabanmaas.Size = new System.Drawing.Size(13, 17);
            this.label_tabanmaas.TabIndex = 25;
            this.label_tabanmaas.Text = "-";
            // 
            // label_makamtazminati
            // 
            this.label_makamtazminati.AutoSize = true;
            this.label_makamtazminati.Location = new System.Drawing.Point(183, 372);
            this.label_makamtazminati.Name = "label_makamtazminati";
            this.label_makamtazminati.Size = new System.Drawing.Size(13, 17);
            this.label_makamtazminati.TabIndex = 26;
            this.label_makamtazminati.Text = "-";
            // 
            // label_idarigrvtazmnt
            // 
            this.label_idarigrvtazmnt.AutoSize = true;
            this.label_idarigrvtazmnt.Location = new System.Drawing.Point(548, 35);
            this.label_idarigrvtazmnt.Name = "label_idarigrvtazmnt";
            this.label_idarigrvtazmnt.Size = new System.Drawing.Size(13, 17);
            this.label_idarigrvtazmnt.TabIndex = 27;
            this.label_idarigrvtazmnt.Text = "-";
            // 
            // label_fazlamesaisa
            // 
            this.label_fazlamesaisa.AutoSize = true;
            this.label_fazlamesaisa.Location = new System.Drawing.Point(529, 68);
            this.label_fazlamesaisa.Name = "label_fazlamesaisa";
            this.label_fazlamesaisa.Size = new System.Drawing.Size(13, 17);
            this.label_fazlamesaisa.TabIndex = 28;
            this.label_fazlamesaisa.Text = "-";
            // 
            // label_fazlamesaiucr
            // 
            this.label_fazlamesaiucr.AutoSize = true;
            this.label_fazlamesaiucr.Location = new System.Drawing.Point(534, 104);
            this.label_fazlamesaiucr.Name = "label_fazlamesaiucr";
            this.label_fazlamesaiucr.Size = new System.Drawing.Size(13, 17);
            this.label_fazlamesaiucr.TabIndex = 29;
            this.label_fazlamesaiucr.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(395, 143);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 17);
            this.label27.TabIndex = 30;
            this.label27.Text = "Vergi Matrahı:";
            // 
            // label_vergimatrahi
            // 
            this.label_vergimatrahi.AutoSize = true;
            this.label_vergimatrahi.Location = new System.Drawing.Point(502, 143);
            this.label_vergimatrahi.Name = "label_vergimatrahi";
            this.label_vergimatrahi.Size = new System.Drawing.Size(13, 17);
            this.label_vergimatrahi.TabIndex = 31;
            this.label_vergimatrahi.Text = "-";
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(238, 26);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(84, 34);
            this.button_ara.TabIndex = 32;
            this.button_ara.Text = "Ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(398, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bürüt Maas:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(398, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Damga Vergisi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(398, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Gelir Vergisi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(398, 372);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Net Maas:";
            // 
            // label_burutmaas
            // 
            this.label_burutmaas.AutoSize = true;
            this.label_burutmaas.Location = new System.Drawing.Point(493, 221);
            this.label_burutmaas.Name = "label_burutmaas";
            this.label_burutmaas.Size = new System.Drawing.Size(13, 17);
            this.label_burutmaas.TabIndex = 37;
            this.label_burutmaas.Text = "-";
            // 
            // label_damgavergisi
            // 
            this.label_damgavergisi.AutoSize = true;
            this.label_damgavergisi.Location = new System.Drawing.Point(507, 259);
            this.label_damgavergisi.Name = "label_damgavergisi";
            this.label_damgavergisi.Size = new System.Drawing.Size(13, 17);
            this.label_damgavergisi.TabIndex = 38;
            this.label_damgavergisi.Text = "-";
            // 
            // label_gelirvergisi
            // 
            this.label_gelirvergisi.AutoSize = true;
            this.label_gelirvergisi.Location = new System.Drawing.Point(493, 293);
            this.label_gelirvergisi.Name = "label_gelirvergisi";
            this.label_gelirvergisi.Size = new System.Drawing.Size(13, 17);
            this.label_gelirvergisi.TabIndex = 39;
            this.label_gelirvergisi.Text = "-";
            // 
            // label_netmaas
            // 
            this.label_netmaas.AutoSize = true;
            this.label_netmaas.Location = new System.Drawing.Point(476, 372);
            this.label_netmaas.Name = "label_netmaas";
            this.label_netmaas.Size = new System.Drawing.Size(13, 17);
            this.label_netmaas.TabIndex = 40;
            this.label_netmaas.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(398, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Emekli Kesintisi:";
            // 
            // label_emeklikesintisi
            // 
            this.label_emeklikesintisi.AutoSize = true;
            this.label_emeklikesintisi.Location = new System.Drawing.Point(507, 333);
            this.label_emeklikesintisi.Name = "label_emeklikesintisi";
            this.label_emeklikesintisi.Size = new System.Drawing.Size(13, 17);
            this.label_emeklikesintisi.TabIndex = 42;
            this.label_emeklikesintisi.Text = "-";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 626);
            this.Controls.Add(this.label_emeklikesintisi);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label_netmaas);
            this.Controls.Add(this.label_gelirvergisi);
            this.Controls.Add(this.label_damgavergisi);
            this.Controls.Add(this.label_burutmaas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.label_vergimatrahi);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label_fazlamesaiucr);
            this.Controls.Add(this.label_fazlamesaisa);
            this.Controls.Add(this.label_idarigrvtazmnt);
            this.Controls.Add(this.label_makamtazminati);
            this.Controls.Add(this.label_tabanmaas);
            this.Controls.Add(this.label_cocuksayisi);
            this.Controls.Add(this.label_calisiyormu);
            this.Controls.Add(this.label_medenihal);
            this.Controls.Add(this.label_calismasure);
            this.Controls.Add(this.label_yası);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.textBox_tc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_dosyasec);
            this.Controls.Add(this.richTextBox_bilgiler);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_bilgiler;
        private System.Windows.Forms.Button button_dosyasec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_yası;
        private System.Windows.Forms.Label label_calismasure;
        private System.Windows.Forms.Label label_medenihal;
        private System.Windows.Forms.Label label_calisiyormu;
        private System.Windows.Forms.Label label_cocuksayisi;
        private System.Windows.Forms.Label label_tabanmaas;
        private System.Windows.Forms.Label label_makamtazminati;
        private System.Windows.Forms.Label label_idarigrvtazmnt;
        private System.Windows.Forms.Label label_fazlamesaisa;
        private System.Windows.Forms.Label label_fazlamesaiucr;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_vergimatrahi;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_burutmaas;
        private System.Windows.Forms.Label label_damgavergisi;
        private System.Windows.Forms.Label label_gelirvergisi;
        private System.Windows.Forms.Label label_netmaas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_emeklikesintisi;
    }
}

