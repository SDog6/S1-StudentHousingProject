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
    public partial class Student : Form
    {
        Complaints allcomplaints;
        public Student()
        {
            InitializeComponent();
            allcomplaints = new Complaints();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            this.Hide();
            LogInForm.Show();
        }

        private void btnAddChore_Click(object sender, EventArgs e)
        {

        }

        private void btnComplaintsAdd_Click(object sender, EventArgs e)
        {
            string complaint = tbCompaints.Text;
            int day = Convert.ToInt32(NumComplaintsDay.Value);
            int month = Convert.ToInt32(NumComplaintsMonth.Value);
            int year = Convert.ToInt32(NumComplaintsYear.Value);

            allcomplaints.AddComplaint(day, month, year, complaint );

            UpdateComplaintList();
        }

        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            int selected = lblComplaints.SelectedIndex;

            if (selected > -1)
            {
                allcomplaints.Complaintlist.RemoveAt(selected);
                UpdateComplaintList();


            }
            else
            {
                MessageBox.Show("you haven't selected a complaint to be removed yet!");
            }

        }


        public void UpdateComplaintList()
        {

            lblComplaints.Items.Clear();
            foreach (Complaint C in allcomplaints.GetComplaintslist() )
            {
                lblComplaints.Items.Add(C.GetInfo());
            }
        
        }
    }
}