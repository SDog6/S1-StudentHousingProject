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
        Rules NewRuleList;
        Tenants NewTenantArray;
        Student StudentForm;
        Random randomcolor;

        public Owner()
        {
            InitializeComponent();
            // CLASSES
            NewRuleList = new Rules();
            NewTenantArray = new Tenants();
            randomcolor = new Random();
            tabControl1.Visible = false;
            btnLogOut.Visible = false;



            // EXTRAS
            label1.Visible = false;
            label1.ForeColor = Color.Red;

            //TENANTS INITIATE
            NewTenantArray.ReturnTenantArray()[0] = new Tenant("Leo", (TenantSex)0, 20, 550);
            NewTenantArray.ReturnTenantArray()[1] = new Tenant("Leo", (TenantSex)0, 20, 0);
            NewTenantArray.ReturnTenantArray()[2] = new Tenant("Leo", (TenantSex)0, 20, 0);
            NewTenantArray.ReturnTenantArray()[3] = new Tenant("Leo", (TenantSex)0, 20, 0);
            lblTenant1Info.Text = NewTenantArray.ReturnTenantArray()[0].GetInfo().ToString();
            lblMoney.Text = $"Monthly revenue:{NewTenantArray.GetRevenue().ToString()}€";
            lblTenant2Info.Text = RemoveMessage;
            lblTenant3Info.Text = RemoveMessage;
            lblTenant4Info.Text = RemoveMessage;
            SetTenantSexOptions();  

           //RULES INITIATE
            StudentForm = new Student(NewRuleList);
            NewRuleList.AddRule("No pets are allowed to be kept by the tenants");
            NewRuleList.AddRule("Before inviting people who do not live in the house the tenant must first contact the owner");
            NewRuleList.AddRule("If something is broken by the tenant, he/she must pay the item in full");
            UpdateRuleList();


        }
        string RemoveMessage = "Room not occupied";


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            btnLogOut.Visible = false;
            pbOwnerLogin.Visible = true;
            lblOwnerLogIn.Visible = true;
            lblOwnerLogin1.Visible = true;
            lblOwnerLogin3.Visible = true;
            lblOwnerLogin4.Visible = true;
            tbOwnerLoginPassword.Visible = true;
            tbOwnerLoginUser.Visible = true;
            btnOwnerLogin.Visible = true;
        }



        // RULES TAB CODE

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string RuleToBeAdded = Convert.ToString(tbRulesToAdd.Text);
            NewRuleList.AddRule(RuleToBeAdded);
            UpdateRuleList();
            StudentForm = new Student(NewRuleList);

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

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void lblChores_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOwnerLogin_Click(object sender, EventArgs e)
        {
            if(tbOwnerLoginUser.Text == "owner" && tbOwnerLoginPassword.Text == "owner")
            {
                tabControl1.Visible = true;
                btnLogOut.Visible = true;
                pbOwnerLogin.Visible = false;
                lblOwnerLogIn.Visible = false;
                lblOwnerLogin1.Visible = false;
                lblOwnerLogin3.Visible = false;
                lblOwnerLogin4.Visible = false;
                tbOwnerLoginPassword.Visible = false;
                tbOwnerLoginUser.Visible = false;
                btnOwnerLogin.Visible = false;

            }
            else if (tbOwnerLoginUser.Text == "student" && tbOwnerLoginPassword.Text == "student")
            {
                StudentForm.Show();
            }
        }
    }
}
