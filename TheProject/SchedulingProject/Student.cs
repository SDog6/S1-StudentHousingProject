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
        Rules Rulesss;
        ScheduleList myScheduleList;
        DiscussionsOrganizer newDiscussionList;
        Complaints allcomplaints;
        Tenants MyTenantNames;
        DateTime date = DateTime.Now;

        public Student()
        {
            InitializeComponent();
            this.Text = "Wellcome dear tenant";
            myScheduleList = new ScheduleList();
            newDiscussionList = new DiscussionsOrganizer();
            allcomplaints = new Complaints();
            Rulesss = new Rules();
            MyTenantNames = new Tenants();


            for (int i = 0; i < 4; i++)
            {
               
                cbStudentDiscussionName.Items.Add(MyTenantNames.ReturnTenantArray()[i].GetName().ToString());
            }

            UpdateAll();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // CHORES

        private void btnAddChore_Click(object sender, EventArgs e)
        {
            string name = tbChoreName.Text;
            string chore = tbChore.Text;
            string date = tbChoreDate.Text;
            if (tbChoreName.Text == "" && tbChore.Text != "" && tbChoreDate.Text != "")
            {
                myScheduleList.AddSchedule(chore, date);
                tbChore.Text = "";
                tbChoreDate.Text = "";
            }
            else if (tbChoreName.Text != "" && tbChore.Text != "" && tbChoreDate.Text != "")
            {
                myScheduleList.AddSchedule(name, chore, date);
                tbChoreName.Text = "";
                tbChore.Text = "";
                tbChoreDate.Text = "";
            }
            else
            {
                MessageBox.Show("Please correctly fill out the schedule form");
            }
            UpdateScheduleList();
        }

        private void BtnRemoveChore_Click(object sender, EventArgs e)
        {
            int index = lblChores.SelectedIndex;
            myScheduleList.RemoveChore(index);
            UpdateScheduleList();
        }

        //DISCUSSIONS

        private void btnDiscussionsSend_Click(object sender, EventArgs e)
        {
            string name = cbStudentDiscussionName.Text;
            string date = this.date.ToString("f");
            string debate = tbDiscussions.Text;
            if(tbDiscussions.Text != "")
            {
                newDiscussionList.AddDiscussion(name, date, debate);
                UpdateDiscussionList();
                tbDiscussions.Text = "";
            }
            else
            {
                MessageBox.Show("Please write something first");
            }
        }



        // STUDENT COMPLAINTS


        public void UpdateComplaintList()
        {

            lblComplaints.Items.Clear();
            foreach (Complaint C in allcomplaints.GetComplaintslist())
            {
                lblComplaints.Items.Add(C.GetInfo());
            }

        }


        private void btnComplaintsAdd_Click_1(object sender, EventArgs e)
        {
            string complaint = tbCompaints.Text;
            int day = Convert.ToInt32(NumComplaintsDay.Value);
            int month = Convert.ToInt32(NumComplaintsMonth.Value);
            int year = Convert.ToInt32(NumComplaintsYear.Value);
            string status = "Pending";
            if (tbCompaints.Text != "")
            {
                allcomplaints.AddComplaint(day, month, year, complaint, status);
                tbCompaints.Text = "";
            }
            else
            {
                MessageBox.Show("Please complain sir/madam");
            }
            UpdateComplaintList();
        }





        //UPDATE LISTBOXES

        public void UpdateScheduleList()
        {
            lblChores.Items.Clear();
            foreach (Schedule schedule in myScheduleList.GetScheduleList())
            {
                lblChores.Items.Add(schedule.GetInfo());
            }
        }


        public void UpdateRuleList()
        {
            lblRuleListS.Items.Clear();
            foreach (Rule R in Rulesss.GetAllRule())
            {
                lblRuleListS.Items.Add(R.GetInfo());
            }
        }

        public void UpdateDiscussionList()
        {
            lbDiscussions.Items.Clear();
            foreach (Discussion D in newDiscussionList.GetAllDiscussions())
            {
                lbDiscussions.Items.Add(D.GetInfo());
            }
        }

        public void UpdateStudentName()
        {
            cbStudentDiscussionName.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                cbStudentDiscussionName.Items.Add(MyTenantNames.ReturnTenantArray()[i].GetName().ToString());
            }
        }

        public void UpdateAll()
        {
            UpdateRuleList();
            UpdateDiscussionList();
            UpdateScheduleList();
            UpdateComplaintList();
            UpdateStudentName();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            UpdateAll();
        }
        // Form Movement
        private bool mouseDown;
        private Point lastLocation;
        private void Student_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Student_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Student_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if(lblChores.SelectedIndex > -1)
            {
                Schedule temp = null;
                string s = lblChores.SelectedItem.ToString();
                foreach (Schedule S in myScheduleList.GetScheduleList())
                {
                    if (S.GetInfo() == s)
                    {
                        temp = S;
                    }
                }
                temp.Name = MyTenantNames.GetRandomTenant();

                UpdateAll();
            }
            else
            {
                MessageBox.Show("Please select a chore.");
            }
    
        }
    }
}