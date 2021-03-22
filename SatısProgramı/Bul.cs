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
    public partial class Bul : Form
    {
        public Bul()
        {
            InitializeComponent();
        }
        public string a=null;
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
        private void griddoldur()
        {
            string grup;
            if (comboBox1.Text == "HEPSİ")
            {
                grup = "";
            }
            else
            {
                grup = comboBox1.Text;
            }
            dataGridView1.DataSource = "";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Urun_Tablosu where Urun_Adi like '%" + textBox1.Text + "%' and Urun_Grubu like '%" + grup + "%' ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void Bul_Load(object sender, EventArgs e)
        {
            griddoldur();
            Grup_Doldur();


        }
        private void Grup_Doldur()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Grup_Adi from Grup", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Grup");
            DataRow dataRow = ds.Tables[0].NewRow();
            dataRow["Grup_Adi"] = "HEPSİ";
            ds.Tables[0].Rows.InsertAt(dataRow, 0);
            // ds.Tables[0].Rows[ds.Tables[0].Rows.Count-1].
            comboBox1.DataSource = ds.Tables["Grup"];
            comboBox1.DisplayMember = "Grup_Adi";
            con.Close();


        }
        public bool bul = false;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                bul = true;
                //msg.mesaj_goster("ÜRÜN BULUNDU", 400);
                this.Close();


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void Bul_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
