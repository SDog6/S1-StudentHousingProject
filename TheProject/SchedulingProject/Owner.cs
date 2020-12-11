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
        Student frm;

        public Owner()
        {
            InitializeComponent();
            label1.Visible = false;
            label1.ForeColor = Color.Red;
            NewRuleList = new Rules();
            frm = new Student(NewRuleList);

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
          
            LogIn frm = new LogIn();

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string RuleToBeAdded = Convert.ToString(tbRulesToAdd.Text);
            NewRuleList.AddRule(RuleToBeAdded);
            UpdateList();
            frm = new Student(NewRuleList);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Index = lblRuleList.SelectedIndex;
            if (Index != -1)
            {
                label1.Visible = false;
                NewRuleList.RemoveRule(Index);
                UpdateList();
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Select a rule to remove*";
            }
           
        }
        public void UpdateList()
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

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
        }
    }
}
