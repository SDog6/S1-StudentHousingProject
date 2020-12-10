using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingProject
{
    public partial class LogIn : Form
    {
        Random randomcolor;
        public LogIn()
        {
            InitializeComponent();
            randomcolor = new Random();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User and password for a student login is:  Student \n Username and password for owner is:  owner");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Student StudentForm = new Student();
            Owner OwnerForm = new Owner();
            LogIn LogInForm = new LogIn();

            if (tbUserName.Text == "student" && tbPassword.Text == "student")
            {
                this.Hide();
                StudentForm.Show();
            }

            else if (tbUserName.Text == "owner" && tbPassword.Text == "owner")
            {
                this.Hide();
                OwnerForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid LogIn credentials");
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {

            changeColor();
        }

        private void changeColor()
        {
            Color randomColor = Color.FromArgb(randomcolor.Next(256), randomcolor.Next(256), randomcolor.Next(256));
            label4.ForeColor = randomColor;
        }
    }
}
