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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDiscussionsSend = new System.Windows.Forms.Button();
            this.tbDiscussions = new System.Windows.Forms.TextBox();
            this.lbDiscussions = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbComplaintsViewMonth = new System.Windows.Forms.ComboBox();
            this.cbComplaintsViewYear = new System.Windows.Forms.ComboBox();
            this.cbComplaintsViewDay = new System.Windows.Forms.ComboBox();
            this.btnCompaintsViewBy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblComplaints = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRuleList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbRulesToAdd = new System.Windows.Forms.TextBox();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.lblChores = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabPage3
            // 
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
            // btnDiscussionsSend
            // 
            this.btnDiscussionsSend.Location = new System.Drawing.Point(779, 428);
            this.btnDiscussionsSend.Name = "btnDiscussionsSend";
            this.btnDiscussionsSend.Size = new System.Drawing.Size(91, 49);
            this.btnDiscussionsSend.TabIndex = 2;
            this.btnDiscussionsSend.Text = "Send";
            this.btnDiscussionsSend.UseVisualStyleBackColor = true;
            // 
            // tbDiscussions
            // 
            this.tbDiscussions.Location = new System.Drawing.Point(7, 428);
            this.tbDiscussions.Multiline = true;
            this.tbDiscussions.Name = "tbDiscussions";
            this.tbDiscussions.Size = new System.Drawing.Size(766, 49);
            this.tbDiscussions.TabIndex = 1;
            // 
            // lbDiscussions
            // 
            this.lbDiscussions.FormattingEnabled = true;
            this.lbDiscussions.Location = new System.Drawing.Point(7, 14);
            this.lbDiscussions.Name = "lbDiscussions";
            this.lbDiscussions.Size = new System.Drawing.Size(863, 394);
            this.lbDiscussions.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbComplaintsViewMonth);
            this.tabPage1.Controls.Add(this.cbComplaintsViewYear);
            this.tabPage1.Controls.Add(this.cbComplaintsViewDay);
            this.tabPage1.Controls.Add(this.btnCompaintsViewBy);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblComplaints);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(879, 488);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Complaints";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbComplaintsViewMonth
            // 
            this.cbComplaintsViewMonth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewMonth.FormattingEnabled = true;
            this.cbComplaintsViewMonth.Location = new System.Drawing.Point(154, 80);
            this.cbComplaintsViewMonth.Name = "cbComplaintsViewMonth";
            this.cbComplaintsViewMonth.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewMonth.TabIndex = 15;
            // 
            // cbComplaintsViewYear
            // 
            this.cbComplaintsViewYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewYear.FormattingEnabled = true;
            this.cbComplaintsViewYear.Location = new System.Drawing.Point(257, 80);
            this.cbComplaintsViewYear.Name = "cbComplaintsViewYear";
            this.cbComplaintsViewYear.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewYear.TabIndex = 14;
            // 
            // cbComplaintsViewDay
            // 
            this.cbComplaintsViewDay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewDay.FormattingEnabled = true;
            this.cbComplaintsViewDay.Location = new System.Drawing.Point(46, 80);
            this.cbComplaintsViewDay.Name = "cbComplaintsViewDay";
            this.cbComplaintsViewDay.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewDay.TabIndex = 13;
            // 
            // btnCompaintsViewBy
            // 
            this.btnCompaintsViewBy.Location = new System.Drawing.Point(195, 121);
            this.btnCompaintsViewBy.Name = "btnCompaintsViewBy";
            this.btnCompaintsViewBy.Size = new System.Drawing.Size(137, 37);
            this.btnCompaintsViewBy.TabIndex = 12;
            this.btnCompaintsViewBy.Text = "View by date";
            this.btnCompaintsViewBy.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRuleList);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.tbRulesToAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRuleList
            // 
            this.lblRuleList.FormattingEnabled = true;
            this.lblRuleList.Location = new System.Drawing.Point(7, 214);
            this.lblRuleList.Name = "lblRuleList";
            this.lblRuleList.Size = new System.Drawing.Size(863, 251);
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
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add a rule";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbRulesToAdd
            // 
            this.tbRulesToAdd.Location = new System.Drawing.Point(6, 26);
            this.tbRulesToAdd.Multiline = true;
            this.tbRulesToAdd.Name = "tbRulesToAdd";
            this.tbRulesToAdd.Size = new System.Drawing.Size(863, 76);
            this.tbRulesToAdd.TabIndex = 0;
            // 
            // Schedule
            // 
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
            // lblChores
            // 
            this.lblChores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChores.FormattingEnabled = true;
            this.lblChores.ItemHeight = 19;
            this.lblChores.Location = new System.Drawing.Point(45, 20);
            this.lblChores.Name = "lblChores";
            this.lblChores.Size = new System.Drawing.Size(375, 422);
            this.lblChores.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(879, 488);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Tenants";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 543);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "Owner";
            this.Text = "Form2";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Schedule.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDiscussionsSend;
        private System.Windows.Forms.TextBox tbDiscussions;
        private System.Windows.Forms.ListBox lbDiscussions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbComplaintsViewMonth;
        private System.Windows.Forms.ComboBox cbComplaintsViewYear;
        private System.Windows.Forms.ComboBox cbComplaintsViewDay;
        private System.Windows.Forms.Button btnCompaintsViewBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lblComplaints;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lblRuleList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbRulesToAdd;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.ListBox lblChores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
    }
}