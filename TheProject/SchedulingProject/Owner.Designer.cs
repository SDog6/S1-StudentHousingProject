namespace SchedulingProject
{
    partial class Owner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.OwnerDiscussions = new System.Windows.Forms.TabPage();
            this.lbDiscussions = new System.Windows.Forms.ListBox();
            this.OwnerRules = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRuleList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbRulesToAdd = new System.Windows.Forms.TextBox();
            this.OwnerSchedule = new System.Windows.Forms.TabPage();
            this.lblChores = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OwnerCompaints = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.NumComplaintsYear = new System.Windows.Forms.NumericUpDown();
            this.NumComplaintsMonth = new System.Windows.Forms.NumericUpDown();
            this.NumComplaintsDay = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCompaintsViewBy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblComplaints = new System.Windows.Forms.ListBox();
            this.OwnerTenants = new System.Windows.Forms.TabPage();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTenant3Info = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTenant2Info = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTenant4Info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenant1Info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTenantRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.tbTenantRent = new System.Windows.Forms.TextBox();
            this.cbTenantSex = new System.Windows.Forms.ComboBox();
            this.tbTenantAge = new System.Windows.Forms.TextBox();
            this.tbTenantName = new System.Windows.Forms.TextBox();
            this.rbTenant4 = new System.Windows.Forms.RadioButton();
            this.rbTenant3 = new System.Windows.Forms.RadioButton();
            this.rbTenant2 = new System.Windows.Forms.RadioButton();
            this.rbTenant1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OwnerDiscussions.SuspendLayout();
            this.OwnerRules.SuspendLayout();
            this.OwnerSchedule.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OwnerCompaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).BeginInit();
            this.OwnerTenants.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(805, 516);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // OwnerDiscussions
            // 
            this.OwnerDiscussions.Controls.Add(this.lbDiscussions);
            this.OwnerDiscussions.Location = new System.Drawing.Point(4, 22);
            this.OwnerDiscussions.Name = "OwnerDiscussions";
            this.OwnerDiscussions.Size = new System.Drawing.Size(879, 488);
            this.OwnerDiscussions.TabIndex = 3;
            this.OwnerDiscussions.Text = "Discussions";
            this.OwnerDiscussions.UseVisualStyleBackColor = true;
            // 
            // lbDiscussions
            // 
            this.lbDiscussions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscussions.FormattingEnabled = true;
            this.lbDiscussions.ItemHeight = 23;
            this.lbDiscussions.Location = new System.Drawing.Point(7, 14);
            this.lbDiscussions.Name = "lbDiscussions";
            this.lbDiscussions.Size = new System.Drawing.Size(863, 441);
            this.lbDiscussions.TabIndex = 0;
            this.lbDiscussions.SelectedIndexChanged += new System.EventHandler(this.lbDiscussions_SelectedIndexChanged);
            // 
            // OwnerRules
            // 
            this.OwnerRules.Controls.Add(this.label1);
            this.OwnerRules.Controls.Add(this.lblRuleList);
            this.OwnerRules.Controls.Add(this.btnRemove);
            this.OwnerRules.Controls.Add(this.btnAdd);
            this.OwnerRules.Controls.Add(this.tbRulesToAdd);
            this.OwnerRules.Location = new System.Drawing.Point(4, 22);
            this.OwnerRules.Name = "OwnerRules";
            this.OwnerRules.Padding = new System.Windows.Forms.Padding(3);
            this.OwnerRules.Size = new System.Drawing.Size(879, 488);
            this.OwnerRules.TabIndex = 1;
            this.OwnerRules.Text = "Rules";
            this.OwnerRules.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblRuleList
            // 
            this.lblRuleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleList.FormattingEnabled = true;
            this.lblRuleList.ItemHeight = 20;
            this.lblRuleList.Location = new System.Drawing.Point(7, 214);
            this.lblRuleList.Name = "lblRuleList";
            this.lblRuleList.Size = new System.Drawing.Size(863, 244);
            this.lblRuleList.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(253, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 40);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove a rule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add a rule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbRulesToAdd
            // 
            this.tbRulesToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRulesToAdd.Location = new System.Drawing.Point(6, 26);
            this.tbRulesToAdd.Multiline = true;
            this.tbRulesToAdd.Name = "tbRulesToAdd";
            this.tbRulesToAdd.Size = new System.Drawing.Size(863, 76);
            this.tbRulesToAdd.TabIndex = 0;
            // 
            // OwnerSchedule
            // 
            this.OwnerSchedule.Controls.Add(this.lblChores);
            this.OwnerSchedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OwnerSchedule.Location = new System.Drawing.Point(4, 22);
            this.OwnerSchedule.Name = "OwnerSchedule";
            this.OwnerSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.OwnerSchedule.Size = new System.Drawing.Size(879, 488);
            this.OwnerSchedule.TabIndex = 0;
            this.OwnerSchedule.Text = "Schedule";
            this.OwnerSchedule.UseVisualStyleBackColor = true;
            // 
            // lblChores
            // 
            this.lblChores.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChores.FormattingEnabled = true;
            this.lblChores.ItemHeight = 23;
            this.lblChores.Location = new System.Drawing.Point(6, 25);
            this.lblChores.Name = "lblChores";
            this.lblChores.Size = new System.Drawing.Size(861, 441);
            this.lblChores.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OwnerSchedule);
            this.tabControl1.Controls.Add(this.OwnerRules);
            this.tabControl1.Controls.Add(this.OwnerCompaints);
            this.tabControl1.Controls.Add(this.OwnerDiscussions);
            this.tabControl1.Controls.Add(this.OwnerTenants);
            this.tabControl1.Location = new System.Drawing.Point(2, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // OwnerCompaints
            // 
            this.OwnerCompaints.Controls.Add(this.label8);
            this.OwnerCompaints.Controls.Add(this.NumComplaintsYear);
            this.OwnerCompaints.Controls.Add(this.NumComplaintsMonth);
            this.OwnerCompaints.Controls.Add(this.NumComplaintsDay);
            this.OwnerCompaints.Controls.Add(this.button1);
            this.OwnerCompaints.Controls.Add(this.btnCompaintsViewBy);
            this.OwnerCompaints.Controls.Add(this.label7);
            this.OwnerCompaints.Controls.Add(this.lblComplaints);
            this.OwnerCompaints.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerCompaints.Location = new System.Drawing.Point(4, 22);
            this.OwnerCompaints.Name = "OwnerCompaints";
            this.OwnerCompaints.Size = new System.Drawing.Size(879, 488);
            this.OwnerCompaints.TabIndex = 2;
            this.OwnerCompaints.Text = "Complaints";
            this.OwnerCompaints.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(174, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "DD/MM/YY";
            // 
            // NumComplaintsYear
            // 
            this.NumComplaintsYear.Location = new System.Drawing.Point(278, 86);
            this.NumComplaintsYear.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumComplaintsYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.NumComplaintsYear.Name = "NumComplaintsYear";
            this.NumComplaintsYear.Size = new System.Drawing.Size(99, 29);
            this.NumComplaintsYear.TabIndex = 24;
            this.NumComplaintsYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // NumComplaintsMonth
            // 
            this.NumComplaintsMonth.Location = new System.Drawing.Point(149, 86);
            this.NumComplaintsMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumComplaintsMonth.Name = "NumComplaintsMonth";
            this.NumComplaintsMonth.Size = new System.Drawing.Size(99, 29);
            this.NumComplaintsMonth.TabIndex = 23;
            this.NumComplaintsMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumComplaintsDay
            // 
            this.NumComplaintsDay.Location = new System.Drawing.Point(26, 86);
            this.NumComplaintsDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumComplaintsDay.Name = "NumComplaintsDay";
            this.NumComplaintsDay.Size = new System.Drawing.Size(98, 29);
            this.NumComplaintsDay.TabIndex = 22;
            this.NumComplaintsDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "View all complaints";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompaintsViewBy
            // 
            this.btnCompaintsViewBy.Location = new System.Drawing.Point(240, 134);
            this.btnCompaintsViewBy.Name = "btnCompaintsViewBy";
            this.btnCompaintsViewBy.Size = new System.Drawing.Size(137, 37);
            this.btnCompaintsViewBy.TabIndex = 12;
            this.btnCompaintsViewBy.Text = "View by date";
            this.btnCompaintsViewBy.UseVisualStyleBackColor = true;
            this.btnCompaintsViewBy.Click += new System.EventHandler(this.btnCompaintsViewBy_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "View Sertain Dates:";
            // 
            // lblComplaints
            // 
            this.lblComplaints.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.FormattingEnabled = true;
            this.lblComplaints.ItemHeight = 21;
            this.lblComplaints.Location = new System.Drawing.Point(402, 26);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(459, 424);
            this.lblComplaints.TabIndex = 0;
            // 
            // OwnerTenants
            // 
            this.OwnerTenants.Controls.Add(this.lblMoney);
            this.OwnerTenants.Controls.Add(this.label6);
            this.OwnerTenants.Controls.Add(this.panel5);
            this.OwnerTenants.Controls.Add(this.panel4);
            this.OwnerTenants.Controls.Add(this.panel3);
            this.OwnerTenants.Controls.Add(this.panel2);
            this.OwnerTenants.Controls.Add(this.panel1);
            this.OwnerTenants.Location = new System.Drawing.Point(4, 22);
            this.OwnerTenants.Name = "OwnerTenants";
            this.OwnerTenants.Size = new System.Drawing.Size(879, 488);
            this.OwnerTenants.TabIndex = 4;
            this.OwnerTenants.Text = "Tenants";
            this.OwnerTenants.UseVisualStyleBackColor = true;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(281, 407);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(109, 18);
            this.lblMoney.TabIndex = 22;
            this.lblMoney.Text = "Imm neck myself";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tenants Configuration";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.lblTenant3Info);
            this.panel5.Location = new System.Drawing.Point(65, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 53);
            this.panel5.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SchedulingProject.Properties.Resources._21294;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // lblTenant3Info
            // 
            this.lblTenant3Info.AutoSize = true;
            this.lblTenant3Info.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant3Info.Location = new System.Drawing.Point(64, 16);
            this.lblTenant3Info.Name = "lblTenant3Info";
            this.lblTenant3Info.Size = new System.Drawing.Size(46, 18);
            this.lblTenant3Info.TabIndex = 11;
            this.lblTenant3Info.Text = "label4";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblTenant2Info);
            this.panel4.Location = new System.Drawing.Point(65, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 53);
            this.panel4.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SchedulingProject.Properties.Resources._21294;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // lblTenant2Info
            // 
            this.lblTenant2Info.AutoSize = true;
            this.lblTenant2Info.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant2Info.Location = new System.Drawing.Point(64, 12);
            this.lblTenant2Info.Name = "lblTenant2Info";
            this.lblTenant2Info.Size = new System.Drawing.Size(46, 18);
            this.lblTenant2Info.TabIndex = 10;
            this.lblTenant2Info.Text = "label3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblTenant4Info);
            this.panel3.Location = new System.Drawing.Point(65, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 53);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchedulingProject.Properties.Resources._21294;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lblTenant4Info
            // 
            this.lblTenant4Info.AutoSize = true;
            this.lblTenant4Info.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant4Info.Location = new System.Drawing.Point(64, 9);
            this.lblTenant4Info.Name = "lblTenant4Info";
            this.lblTenant4Info.Size = new System.Drawing.Size(46, 18);
            this.lblTenant4Info.TabIndex = 12;
            this.lblTenant4Info.Text = "label5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTenant1Info);
            this.panel2.Location = new System.Drawing.Point(65, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 53);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchedulingProject.Properties.Resources._21294;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenant1Info
            // 
            this.lblTenant1Info.AutoSize = true;
            this.lblTenant1Info.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant1Info.Location = new System.Drawing.Point(64, 15);
            this.lblTenant1Info.Name = "lblTenant1Info";
            this.lblTenant1Info.Size = new System.Drawing.Size(46, 18);
            this.lblTenant1Info.TabIndex = 9;
            this.lblTenant1Info.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTenantRemove);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddTenant);
            this.panel1.Controls.Add(this.tbTenantRent);
            this.panel1.Controls.Add(this.cbTenantSex);
            this.panel1.Controls.Add(this.tbTenantAge);
            this.panel1.Controls.Add(this.tbTenantName);
            this.panel1.Controls.Add(this.rbTenant4);
            this.panel1.Controls.Add(this.rbTenant3);
            this.panel1.Controls.Add(this.rbTenant2);
            this.panel1.Controls.Add(this.rbTenant1);
            this.panel1.Location = new System.Drawing.Point(396, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 317);
            this.panel1.TabIndex = 17;
            // 
            // btnTenantRemove
            // 
            this.btnTenantRemove.Location = new System.Drawing.Point(266, 231);
            this.btnTenantRemove.Name = "btnTenantRemove";
            this.btnTenantRemove.Size = new System.Drawing.Size(55, 44);
            this.btnTenantRemove.TabIndex = 17;
            this.btnTenantRemove.Text = "Remove";
            this.btnTenantRemove.UseVisualStyleBackColor = true;
            this.btnTenantRemove.Click += new System.EventHandler(this.btnTenantRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(125, 231);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(121, 44);
            this.btnAddTenant.TabIndex = 8;
            this.btnAddTenant.Text = "Add/Modify Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // tbTenantRent
            // 
            this.tbTenantRent.Location = new System.Drawing.Point(146, 170);
            this.tbTenantRent.Name = "tbTenantRent";
            this.tbTenantRent.Size = new System.Drawing.Size(100, 20);
            this.tbTenantRent.TabIndex = 7;
            // 
            // cbTenantSex
            // 
            this.cbTenantSex.FormattingEnabled = true;
            this.cbTenantSex.Location = new System.Drawing.Point(177, 83);
            this.cbTenantSex.Name = "cbTenantSex";
            this.cbTenantSex.Size = new System.Drawing.Size(69, 21);
            this.cbTenantSex.TabIndex = 6;
            // 
            // tbTenantAge
            // 
            this.tbTenantAge.Location = new System.Drawing.Point(206, 128);
            this.tbTenantAge.Name = "tbTenantAge";
            this.tbTenantAge.Size = new System.Drawing.Size(40, 20);
            this.tbTenantAge.TabIndex = 5;
            // 
            // tbTenantName
            // 
            this.tbTenantName.Location = new System.Drawing.Point(146, 35);
            this.tbTenantName.Name = "tbTenantName";
            this.tbTenantName.Size = new System.Drawing.Size(100, 20);
            this.tbTenantName.TabIndex = 4;
            // 
            // rbTenant4
            // 
            this.rbTenant4.AutoSize = true;
            this.rbTenant4.Location = new System.Drawing.Point(287, 173);
            this.rbTenant4.Name = "rbTenant4";
            this.rbTenant4.Size = new System.Drawing.Size(68, 17);
            this.rbTenant4.TabIndex = 3;
            this.rbTenant4.TabStop = true;
            this.rbTenant4.Text = "Tenant 4";
            this.rbTenant4.UseVisualStyleBackColor = true;
            // 
            // rbTenant3
            // 
            this.rbTenant3.AutoSize = true;
            this.rbTenant3.Location = new System.Drawing.Point(287, 128);
            this.rbTenant3.Name = "rbTenant3";
            this.rbTenant3.Size = new System.Drawing.Size(68, 17);
            this.rbTenant3.TabIndex = 2;
            this.rbTenant3.TabStop = true;
            this.rbTenant3.Text = "Tenant 3";
            this.rbTenant3.UseVisualStyleBackColor = true;
            // 
            // rbTenant2
            // 
            this.rbTenant2.AutoSize = true;
            this.rbTenant2.Location = new System.Drawing.Point(287, 79);
            this.rbTenant2.Name = "rbTenant2";
            this.rbTenant2.Size = new System.Drawing.Size(68, 17);
            this.rbTenant2.TabIndex = 1;
            this.rbTenant2.TabStop = true;
            this.rbTenant2.Text = "Tenant 2";
            this.rbTenant2.UseVisualStyleBackColor = true;
            // 
            // rbTenant1
            // 
            this.rbTenant1.AutoSize = true;
            this.rbTenant1.Location = new System.Drawing.Point(287, 38);
            this.rbTenant1.Name = "rbTenant1";
            this.rbTenant1.Size = new System.Drawing.Size(68, 17);
            this.rbTenant1.TabIndex = 0;
            this.rbTenant1.TabStop = true;
            this.rbTenant1.Text = "Tenant 1";
            this.rbTenant1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Owner";
            this.Text = "Form2";
            this.OwnerDiscussions.ResumeLayout(false);
            this.OwnerRules.ResumeLayout(false);
            this.OwnerRules.PerformLayout();
            this.OwnerSchedule.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.OwnerCompaints.ResumeLayout(false);
            this.OwnerCompaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).EndInit();
            this.OwnerTenants.ResumeLayout(false);
            this.OwnerTenants.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabPage OwnerDiscussions;
        private System.Windows.Forms.ListBox lbDiscussions;
        private System.Windows.Forms.TabPage OwnerRules;
        private System.Windows.Forms.ListBox lblRuleList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbRulesToAdd;
        private System.Windows.Forms.TabPage OwnerSchedule;
        private System.Windows.Forms.ListBox lblChores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OwnerTenants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenant4Info;
        private System.Windows.Forms.Label lblTenant3Info;
        private System.Windows.Forms.Label lblTenant2Info;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.TextBox tbTenantRent;
        private System.Windows.Forms.ComboBox cbTenantSex;
        private System.Windows.Forms.TextBox tbTenantAge;
        private System.Windows.Forms.TextBox tbTenantName;
        private System.Windows.Forms.RadioButton rbTenant4;
        private System.Windows.Forms.RadioButton rbTenant3;
        private System.Windows.Forms.RadioButton rbTenant2;
        private System.Windows.Forms.RadioButton rbTenant1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTenant1Info;
        private System.Windows.Forms.Button btnTenantRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TabPage OwnerCompaints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCompaintsViewBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lblComplaints;
        private System.Windows.Forms.NumericUpDown NumComplaintsYear;
        private System.Windows.Forms.NumericUpDown NumComplaintsMonth;
        private System.Windows.Forms.NumericUpDown NumComplaintsDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}