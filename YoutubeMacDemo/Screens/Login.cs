using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMacDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_focus()
        {
            usernameTextBox.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            passwordTextBox.BackColor = SystemColors.Control;
            usernameTextBox.Focus();

        }

        private void password_focus()
        {
            usernameTextBox.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            button1.ForeColor = Color.White;
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            username_focus();
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            password_focus();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            username_focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            password_focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                if (usernameTextBox.Text.Trim() == "admin" && passwordTextBox.Text.Trim() == "admin")
                {
                    MessageBox.Show("Credentials Accepted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                }
            }
        }

        private bool isValid()
        {
            if (usernameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter your username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username_focus();
                return false;
            }
            if (passwordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter your password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_focus();
                return false;
            }
            return true;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username_focus();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password_focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thsi is commit");
        }
    }
}
