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
    public partial class Stok_Girisi_Toplu : Form
    {
        public Stok_Girisi_Toplu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataRow[] row;

        List<string> vs = new List<string>();
        bool den = false;
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex > -1 && e.ColumnIndex == 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == row[i][0].ToString())
                    {
                        vs.Clear();
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = row[i][1].ToString();
                        vs.Add(row[i][8].ToString());
                        vs.Add(row[i][6].ToString());
                        DataGridViewComboBoxCell boxCell = dataGridView1.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell;
                        boxCell.Items.Add(row[i][8].ToString());
                        boxCell.Items.Add(row[i][6].ToString());
                        boxCell.Value = row[i][8].ToString();

                    }


                }
            }
            if (e.RowIndex > -1 && (e.ColumnIndex == 3 || e.ColumnIndex == 4))
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null && dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
                {

                    int i = dataGridView1.Rows.Count - 1;


                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    


                }
            }
        }

        private void Stok_Girisi_Toplu_Load(object sender, EventArgs e)
        {
            // dataGridView1.Rows.Add();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* From Urun_Tablosu ", con);
            da.Fill(ds);
            row = ds.Tables[0].Select();
            con.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {

                TextBox text = e.Control as TextBox;
                if (text != null)
                {
                    text.KeyPress += Text_KeyPress;
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("samet");
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows.Count > e.RowIndex && e.RowIndex > -1)
            {
                Bul ff = new Bul();
                ff.ShowDialog();
                MesajEkranı mesaj = new MesajEkranı();
                if (ff.a == null)
                {
                    mesaj.mesaj_goster_olumsuz("Ürün Bulunamadı", 700);
                }
                else
                {

                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = ff.a;
                    mesaj.mesaj_goster_olumlu("Ürün Bulundu", 700);
                    for (int i = 0; i < row.Length; i++)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == row[i][0].ToString())
                        {
                            vs.Clear();
                            dataGridView1.Rows[e.RowIndex].Cells[1].Value = row[i][1].ToString();
                            vs.Add(row[i][8].ToString());
                            vs.Add(row[i][6].ToString());
                            DataGridViewComboBoxCell boxCell = dataGridView1.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell;
                            boxCell.Items.Add(row[i][8].ToString());
                            boxCell.Items.Add(row[i][6].ToString());
                            boxCell.Value = row[i][8].ToString();
                            dataGridView1.Rows[e.RowIndex].Cells[7].Value = row[i][6].ToString();
                        }

                    }
                   

                }

            }
            if(e.ColumnIndex==6 && e.RowIndex > 0&&e.RowIndex<dataGridView1.Rows.Count-1)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajEkranı msg = new MesajEkranı();
            bool control=true;
            if (dataGridView1.Rows.Count>1)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            control = false;
                        }
                    }

                }
                if (control == false)
                {
                    msg.mesaj_goster_olumsuz("Kaydetme İşlemi İçin Bütün Satırlar Dolu Olmalıdır!!",500);
                }
                else
                {
                    sql_Kaydet();
                    msg.mesaj_goster_olumlu("Kaydetme İşlemi Tamamlandı:))",500);
                    this.Close();
                } 
            }
            else
            {
                msg.mesaj_goster_olumsuz("En az bir ürün girilmeli",500);
            }
        }
        private void sql_Kaydet()
        {
            string eklenen_birim;
            int barkod;
            double alis_fiyati, Miktar,eklenen_birim_Carpan;
            DateTimePicker time = new DateTimePicker();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                barkod = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                eklenen_birim = dataGridView1.Rows[i].Cells[2].Value.ToString();
                eklenen_birim_Carpan = birim_carpanı_al(eklenen_birim);
                Miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)*eklenen_birim_Carpan;
                alis_fiyati = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value)/ eklenen_birim_Carpan;
                MessageBox.Show(eklenen_birim + "   " + eklenen_birim_Carpan + "\nEklenen Miktar "
                    + Miktar.ToString() + "\n Alış Fiyatı" + alis_fiyati.ToString() +
                    "\n" + time.Value.ToString()
                    ); ;
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Stok_Ekle (Barkod," +
                    "Alis_Fiyati,Miktar,Zaman) values (@Barkod," +
                    "@Alis_Fiyati,@Miktar,@Zaman) ",con);
                cmd.Parameters.AddWithValue("@Barkod",barkod);
                cmd.Parameters.AddWithValue("@Alis_Fiyati", alis_fiyati);
                cmd.Parameters.AddWithValue("@Miktar", Miktar);
                cmd.Parameters.AddWithValue("@Zaman",time.Value );
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Urun_Tablosu set" +
                    " Alis_Fiyati=@Alis_Fiyati,Stok_Adeti=Stok_Adeti+@Stok_Adeti where" +
                    " Barkod=@Barkod ",con);
                cmd2.Parameters.AddWithValue("@Alis_Fiyati", alis_fiyati);
                cmd2.Parameters.AddWithValue("@Stok_Adeti", Miktar);
                cmd2.Parameters.AddWithValue("@Barkod", barkod);
                cmd2.ExecuteNonQuery();
                con.Close();


            }

        }
        private double birim_carpanı_al(string birim)
        {
            double carpan=0;
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim ",con);
            da.Fill(ds);
            con.Close();
            DataRow[] drow = ds.Tables[0].Select();
            for (int i = 0; i < drow.Length; i++)
            {
                if (birim==drow[i].Table.Rows[i][1].ToString())
                {
                    carpan= Convert.ToDouble(drow[i].Table.Rows[i][2].ToString());
                    
                }
            }
            return carpan;
        }
    }
}
