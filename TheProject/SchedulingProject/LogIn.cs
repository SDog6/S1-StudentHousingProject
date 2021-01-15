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
        Rules NewRulesList;
        Student StudentForm;
        Owner OwnerF;
        public LogIn()
        {
          
            InitializeComponent();
            this.Text = "Welcome !";
            NewRulesList = new Rules();
            StudentForm = new Student();
            OwnerF = new Owner();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        { 
            if (tbUserName.Text == "student" && tbPassword.Text == "student")
            {
                
                StudentForm.Show();
                OwnerF.Hide();
            }

            else if (tbUserName.Text == "owner" && tbPassword.Text == "owner")
            {
                OwnerF.Show();
                StudentForm.Hide();
            }
            else
            {
                MessageBox.Show("Invalid LogIn credentials");
            }
        }

        // Form Movement
        private bool mouseDown;
        private Point lastLocation;

        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
