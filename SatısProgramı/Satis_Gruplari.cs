using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace SatısProgramı
{
    public partial class Satis_Gruplari : Form
    {
        public Satis_Gruplari()
        {
            InitializeComponent();
        }

        private void Satis_Gruplari_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Resources.Satis_Grubu_1;
            textBox2.Text = Properties.Resources.Satis_Grubu_2;
            textBox3.Text = Properties.Resources.Satis_Grubu_3;
            textBox4.Text = Properties.Resources.Satis_Grubu_4;
            
            
        }
    }
}
