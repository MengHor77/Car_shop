using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" && textBox_password.Text == "")
            {
                MessageBox.Show("Please fill Username and Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_username.Text == "")
            {
                MessageBox.Show("Please fill Username", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_password.Text == "")
            {
                MessageBox.Show("Please fill Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_username.Text.ToLower() == "admin" && textBox_password.Text == "123")
            {
                Program.frmHome.WindowState = Program.frmLogin.WindowState;
                Program.frmHome.Show();
                Program.frmLogin.Hide();
            }
            else if (textBox_username.Text.ToLower() != "admin" && textBox_password.Text != "123")
            {
                labelusername.Text = "Incorrect UserName";
                labelpassword.Text = "Incorrect Password";
            }
            else if (textBox_username.Text.ToLower() != "admin")
            {
                labelusername.Text = "Incorrect UserName";
                labelpassword.Text = "";
            }
            else if (textBox_password.Text != "123")
            {
                labelpassword.Text = "Incorrect Password";
                labelusername.Text = "";
            }
        }

        private void checkBox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpassword.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_big_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
