
namespace SatısProgramı
{
    partial class Kisa_yol_ekle
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
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.txtb_Barkod = new System.Windows.Forms.TextBox();
            this.txtb_Kisa_Yol_Ismi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Location = new System.Drawing.Point(30, 72);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(41, 13);
            this.lbl_barkod.TabIndex = 0;
            this.lbl_barkod.Text = "Barkod";
            // 
            // txtb_Barkod
            // 
            this.txtb_Barkod.Location = new System.Drawing.Point(90, 69);
            this.txtb_Barkod.Name = "txtb_Barkod";
            this.txtb_Barkod.Size = new System.Drawing.Size(100, 20);
            this.txtb_Barkod.TabIndex = 1;
            // 
            // txtb_Kisa_Yol_Ismi
            // 
            this.txtb_Kisa_Yol_Ismi.Location = new System.Drawing.Point(90, 111);
            this.txtb_Kisa_Yol_Ismi.Name = "txtb_Kisa_Yol_Ismi";
            this.txtb_Kisa_Yol_Ismi.Size = new System.Drawing.Size(100, 20);
            this.txtb_Kisa_Yol_Ismi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kısayol İsmi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kisa_yol_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtb_Kisa_Yol_Ismi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_Barkod);
            this.Controls.Add(this.lbl_barkod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kisa_yol_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisa_yol_ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.TextBox txtb_Barkod;
        private System.Windows.Forms.TextBox txtb_Kisa_Yol_Ismi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}