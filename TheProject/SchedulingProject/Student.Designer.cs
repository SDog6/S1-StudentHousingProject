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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChoreName = new System.Windows.Forms.TextBox();
            this.BtnRemoveChore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.tbChore = new System.Windows.Forms.TextBox();
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbClose = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(0, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 12);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.groupBox2);
            this.Schedule.Controls.Add(this.dtPicker);
            this.Schedule.Controls.Add(this.btnAssign);
            this.Schedule.Controls.Add(this.BtnRemoveChore);
            this.Schedule.Controls.Add(this.groupBox1);
            this.Schedule.Controls.Add(this.label3);
            this.Schedule.Controls.Add(this.label2);
            this.Schedule.Controls.Add(this.btnAddChore);
            this.Schedule.Controls.Add(this.tbChore);
            this.Schedule.Controls.Add(this.lblChores);
            this.Schedule.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Schedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Schedule.Location = new System.Drawing.Point(4, 47);
            this.Schedule.Name = "Schedule";
            this.Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule.Size = new System.Drawing.Size(770, 394);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(136, 144);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(176, 26);
            this.dtPicker.TabIndex = 12;
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAssign.Location = new System.Drawing.Point(19, 327);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(341, 46);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign chore on random";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbChoreName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // tbChoreName
            // 
            this.tbChoreName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChoreName.Location = new System.Drawing.Point(92, 19);
            this.tbChoreName.Multiline = true;
            this.tbChoreName.Name = "tbChoreName";
            this.tbChoreName.Size = new System.Drawing.Size(176, 31);
            this.tbChoreName.TabIndex = 1;
            // 
            // BtnRemoveChore
            // 
            this.BtnRemoveChore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveChore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRemoveChore.Location = new System.Drawing.Point(191, 275);
            this.BtnRemoveChore.Name = "BtnRemoveChore";
            this.BtnRemoveChore.Size = new System.Drawing.Size(169, 46);
            this.BtnRemoveChore.TabIndex = 9;
            this.BtnRemoveChore.Text = "Remove a scheduled chore";
            this.BtnRemoveChore.UseVisualStyleBackColor = true;
            this.BtnRemoveChore.Click += new System.EventHandler(this.BtnRemoveChore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please enter the name of the person\r\nyou wish to assign a chore to and a date\r\non" +
    " which that chore is to be done.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(80, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chore:";
            // 
            // btnAddChore
            // 
            this.btnAddChore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddChore.Location = new System.Drawing.Point(19, 275);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(169, 46);
            this.btnAddChore.TabIndex = 4;
            this.btnAddChore.Text = "Add/Update schedule";
            this.btnAddChore.UseVisualStyleBackColor = true;
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // tbChore
            // 
            this.tbChore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChore.Location = new System.Drawing.Point(136, 107);
            this.tbChore.Multiline = true;
            this.tbChore.Name = "tbChore";
            this.tbChore.Size = new System.Drawing.Size(176, 22);
            this.tbChore.TabIndex = 2;
            // 
            // lblChores
            // 
            this.lblChores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChores.FormattingEnabled = true;
            this.lblChores.ItemHeight = 21;
            this.lblChores.Location = new System.Drawing.Point(378, 6);
            this.lblChores.Name = "lblChores";
            this.lblChores.Size = new System.Drawing.Size(386, 382);
            this.lblChores.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRuleListS);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRuleListS
            // 
            this.lblRuleListS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleListS.FormattingEnabled = true;
            this.lblRuleListS.ItemHeight = 21;
            this.lblRuleListS.Location = new System.Drawing.Point(3, 6);
            this.lblRuleListS.Name = "lblRuleListS";
            this.lblRuleListS.Size = new System.Drawing.Size(764, 382);
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
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(770, 394);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Complaints";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NumComplaintsMonth
            // 
            this.NumComplaintsMonth.Location = new System.Drawing.Point(179, 242);
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
            this.NumComplaintsMonth.Size = new System.Drawing.Size(64, 33);
            this.NumComplaintsMonth.TabIndex = 14;
            this.NumComplaintsMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumComplaintsYear
            // 
            this.NumComplaintsYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumComplaintsYear.Location = new System.Drawing.Point(262, 242);
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
            this.NumComplaintsYear.Size = new System.Drawing.Size(69, 33);
            this.NumComplaintsYear.TabIndex = 13;
            this.NumComplaintsYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // NumComplaintsDay
            // 
            this.NumComplaintsDay.Location = new System.Drawing.Point(87, 242);
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
            this.NumComplaintsDay.Size = new System.Drawing.Size(64, 33);
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
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(31, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apologies for any inconvenience. \r\nPlease fill out the form bellow to submit a Co" +
    "mplaint";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComplaintsAdd
            // 
            this.btnComplaintsAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnComplaintsAdd.Location = new System.Drawing.Point(35, 297);
            this.btnComplaintsAdd.Name = "btnComplaintsAdd";
            this.btnComplaintsAdd.Size = new System.Drawing.Size(311, 56);
            this.btnComplaintsAdd.TabIndex = 2;
            this.btnComplaintsAdd.Text = "Submit Complaint";
            this.btnComplaintsAdd.UseVisualStyleBackColor = true;
            this.btnComplaintsAdd.Click += new System.EventHandler(this.btnComplaintsAdd_Click_1);
            // 
            // tbCompaints
            // 
            this.tbCompaints.Location = new System.Drawing.Point(35, 88);
            this.tbCompaints.Multiline = true;
            this.tbCompaints.Name = "tbCompaints";
            this.tbCompaints.Size = new System.Drawing.Size(311, 131);
            this.tbCompaints.TabIndex = 1;
            // 
            // lblComplaints
            // 
            this.lblComplaints.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.FormattingEnabled = true;
            this.lblComplaints.ItemHeight = 21;
            this.lblComplaints.Location = new System.Drawing.Point(381, 5);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(382, 382);
            this.lblComplaints.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbStudentDiscussionName);
            this.tabPage3.Controls.Add(this.lblDiscussionName);
            this.tabPage3.Controls.Add(this.btnDiscussionsSend);
            this.tabPage3.Controls.Add(this.tbDiscussions);
            this.tabPage3.Controls.Add(this.lbDiscussions);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tabPage3.Location = new System.Drawing.Point(4, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 394);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Discussions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbStudentDiscussionName
            // 
            this.cbStudentDiscussionName.FormattingEnabled = true;
            this.cbStudentDiscussionName.Location = new System.Drawing.Point(99, 392);
            this.cbStudentDiscussionName.Name = "cbStudentDiscussionName";
            this.cbStudentDiscussionName.Size = new System.Drawing.Size(146, 32);
            this.cbStudentDiscussionName.TabIndex = 8;
            // 
            // lblDiscussionName
            // 
            this.lblDiscussionName.AutoSize = true;
            this.lblDiscussionName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscussionName.Location = new System.Drawing.Point(13, 392);
            this.lblDiscussionName.Name = "lblDiscussionName";
            this.lblDiscussionName.Size = new System.Drawing.Size(80, 24);
            this.lblDiscussionName.TabIndex = 6;
            this.lblDiscussionName.Text = "Name:";
            // 
            // btnDiscussionsSend
            // 
            this.btnDiscussionsSend.Location = new System.Drawing.Point(759, 392);
            this.btnDiscussionsSend.Name = "btnDiscussionsSend";
            this.btnDiscussionsSend.Size = new System.Drawing.Size(91, 66);
            this.btnDiscussionsSend.TabIndex = 2;
            this.btnDiscussionsSend.Text = "Send";
            this.btnDiscussionsSend.UseVisualStyleBackColor = true;
            this.btnDiscussionsSend.Click += new System.EventHandler(this.btnDiscussionsSend_Click);
            // 
            // tbDiscussions
            // 
            this.tbDiscussions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscussions.Location = new System.Drawing.Point(251, 392);
            this.tbDiscussions.Multiline = true;
            this.tbDiscussions.Name = "tbDiscussions";
            this.tbDiscussions.Size = new System.Drawing.Size(502, 66);
            this.tbDiscussions.TabIndex = 1;
            // 
            // lbDiscussions
            // 
            this.lbDiscussions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscussions.FormattingEnabled = true;
            this.lbDiscussions.ItemHeight = 21;
            this.lbDiscussions.Location = new System.Drawing.Point(3, 3);
            this.lbDiscussions.Name = "lbDiscussions";
            this.lbDiscussions.Size = new System.Drawing.Size(764, 382);
            this.lbDiscussions.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(742, -5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(32, 39);
            this.lbClose.TabIndex = 11;
            this.lbClose.Text = "x";
            this.lbClose.Click += new System.EventHandler(this.LbClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(778, 451);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Student_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Student_MouseUp);
            this.tabControl1.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumComplaintsDay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblDiscussionName;
        private System.Windows.Forms.NumericUpDown NumComplaintsMonth;
        private System.Windows.Forms.NumericUpDown NumComplaintsYear;
        private System.Windows.Forms.NumericUpDown NumComplaintsDay;
        private System.Windows.Forms.ComboBox cbStudentDiscussionName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lblRuleListS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

