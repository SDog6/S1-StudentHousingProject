namespace SchedulingProject
{
    partial class Student
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.BtnRemoveChore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.tbChoreDate = new System.Windows.Forms.TextBox();
            this.tbChore = new System.Windows.Forms.TextBox();
            this.tbChoreName = new System.Windows.Forms.TextBox();
            this.lblChores = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRuleListS = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NumComplaintsMonth = new System.Windows.Forms.NumericUpDown();
            this.NumComplaintsYear = new System.Windows.Forms.NumericUpDown();
            this.NumComplaintsDay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComplaintsAdd = new System.Windows.Forms.Button();
            this.tbCompaints = new System.Windows.Forms.TextBox();
            this.lblComplaints = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbStudentDiscussionName = new System.Windows.Forms.ComboBox();
            this.lblDiscussionName = new System.Windows.Forms.Label();
            this.btnDiscussionsSend = new System.Windows.Forms.Button();
            this.tbDiscussions = new System.Windows.Forms.TextBox();
            this.lbDiscussions = new System.Windows.Forms.ListBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.BtnRemoveChore);
            this.Schedule.Controls.Add(this.label4);
            this.Schedule.Controls.Add(this.label3);
            this.Schedule.Controls.Add(this.label2);
            this.Schedule.Controls.Add(this.label1);
            this.Schedule.Controls.Add(this.btnAddChore);
            this.Schedule.Controls.Add(this.tbChoreDate);
            this.Schedule.Controls.Add(this.tbChore);
            this.Schedule.Controls.Add(this.tbChoreName);
            this.Schedule.Controls.Add(this.lblChores);
            this.Schedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule.Size = new System.Drawing.Size(879, 488);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveChore
            // 
            this.BtnRemoveChore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveChore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRemoveChore.Location = new System.Drawing.Point(140, 419);
            this.BtnRemoveChore.Name = "BtnRemoveChore";
            this.BtnRemoveChore.Size = new System.Drawing.Size(171, 46);
            this.BtnRemoveChore.TabIndex = 9;
            this.BtnRemoveChore.Text = "Remove a scheduled chore";
            this.BtnRemoveChore.UseVisualStyleBackColor = true;
            this.BtnRemoveChore.Click += new System.EventHandler(this.BtnRemoveChore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(40, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please enter the name of ther person you wish to assign a \r\nchore to and a date o" +
    "n which that chore is to be done.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(70, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(63, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chore:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(63, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // btnAddChore
            // 
            this.btnAddChore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddChore.Location = new System.Drawing.Point(140, 354);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(171, 46);
            this.btnAddChore.TabIndex = 4;
            this.btnAddChore.Text = "Add to chore schedule";
            this.btnAddChore.UseVisualStyleBackColor = true;
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // tbChoreDate
            // 
            this.tbChoreDate.Location = new System.Drawing.Point(140, 294);
            this.tbChoreDate.Multiline = true;
            this.tbChoreDate.Name = "tbChoreDate";
            this.tbChoreDate.Size = new System.Drawing.Size(171, 32);
            this.tbChoreDate.TabIndex = 3;
            // 
            // tbChore
            // 
            this.tbChore.Location = new System.Drawing.Point(140, 208);
            this.tbChore.Multiline = true;
            this.tbChore.Name = "tbChore";
            this.tbChore.Size = new System.Drawing.Size(171, 31);
            this.tbChore.TabIndex = 2;
            // 
            // tbChoreName
            // 
            this.tbChoreName.Location = new System.Drawing.Point(140, 125);
            this.tbChoreName.Multiline = true;
            this.tbChoreName.Name = "tbChoreName";
            this.tbChoreName.Size = new System.Drawing.Size(171, 31);
            this.tbChoreName.TabIndex = 1;
            // 
            // lblChores
            // 
            this.lblChores.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChores.FormattingEnabled = true;
            this.lblChores.ItemHeight = 21;
            this.lblChores.Location = new System.Drawing.Point(429, 32);
            this.lblChores.Name = "lblChores";
            this.lblChores.Size = new System.Drawing.Size(391, 403);
            this.lblChores.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRuleListS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRuleListS
            // 
            this.lblRuleListS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleListS.FormattingEnabled = true;
            this.lblRuleListS.ItemHeight = 20;
            this.lblRuleListS.Location = new System.Drawing.Point(7, 19);
            this.lblRuleListS.Name = "lblRuleListS";
            this.lblRuleListS.Size = new System.Drawing.Size(863, 424);
            this.lblRuleListS.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumComplaintsMonth);
            this.tabPage1.Controls.Add(this.NumComplaintsYear);
            this.tabPage1.Controls.Add(this.NumComplaintsDay);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnComplaintsAdd);
            this.tabPage1.Controls.Add(this.tbCompaints);
            this.tabPage1.Controls.Add(this.lblComplaints);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(879, 488);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Complaints";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NumComplaintsMonth
            // 
            this.NumComplaintsMonth.Location = new System.Drawing.Point(174, 233);
            this.NumComplaintsMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumComplaintsMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumComplaintsMonth.Name = "NumComplaintsMonth";
            this.NumComplaintsMonth.Size = new System.Drawing.Size(64, 29);
            this.NumComplaintsMonth.TabIndex = 14;
            this.NumComplaintsMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumComplaintsYear
            // 
            this.NumComplaintsYear.Location = new System.Drawing.Point(273, 233);
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
            this.NumComplaintsYear.Size = new System.Drawing.Size(69, 29);
            this.NumComplaintsYear.TabIndex = 13;
            this.NumComplaintsYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // NumComplaintsDay
            // 
            this.NumComplaintsDay.Location = new System.Drawing.Point(66, 233);
            this.NumComplaintsDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumComplaintsDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumComplaintsDay.Name = "NumComplaintsDay";
            this.NumComplaintsDay.Size = new System.Drawing.Size(64, 29);
            this.NumComplaintsDay.TabIndex = 11;
            this.NumComplaintsDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apologies for any inconvenience. \r\nPlease fill out the form bellow to submit a Co" +
    "mplaint";
            // 
            // btnComplaintsAdd
            // 
            this.btnComplaintsAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaintsAdd.Location = new System.Drawing.Point(86, 310);
            this.btnComplaintsAdd.Name = "btnComplaintsAdd";
            this.btnComplaintsAdd.Size = new System.Drawing.Size(206, 56);
            this.btnComplaintsAdd.TabIndex = 2;
            this.btnComplaintsAdd.Text = "Submit Complaint";
            this.btnComplaintsAdd.UseVisualStyleBackColor = true;
            this.btnComplaintsAdd.Click += new System.EventHandler(this.btnComplaintsAdd_Click_1);
            // 
            // tbCompaints
            // 
            this.tbCompaints.Location = new System.Drawing.Point(56, 84);
            this.tbCompaints.Multiline = true;
            this.tbCompaints.Name = "tbCompaints";
            this.tbCompaints.Size = new System.Drawing.Size(286, 131);
            this.tbCompaints.TabIndex = 1;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbStudentDiscussionName);
            this.tabPage3.Controls.Add(this.lblDiscussionName);
            this.tabPage3.Controls.Add(this.btnDiscussionsSend);
            this.tabPage3.Controls.Add(this.tbDiscussions);
            this.tabPage3.Controls.Add(this.lbDiscussions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(879, 488);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Discussions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbStudentDiscussionName
            // 
            this.cbStudentDiscussionName.FormattingEnabled = true;
            this.cbStudentDiscussionName.Location = new System.Drawing.Point(109, 428);
            this.cbStudentDiscussionName.Name = "cbStudentDiscussionName";
            this.cbStudentDiscussionName.Size = new System.Drawing.Size(77, 21);
            this.cbStudentDiscussionName.TabIndex = 8;
            // 
            // lblDiscussionName
            // 
            this.lblDiscussionName.AutoSize = true;
            this.lblDiscussionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscussionName.Location = new System.Drawing.Point(59, 428);
            this.lblDiscussionName.Name = "lblDiscussionName";
            this.lblDiscussionName.Size = new System.Drawing.Size(44, 15);
            this.lblDiscussionName.TabIndex = 6;
            this.lblDiscussionName.Text = "Name:";
            // 
            // btnDiscussionsSend
            // 
            this.btnDiscussionsSend.Location = new System.Drawing.Point(779, 428);
            this.btnDiscussionsSend.Name = "btnDiscussionsSend";
            this.btnDiscussionsSend.Size = new System.Drawing.Size(91, 49);
            this.btnDiscussionsSend.TabIndex = 2;
            this.btnDiscussionsSend.Text = "Send";
            this.btnDiscussionsSend.UseVisualStyleBackColor = true;
            this.btnDiscussionsSend.Click += new System.EventHandler(this.btnDiscussionsSend_Click);
            // 
            // tbDiscussions
            // 
            this.tbDiscussions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscussions.Location = new System.Drawing.Point(192, 428);
            this.tbDiscussions.Multiline = true;
            this.tbDiscussions.Name = "tbDiscussions";
            this.tbDiscussions.Size = new System.Drawing.Size(581, 49);
            this.tbDiscussions.TabIndex = 1;
            // 
            // lbDiscussions
            // 
            this.lbDiscussions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscussions.FormattingEnabled = true;
            this.lbDiscussions.ItemHeight = 23;
            this.lbDiscussions.Location = new System.Drawing.Point(7, 14);
            this.lbDiscussions.Name = "lbDiscussions";
            this.lbDiscussions.Size = new System.Drawing.Size(863, 372);
            this.lbDiscussions.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(805, 518);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 544);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "Student";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnRemoveChore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddChore;
        private System.Windows.Forms.TextBox tbChoreDate;
        private System.Windows.Forms.TextBox tbChore;
        private System.Windows.Forms.TextBox tbChoreName;
        private System.Windows.Forms.ListBox lblChores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComplaintsAdd;
        private System.Windows.Forms.TextBox tbCompaints;
        private System.Windows.Forms.ListBox lblComplaints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbDiscussions;
        private System.Windows.Forms.Button btnDiscussionsSend;
        private System.Windows.Forms.TextBox tbDiscussions;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDiscussionName;
        private System.Windows.Forms.NumericUpDown NumComplaintsMonth;
        private System.Windows.Forms.NumericUpDown NumComplaintsYear;
        private System.Windows.Forms.NumericUpDown NumComplaintsDay;
        private System.Windows.Forms.ComboBox cbStudentDiscussionName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lblRuleListS;
    }
}

