﻿using System;
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
        Rules NewRulen;
        Random randomcolor;
        public LogIn()
        {
          
            InitializeComponent();
            randomcolor = new Random();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User and password for a student login is:  Student \n Username and password for owner is:  owner");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Student StudentForm = new Student(NewRulen);
            Owner OwnerForm = new Owner();
            LogIn LogInForm = new LogIn();

            if (tbUserName.Text == "student" && tbPassword.Text == "student")
            {
                
                StudentForm.Show();
            }

            else if (tbUserName.Text == "owner" && tbPassword.Text == "owner")
            {
                
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
            Color randomColor = Color.FromArgb(randomcolor.Next(200), randomcolor.Next(200), randomcolor.Next(200));
            label4.ForeColor = randomColor;
        }
        
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
