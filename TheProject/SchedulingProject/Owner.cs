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
        public Owner()
        {
            InitializeComponent();
            lblChores.Items.Add("suicide");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            this.Hide();
            LogInForm.Show();
        }
    }
}
