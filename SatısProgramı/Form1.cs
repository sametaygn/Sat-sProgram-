using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatısProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width ;
            this.Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height ;
        }
        public static string sqlcon_stiring = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Satis_Programi" + "\\Database1.mdf; Integrated Security = True";
        //public static string sqlcon_stiring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SerSam\source\repos\SatısProgramı\SatısProgramı\Database1.mdf;Integrated Security = True";
        private void  Form1_Load(object sender, System.EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            // MessageBox.Show("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = "+ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Satis_Programi" + "\\Database1.mdf; Integrated Security = True");
            //MessageBox.Show(Application.UserAppDataPath);
            //MessageBox.Show(sqlcon_stiring);
            //MessageBox.Show("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Satis_Programi" + "\\Database1.mdf; Integrated Security = True");
            //btn1
           
                button1.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button1.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                //btn2
                button2.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button2.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn3
                button3.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button3.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn4
                button4.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button4.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn5
                button5.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button5.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn6
                button6.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button6.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn7
                button7.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button7.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn8
                button8.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button8.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn9
                button9.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button9.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn10
                button10.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button10.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn11
                button11.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button11.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
                ////btn12
                button12.Size = new System.Drawing.Size(flowLayoutPanel2.Width / 5, flowLayoutPanel2.Height / 4);
                button12.Margin = new Padding(flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5, flowLayoutPanel2.Width / 25, flowLayoutPanel2.Height / 16 - 5 - 5);
            
        }

        private void günSonuKarCiroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Rapor ff = new Rapor();
            ff.Show();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            UrunEkle2 ff = new UrunEkle2();
            ff.Show();
          
        }

        private void birimEkleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void birimEkleToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Birim ff = new Birim();
            ff.ShowDialog();
        }

        private void grupEkleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Grup ff = new Grup();
            ff.ShowDialog();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            Stok_Girisi_Toplu ff = new Stok_Girisi_Toplu();
            ff.Show();
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            Stok_Girisi_Tek ff = new Stok_Girisi_Tek();
            ff.ShowDialog();
        }

        private void guruplarıDüzenleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Satis_Gruplari ff = new Satis_Gruplari();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Satis_Ekrani ff = new Satis_Ekrani();
            ff.Show();
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
           
        }
    }
}
