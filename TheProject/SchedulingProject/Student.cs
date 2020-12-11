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
    { Rules Rulesss;
 
        public Student(Rules Rulesss)
        {
            InitializeComponent();
            this.Rulesss = Rulesss;
            
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

        private void Student_Load(object sender, EventArgs e)
        {

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
    }
}