
namespace stressTool
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
            this.hedefUrl = new System.Windows.Forms.Label();
            this.kullanicisayisilabel = new System.Windows.Forms.Label();
            this.urlGir = new System.Windows.Forms.TextBox();
            this.ortalamaiSteklabel = new System.Windows.Forms.Label();
            this.ortalamaHizlabel = new System.Windows.Forms.Label();
            this.toplamVerilabel = new System.Windows.Forms.Label();
            this.Birakilanisteklabel = new System.Windows.Forms.Label();
            this.toplamZamanlabel = new System.Windows.Forms.Label();
            this.toplamTaleplabel = new System.Windows.Forms.Label();
            this.saniyedeGonderileniSteklabel = new System.Windows.Forms.Label();
            this.baslaButton = new System.Windows.Forms.Button();
            this.sıfırlaButton = new System.Windows.Forms.Button();
            this.bitirButton = new System.Windows.Forms.Button();
            this.kullaniciSayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // hedefUrl
            // 
            this.hedefUrl.AutoSize = true;
            this.hedefUrl.Location = new System.Drawing.Point(52, 38);
            this.hedefUrl.Name = "hedefUrl";
            this.hedefUrl.Size = new System.Drawing.Size(51, 13);
            this.hedefUrl.TabIndex = 0;
            this.hedefUrl.Text = "URL GİR";
            // 
            // kullanicisayisilabel
            // 
            this.kullanicisayisilabel.AutoSize = true;
            this.kullanicisayisilabel.Location = new System.Drawing.Point(52, 85);
            this.kullanicisayisilabel.Name = "kullanicisayisilabel";
            this.kullanicisayisilabel.Size = new System.Drawing.Size(76, 13);
            this.kullanicisayisilabel.TabIndex = 1;
            this.kullanicisayisilabel.Text = "Kullanıcı Sayısı";
            // 
            // urlGir
            // 
            this.urlGir.Location = new System.Drawing.Point(150, 35);
            this.urlGir.Name = "urlGir";
            this.urlGir.Size = new System.Drawing.Size(267, 20);
            this.urlGir.TabIndex = 3;
            this.urlGir.Text = "http://localhost";
            // 
            // ortalamaiSteklabel
            // 
            this.ortalamaiSteklabel.AutoSize = true;
            this.ortalamaiSteklabel.Location = new System.Drawing.Point(147, 276);
            this.ortalamaiSteklabel.Name = "ortalamaiSteklabel";
            this.ortalamaiSteklabel.Size = new System.Drawing.Size(175, 13);
            this.ortalamaiSteklabel.TabIndex = 22;
            this.ortalamaiSteklabel.Text = "Saniyedeki Ortalama İstek Sayısı : 0";
            this.ortalamaiSteklabel.Click += new System.EventHandler(this.AverageRequestsLabel_Click);
            // 
            // ortalamaHizlabel
            // 
            this.ortalamaHizlabel.AutoSize = true;
            this.ortalamaHizlabel.Location = new System.Drawing.Point(147, 248);
            this.ortalamaHizlabel.Name = "ortalamaHizlabel";
            this.ortalamaHizlabel.Size = new System.Drawing.Size(111, 13);
            this.ortalamaHizlabel.TabIndex = 21;
            this.ortalamaHizlabel.Text = "Ortalama İletim Hızı : 0";
            // 
            // toplamVerilabel
            // 
            this.toplamVerilabel.AutoSize = true;
            this.toplamVerilabel.Location = new System.Drawing.Point(145, 226);
            this.toplamVerilabel.Name = "toplamVerilabel";
            this.toplamVerilabel.Size = new System.Drawing.Size(110, 13);
            this.toplamVerilabel.TabIndex = 20;
            this.toplamVerilabel.Text = "Alınan Toplam Veri : 0";
            // 
            // Birakilanisteklabel
            // 
            this.Birakilanisteklabel.AutoSize = true;
            this.Birakilanisteklabel.Location = new System.Drawing.Point(147, 204);
            this.Birakilanisteklabel.Name = "Birakilanisteklabel";
            this.Birakilanisteklabel.Size = new System.Drawing.Size(250, 13);
            this.Birakilanisteklabel.TabIndex = 19;
            this.Birakilanisteklabel.Text = "Sunucu Tarafından Bırakılan Toplam İstek Sayısı : 0";
            // 
            // toplamZamanlabel
            // 
            this.toplamZamanlabel.AutoSize = true;
            this.toplamZamanlabel.Location = new System.Drawing.Point(147, 181);
            this.toplamZamanlabel.Name = "toplamZamanlabel";
            this.toplamZamanlabel.Size = new System.Drawing.Size(82, 13);
            this.toplamZamanlabel.TabIndex = 18;
            this.toplamZamanlabel.Text = "Toplam Süre : 0";
            // 
            // toplamTaleplabel
            // 
            this.toplamTaleplabel.AutoSize = true;
            this.toplamTaleplabel.Location = new System.Drawing.Point(147, 158);
            this.toplamTaleplabel.Name = "toplamTaleplabel";
            this.toplamTaleplabel.Size = new System.Drawing.Size(137, 13);
            this.toplamTaleplabel.TabIndex = 17;
            this.toplamTaleplabel.Text = "Gönderilen Toplam İstek : 0";
            // 
            // saniyedeGonderileniSteklabel
            // 
            this.saniyedeGonderileniSteklabel.AutoSize = true;
            this.saniyedeGonderileniSteklabel.Location = new System.Drawing.Point(147, 130);
            this.saniyedeGonderileniSteklabel.Name = "saniyedeGonderileniSteklabel";
            this.saniyedeGonderileniSteklabel.Size = new System.Drawing.Size(236, 13);
            this.saniyedeGonderileniSteklabel.TabIndex = 16;
            this.saniyedeGonderileniSteklabel.Text = "Saniyede Gönderilen İstek Hızında Gönderme : 0";
            // 
            // baslaButton
            // 
            this.baslaButton.Location = new System.Drawing.Point(492, 38);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(75, 23);
            this.baslaButton.TabIndex = 23;
            this.baslaButton.Text = "Başla";
            this.baslaButton.UseVisualStyleBackColor = true;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // sıfırlaButton
            // 
            this.sıfırlaButton.Location = new System.Drawing.Point(492, 85);
            this.sıfırlaButton.Name = "sıfırlaButton";
            this.sıfırlaButton.Size = new System.Drawing.Size(75, 23);
            this.sıfırlaButton.TabIndex = 24;
            this.sıfırlaButton.Text = "Sıfırla";
            this.sıfırlaButton.UseVisualStyleBackColor = true;
            this.sıfırlaButton.Click += new System.EventHandler(this.sıfırlaButton_Click);
            // 
            // bitirButton
            // 
            this.bitirButton.Location = new System.Drawing.Point(492, 130);
            this.bitirButton.Name = "bitirButton";
            this.bitirButton.Size = new System.Drawing.Size(75, 23);
            this.bitirButton.TabIndex = 25;
            this.bitirButton.Text = "Bitir";
            this.bitirButton.UseVisualStyleBackColor = true;
            this.bitirButton.Click += new System.EventHandler(this.bitirButton_Click);
            // 
            // kullaniciSayisi
            // 
            this.kullaniciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.kullaniciSayisi.Location = new System.Drawing.Point(150, 71);
            this.kullaniciSayisi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.kullaniciSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kullaniciSayisi.Name = "kullaniciSayisi";
            this.kullaniciSayisi.Size = new System.Drawing.Size(255, 35);
            this.kullaniciSayisi.TabIndex = 26;
            this.kullaniciSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 315);
            this.Controls.Add(this.kullaniciSayisi);
            this.Controls.Add(this.bitirButton);
            this.Controls.Add(this.sıfırlaButton);
            this.Controls.Add(this.baslaButton);
            this.Controls.Add(this.ortalamaiSteklabel);
            this.Controls.Add(this.ortalamaHizlabel);
            this.Controls.Add(this.toplamVerilabel);
            this.Controls.Add(this.Birakilanisteklabel);
            this.Controls.Add(this.toplamZamanlabel);
            this.Controls.Add(this.toplamTaleplabel);
            this.Controls.Add(this.saniyedeGonderileniSteklabel);
            this.Controls.Add(this.urlGir);
            this.Controls.Add(this.kullanicisayisilabel);
            this.Controls.Add(this.hedefUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hedefUrl;
        private System.Windows.Forms.Label kullanicisayisilabel;
        private System.Windows.Forms.TextBox urlGir;
        private System.Windows.Forms.Label ortalamaiSteklabel;
        private System.Windows.Forms.Label ortalamaHizlabel;
        private System.Windows.Forms.Label toplamVerilabel;
        private System.Windows.Forms.Label Birakilanisteklabel;
        private System.Windows.Forms.Label toplamZamanlabel;
        private System.Windows.Forms.Label toplamTaleplabel;
        private System.Windows.Forms.Label saniyedeGonderileniSteklabel;
        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Button sıfırlaButton;
        private System.Windows.Forms.Button bitirButton;
        private System.Windows.Forms.NumericUpDown kullaniciSayisi;
    }
}

