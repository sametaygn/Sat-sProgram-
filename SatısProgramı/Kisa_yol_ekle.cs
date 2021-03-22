using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatısProgramı
{
    public partial class Kisa_yol_ekle : Form
    {
        public Kisa_yol_ekle()
        {
            InitializeComponent();
        }
        public string barkod, Kisa_yol_isim;

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtb_Kisa_Yol_Ismi.Text==null)
            {
                MesajEkranı msg = new MesajEkranı();
                msg.mesaj_goster_olumsuz("Kısayol ismi girmek zorundasınız", 500);
            }
            else
            {
                Kisa_yol_isim = txtb_Kisa_Yol_Ismi.Text;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bul ff = new Bul();
            ff.ShowDialog();
            txtb_Barkod.Text = ff.a;
            barkod = txtb_Barkod.Text;
            
        }
    }
}
