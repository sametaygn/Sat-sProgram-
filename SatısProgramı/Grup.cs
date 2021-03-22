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
    public partial class Grup : Form
    {
        public Grup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        private void datagridview_doldur()
        {
            dataGridView1.DataSource = "";
            con.Open();
            //SqlCommand cmd = new SqlCommand("select Birim,Carpani from Birim", con);
            SqlDataAdapter da = new SqlDataAdapter("select * from Grup", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Grup");
            con.Close();
            dataGridView1.DataSource = ds.Tables["Grup"];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        int id;
        private void Grup_Load(object sender, EventArgs e)
        {
            datagridview_doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {// MessageBox.Show(e.RowIndex.ToString()+"\n"+dataGridView1.Rows.Count.ToString());
                txtbox_Grup_Adi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Grup (Grup_Adi) values(@Grup_Adi)", con);
            cmd.Parameters.AddWithValue("@Grup_Adi", txtbox_Grup_Adi.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            textbox_clear();
            datagridview_doldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Grup set Grup_Adi=@Grup_Adi where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Grup_Adi", txtbox_Grup_Adi.Text);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                datagridview_doldur();
                textbox_clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Grup Güncellemek İçin Bir Grup Seçmelisiniz!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Grup where Id=@id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                datagridview_doldur();
                textbox_clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Grup Silmek İçin Bir Grup Seçmelisiniz!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox_clear();
        }
    }
}
