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
        Random randomcolor;
        Rules NewRuleList;
        Tenants NewTenantArray;
        ScheduleList mySchedule;
        Complaints GatherAllComplaints;
        DiscussionsOrganizer newDiscussionList;

        public Owner()
        {
            InitializeComponent();
            // CLASSES
            this.Text = "Administration Panel";
            NewRuleList = new Rules();
            NewTenantArray = new Tenants();
            randomcolor = new Random();
            GatherAllComplaints = new Complaints();
            newDiscussionList = new DiscussionsOrganizer();
            mySchedule = new ScheduleList();

            //Rules warning label
            label1.Visible = false;
       

            //TENANTS INITIATE
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";
            lblTenant1Info.Text = NewTenantArray.ReturnTenantArray()[0].GetInfo().ToString();
            lblTenant2Info.Text = NewTenantArray.ReturnTenantArray()[1].GetInfo().ToString();
            lblTenant3Info.Text = NewTenantArray.ReturnTenantArray()[2].GetInfo().ToString();
            lblTenant4Info.Text = NewTenantArray.ReturnTenantArray()[3].GetInfo().ToString();
            SetTenantSexOptions();

            UpdateAll();

        }


        // RULES 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string RuleToBeAdded = Convert.ToString(tbRulesToAdd.Text);
            if (tbRulesToAdd.Text != "")
            {
                NewRuleList.AddRule(RuleToBeAdded);
                tbRulesToAdd.Text = "";
            }
            else
            {
                MessageBox.Show("Please write a rule");
            }
            UpdateRuleList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Index = lblRuleList.SelectedIndex;
            if (Index != -1)
            {
                label1.Visible = false;
                NewRuleList.RemoveRule(Index);
                UpdateRuleList();
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Select a rule to remove*";
            }

        }
        public void UpdateRuleList()
        {
            lblRuleList.Items.Clear();
            foreach (Rule R in NewRuleList.GetAllRule())
            {
                lblRuleList.Items.Add(R.GetInfo());
            }
        }


        // TENANT TAB CODE

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            if (tbTenantName.Text != "" && tbTenantAge.Text != "" && tbTenantRent.Text != "")
            {
                string Tenantname = tbTenantName.Text;
                int Tenantage = Convert.ToInt32(tbTenantAge.Text);
                int Rent = Convert.ToInt32(tbTenantRent.Text);

                if (rbTenant1.Checked)
                {
                    NewTenantArray.ReturnTenantArray()[0] = new Tenant(Tenantname, (TenantSex)cbTenantSex.SelectedItem, Tenantage, Rent);
                    lblTenant1Info.Text = NewTenantArray.ReturnTenantArray()[0].GetInfo().ToString();
                }
                else if (rbTenant2.Checked)
                {
                    NewTenantArray.ReturnTenantArray()[1] = new Tenant(Tenantname, (TenantSex)cbTenantSex.SelectedItem, Tenantage, Rent);
                    lblTenant2Info.Text = NewTenantArray.ReturnTenantArray()[1].GetInfo().ToString();
                }
                else if (rbTenant3.Checked)
                {
                    NewTenantArray.ReturnTenantArray()[2] = new Tenant(Tenantname, (TenantSex)cbTenantSex.SelectedItem, Tenantage, Rent);
                    lblTenant3Info.Text = NewTenantArray.ReturnTenantArray()[2].GetInfo().ToString();
                }
                else if (rbTenant4.Checked)
                {
                    NewTenantArray.ReturnTenantArray()[3] = new Tenant(Tenantname, (TenantSex)cbTenantSex.SelectedItem, Tenantage, Rent);
                    lblTenant4Info.Text = NewTenantArray.ReturnTenantArray()[3].GetInfo().ToString();
                }
                else
                {

                }
                tbTenantName.Text = "";
                tbTenantAge.Text = "";
                tbTenantRent.Text = "";
                lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";
            }
            else
            {
                MessageBox.Show("Please fill out the tenants details");
            }
        }

        public void SetTenantSexOptions()
        {
            for (int i = 0; i <= 1; i++)
            {
                cbTenantSex.Items.Add((TenantSex)i);
            }
        }
        private void btnTenantRemove_Click(object sender, EventArgs e)
        {
            if (rbTenant1.Checked)
            {
                NewTenantArray.ReturnTenantArray()[0].RemoveTenant();
                lblTenant1Info.Text = NewTenantArray.ReturnTenantArray()[0].GetInfo().ToString();
            }
            else if (rbTenant2.Checked)
            {
                NewTenantArray.ReturnTenantArray()[1].RemoveTenant();
                lblTenant2Info.Text = NewTenantArray.ReturnTenantArray()[1].GetInfo().ToString();
            }
            else if (rbTenant3.Checked)
            {
                NewTenantArray.ReturnTenantArray()[2].RemoveTenant();
                lblTenant3Info.Text = NewTenantArray.ReturnTenantArray()[2].GetInfo().ToString();
            }
            else if (rbTenant4.Checked)
            {
                NewTenantArray.ReturnTenantArray()[3].RemoveTenant();
                lblTenant4Info.Text = NewTenantArray.ReturnTenantArray()[3].GetInfo().ToString();
            }
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";

        }


        //COMPLAINTS 

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            UpdateComplaintList();
        }
        private void btnCompaintsViewBy_Click(object sender, EventArgs e)
        {
            UpdateComplaintList();
        }
        public void UpdateComplaintList()
        {

            lblComplaints.Items.Clear();
            foreach (Complaint C in GatherAllComplaints.GetComplaintslist())
            {
                lblComplaints.Items.Add(C.GetInfo());
            }

        }
        // DISCUSSIONS

        public void UpdateDiscussionList()
        {
            lbDiscussions.Items.Clear();
            foreach (Discussion D in newDiscussionList.GetAllDiscussions())
            {
                lbDiscussions.Items.Add(D.GetInfo());
            }
        }

        // SCHEDULE

        public void UpdateScheduleList()
        {
            lblChores.Items.Clear();
            foreach (Schedule schedule in mySchedule.GetScheduleList())
            {
                lblChores.Items.Add(schedule.GetInfo());
            }
        }
        public void UpdateAll()
        {
            UpdateScheduleList();
            UpdateDiscussionList();
            UpdateRuleList();
           // UpdateComplaintList();
        }

        private void btnCompaintsViewBy_Click_1(object sender, EventArgs e)
        {
            timer2.Stop();
            int day = Convert.ToInt32(NumComplaintsDay.Value);
            int month = Convert.ToInt32(NumComplaintsMonth.Value);
            int year = Convert.ToInt32(NumComplaintsYear.Value);
            lblComplaints.Items.Clear();
            foreach (Complaint c in GatherAllComplaints.FilterList(day, month, year))
            {
                lblComplaints.Items.Add(c.GetInfo());
            }

            GatherAllComplaints.FilterList(day, month, year);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAll();
        }

     
        // button to change the status of the complaint from pending to Complete
        private void btnDone_Click(object sender, EventArgs e)
        {
             string status = "Done";
           
                if (lblComplaints.SelectedItem == null)
                {
                    MessageBox.Show("Please select the complaint that you want to change the status of!");
                }
            foreach (Complaint item in GatherAllComplaints.GetComplaintslist())
            {

                if (lblComplaints.SelectedItem == null)
                {
                    
                }
                else if (lblComplaints.SelectedItem.ToString() == item.GetInfo())
                {
                    item.Cstatus = status;
                    lblComplaints.Items.Add(item.GetInfo());
                    UpdateComplaintList();
                }
            }
        }

        // Timer for the complaint tab so you can view complaint by day without reseting or stopping the timer for the entire application 
        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateComplaintList();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        // Form Movement
        private bool mouseDown;
        private Point lastLocation;

        private void Owner_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Owner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Owner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
