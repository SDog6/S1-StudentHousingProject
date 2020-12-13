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
    public partial class Owner : Form
    {
        Complaints GatherAllComplaints;
        public Owner()
        {
            InitializeComponent();
            GatherAllComplaints = new Complaints();
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //LogIn LogInForm = new LogIn();
            this.Hide();
            //LogInForm.Show();
        }
        public void UpdateComplaintList()
        {

            lblComplaints.Items.Clear();
            foreach (Complaint C in GatherAllComplaints.GetComplaintslist())
            {
                lblComplaints.Items.Add(C.GetInfo());
            }

        }

        private void btnCompaintsViewBy_Click(object sender, EventArgs e)
        {
            UpdateComplaintList();
        }
    }
}
