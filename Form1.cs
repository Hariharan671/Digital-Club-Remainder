using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Digital_Club_Remainder
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            label4.Hide();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername()
        {
            con.Open();
            String syntax = "SELECT Username FROM systemtable where Username='"+f_username.Text+"'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String t = dr[0].ToString();
            con.Close();
            return t;

        }

        private String getPass()
        {
            con.Open();
            String syntax = "SELECT Password FROM systemtable where Username='" + f_username.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String tu = dr[0].ToString();
            con.Close();
            return tu;

        }

        private String getClubcode()
        {
            con.Open();
            String syntax = "SELECT clubcode FROM systemtable where Username='" + f_username.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String cc = dr[0].ToString();
            con.Close();
            return cc;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void F_login_Click(object sender, EventArgs e)
        {
            
            String name, pass, clubcode;
            name = f_username.Text;
            pass = f_pass.Text;
          
            clubcode = f_code.Text;
            /*if (name.Equals("")||pass.Equals("")||clubcode.Equals(""))
            {
                label4.Text = "Enter All Credentials";
                label4.Show();
             
            }*/
            String uname = getUsername(), upass = getPass(),uclubcode=getClubcode();
            
            if (name.Equals(uname) && pass.Equals(upass)&&clubcode.Equals(uclubcode))
            {
                label4.Hide();
               //MessageBox.Show("Log In Successful");
                Appbody obj = new Appbody();
                this.Hide();
                obj.Show();
            }
            else
            {
                label4.Text = "Invalid Credentials";
                label4.Show();
            }
        }

        private void F_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
