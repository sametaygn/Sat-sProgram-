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
    public partial class Urun_Ekleme : Form
    {
        public Urun_Ekleme()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(Form1.sqlcon_stiring);
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
        private void Birim_Doldur()
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Birim from Birim", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Birim");
            birimComboBox.DataSource = ds.Tables["Birim"];
            birimComboBox.DisplayMember = "Birim";
            con.Close();
            birimComboBox.Text = "";


        }
        private void Urun_Ekleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            // this.tableTableAdapter.Fill(this.database1DataSet.Table);
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.database1DataSet.Table);
            //barkodtxb_visiblity(false);
            Grup_Doldur();
            Birim_Doldur();
            foreach (var item in panel3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox a = (TextBox)item;

                    if (a.Name == barkodTextBox.Name)
                    {

                    }
                    else
                    {
                        a.Enabled = false;
                    }
                }
                if (item is ComboBox)
                {
                    ComboBox c = (ComboBox)item;
                    c.Enabled = false;
                }
            }


        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.tableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void tableBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           
            


        }
        private void txb_visiblity(bool a)
        {
            if (a == true)
            {
                barkodTextBox.Enabled = true;
            }
            else
            {
                barkodTextBox.Enabled = false;
            }
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //barkodtxb_visiblity(true);
            barkodTextBox.Focus();
        }

        private void barkodTextBox_Enter(object sender, EventArgs e)
        {
            

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    } 

