using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using MySql.Data.MySqlClient;

namespace IOSv1
{
    public partial class login_frm : Form
    {
       
        public login_frm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please complete all the required fields");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource= localhost; database=importsys_db;port=3306; username = root; password= "); //open connection
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from login where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //MENU FORM
                        menu_frm frm = new menu_frm();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username And Password Not Match!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtUsername.Focus();

                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    reader.Close();
                    cmd.Dispose();
                    con.Close(); // always close connection 
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
        }
    }
}
