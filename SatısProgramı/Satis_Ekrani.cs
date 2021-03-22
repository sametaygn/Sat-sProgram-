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
    public partial class Satis_Ekrani : Form
    {
        bool kayit;
        public Satis_Ekrani()
        {
            InitializeComponent();
        }
       
        
        
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        double toplam_satır_tutar1 =0, toplam_satır_tutar2=0, toplam_satır_tutar3=0;
        private void Satis_Ekrani_Load(object sender, EventArgs e)
        {
            tabControl2.TabPages[0].Text = Properties.Resources.Satis_Grubu_1;
            Padding padding = new Padding();
            padding.All = 5;
            int buton_size;
            buton_size = (flwp_tap4.Width - (4 * padding.All)) / 3;
           
            
            for (int i = 0; i <= 26*4; i++)
            {
                ContextMenu cm = new ContextMenu();

                cm.MenuItems.Add("Kısa Yol Ekle",new EventHandler(kisayol_ekle)); 
                cm.MenuItems.Add("Kısa Yol Sil");
                cm.MenuItems[0].Name = "" + i + "";
                cm.MenuItems[1].Name = "" + i + "";
                Button kisa_yol_btn = new Button();
                kisa_yol_btn.Name = ""+i+"";
                kisa_yol_btn.Tag = ""+(i+1)+"";
                kisa_yol_btn.Text = "samet";
                kisa_yol_btn.Margin = padding;
                kisa_yol_btn.ContextMenu = cm;
                kisa_yol_btn.Size = new Size(buton_size-10,buton_size-10);

                int s=i/27;
                
                switch (s)
                {
                    case 0:
                        flwp_tap4.Controls.Add(kisa_yol_btn);
                        break;
                    case 1:
                    flw_tab5.Controls.Add(kisa_yol_btn);
                        break;
                    case 2:
                    flwp_tap6.Controls.Add(kisa_yol_btn);
                        break;
                    case 3:
                    flwp_tap7.Controls.Add(kisa_yol_btn);
                        break;
                            

                }
                kisa_yol_btn.Click += Kisa_yol_btn_Click;
                
            
            }
            int buton_size_width, buton_size_height;
            buton_size_width = (flowLayoutPanel1.Width - 3 * 6) / 3;
            buton_size_height = flowLayoutPanel1.Height - 6;
            button1.Size = new Size(buton_size_width, buton_size_height);
            button2.Size = new Size(buton_size_width, buton_size_height);
            button3.Size = new Size(buton_size_width, buton_size_height);
            label1.Size = new Size(flowLayoutPanel2.Width - 6,30);

            ///Numara Butonları
            string name;
            for (int i = 1; i < 13; i++)
            {
                Padding keypadp = new Padding();
                keypadp.All = 0;
                name = i.ToString();
                Button keypad = new Button();
                int keypad_size_w, keypad_size_h;
                keypad_size_w = flowLayoutPanel4.Width / 3;
                keypad_size_h = flowLayoutPanel4.Height / 4;
                keypad.Size = new Size(keypad_size_w, keypad_size_h);
                keypad.Margin = keypadp;
                if (i==10)
                {
                    name = ",";
                }
                else if (i==11)
                {
                    name = "0";
                }
                else if(i == 12)
                {
                    name = "CLR";
                }
                keypad.Text = name;
                keypad.Name = name;
                flowLayoutPanel4.Controls.Add(keypad);
                keypad.Click += Keypad_Click;

            }
            kayit = false;
            sqltemp_kayıt_getir("select * from Temp1",dataGridView1,"Temp1");
            sqltemp_kayıt_getir("select * from Temp2", dataGridView2, "Temp2");
            sqltemp_kayıt_getir("select * from Temp3", dataGridView3, "Temp3");
            kayit = true;

            kisayol_btn_sql();
            toplam_satır_tutar_1(dataGridView1);
            toplam_satır_tutar_2(dataGridView2);
            toplam_satır_tutar_3(dataGridView3);
        }

        private void kisayol_btn_sql()
        {
            foreach (var item in flwp_tap4.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;
                    sql_kisa_ekle(button);
                }
            }
            foreach (var item in flw_tab5.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;

                }
            }
            foreach (var item in flwp_tap6.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;

                }
            }
            foreach (var item in flwp_tap7.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;

                }
            }
        }

        private void sql_kisa_ekle(Button button)
        {
            Button button1 = button as Button;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select kisa_yol_barkod,kisa_yol_isim from kisa_yol where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id",Convert.ToInt32( button1.Name));
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                button1.Text = red[1].ToString();
                button1.Tag = Convert.ToInt32(red[0].ToString());
            }
            con.Close();

        }

        private void kisayol_ekle(object sender,EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Kisa_yol_ekle ff = new Kisa_yol_ekle();
            ff.ShowDialog();

            var a=ff.barkod;
            var b=ff.Kisa_yol_isim;
           
            
             
            con.Open();
            SqlCommand cmd = new SqlCommand("update kisa_yol set kisa_yol_barkod=@kisa_yol_barkod," +
                " kisa_yol_isim=@kisa_yol_isim where Id=@Id  ",con);
            cmd.Parameters.AddWithValue("@kisa_yol_barkod", Convert.ToInt32(a));
            cmd.Parameters.AddWithValue("@kisa_yol_isim", b);
            cmd.Parameters.AddWithValue("@Id",Convert.ToInt32(menuItem.Name));
            cmd.ExecuteNonQuery();
            con.Close();

            

            
        }

        private void Kisa_yol_btn_Click(object sender, EventArgs e)
        {
           Button a=sender as Button;
            if (!(a.Tag.ToString()=="0"))
            {
                txtb_barkod.Text = a.Tag.ToString();
                datagride_urun_ekle(txtb_barkod.Text, lbl_carpim);
            }
           
           
        }

        private void sqltemp_kayıt_getir(string sqlcmd,DataGridView dataGrid,string n_temp)
        {
            DataRow[] drow;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd,con);
            DataSet ds = new DataSet();
            da.Fill(ds,n_temp);
            con.Close();
            drow = ds.Tables[0].Select();
            for (int i = 0; i < drow.Length; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = drow[i].Table.Rows[i][0].ToString();
                dataGrid.Rows[i].Cells[1].Value = drow[i].Table.Rows[i][1].ToString();
                dataGrid.Rows[i].Cells[3].Value = drow[i].Table.Rows[i][2].ToString();
                dataGrid.Rows[i].Cells[5].Value = drow[i].Table.Rows[i][3].ToString();
                dataGrid.Rows[i].Cells[6].Value = drow[i].Table.Rows[i][4].ToString();
                dataGrid.Rows[i].Cells[8].Value = drow[i].Table.Rows[i][5].ToString();
                dataGrid.Rows[i].Cells[9].Value = drow[i].Table.Rows[i][6].ToString();
                dataGrid.Rows[i].Cells[10].Value = drow[i].Table.Rows[i][7].ToString();

            }

        }
        private void Keypad_Click(object sender, EventArgs e)
        {
            Button button=  (Button)sender;
           
            if (lbl_carpim.Text=="1,00")
            {
                if (button.Name==",")
                {
                    lbl_carpim.Text = "0,";
                }
                else if (button.Name=="CLR")
                {
                    lbl_carpim.Text = "1,00";
                }
                else 
                {
                    lbl_carpim.Text =button.Name;
                }
                
            }
            else if (lbl_carpim.Text.Contains(",")==false)
            {
                if (button.Name=="CLR")
                {
                    lbl_carpim.Text = "1,00";
                }
                else
                {
                    lbl_carpim.Text = lbl_carpim.Text + button.Name;
                }
                
            }
            else if (lbl_carpim.Text.Contains(","))
            {
                if (button.Name == "CLR")
                {
                    lbl_carpim.Text = "1,00";
                }
                else if (button.Name==",")
                {

                }
                else
                {
                    lbl_carpim.Text = lbl_carpim.Text + button.Name;
                }
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            row_ekleme(e,dataGridView1);
            sql_kayıt_temp("insert into Temp1 (Barkod,Urun_Adi,Miktar," +
                "Satis_Fiyati,Satir_Toplami,Alis_Fiyati,Birim,Urun_Grubu) " +
                "values (@Barkod,@Urun_Adi,@Miktar," +
                "@Satis_Fiyati,@Satir_Toplami,@Alis_Fiyati,@Birim,@Urun_Grubu) ", dataGridView1, e);
            toplam_satır_tutar_1(dataGridView1);
        }

        private void row_ekleme(DataGridViewRowsAddedEventArgs e,DataGridView a)
        {
            if (e.RowIndex % 2 == 1&& e.RowIndex % 2>0&&e.RowIndex<a.Rows.Count)
            {
                a.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
            }
        }

       

       

        private void sql_kayıt_temp(string sqlcom, DataGridView dataGrid, DataGridViewRowsAddedEventArgs e)
        {
            if (kayit == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlcom, con);
                cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                cmd.Parameters.AddWithValue("@Urun_Adi", dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Miktar", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                cmd.Parameters.AddWithValue("@Satis_Fiyati", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString()));
                cmd.Parameters.AddWithValue("@Satir_Toplami", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString()));
                cmd.Parameters.AddWithValue("@Alis_Fiyati", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString()));
                cmd.Parameters.AddWithValue("@Birim", dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString());
                cmd.Parameters.AddWithValue("@Urun_Grubu", dataGrid.Rows[e.RowIndex].Cells[10].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
               
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string satis_turu = "nakit";
            if (tabControl1.SelectedTab.Name == "tabPage1" && dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Satış İşlemi Tamamlandı");
                satis_yap(satis_turu, dataGridView1);
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2" && dataGridView2.Rows.Count > 0)
            {
                MessageBox.Show("Satış İşlemi Tamamlandı");
                satis_yap(satis_turu, dataGridView2);
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3" && dataGridView3.Rows.Count > 0)
            {
                MessageBox.Show("Satış İşlemi Tamamlandı");
                satis_yap(satis_turu, dataGridView3);
            }
            else MessageBox.Show("Satış Yapabilmek için Ürün Girmelisiniz!!!");

        }

        private void satis_yap(string satis_turu, DataGridView dataGrid)
        {
            DateTimePicker date = new DateTimePicker();
            double maliyet = 0, kar_miktari = 0, miktar = 0;
            Satis_fis_ekle(satis_turu);
            int fis_no = Satis_fis_no_al();

            miktar = sqlMiktar_Azalt(dataGrid, miktar);
            Satıs_Tek_Kaydet(satis_turu, dataGrid, date, ref maliyet, ref kar_miktari, fis_no);

        }

        private double sqlMiktar_Azalt(DataGridView dataGrid, double miktar)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (!(dataGrid.Rows[i].Cells[9].Value.ToString() == "Kilo"))
                {
                    miktar = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value);
                }
                else
                {
                    miktar = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value) / 1000;
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("update Urun_Tablosu set Stok_Adeti=Stok_Adeti-@Stok_Adeti where Barkod=@Barkod", con);
                cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(dataGrid.Rows[i].Cells[0].Value));
                cmd.Parameters.AddWithValue("@Stok_Adeti", miktar);
                cmd.ExecuteNonQuery();
                con.Close();

            }

            return miktar;
        }

        private void Satıs_Tek_Kaydet(string satis_turu, DataGridView dataGrid, DateTimePicker date, ref double maliyet, ref double kar_miktari, int fis_no)
        {
            double miktar;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (!(dataGrid.Rows[i].Cells[9].Value.ToString() == "Kilo"))
                {
                    maliyet = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value.ToString()) * Convert.ToDouble(dataGrid.Rows[i].Cells[8].Value.ToString());
                    miktar = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value.ToString());
                }
                else
                {
                    maliyet = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value.ToString()) * Convert.ToDouble(dataGrid.Rows[i].Cells[8].Value.ToString()) / 1000;
                    miktar = Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value.ToString())/1000;
                }
                kar_miktari = (Convert.ToDouble(dataGrid.Rows[i].Cells[6].Value) - maliyet);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Satislar_Tek " +
                    " (Tarih,Belge_No,Urun_Adi,Odeme_Tipi,Miktar,Maliyet,Fiyat," +
                    "Tutar,Kar_Miktari,Kar_Orani,Urun_Grubu) values (@Tarih,@Belge_No," +
                    "@Urun_Adi,@Odeme_Tipi,@Miktar,@Maliyet,@Fiyat,@Tutar,@Kar_Miktari," +
                    "@Kar_Orani,@Urun_Grubu) ", con);
                cmd.Parameters.AddWithValue("@Tarih", date.Value);
                cmd.Parameters.AddWithValue("@Belge_No", fis_no);
                cmd.Parameters.AddWithValue("@Urun_Adi", dataGrid.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Odeme_Tipi", satis_turu);
                cmd.Parameters.AddWithValue("@Miktar", Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value.ToString()));
                cmd.Parameters.AddWithValue("@Maliyet", maliyet);
                cmd.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(dataGrid.Rows[i].Cells[5].Value.ToString()));
                cmd.Parameters.AddWithValue("@Tutar", Convert.ToDouble(dataGrid.Rows[i].Cells[6].Value.ToString()));
                cmd.Parameters.AddWithValue("@Kar_Miktari", kar_miktari);
                cmd.Parameters.AddWithValue("@Kar_Orani", (kar_miktari /  maliyet*100 ));
                cmd.Parameters.AddWithValue("@Urun_Grubu", dataGrid.Rows[i].Cells[10].Value.ToString());

                cmd.ExecuteNonQuery();
                con.Close();

            }
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                dataGridView1.Rows.Clear();
                sqltemizle("delete from Temp1");
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                dataGridView2.Rows.Clear();
                sqltemizle("delete from Temp2");
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                dataGridView3.Rows.Clear();
                sqltemizle("delete from Temp3");
            }
        }

        private int Satis_fis_no_al()
        {
            int fis_no=0;
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from Satislar_Fis",con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                fis_no = Convert.ToInt32( red[0].ToString());
            }
            
            con.Close();
            return fis_no;
        }

        private void Satis_fis_ekle(string satis_turu)
        {
            DateTimePicker date = new DateTimePicker();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Satislar_Fis (Tarih,Odeme_Tipi) values " +
                "(@Tarih,@Odeme_Tipi )", con);
            cmd.Parameters.AddWithValue("@Tarih", date.Value);
            cmd.Parameters.AddWithValue("@Odeme_Tipi", satis_turu);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name=="tabPage1")
            {
                dataGridView1.Rows.Clear();
                sqltemizle("delete from Temp1");
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                dataGridView2.Rows.Clear();
                sqltemizle("delete from Temp2");
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                dataGridView3.Rows.Clear();
                sqltemizle("delete from Temp3");
            }
          
        }

        private void sqltemizle(string v)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(v, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView2_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            row_ekleme(e, dataGridView2);
            row_ekleme(e, dataGridView1);
            sql_kayıt_temp("insert into Temp2 (Barkod,Urun_Adi,Miktar," +
                "Satis_Fiyati,Satir_Toplami,Alis_Fiyati,Birim,Urun_Grubu) " +
                "values (@Barkod,@Urun_Adi,@Miktar," +
                "@Satis_Fiyati,@Satir_Toplami,@Alis_Fiyati,@Birim,@Urun_Grubu) ", dataGridView2, e);
            toplam_satır_tutar_2(dataGridView2);
        }

        private void dataGridView3_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            row_ekleme(e, dataGridView3);
            row_ekleme(e, dataGridView1);
            sql_kayıt_temp("insert into Temp3 (Barkod,Urun_Adi,Miktar," +
                "Satis_Fiyati,Satir_Toplami,Alis_Fiyati,Birim,Urun_Grubu) " +
                "values (@Barkod,@Urun_Adi,@Miktar," +
                "@Satis_Fiyati,@Satir_Toplami,@Alis_Fiyati,@Birim,@Urun_Grubu) ", dataGridView3, e);
            toplam_satır_tutar_3(dataGridView3);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1&&e.ColumnIndex==7)
            {
                
                int barkod =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                sql_kayitsil_tek(dataGridView1, barkod,"delete from Temp1 where Barkod=@Barkod ");
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                if (!(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()=="Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    a--;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    if (a<=0)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_1(dataGridView1);
                        sql_kayıt_temp_artı_eksi("update Temp1 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView1,e);
                        
                    }
                }
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                if (!(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    a++;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    if (a <= 0)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_1(dataGridView1);
                        sql_kayıt_temp_artı_eksi("update Temp1 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView1, e);

                    }
                }
            }
        }

        private void sql_kayıt_temp_artı_eksi(string v, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(v, con);
            cmd.Parameters.AddWithValue("@Barkod", Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@Urun_Adi", dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Miktar", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString()));
            cmd.Parameters.AddWithValue("@Satis_Fiyati", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString()));
            cmd.Parameters.AddWithValue("@Satir_Toplami", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString()));
            cmd.Parameters.AddWithValue("@Alis_Fiyati", Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString()));
            cmd.Parameters.AddWithValue("@Birim", dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString());
            cmd.Parameters.AddWithValue("@Urun_Grubu", dataGrid.Rows[e.RowIndex].Cells[10].Value.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void sql_kayitsil_tek(DataGridView dataGridView,int barkod,string sqlcom)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcom,con);
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
               
                int barkod = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                sql_kayitsil_tek(dataGridView2, barkod, "delete from Temp2 where Barkod=@Barkod ");
                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                if (!(dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString() == "Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
                    a--;
                    dataGridView2.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
                    if (a <= 0)
                    {
                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView2.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_2(dataGridView2);
                        sql_kayıt_temp_artı_eksi("update Temp2 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView2, e);
                    }
                }
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                if (!(dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString() == "Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
                    a++;
                    dataGridView2.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
                    if (a <= 0)
                    {
                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView2.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_2(dataGridView2);
                        sql_kayıt_temp_artı_eksi("update Temp2 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView2, e);
                    }
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                
                int barkod = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value);
                sql_kayitsil_tek(dataGridView3, barkod, "delete from Temp3 where Barkod=@Barkod ");
                dataGridView3.Rows.RemoveAt(e.RowIndex);
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                if (!(dataGridView3.Rows[e.RowIndex].Cells[9].Value.ToString() == "Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells[3].Value);
                    a--;
                    dataGridView3.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells[5].Value);
                    if (a <= 0)
                    {
                        dataGridView3.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView3.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_3(dataGridView3);
                        sql_kayıt_temp_artı_eksi("update Temp3 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView3, e);
                    }
                }
            }
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                if (!(dataGridView3.Rows[e.RowIndex].Cells[9].Value.ToString() == "Kilo"))
                {
                    var a = Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells[3].Value);
                    a++;
                    dataGridView3.Rows[e.RowIndex].Cells[3].Value = a;
                    var b = Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells[5].Value);
                    if (a <= 0)
                    {
                        dataGridView3.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridView3.Rows[e.RowIndex].Cells[6].Value = a * b;
                        toplam_satır_tutar_3(dataGridView3);
                        sql_kayıt_temp_artı_eksi("update Temp3 set Urun_Adi=@Urun_Adi," +
                            "Miktar=@Miktar,Satis_Fiyati=@Satis_Fiyati," +
                            "Satir_Toplami=@Satir_Toplami,Alis_Fiyati=@Alis_Fiyati," +
                            "Birim=@Birim,Urun_Grubu=@Urun_Grubu" +
                            " where Barkod=@Barkod ", dataGridView3, e);
                    }
                }
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
                              
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                datagride_urun_ekle(txtb_barkod.Text, lbl_carpim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bul ff = new Bul();
            ff.ShowDialog();
            txtb_barkod.Text = ff.a;
            datagride_urun_ekle(txtb_barkod.Text, lbl_carpim);
        }

        private void datagride_urun_ekle(string barkod, Label lbl_carpim)
        {
            if (tabControl1.SelectedTab.Name=="tabPage1")
            {
                sql_urun_bilgisi_al(barkod, lbl_carpim, dataGridView1);
            }
           else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                sql_urun_bilgisi_al(barkod, lbl_carpim, dataGridView2);
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                sql_urun_bilgisi_al(barkod, lbl_carpim, dataGridView3);
            }
        }

        private void sql_urun_bilgisi_al(string barkod, Label lbl_carpim, DataGridView dataGrid)
        {
            
            string Barkod="", Urun_Adi="", Urun_Grubu="",
                Satis_Fiyati="", Alis_Fiyati="", Birim="";
            double miktar=0,satir_toplami=0;
            int c = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Urun_Tablosu where Barkod=@Barkod", con);
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                Barkod =red[0].ToString();
                Urun_Adi = red[1].ToString();
                Urun_Grubu = red[3].ToString();
                Satis_Fiyati = red[4].ToString();
                Alis_Fiyati = red[5].ToString();
                Birim = red[6].ToString();
                Urun_Grubu = red[3].ToString();
                c++;
            }
            con.Close();
            if (c == 1) 
            {
                if (Birim == "Kilo")
                {
                     miktar = Convert.ToDouble(lbl_carpim.Text) * 1000 / Convert.ToDouble(Satis_Fiyati);
                    Satis_Fiyati = lbl_carpim.Text;
                    satir_toplami =Convert.ToDouble(Satis_Fiyati);
                }
                else
                {
                    miktar =Convert.ToDouble( lbl_carpim.Text);
                    satir_toplami =Convert.ToDouble( miktar) *Convert.ToDouble( Satis_Fiyati);
                }
                dataGrid.Rows.Add(Convert.ToInt32(Barkod), Urun_Adi, "-",
                    Convert.ToDouble(miktar), "+",
                    Convert.ToDouble(Satis_Fiyati),
                    Convert.ToDouble(satir_toplami),
                    "SİL", Convert.ToDouble(Alis_Fiyati),Birim,Urun_Grubu);
            }
            if (c == 0)
            {
                MesajEkranı msg = new MesajEkranı();
                msg.mesaj_goster_olumsuz("Ürün Bulunamadı :(", 750);
            }
            txtb_barkod.Clear();
            lbl_carpim.Text = "1,00";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toplam_satır_tutar_1(dataGridView1);
        }

     
        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toplam_satır_tutar_2(dataGridView2);
        }

        private void dataGridView3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toplam_satır_tutar_3(dataGridView3);
        }
      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabPage = sender as TabControl;
            if (tabPage.SelectedTab.Name=="tabPage1")
            {
                lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar1);
            }
            else if (tabPage.SelectedTab.Name == "tabPage2")
            {
                lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar2);
            }
            else
            {
                lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar3);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void toplam_satır_tutar_1(DataGridView dataGridView)
        {
            toplam_satır_tutar1 = 0;
            if (dataGridView.Rows.Count > -1)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    toplam_satır_tutar1 += Convert.ToDouble(dataGridView.Rows[i].Cells[6].Value);

                }

            }
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                if (dataGridView.Rows.Count < 0)
                {
                    lbl_tutar.Text = "0";
                }
                else
                lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar1);
            }
        }
        private void toplam_satır_tutar_2(DataGridView dataGridView)
        {
            toplam_satır_tutar2 = 0;
            if (dataGridView.Rows.Count > -1)
            {
                for (int i = 0; i < dataGridView.Rows.Count ; i++)
                {
                    toplam_satır_tutar2 += Convert.ToDouble(dataGridView.Rows[i].Cells[6].Value);

                }

            }
            if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                if (dataGridView.Rows.Count < 0)
                {
                    lbl_tutar.Text = "0";
                }
                else
                lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar2);
            }
        }
        private void toplam_satır_tutar_3(DataGridView dataGridView)
        {
            toplam_satır_tutar3 = 0;
            if (dataGridView.Rows.Count > -1)
            {
                for (int i = 0; i < dataGridView.Rows.Count ; i++)
                {
                    toplam_satır_tutar3 += Convert.ToDouble(dataGridView.Rows[i].Cells[6].Value);

                }


            }
            if (tabControl1.SelectedTab.Name=="tabPage3")
            {
                if (dataGridView.Rows.Count < 0)
                {
                    lbl_tutar.Text = "0";
                }
                else
                    lbl_tutar.Text = String.Format("{0:0.00}", toplam_satır_tutar3);
            }
        }
    }
}
