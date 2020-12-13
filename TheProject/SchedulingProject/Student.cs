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
        Owner OwnerForm;

        public Student(Rules Rulesss)
        {
            InitializeComponent();
            this.Rulesss = Rulesss;
            myScheduleList = new ScheduleList();
            newDiscussionList = new DiscussionsOrganizer();

            //EXTRAS
            newDiscussionList.AddDiscussion("Leo", "13.12.2020", "Hey did you guys clean the living room?");
            newDiscussionList.AddDiscussion("Daniel", "14.12.2020", "No, because we claned it 2 days ago. It's not durty.");
            UpdateDiscussionList();

        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddChore_Click(object sender, EventArgs e)
        {
            string name = tbChoreName.Text;
            string chore = tbChore.Text;
            string date = tbChoreDate.Text;
            myScheduleList.AddSchedule(name,chore,date);
            UpdateScheduleList();
        }

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

        private void btnUpdateRules_Click(object sender, EventArgs e)
        {
            UpdateRuleList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = lblChores.SelectedIndex;
            myScheduleList.RemoveChore(index);
            UpdateScheduleList();
        }

        private void btnDiscussionsSend_Click(object sender, EventArgs e)
        {
            string name = tbDicussionName.Text;
            string date =tbDiscussionDate.Text;
            string debate = tbDiscussions.Text;
            newDiscussionList.AddDiscussion(name, date, debate);
            UpdateDiscussionList();
        }

        public void UpdateDiscussionList()
        {
            lbDiscussions.Items.Clear();
            foreach (Discussion D in newDiscussionList.GetAllDiscussions())
            {
                lbDiscussions.Items.Add(D.GetInfo());
            }
        }
    }
}