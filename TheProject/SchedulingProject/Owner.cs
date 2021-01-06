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
    public partial class Owner : Form
    {
        Random randomcolor;
        Student StudentForm;

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

            // EXTRAS
            label1.Visible = false;
            label1.ForeColor = Color.Red;
          

            //TENANTS INITIATE
            NewTenantArray.ReturnTenantArray()[0] = new Tenant("Leo", (TenantSex)0, 20, 550);
            NewTenantArray.ReturnTenantArray()[1] = new Tenant("", (TenantSex)0, 0, 0);
            NewTenantArray.ReturnTenantArray()[2] = new Tenant("", (TenantSex)0, 0, 0);
            NewTenantArray.ReturnTenantArray()[3] = new Tenant("", (TenantSex)0, 0, 0);
            lblTenant1Info.Text = NewTenantArray.ReturnTenantArray()[0].GetInfo().ToString();
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";
            lblTenant2Info.Text = RemoveMessage;
            lblTenant3Info.Text = RemoveMessage;
            lblTenant4Info.Text = RemoveMessage;
            SetTenantSexOptions();  

        }
        string RemoveMessage = "Room not occupied";


        // RULES 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string RuleToBeAdded = Convert.ToString(tbRulesToAdd.Text);
            NewRuleList.AddRule(RuleToBeAdded);
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
            foreach(Rule R in NewRuleList.GetAllRule())
            {
                lblRuleList.Items.Add(R.GetInfo());
            }
        }


        // TENANT TAB CODE

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            string Tenantname = tbTenantName.Text;
            int Tenantage = Convert.ToInt32(tbTenantAge.Text);
            int Rent = Convert.ToInt32(tbTenantRent.Text);

            if (rbTenant1.Checked)
            {
                NewTenantArray.ReturnTenantArray()[0] = new Tenant (Tenantname, (TenantSex)cbTenantSex.SelectedItem, Tenantage, Rent);
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
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";

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
                lblTenant1Info.Text = RemoveMessage;
                NewTenantArray.ReturnTenantArray()[0].RemoveTenant();
            }
            else if (rbTenant2.Checked)
            {
                lblTenant2Info.Text = RemoveMessage;
                NewTenantArray.ReturnTenantArray()[1].RemoveTenant();
            }
            else if (rbTenant3.Checked)
            {
                lblTenant3Info.Text = RemoveMessage;
                NewTenantArray.ReturnTenantArray()[2].RemoveTenant();
            }
            else if (rbTenant4.Checked)
            {
                lblTenant4Info.Text = RemoveMessage;
                NewTenantArray.ReturnTenantArray()[3].RemoveTenant();
            }
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";

        }


        //COMPLAINTS 
 
        private void button1_Click(object sender, EventArgs e)
        {
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

        private void btnDiscussionsRefesh_Click(object sender, EventArgs e)
        {
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

        // SCHEDULE

        private void btnScheduleRefresh_Click(object sender, EventArgs e)
        {
            UpdateScheduleList();
        }
        public void UpdateScheduleList()
        {
            lblChores.Items.Clear();
            foreach (Schedule schedule in mySchedule.GetScheduleList())
            {
                lblChores.Items.Add(schedule.GetInfo());
            }
        }
    }
}
