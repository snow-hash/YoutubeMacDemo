using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeMacDemo.Screens;

namespace YoutubeMacDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();

            
        }


        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
          
            moveImageBox(sender);
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StudentAdmissionInfo sai = new StudentAdmissionInfo();
            sai.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("you are about to LogOut from the System!\nAre you ready?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Show();
            }
        }
    }
}
