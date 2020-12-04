namespace SchedulingProject
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbRulesToAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRuleList = new System.Windows.Forms.ListBox();
            this.lblChores = new System.Windows.Forms.ListBox();
            this.tbChoreName = new System.Windows.Forms.TextBox();
            this.tbChore = new System.Windows.Forms.TextBox();
            this.tbChoreDate = new System.Windows.Forms.TextBox();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblComplaints = new System.Windows.Forms.ListBox();
            this.tbCompaints = new System.Windows.Forms.TextBox();
            this.btnComplaintsAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCompaintsDay = new System.Windows.Forms.ComboBox();
            this.cbComplaintsMonth = new System.Windows.Forms.ComboBox();
            this.cbComplaintsYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompaintsViewBy = new System.Windows.Forms.Button();
            this.cbComplaintsViewDay = new System.Windows.Forms.ComboBox();
            this.cbComplaintsViewYear = new System.Windows.Forms.ComboBox();
            this.cbComplaintsViewMonth = new System.Windows.Forms.ComboBox();
            this.lbDiscussions = new System.Windows.Forms.ListBox();
            this.tbDiscussions = new System.Windows.Forms.TextBox();
            this.btnDiscussionsSend = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.button1);
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
            this.Schedule.Click += new System.EventHandler(this.tabPage1_Click);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbComplaintsViewMonth);
            this.tabPage1.Controls.Add(this.cbComplaintsViewYear);
            this.tabPage1.Controls.Add(this.cbComplaintsViewDay);
            this.tabPage1.Controls.Add(this.btnCompaintsViewBy);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbComplaintsYear);
            this.tabPage1.Controls.Add(this.cbComplaintsMonth);
            this.tabPage1.Controls.Add(this.cbCompaintsDay);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnRemoveComplaint);
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
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
            // tbRulesToAdd
            // 
            this.tbRulesToAdd.Location = new System.Drawing.Point(6, 26);
            this.tbRulesToAdd.Multiline = true;
            this.tbRulesToAdd.Name = "tbRulesToAdd";
            this.tbRulesToAdd.Size = new System.Drawing.Size(863, 76);
            this.tbRulesToAdd.TabIndex = 0;
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(253, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 40);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove a rule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRuleList
            // 
            this.lblRuleList.FormattingEnabled = true;
            this.lblRuleList.Location = new System.Drawing.Point(7, 214);
            this.lblRuleList.Name = "lblRuleList";
            this.lblRuleList.Size = new System.Drawing.Size(863, 251);
            this.lblRuleList.TabIndex = 3;
            // 
            // lblChores
            // 
            this.lblChores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChores.FormattingEnabled = true;
            this.lblChores.ItemHeight = 19;
            this.lblChores.Location = new System.Drawing.Point(445, 32);
            this.lblChores.Name = "lblChores";
            this.lblChores.Size = new System.Drawing.Size(375, 422);
            this.lblChores.TabIndex = 0;
            // 
            // tbChoreName
            // 
            this.tbChoreName.Location = new System.Drawing.Point(140, 125);
            this.tbChoreName.Multiline = true;
            this.tbChoreName.Name = "tbChoreName";
            this.tbChoreName.Size = new System.Drawing.Size(171, 20);
            this.tbChoreName.TabIndex = 1;
            // 
            // tbChore
            // 
            this.tbChore.Location = new System.Drawing.Point(140, 208);
            this.tbChore.Multiline = true;
            this.tbChore.Name = "tbChore";
            this.tbChore.Size = new System.Drawing.Size(171, 20);
            this.tbChore.TabIndex = 2;
            // 
            // tbChoreDate
            // 
            this.tbChoreDate.Location = new System.Drawing.Point(140, 294);
            this.tbChoreDate.Multiline = true;
            this.tbChoreDate.Name = "tbChoreDate";
            this.tbChoreDate.Size = new System.Drawing.Size(171, 20);
            this.tbChoreDate.TabIndex = 3;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(63, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(70, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(140, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Remove a scheduled chore";
            this.button1.UseVisualStyleBackColor = true;
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
            // tbCompaints
            // 
            this.tbCompaints.Location = new System.Drawing.Point(56, 84);
            this.tbCompaints.Multiline = true;
            this.tbCompaints.Name = "tbCompaints";
            this.tbCompaints.Size = new System.Drawing.Size(286, 131);
            this.tbCompaints.TabIndex = 1;
            // 
            // btnComplaintsAdd
            // 
            this.btnComplaintsAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaintsAdd.Location = new System.Drawing.Point(56, 292);
            this.btnComplaintsAdd.Name = "btnComplaintsAdd";
            this.btnComplaintsAdd.Size = new System.Drawing.Size(100, 56);
            this.btnComplaintsAdd.TabIndex = 2;
            this.btnComplaintsAdd.Text = "Add";
            this.btnComplaintsAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apologies for any inconviniances. \r\nPlease tell us if you have had any bad experi" +
    "ances";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveComplaint.Location = new System.Drawing.Point(242, 292);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(100, 56);
            this.btnRemoveComplaint.TabIndex = 4;
            this.btnRemoveComplaint.Text = "Remove";
            this.btnRemoveComplaint.UseVisualStyleBackColor = true;
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
            // cbCompaintsDay
            // 
            this.cbCompaintsDay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompaintsDay.FormattingEnabled = true;
            this.cbCompaintsDay.Location = new System.Drawing.Point(56, 236);
            this.cbCompaintsDay.Name = "cbCompaintsDay";
            this.cbCompaintsDay.Size = new System.Drawing.Size(75, 23);
            this.cbCompaintsDay.TabIndex = 7;
            // 
            // cbComplaintsMonth
            // 
            this.cbComplaintsMonth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsMonth.FormattingEnabled = true;
            this.cbComplaintsMonth.Location = new System.Drawing.Point(160, 236);
            this.cbComplaintsMonth.Name = "cbComplaintsMonth";
            this.cbComplaintsMonth.Size = new System.Drawing.Size(79, 23);
            this.cbComplaintsMonth.TabIndex = 8;
            this.cbComplaintsMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbComplaintsYear
            // 
            this.cbComplaintsYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsYear.FormattingEnabled = true;
            this.cbComplaintsYear.Location = new System.Drawing.Point(263, 236);
            this.cbComplaintsYear.Name = "cbComplaintsYear";
            this.cbComplaintsYear.Size = new System.Drawing.Size(79, 23);
            this.cbComplaintsYear.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "View Sertain Dates:";
            // 
            // btnCompaintsViewBy
            // 
            this.btnCompaintsViewBy.Location = new System.Drawing.Point(205, 446);
            this.btnCompaintsViewBy.Name = "btnCompaintsViewBy";
            this.btnCompaintsViewBy.Size = new System.Drawing.Size(137, 37);
            this.btnCompaintsViewBy.TabIndex = 12;
            this.btnCompaintsViewBy.Text = "View by date";
            this.btnCompaintsViewBy.UseVisualStyleBackColor = true;
            // 
            // cbComplaintsViewDay
            // 
            this.cbComplaintsViewDay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewDay.FormattingEnabled = true;
            this.cbComplaintsViewDay.Location = new System.Drawing.Point(56, 417);
            this.cbComplaintsViewDay.Name = "cbComplaintsViewDay";
            this.cbComplaintsViewDay.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewDay.TabIndex = 13;
            // 
            // cbComplaintsViewYear
            // 
            this.cbComplaintsViewYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewYear.FormattingEnabled = true;
            this.cbComplaintsViewYear.Location = new System.Drawing.Point(267, 417);
            this.cbComplaintsViewYear.Name = "cbComplaintsViewYear";
            this.cbComplaintsViewYear.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewYear.TabIndex = 14;
            // 
            // cbComplaintsViewMonth
            // 
            this.cbComplaintsViewMonth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplaintsViewMonth.FormattingEnabled = true;
            this.cbComplaintsViewMonth.Location = new System.Drawing.Point(164, 417);
            this.cbComplaintsViewMonth.Name = "cbComplaintsViewMonth";
            this.cbComplaintsViewMonth.Size = new System.Drawing.Size(75, 23);
            this.cbComplaintsViewMonth.TabIndex = 15;
            // 
            // lbDiscussions
            // 
            this.lbDiscussions.FormattingEnabled = true;
            this.lbDiscussions.Location = new System.Drawing.Point(7, 14);
            this.lbDiscussions.Name = "lbDiscussions";
            this.lbDiscussions.Size = new System.Drawing.Size(863, 394);
            this.lbDiscussions.TabIndex = 0;
            // 
            // tbDiscussions
            // 
            this.tbDiscussions.Location = new System.Drawing.Point(7, 428);
            this.tbDiscussions.Multiline = true;
            this.tbDiscussions.Name = "tbDiscussions";
            this.tbDiscussions.Size = new System.Drawing.Size(766, 49);
            this.tbDiscussions.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbRulesToAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddChore;
        private System.Windows.Forms.TextBox tbChoreDate;
        private System.Windows.Forms.TextBox tbChore;
        private System.Windows.Forms.TextBox tbChoreName;
        private System.Windows.Forms.ListBox lblChores;
        private System.Windows.Forms.ListBox lblRuleList;
        private System.Windows.Forms.Button btnRemoveComplaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComplaintsAdd;
        private System.Windows.Forms.TextBox tbCompaints;
        private System.Windows.Forms.ListBox lblComplaints;
        private System.Windows.Forms.ComboBox cbComplaintsYear;
        private System.Windows.Forms.ComboBox cbComplaintsMonth;
        private System.Windows.Forms.ComboBox cbCompaintsDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCompaintsViewBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbComplaintsViewMonth;
        private System.Windows.Forms.ComboBox cbComplaintsViewYear;
        private System.Windows.Forms.ComboBox cbComplaintsViewDay;
        private System.Windows.Forms.ListBox lbDiscussions;
        private System.Windows.Forms.Button btnDiscussionsSend;
        private System.Windows.Forms.TextBox tbDiscussions;
    }
}

