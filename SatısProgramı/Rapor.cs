using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatısProgramı
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        string Urun_Grubu="";
        private void Rapor_Load(object sender, EventArgs e)
        {
           DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            DateTime dateTimee = new DateTime(dateTime.Year,dateTime.Month, dateTime.Day,00,00,00);
            DateTime dateTimeee = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59);
          //  MessageBox.Show(dateTimee.ToString());
            dateTimePicker1.Value = dateTimee;
            dateTimePicker2.Value = dateTimee;
            dateTimePicker3.Value = dateTimeee;
            dateTimePicker4.Value = dateTimeee;

            Grid_Doldur();
           
            cmb_grup_adi.Items.Add("Hepsi");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Grup_Adi from Grup",con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())

            {
                cmb_grup_adi.Items.Add(red[0]);

            }
            con.Close();



        }

        private void Grid_Doldur()
        {
             DateTime dateTime1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
             DateTime dateTime2 = new DateTime(dateTimePicker3.Value.Year, dateTimePicker3.Value.Month, dateTimePicker3.Value.Day, dateTimePicker4.Value.Hour, dateTimePicker4.Value.Minute, dateTimePicker4.Value.Second);

             //MessageBox.Show(dateTimePicker1.Value.Date.ToShortDateString());
             //MessageBox.Show(dateTimePicker2.Value.ToLongTimeString().ToString() + "\n");
             DataSet ds = new DataSet();
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from Satislar_Tek  where Tarih between @a and @b and Urun_Adi like  @Urun_Adi and Urun_Grubu like @Urun_Grubu", con);
             SqlDataAdapter da = new SqlDataAdapter();
             cmd.Parameters.AddWithValue("@Urun_Adi","%"+ textBox1.Text+"%");
             cmd.Parameters.AddWithValue("@Urun_Grubu", "%" + Urun_Grubu + "%");

             cmd.Parameters.AddWithValue("@a", dateTime1);
             cmd.Parameters.AddWithValue("@b", dateTime2);
             da.SelectCommand = cmd;
             da.Fill(ds);
             con.Close();
             dataGridView1.DataSource = ds.Tables[0];
            DataGridView_verileri_hesapla();
            dataGridView1.Columns[5].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[9].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[10].DefaultCellStyle.Format = "n2";
      


            /*  con.Open();
              SqlCommand cmd = new SqlCommand("select Satislar_Tek.Miktar,Urun_Tablosu.Urun_Grubu from Satislar_Tek,Urun_Tablosu where Urun_Tablosu.Urun_Adi=Satislar_Tek.Urun_Adi", con);
              SqlDataAdapter da = new SqlDataAdapter();
              da.SelectCommand = cmd;
              DataSet ds = new DataSet();
              da.Fill(ds);
              con.Close();
              dataGridView1.DataSource = ds.Tables[0];
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid_Doldur();
        }

        private void cmb_grup_adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_grup_adi.SelectedItem.ToString()=="Hepsi")
            {
                Urun_Grubu = "";
            }
            else
            {
                Urun_Grubu = cmb_grup_adi.SelectedItem.ToString();  
            }
            DataGridView_verileri_hesapla();
        }

        private void DataGridView_verileri_hesapla()
        {
            double toplam_miktar = 0, toplam_maliyet = 0, toplam_tutar=0, toplam_kar=0; 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
              
                toplam_miktar+=  Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);//toplam miktar
                toplam_maliyet+= Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);//toplam maliyet
                toplam_tutar += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);//toplam tutar
               

            }
            toplam_kar = toplam_tutar - toplam_maliyet;
            txtb_Toplamsatis.Text = toplam_tutar.ToString();
            txtb_Toplam_kar.Text = toplam_kar.ToString();
            txtb_Toplam_Maliyet.Text = toplam_maliyet.ToString();
            txtb_Toplam_Çıkış.Text = toplam_miktar.ToString();
        }
    }
}
