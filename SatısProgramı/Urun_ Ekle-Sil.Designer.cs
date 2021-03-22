
namespace SatısProgramı
{
    partial class UrunEkle2
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
            System.Windows.Forms.Label birimLabel;
            System.Windows.Forms.Label barkodLabel;
            System.Windows.Forms.Label stok_AdetiLabel;
            System.Windows.Forms.Label urun_AdıLabel;
            System.Windows.Forms.Label alis_FiyatiLabel;
            System.Windows.Forms.Label acıklamaLabel;
            System.Windows.Forms.Label satis_FiyatiLabel;
            System.Windows.Forms.Label urun_GrubuLabel;
            System.Windows.Forms.Label label1;
            this.button1 = new System.Windows.Forms.Button();
            this.urun_GrubuComboBox = new System.Windows.Forms.ComboBox();
            this.stok_AdetiTextBox = new System.Windows.Forms.TextBox();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.birimComboBox = new System.Windows.Forms.ComboBox();
            this.alis_FiyatiTextBox = new System.Windows.Forms.TextBox();
            this.urun_AdıTextBox = new System.Windows.Forms.TextBox();
            this.satis_FiyatiTextBox = new System.Windows.Forms.TextBox();
            this.acıklamaTextBox = new System.Windows.Forms.TextBox();
            this.btn_Urun_Ekle = new System.Windows.Forms.Button();
            this.btn_Urun_Guncelle = new System.Windows.Forms.Button();
            this.btn_Urun_Sil = new System.Windows.Forms.Button();
            this.cmb_tercih_birim = new System.Windows.Forms.ComboBox();
            birimLabel = new System.Windows.Forms.Label();
            barkodLabel = new System.Windows.Forms.Label();
            stok_AdetiLabel = new System.Windows.Forms.Label();
            urun_AdıLabel = new System.Windows.Forms.Label();
            alis_FiyatiLabel = new System.Windows.Forms.Label();
            acıklamaLabel = new System.Windows.Forms.Label();
            satis_FiyatiLabel = new System.Windows.Forms.Label();
            urun_GrubuLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birimLabel
            // 
            birimLabel.AutoSize = true;
            birimLabel.Location = new System.Drawing.Point(43, 302);
            birimLabel.Name = "birimLabel";
            birimLabel.Size = new System.Drawing.Size(32, 13);
            birimLabel.TabIndex = 30;
            birimLabel.Text = "Birim:";
            // 
            // barkodLabel
            // 
            barkodLabel.AutoSize = true;
            barkodLabel.Location = new System.Drawing.Point(31, 23);
            barkodLabel.Name = "barkodLabel";
            barkodLabel.Size = new System.Drawing.Size(44, 13);
            barkodLabel.TabIndex = 18;
            barkodLabel.Text = "Barkod:";
            // 
            // stok_AdetiLabel
            // 
            stok_AdetiLabel.AutoSize = true;
            stok_AdetiLabel.Location = new System.Drawing.Point(17, 356);
            stok_AdetiLabel.Name = "stok_AdetiLabel";
            stok_AdetiLabel.Size = new System.Drawing.Size(59, 13);
            stok_AdetiLabel.TabIndex = 32;
            stok_AdetiLabel.Text = "Stok Adeti:";
            // 
            // urun_AdıLabel
            // 
            urun_AdıLabel.AutoSize = true;
            urun_AdıLabel.Location = new System.Drawing.Point(25, 49);
            urun_AdıLabel.Name = "urun_AdıLabel";
            urun_AdıLabel.Size = new System.Drawing.Size(51, 13);
            urun_AdıLabel.TabIndex = 20;
            urun_AdıLabel.Text = "Urun Adı:";
            // 
            // alis_FiyatiLabel
            // 
            alis_FiyatiLabel.AutoSize = true;
            alis_FiyatiLabel.Location = new System.Drawing.Point(204, 276);
            alis_FiyatiLabel.Name = "alis_FiyatiLabel";
            alis_FiyatiLabel.Size = new System.Drawing.Size(53, 13);
            alis_FiyatiLabel.TabIndex = 28;
            alis_FiyatiLabel.Text = "Alis Fiyati:";
            // 
            // acıklamaLabel
            // 
            acıklamaLabel.AutoSize = true;
            acıklamaLabel.Location = new System.Drawing.Point(22, 80);
            acıklamaLabel.Name = "acıklamaLabel";
            acıklamaLabel.Size = new System.Drawing.Size(53, 13);
            acıklamaLabel.TabIndex = 22;
            acıklamaLabel.Text = "Acıklama:";
            // 
            // satis_FiyatiLabel
            // 
            satis_FiyatiLabel.AutoSize = true;
            satis_FiyatiLabel.Location = new System.Drawing.Point(14, 276);
            satis_FiyatiLabel.Name = "satis_FiyatiLabel";
            satis_FiyatiLabel.Size = new System.Drawing.Size(60, 13);
            satis_FiyatiLabel.TabIndex = 26;
            satis_FiyatiLabel.Text = "Satis Fiyati:";
            // 
            // urun_GrubuLabel
            // 
            urun_GrubuLabel.AutoSize = true;
            urun_GrubuLabel.Location = new System.Drawing.Point(10, 249);
            urun_GrubuLabel.Name = "urun_GrubuLabel";
            urun_GrubuLabel.Size = new System.Drawing.Size(65, 13);
            urun_GrubuLabel.TabIndex = 24;
            urun_GrubuLabel.Text = "Ürün Grubu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun_GrubuComboBox
            // 
            this.urun_GrubuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urun_GrubuComboBox.FormattingEnabled = true;
            this.urun_GrubuComboBox.Location = new System.Drawing.Point(82, 246);
            this.urun_GrubuComboBox.Name = "urun_GrubuComboBox";
            this.urun_GrubuComboBox.Size = new System.Drawing.Size(256, 21);
            this.urun_GrubuComboBox.TabIndex = 25;
            // 
            // stok_AdetiTextBox
            // 
            this.stok_AdetiTextBox.Location = new System.Drawing.Point(82, 353);
            this.stok_AdetiTextBox.Name = "stok_AdetiTextBox";
            this.stok_AdetiTextBox.Size = new System.Drawing.Size(67, 20);
            this.stok_AdetiTextBox.TabIndex = 33;
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Location = new System.Drawing.Point(81, 20);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(115, 20);
            this.barkodTextBox.TabIndex = 19;
            this.barkodTextBox.Enter += new System.EventHandler(this.barkodTextBox_Enter);
            this.barkodTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barkodTextBox_KeyDown);
            this.barkodTextBox.Leave += new System.EventHandler(this.barkodTextBox_Leave);
            // 
            // birimComboBox
            // 
            this.birimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birimComboBox.FormattingEnabled = true;
            this.birimComboBox.Location = new System.Drawing.Point(82, 299);
            this.birimComboBox.Name = "birimComboBox";
            this.birimComboBox.Size = new System.Drawing.Size(256, 21);
            this.birimComboBox.TabIndex = 31;
            // 
            // alis_FiyatiTextBox
            // 
            this.alis_FiyatiTextBox.Location = new System.Drawing.Point(263, 273);
            this.alis_FiyatiTextBox.Name = "alis_FiyatiTextBox";
            this.alis_FiyatiTextBox.Size = new System.Drawing.Size(45, 20);
            this.alis_FiyatiTextBox.TabIndex = 29;
            // 
            // urun_AdıTextBox
            // 
            this.urun_AdıTextBox.Location = new System.Drawing.Point(82, 46);
            this.urun_AdıTextBox.Name = "urun_AdıTextBox";
            this.urun_AdıTextBox.Size = new System.Drawing.Size(256, 20);
            this.urun_AdıTextBox.TabIndex = 21;
            // 
            // satis_FiyatiTextBox
            // 
            this.satis_FiyatiTextBox.Location = new System.Drawing.Point(81, 273);
            this.satis_FiyatiTextBox.Name = "satis_FiyatiTextBox";
            this.satis_FiyatiTextBox.Size = new System.Drawing.Size(46, 20);
            this.satis_FiyatiTextBox.TabIndex = 27;
            // 
            // acıklamaTextBox
            // 
            this.acıklamaTextBox.Location = new System.Drawing.Point(81, 80);
            this.acıklamaTextBox.Multiline = true;
            this.acıklamaTextBox.Name = "acıklamaTextBox";
            this.acıklamaTextBox.Size = new System.Drawing.Size(257, 145);
            this.acıklamaTextBox.TabIndex = 23;
            // 
            // btn_Urun_Ekle
            // 
            this.btn_Urun_Ekle.Location = new System.Drawing.Point(20, 403);
            this.btn_Urun_Ekle.Name = "btn_Urun_Ekle";
            this.btn_Urun_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Urun_Ekle.TabIndex = 35;
            this.btn_Urun_Ekle.Text = "Ürün Ekle";
            this.btn_Urun_Ekle.UseVisualStyleBackColor = true;
            this.btn_Urun_Ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Urun_Guncelle
            // 
            this.btn_Urun_Guncelle.Location = new System.Drawing.Point(141, 403);
            this.btn_Urun_Guncelle.Name = "btn_Urun_Guncelle";
            this.btn_Urun_Guncelle.Size = new System.Drawing.Size(85, 23);
            this.btn_Urun_Guncelle.TabIndex = 35;
            this.btn_Urun_Guncelle.Text = "Ürün Güncelle";
            this.btn_Urun_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Urun_Guncelle.Click += new System.EventHandler(this.btn_Urun_Guncelle_Click);
            // 
            // btn_Urun_Sil
            // 
            this.btn_Urun_Sil.Location = new System.Drawing.Point(272, 403);
            this.btn_Urun_Sil.Name = "btn_Urun_Sil";
            this.btn_Urun_Sil.Size = new System.Drawing.Size(66, 23);
            this.btn_Urun_Sil.TabIndex = 35;
            this.btn_Urun_Sil.Text = "Ürün Sil";
            this.btn_Urun_Sil.UseVisualStyleBackColor = true;
            this.btn_Urun_Sil.Click += new System.EventHandler(this.btn_Urun_Sil_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 322);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 26);
            label1.TabIndex = 24;
            label1.Text = "Tercih Edilen\r\n Birim:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_tercih_birim
            // 
            this.cmb_tercih_birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tercih_birim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_tercih_birim.FormattingEnabled = true;
            this.cmb_tercih_birim.ItemHeight = 13;
            this.cmb_tercih_birim.Location = new System.Drawing.Point(82, 326);
            this.cmb_tercih_birim.Name = "cmb_tercih_birim";
            this.cmb_tercih_birim.Size = new System.Drawing.Size(256, 21);
            this.cmb_tercih_birim.TabIndex = 25;
            // 
            // UrunEkle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 448);
            this.Controls.Add(this.btn_Urun_Sil);
            this.Controls.Add(this.btn_Urun_Guncelle);
            this.Controls.Add(this.btn_Urun_Ekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_tercih_birim);
            this.Controls.Add(this.urun_GrubuComboBox);
            this.Controls.Add(this.stok_AdetiTextBox);
            this.Controls.Add(birimLabel);
            this.Controls.Add(barkodLabel);
            this.Controls.Add(stok_AdetiLabel);
            this.Controls.Add(this.barkodTextBox);
            this.Controls.Add(this.birimComboBox);
            this.Controls.Add(urun_AdıLabel);
            this.Controls.Add(this.alis_FiyatiTextBox);
            this.Controls.Add(this.urun_AdıTextBox);
            this.Controls.Add(alis_FiyatiLabel);
            this.Controls.Add(acıklamaLabel);
            this.Controls.Add(this.satis_FiyatiTextBox);
            this.Controls.Add(this.acıklamaTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(satis_FiyatiLabel);
            this.Controls.Add(urun_GrubuLabel);
            this.Name = "UrunEkle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle-Düzenle";
            this.Load += new System.EventHandler(this.UrunEkle2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox urun_GrubuComboBox;
        private System.Windows.Forms.TextBox stok_AdetiTextBox;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.ComboBox birimComboBox;
        private System.Windows.Forms.TextBox alis_FiyatiTextBox;
        private System.Windows.Forms.TextBox urun_AdıTextBox;
        private System.Windows.Forms.TextBox satis_FiyatiTextBox;
        private System.Windows.Forms.TextBox acıklamaTextBox;
        private System.Windows.Forms.Button btn_Urun_Ekle;
        private System.Windows.Forms.Button btn_Urun_Guncelle;
        private System.Windows.Forms.Button btn_Urun_Sil;
        private System.Windows.Forms.ComboBox cmb_tercih_birim;
    }
}