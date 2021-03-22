
namespace SatısProgramı
{
    partial class Stok_Girisi_Tek
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
            System.Windows.Forms.Label acıklamaLabel;
            System.Windows.Forms.Label satis_FiyatiLabel;
            System.Windows.Forms.Label urun_GrubuLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.stok_AdetiTextBox = new System.Windows.Forms.TextBox();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.birimComboBox = new System.Windows.Forms.ComboBox();
            this.urun_AdıTextBox = new System.Windows.Forms.TextBox();
            this.satis_FiyatiTextBox = new System.Windows.Forms.TextBox();
            this.acıklamaTextBox = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.txtb_Ek_Stok = new System.Windows.Forms.TextBox();
            this.txtb_Urun_Grubu = new System.Windows.Forms.TextBox();
            this.txtb_alıs_fiyatı = new System.Windows.Forms.TextBox();
            birimLabel = new System.Windows.Forms.Label();
            barkodLabel = new System.Windows.Forms.Label();
            stok_AdetiLabel = new System.Windows.Forms.Label();
            urun_AdıLabel = new System.Windows.Forms.Label();
            acıklamaLabel = new System.Windows.Forms.Label();
            satis_FiyatiLabel = new System.Windows.Forms.Label();
            urun_GrubuLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birimLabel
            // 
            birimLabel.AutoSize = true;
            birimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            birimLabel.Location = new System.Drawing.Point(31, 316);
            birimLabel.Name = "birimLabel";
            birimLabel.Size = new System.Drawing.Size(43, 17);
            birimLabel.TabIndex = 49;
            birimLabel.Text = "Birim:";
            // 
            // barkodLabel
            // 
            barkodLabel.AutoSize = true;
            barkodLabel.Location = new System.Drawing.Point(40, 18);
            barkodLabel.Name = "barkodLabel";
            barkodLabel.Size = new System.Drawing.Size(44, 13);
            barkodLabel.TabIndex = 35;
            barkodLabel.Text = "Barkod:";
            // 
            // stok_AdetiLabel
            // 
            stok_AdetiLabel.AutoSize = true;
            stok_AdetiLabel.Location = new System.Drawing.Point(201, 375);
            stok_AdetiLabel.Name = "stok_AdetiLabel";
            stok_AdetiLabel.Size = new System.Drawing.Size(59, 13);
            stok_AdetiLabel.TabIndex = 51;
            stok_AdetiLabel.Text = "Stok Adeti:";
            // 
            // urun_AdıLabel
            // 
            urun_AdıLabel.AutoSize = true;
            urun_AdıLabel.Location = new System.Drawing.Point(34, 44);
            urun_AdıLabel.Name = "urun_AdıLabel";
            urun_AdıLabel.Size = new System.Drawing.Size(51, 13);
            urun_AdıLabel.TabIndex = 37;
            urun_AdıLabel.Text = "Urun Adı:";
            // 
            // acıklamaLabel
            // 
            acıklamaLabel.AutoSize = true;
            acıklamaLabel.Location = new System.Drawing.Point(31, 75);
            acıklamaLabel.Name = "acıklamaLabel";
            acıklamaLabel.Size = new System.Drawing.Size(53, 13);
            acıklamaLabel.TabIndex = 39;
            acıklamaLabel.Text = "Acıklama:";
            // 
            // satis_FiyatiLabel
            // 
            satis_FiyatiLabel.AutoSize = true;
            satis_FiyatiLabel.Location = new System.Drawing.Point(23, 285);
            satis_FiyatiLabel.Name = "satis_FiyatiLabel";
            satis_FiyatiLabel.Size = new System.Drawing.Size(60, 13);
            satis_FiyatiLabel.TabIndex = 45;
            satis_FiyatiLabel.Text = "Satis Fiyati:";
            // 
            // urun_GrubuLabel
            // 
            urun_GrubuLabel.AutoSize = true;
            urun_GrubuLabel.Location = new System.Drawing.Point(19, 244);
            urun_GrubuLabel.Name = "urun_GrubuLabel";
            urun_GrubuLabel.Size = new System.Drawing.Size(65, 13);
            urun_GrubuLabel.TabIndex = 42;
            urun_GrubuLabel.Text = "Ürün Grubu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Location = new System.Drawing.Point(6, 381);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 30);
            label1.TabIndex = 51;
            label1.Text = "Eklenecek Stok \r\nAdeti:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.Location = new System.Drawing.Point(23, 353);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 15);
            label2.TabIndex = 51;
            label2.Text = "Alış Fiyatı";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // stok_AdetiTextBox
            // 
            this.stok_AdetiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_AdetiTextBox.Location = new System.Drawing.Point(266, 367);
            this.stok_AdetiTextBox.Name = "stok_AdetiTextBox";
            this.stok_AdetiTextBox.Size = new System.Drawing.Size(67, 30);
            this.stok_AdetiTextBox.TabIndex = 52;
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Location = new System.Drawing.Point(90, 15);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(115, 20);
            this.barkodTextBox.TabIndex = 1;
            this.barkodTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barkodTextBox_KeyDown);
            // 
            // birimComboBox
            // 
            this.birimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birimComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimComboBox.FormattingEnabled = true;
            this.birimComboBox.Location = new System.Drawing.Point(90, 313);
            this.birimComboBox.Name = "birimComboBox";
            this.birimComboBox.Size = new System.Drawing.Size(256, 24);
            this.birimComboBox.TabIndex = 4;
            // 
            // urun_AdıTextBox
            // 
            this.urun_AdıTextBox.Location = new System.Drawing.Point(91, 41);
            this.urun_AdıTextBox.Name = "urun_AdıTextBox";
            this.urun_AdıTextBox.Size = new System.Drawing.Size(256, 20);
            this.urun_AdıTextBox.TabIndex = 38;
            // 
            // satis_FiyatiTextBox
            // 
            this.satis_FiyatiTextBox.Location = new System.Drawing.Point(90, 279);
            this.satis_FiyatiTextBox.Multiline = true;
            this.satis_FiyatiTextBox.Name = "satis_FiyatiTextBox";
            this.satis_FiyatiTextBox.Size = new System.Drawing.Size(46, 19);
            this.satis_FiyatiTextBox.TabIndex = 46;
            this.satis_FiyatiTextBox.Tag = "";
            // 
            // acıklamaTextBox
            // 
            this.acıklamaTextBox.Location = new System.Drawing.Point(90, 75);
            this.acıklamaTextBox.Multiline = true;
            this.acıklamaTextBox.Name = "acıklamaTextBox";
            this.acıklamaTextBox.Size = new System.Drawing.Size(257, 145);
            this.acıklamaTextBox.TabIndex = 40;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Lime;
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Ekle.FlatAppearance.BorderSize = 2;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(90, 439);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(98, 67);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "Kaydet";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Crimson;
            this.btn_Temizle.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_Temizle.FlatAppearance.BorderSize = 2;
            this.btn_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(219, 439);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(98, 67);
            this.btn_Temizle.TabIndex = 55;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtb_Ek_Stok
            // 
            this.txtb_Ek_Stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtb_Ek_Stok.Location = new System.Drawing.Point(121, 381);
            this.txtb_Ek_Stok.Name = "txtb_Ek_Stok";
            this.txtb_Ek_Stok.Size = new System.Drawing.Size(67, 30);
            this.txtb_Ek_Stok.TabIndex = 4;
            // 
            // txtb_Urun_Grubu
            // 
            this.txtb_Urun_Grubu.Location = new System.Drawing.Point(91, 244);
            this.txtb_Urun_Grubu.Multiline = true;
            this.txtb_Urun_Grubu.Name = "txtb_Urun_Grubu";
            this.txtb_Urun_Grubu.Size = new System.Drawing.Size(256, 17);
            this.txtb_Urun_Grubu.TabIndex = 56;
            // 
            // txtb_alıs_fiyatı
            // 
            this.txtb_alıs_fiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtb_alıs_fiyatı.Location = new System.Drawing.Point(121, 343);
            this.txtb_alıs_fiyatı.Name = "txtb_alıs_fiyatı";
            this.txtb_alıs_fiyatı.Size = new System.Drawing.Size(67, 30);
            this.txtb_alıs_fiyatı.TabIndex = 3;
            this.txtb_alıs_fiyatı.Tag = "";
            // 
            // Stok_Girisi_Tek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 578);
            this.Controls.Add(this.txtb_Urun_Grubu);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtb_alıs_fiyatı);
            this.Controls.Add(this.txtb_Ek_Stok);
            this.Controls.Add(this.stok_AdetiTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(birimLabel);
            this.Controls.Add(label1);
            this.Controls.Add(barkodLabel);
            this.Controls.Add(stok_AdetiLabel);
            this.Controls.Add(this.barkodTextBox);
            this.Controls.Add(this.birimComboBox);
            this.Controls.Add(urun_AdıLabel);
            this.Controls.Add(this.urun_AdıTextBox);
            this.Controls.Add(acıklamaLabel);
            this.Controls.Add(this.satis_FiyatiTextBox);
            this.Controls.Add(this.acıklamaTextBox);
            this.Controls.Add(satis_FiyatiLabel);
            this.Controls.Add(urun_GrubuLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stok_Girisi_Tek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok_Girisi";
            this.Load += new System.EventHandler(this.Stok_Girisi_Tek_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_Girisi_Tek_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stok_AdetiTextBox;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.ComboBox birimComboBox;
        private System.Windows.Forms.TextBox urun_AdıTextBox;
        private System.Windows.Forms.TextBox satis_FiyatiTextBox;
        private System.Windows.Forms.TextBox acıklamaTextBox;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.TextBox txtb_Ek_Stok;
        private System.Windows.Forms.TextBox txtb_Urun_Grubu;
        private System.Windows.Forms.TextBox txtb_alıs_fiyatı;
    }
}