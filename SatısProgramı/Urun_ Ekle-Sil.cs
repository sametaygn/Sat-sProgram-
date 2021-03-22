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
    public partial class UrunEkle2 : Form
    {
        bool urun_ekle=false, urun_guncelle=false, urun_sil=false;
        
        public UrunEkle2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        private void textbox_visibility(bool b)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox a = (TextBox)item;

                    if (a.Name == barkodTextBox.Name||a.Name==stok_AdetiTextBox.Name)
                    {

                    }
                    else
                    {
                        a.Enabled = b;
                    }
                }
                if (item is ComboBox)
                {
                    ComboBox c = (ComboBox)item;
                    c.Enabled = b;
                }
            }
        }
        private void barkodTextBox_Enter(object sender, EventArgs e)
        {
            
        }
        private void Urun_Ekle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Urun_Tablosu (Barkod,Urun_Adi,Aciklama,Urun_Grubu,Satis_Fiyati,Alis_Fiyati,Birim,Stok_Adeti,Tercih_Edilen_Birim) values" +
                "(@Barkod,@Urun_Adi,@Aciklama,@Urun_Grubu,@Satis_Fiyati,@Alis_Fiyati,@Birim," +
                "@Stok_Adeti,@Tercih_Edilen_Birim)", con);
            cmd.Parameters.AddWithValue("@Barkod",Convert.ToInt32(barkodTextBox.Text));
            cmd.Parameters.AddWithValue("@Urun_Adi", urun_AdıTextBox.Text);
            cmd.Parameters.AddWithValue("@Aciklama", acıklamaTextBox.Text);
            cmd.Parameters.AddWithValue("@Urun_Grubu", urun_GrubuComboBox.Text);
            cmd.Parameters.AddWithValue("@Satis_Fiyati", Convert.ToDouble(satis_FiyatiTextBox.Text));
            cmd.Parameters.AddWithValue("@Alis_Fiyati", Convert.ToDouble(alis_FiyatiTextBox.Text));
            cmd.Parameters.AddWithValue("@Birim", birimComboBox.Text);
            cmd.Parameters.AddWithValue("@Stok_Adeti", Convert.ToDouble( stok_AdetiTextBox.Text));
            cmd.Parameters.AddWithValue("@Tercih_Edilen_Birim", cmb_tercih_birim.Text);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        private void UrunEkle2_Load(object sender, EventArgs e)
        {
            textbox_visibility(false);
            btn_Urun_Ekle.Enabled = urun_ekle;
            btn_Urun_Guncelle.Enabled = urun_guncelle;
            btn_Urun_Sil.Enabled = urun_sil;
            Birim_Doldur(cmb_tercih_birim);
            Birim_Doldur(birimComboBox);
            Grup_Doldur();
            stok_AdetiTextBox.Enabled = false;
        }

        private void barkodTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Urun_Ara_Ekle();
            }
        }

        private void Urun_Ara_Ekle()
        {
            if (barkodTextBox.Text == "")
            {

            }
            else
            {
                int ab, c;
                c = 0;

                ab = Convert.ToInt32(barkodTextBox.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  Urun_Adi, Aciklama, Urun_Grubu, Satis_Fiyati, Alis_Fiyati, Birim, Stok_Adeti,Tercih_Edilen_Birim from Urun_Tablosu where Barkod=@Barkod", con);
                cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(barkodTextBox.Text));
                SqlDataReader red = cmd.ExecuteReader();
                foreach (var x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        TextBox a = (TextBox)x;
                        a.Clear();
                    }
                    if (x is ComboBox)
                    {
                        ComboBox box = (ComboBox)x;
                        box.Text = "";
                    }
                }
                barkodTextBox.Text = ab.ToString();
                while (red.Read())
                {
                    urun_AdıTextBox.Text = red[0].ToString();
                    acıklamaTextBox.Text = red[1].ToString();
                    urun_GrubuComboBox.Text = red[2].ToString();
                    satis_FiyatiTextBox.Text = red[3].ToString();
                    alis_FiyatiTextBox.Text = red[4].ToString();
                    birimComboBox.Text = red[5].ToString();
                    stok_AdetiTextBox.Text = red[6].ToString();
                    cmb_tercih_birim.Text = red[7].ToString();
                    c++;
                }
                con.Close();
                if (c == 0)
                {
                    MessageBox.Show("Bu Barkoda Sahip Bir Ürün Bulunamadı");
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Bu Barkoda Sahip Bir Ürün Eklemek İstermisiniz?", "Ürün Ekle", MessageBoxButtons.YesNo);
                    btn_Urun_Guncelle.Enabled = false;
                    btn_Urun_Sil.Enabled = false;
                    if (dialog == DialogResult.Yes)
                    {
                        textbox_visibility(true);
                        btn_Urun_Ekle.Enabled = true;
                        /*Urun_Ekle();
                        MessageBox.Show("Ürün Başarı İle Eklendi");
                        textboxvegrupbox_temizle();
                        */
                        alis_FiyatiTextBox.Text = "0";
                        satis_FiyatiTextBox.Text = "0";
                        stok_AdetiTextBox.Text = "0";
                    }
                    else
                    {

                    }
                }
                else if (c == 1)
                {
                    
                    textbox_visibility(true);
                    btn_Urun_Ekle.Enabled = false;
                    btn_Urun_Guncelle.Enabled = true;
                    btn_Urun_Sil.Enabled = true;
                }


            }
        }

        private void urun_listele(int ab)
        {
            
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            {
                Urun_Ekle();
                MessageBox.Show("Ürün Başarı İle Eklendi");
                textboxvegrupbox_temizle();
                btn_Urun_Ekle.Enabled = false;
            }
            //catch (Exception a)
            {

            //    MessageBox.Show("Hata" + a.ToString());
            }
        }

        private void btn_Urun_Guncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Urun_Tablosu set" +
                " Urun_Adi=@Urun_Adi, Aciklama=@Aciklama, Urun_Grubu=@Urun_Grubu," +
                " Satis_Fiyati=@Satis_Fiyati, Alis_Fiyati=@Alis_Fiyati," +
                " Birim=@Birim, Stok_Adeti=@Stok_Adeti,Tercih_Edilen_Birim=@Tercih_Edilen_Birim" +
                " where Barkod=@Barkod ", con);
            cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(barkodTextBox.Text));
            cmd.Parameters.AddWithValue("@Urun_Adi", urun_AdıTextBox.Text);
            cmd.Parameters.AddWithValue("@Aciklama", acıklamaTextBox.Text);
            cmd.Parameters.AddWithValue("@Urun_Grubu", urun_GrubuComboBox.Text);
            cmd.Parameters.AddWithValue("@Satis_Fiyati", Convert.ToDouble(satis_FiyatiTextBox.Text));
            cmd.Parameters.AddWithValue("@Alis_Fiyati", Convert.ToDouble(alis_FiyatiTextBox.Text));
            cmd.Parameters.AddWithValue("@Birim", birimComboBox.Text);
            cmd.Parameters.AddWithValue("@Stok_Adeti", Convert.ToDouble(stok_AdetiTextBox.Text));
            cmd.Parameters.AddWithValue("@Tercih_Edilen_Birim", cmb_tercih_birim.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ürün Güncellendi");
            btn_Urun_Ekle.Enabled = false;
            btn_Urun_Guncelle.Enabled = false;
            btn_Urun_Sil.Enabled = false;
            textboxvegrupbox_temizle();
            textbox_visibility(false);
        }

        private void btn_Urun_Sil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Urun_Tablosu where Barkod=@Barkod", con);
            cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(barkodTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ürün Silindi");
            btn_Urun_Ekle.Enabled = false;
            btn_Urun_Guncelle.Enabled = false;
            btn_Urun_Sil.Enabled = false;
            textboxvegrupbox_temizle();
            textbox_visibility(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bul ff = new Bul();
            ff.ShowDialog();
            MesajEkranı msg = new MesajEkranı();
            if (ff.bul==true)
            {
               
                msg.mesaj_goster_olumlu("ÜRÜN BULUNDU", 400);
                barkodTextBox.Text = ff.a;
                Urun_Ara_Ekle();
            }
           
           
            


        }

        private void barkodTextBox_Leave(object sender, EventArgs e)
        {
            Urun_Ara_Ekle();
        }

        private void Grup_Doldur()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Grup_Adi from Grup", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Grup");
            urun_GrubuComboBox.DataSource = ds.Tables["Grup"];
            urun_GrubuComboBox.DisplayMember = "Grup_Adi";
            con.Close();
            urun_GrubuComboBox.Text = "";
           
           

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
    }
}
