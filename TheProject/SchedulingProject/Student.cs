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

        //RULES
        private void btnUpdateRules_Click(object sender, EventArgs e)
        {
            UpdateRuleList();
            string s = "fuck this";
        }

        // CHORES

        private void btnAddChore_Click(object sender, EventArgs e)
        {
            string name = tbChoreName.Text;
            string chore = tbChore.Text;
            string date = tbChoreDate.Text;
            myScheduleList.AddSchedule(name, chore, date);
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
            newDiscussionList.AddDiscussion(name, date, debate);
            UpdateDiscussionList();
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

            allcomplaints.AddComplaint(day, month, year, complaint);

            UpdateComplaintList();
        }



        private void btnRemoveComplaint_Click_1(object sender, EventArgs e)
        {
            int selected = lblComplaints.SelectedIndex;
            allcomplaints.RemoveFromlist(selected);

            if (selected == -1)
            {
                MessageBox.Show("you haven't selected a complaint to be removed yet!");
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStudentName();
        }

        public void UpdateAll()
        {
            UpdateRuleList();
            UpdateDiscussionList();
            UpdateScheduleList();
            UpdateComplaintList();
        }
    }
}