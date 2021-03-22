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
    public partial class Stok_Girisi_Tek : Form
    {
        public Stok_Girisi_Tek()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        DataRow[] drow;
        private void textbox_visibility(bool b)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox a = (TextBox)item;

                    if (a.Name == txtb_alıs_fiyatı.Name || a.Name == txtb_Ek_Stok.Name)
                    {
                        a.Enabled = b;
                    }
                    else
                    {
                        
                    }
                }
                
            }
        }

        private void Stok_Girisi_Tek_Load(object sender, EventArgs e)
        {
            textbox_visibility(false);
            btn_Ekle.Enabled = false;
            stok_AdetiTextBox.Enabled = false;
            acıklamaTextBox.Enabled = false;
            urun_AdıTextBox.Enabled = false;
            txtb_Urun_Grubu.Enabled = false;
            satis_FiyatiTextBox.Enabled = false;
            stok_AdetiTextBox.Enabled = false;
            txtb_alıs_fiyatı.Enabled = false;
            datarow_fill();
        }
        private void textboxvegrupbox_temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    comboBox.Text = "";
                }
            }
            btn_Ekle.Enabled = false;
        }
       
        private void Birim_Doldur(ComboBox a)
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Birim from Birim", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Birim");
            a.DataSource = ds.Tables["Birim"];
            a.DisplayMember = "Birim";
            con.Close();
            a.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            textboxvegrupbox_temizle();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        private void urunverilerini_al()
        {
            bool deneme=false;
            MesajEkranı msg = new MesajEkranı();
            for (int i = 0; i < drow.Length; i++)
            {
                if (barkodTextBox.Text==drow[i].Table.Rows[i][0].ToString())
                {
                    birimComboBox.Items.Clear();
                    urun_AdıTextBox.Text = drow[i].Table.Rows[i][1].ToString();
                    acıklamaTextBox.Text = drow[i].Table.Rows[i][2].ToString();
                    satis_FiyatiTextBox.Text= drow[i].Table.Rows[i][4].ToString();
                    txtb_alıs_fiyatı.Text= drow[i].Table.Rows[i][5].ToString();
                    stok_AdetiTextBox.Text= drow[i].Table.Rows[i][7].ToString();
                    txtb_Urun_Grubu.Text= drow[i].Table.Rows[i][3].ToString();
                    birimComboBox.Items.Add(drow[i].Table.Rows[i][8].ToString());
                    birimComboBox.Items.Add(drow[i].Table.Rows[i][6].ToString());
                    birimComboBox.SelectedIndex = 0;
                    deneme = true;
                    break;
                }
            }
            textbox_visibility(deneme);
            if (deneme==true)
            {
                msg.mesaj_goster_olumlu("Ürün Bulundu :)", 1000);
                txtb_alıs_fiyatı.Focus();
                btn_Ekle.Enabled = true;
            }
            else
            {
                msg.mesaj_goster_olumsuz("Ürün Bulunamadı Ürünün Sistemde Ekli Olduğundan Emin Olun:(", 2000);
            }
        }
        private void datarow_fill()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Urun_Tablosu", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            drow = ds.Tables[0].Select();
            con.Close();
        }
        private double birim_carpanı_al(string birim)
        {
            double carpan = 0;
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim ", con);
            da.Fill(ds);
            con.Close();
            DataRow[] drow = ds.Tables[0].Select();
            for (int i = 0; i < drow.Length; i++)
            {
                if (birim == drow[i].Table.Rows[i][1].ToString())
                {
                    carpan = Convert.ToDouble(drow[i].Table.Rows[i][2].ToString());

                }
            }
            return carpan;
        }

        private void barkodTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                
                urunverilerini_al();
                         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bul ff = new Bul();
            ff.ShowDialog();
            barkodTextBox.Text = ff.a;
            urunverilerini_al();
            
            
        }
        private void sqlguncelle(double carpan)
        {
            double alis_fiyati, stok_adeti;
            int barkod=Convert.ToInt32( barkodTextBox.Text);
            alis_fiyati =Convert.ToDouble( txtb_alıs_fiyatı.Text)/carpan;
            stok_adeti = Convert.ToDouble(txtb_Ek_Stok.Text)*carpan;
            con.Open();
            SqlCommand cmd =new SqlCommand("update  Urun_Tablosu " +
                "set Alis_Fiyati=@Alis_Fiyati,Stok_Adeti=Stok_Adeti+@Stok_Adeti" +
                "  where Barkod=@Barkod ", con);
            cmd.Parameters.AddWithValue("@Barkod",barkod);
            cmd.Parameters.AddWithValue("@Alis_Fiyati", alis_fiyati);
            cmd.Parameters.AddWithValue("@Stok_Adeti", stok_adeti);
            cmd.ExecuteNonQuery();
            con.Close();
        }
      
        private void Stok_Girisi_Tek_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

       

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            sqlguncelle(birim_carpanı_al(birimComboBox.Text));
            textboxvegrupbox_temizle();
            MesajEkranı msg = new MesajEkranı();
            msg.mesaj_goster_olumlu("Stok Girişi Tamamlandı :)", 700);
            datarow_fill();
            barkodTextBox.Focus();
        }
    }
}
