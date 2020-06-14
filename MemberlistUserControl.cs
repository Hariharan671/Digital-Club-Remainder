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
    public partial class MemberlistUserControl : UserControl
    {
        private static MemberlistUserControl instance;

        public static MemberlistUserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberlistUserControl();
                }
                return instance;
            }
        }
        public MemberlistUserControl()
        {
            InitializeComponent();
        }

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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowmemsData_SP" + ex);
            }
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memid_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mem_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("MemsAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@memberid",memid_in.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@name", mem_name.Text);
            cmd.Parameters.AddWithValue("@clubcode", ccode.Text);
            cmd.Parameters.AddWithValue("@language", textBox13.Text);
            cmd.Parameters.AddWithValue("@state", textBox9.Text);
            cmd.Parameters.AddWithValue("@dept", textBox8.Text);
            cmd.Parameters.AddWithValue("@regno", textBox12.Text);
            cmd.Parameters.AddWithValue("@bday", bday.Text);
            cmd.Parameters.AddWithValue("@blood", textBox18.Text);
            cmd.Parameters.AddWithValue("@hostel", textBox19.Text);
            cmd.Parameters.AddWithValue("@phone", phno.Text);
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

        private void Mem_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Memdelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memid", memid_in.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("       <<INVALID SQL OPERATION.... " + ex);
                }
                con.Close();
                refresh_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mem_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
      
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Mem_update_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Memupdate_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@memberid", memid_in.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@name", mem_name.Text);
            cmd.Parameters.AddWithValue("@clubcode", ccode.Text);
            cmd.Parameters.AddWithValue("@language", textBox13.Text);
            cmd.Parameters.AddWithValue("@state", textBox9.Text);
            cmd.Parameters.AddWithValue("@dept", textBox8.Text);
            cmd.Parameters.AddWithValue("@regno", textBox12.Text);
            cmd.Parameters.AddWithValue("@bday", bday.Text);
            cmd.Parameters.AddWithValue("@blood", textBox18.Text);
            cmd.Parameters.AddWithValue("@hostel", textBox19.Text);
            cmd.Parameters.AddWithValue("@phone", phno.Text);
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

        private void Mem_clr_Click(object sender, EventArgs e)
        {
            memid_in.Text = "";
            email.Text = "";
            mem_name.Text="";
            ccode.Text="";
            textBox13.Text="";
            textBox9.Text="";
            textBox8.Text="";
            textBox12.Text="";
            bday.Text="";
            textBox18.Text="";
            textBox19.Text="";
            phno.Text="";
        }
    }
}
