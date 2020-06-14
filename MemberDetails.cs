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
using System.IO;

namespace Digital_Club_Remainder
{
    public partial class MemberDetails : UserControl
    {

        private static MemberDetails instance;

        public static MemberDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberDetails();
                }
                return instance;
            }
        }

        public MemberDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\Digital_Club_Remainder\Database.mdf;Integrated Security = True");
        public string bb;
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Member_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string syntax = "SELECT name FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                String tu = dr[0].ToString();
                textBox1.Text = tu;
                con.Close();
                con.Open();
                syntax = "SELECT bday FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                dob.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT email FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                email.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT phone FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                phno.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT state FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                textBox11.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT dept FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                dept.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT regno FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                textBox9.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT language FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                ccode.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT blood FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                blood.Text = bb;
                con.Close();
                con.Open();
                syntax = "SELECT hostel FROM members where memberid=" + miid.Text;
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                bb = dr[0].ToString();
                bday.Text = bb;
                con.Close();
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
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Naam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bday_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemberDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
