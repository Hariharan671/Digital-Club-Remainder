using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Digital_Club_Remainder
{
    public partial class ClubDetails : UserControl
    {
        private static ClubDetails instance;

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\Digital_Club_Remainder\Database.mdf;Integrated Security = True");

        public void refresh_grid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowmemsData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                dataGridView2.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowmemsData_SP" + ex);
            }
        }

        public static ClubDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClubDetails();
                }
                return instance;
            }
        }
        public ClubDetails()
        {
            InitializeComponent();
            refresh_grid();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mem_clr_Click(object sender, EventArgs e)
        {
            refresh_grid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            refresh_grid();
        }
    }
}
