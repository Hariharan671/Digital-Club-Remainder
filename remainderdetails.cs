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
    public partial class remainderdetails : UserControl
    {

        private static remainderdetails instance;

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\Digital_Club_Remainder\Database.mdf;Integrated Security = True");

        public void refresh_grid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Showmsg", con);
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
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Columns[0].Name = "sender";
                dataGridView1.Columns[0].HeaderText = "Sender";
                dataGridView1.Columns[0].DataPropertyName = "Sender";
                dataGridView1.Columns[0].Width = 120;

                dataGridView1.Columns[1].HeaderText = "Message";
                dataGridView1.Columns[1].Name = "message";
                dataGridView1.Columns[1].DataPropertyName = "Message";
                dataGridView1.Columns[1].Width = 230;

                dataGridView1.Columns[2].Name = "time";
                dataGridView1.Columns[2].HeaderText = "Time";
                dataGridView1.Columns[2].DataPropertyName = "Time";
                dataGridView1.Columns[2].Width = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Showmsg" + ex);
            }
        }

        public static remainderdetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new remainderdetails();
                }
                return instance;
            }
        }

        public remainderdetails()
        {
            InitializeComponent();
            refresh_grid();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Member_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("msg_Add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sender","hari");
            cmd.Parameters.AddWithValue("@msg", textBox2.Text);
            cmd.Parameters.AddWithValue("@time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
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
            refresh_grid();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
