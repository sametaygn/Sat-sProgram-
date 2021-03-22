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
    public partial class Birim : Form
    {
        public Birim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        private void datagridview_doldur()
        {
            dataGridView1.DataSource = "";
            con.Open();
            //SqlCommand cmd = new SqlCommand("select Birim,Carpani from Birim", con);
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"Birim");
            con.Close();
            dataGridView1.DataSource = ds.Tables["Birim"];
            dataGridView1.Columns[0].Visible = false;
            
        }
        int id;
        private void Birim_Load(object sender, EventArgs e)
        {
            datagridview_doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Birim (Birim,Carpani) values(@birim,@carpani)", con);
            cmd.Parameters.AddWithValue("@birim", txtbox_Birim_Adi.Text);
            cmd.Parameters.AddWithValue("@carpani", Convert.ToDouble(txtbox_Birim_Carpani.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            textbox_clear();
            datagridview_doldur();
        }

        private void textbox_clear()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox box = (TextBox)item;
                    box.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Birim set Birim=@Birim,Carpani=@Carpani where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Birim", txtbox_Birim_Adi.Text);
                cmd.Parameters.AddWithValue("@Carpani", Convert.ToDouble(txtbox_Birim_Carpani.Text));
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                datagridview_doldur();
                textbox_clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Yapmak İçin Bir Birim Seçmelisiniz!!!");
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Birim where Id=@id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                datagridview_doldur();
                textbox_clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Birim Güncellemek İçin Bir Birim Seçmelisiniz!!!");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {// MessageBox.Show(e.RowIndex.ToString()+"\n"+dataGridView1.Rows.Count.ToString());
                txtbox_Birim_Adi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbox_Birim_Carpani.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox_clear();
        }
    }
}
