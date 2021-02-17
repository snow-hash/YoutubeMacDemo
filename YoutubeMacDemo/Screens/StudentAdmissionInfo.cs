using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMacDemo.Screens
{
    public partial class StudentAdmissionInfo : Form
    {
        public StudentAdmissionInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (PersonalInfoPanel.Visible)
            {
                if (isSValidated())
                {
                    GuardianInfoPanel.Visible = true;
                    PersonalInfoPanel.Visible = false;
                    BackButton.Visible = true;
                }
            }
            else
            {
                if (isGValidated())
                {
                    GuardianInfoPanel.Visible = false;
                    PersonalInfoPanel.Visible = true;
                    BackButton.Visible = false;
                }
            }

        }

        private bool isGValidated()
        {
            if (FNameTextBox.Text.Trim() == "" || FOccupationTextBox.Text.Trim() == "" || FNICTextBox.Text.Trim() == "" || FAddressTextBox.Text.Trim() == "" || FContactTextBox.Text.Trim() == "" || (FMaleRadioButton.Checked == false && FFmaleRadioButton.Checked == false))
            {
                MessageBox.Show("Please insert all the required data into similar fields.", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool isSValidated()
        {
            if (SNameTextBox.Text.Trim() == "" || SAgeTextBox.Text.Trim() == "" || SContactTextBox.Text.Trim() == "" || SNICTextBox.Text.Trim() == "" || SAddressTextBox.Text.Trim() == "" || (SMaleRadioButton.Checked == false && SFMaleRadioButton.Checked == false))
            {
                MessageBox.Show("Please insert all the required data into similar fields.", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void SAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hi");
        }

        private void FAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if(FAddressTextBox.Text.Trim() == "==")
            {
                FAddressTextBox.Text = SAddressTextBox.Text;
            }
        }
    }
}
