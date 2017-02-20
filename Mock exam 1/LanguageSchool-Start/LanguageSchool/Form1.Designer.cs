namespace LanguageSchool
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
            this.btnNrCourses = new System.Windows.Forms.Button();
            this.lbCapacity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnCoursesList = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNrCourses
            // 
            this.btnNrCourses.Location = new System.Drawing.Point(16, 27);
            this.btnNrCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNrCourses.Name = "btnNrCourses";
            this.btnNrCourses.Size = new System.Drawing.Size(199, 28);
            this.btnNrCourses.TabIndex = 0;
            this.btnNrCourses.Text = "Get Number of Courses";
            this.btnNrCourses.UseVisualStyleBackColor = true;
            this.btnNrCourses.Click += new System.EventHandler(this.btnNrCourses_Click);
            // 
            // lbCapacity
            // 
            this.lbCapacity.FormattingEnabled = true;
            this.lbCapacity.ItemHeight = 16;
            this.lbCapacity.Location = new System.Drawing.Point(277, 28);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.ScrollAlwaysVisible = true;
            this.lbCapacity.Size = new System.Drawing.Size(152, 100);
            this.lbCapacity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "course capacity";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbCapacity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(232, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 140);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "course name";
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 16;
            this.lbName.Location = new System.Drawing.Point(4, 28);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbName.Name = "lbName";
            this.lbName.ScrollAlwaysVisible = true;
            this.lbName.Size = new System.Drawing.Size(264, 100);
            this.lbName.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbCourseName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnTeacher);
            this.panel2.Location = new System.Drawing.Point(16, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 80);
            this.panel2.TabIndex = 6;
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(140, 7);
            this.tbCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(108, 22);
            this.tbCourseName.TabIndex = 2;
            this.tbCourseName.Text = "tbCourseName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "enter course code:";
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(8, 39);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(189, 28);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "Get Teacher Name";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnCoursesList
            // 
            this.btnCoursesList.Location = new System.Drawing.Point(16, 229);
            this.btnCoursesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCoursesList.Name = "btnCoursesList";
            this.btnCoursesList.Size = new System.Drawing.Size(199, 28);
            this.btnCoursesList.TabIndex = 7;
            this.btnCoursesList.Text = "Get Courses List";
            this.btnCoursesList.UseVisualStyleBackColor = true;
            this.btnCoursesList.Click += new System.EventHandler(this.btnCoursesList_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(16, 265);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(199, 28);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign in for selected Course";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbNotifications
            // 
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.ItemHeight = 16;
            this.lbNotifications.Location = new System.Drawing.Point(307, 11);
            this.lbNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.ScrollAlwaysVisible = true;
            this.lbNotifications.Size = new System.Drawing.Size(384, 212);
            this.lbNotifications.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 386);
            this.Controls.Add(this.lbNotifications);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnCoursesList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNrCourses);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "School Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNrCourses;
        private System.Windows.Forms.ListBox lbCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCoursesList;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.ListBox lbNotifications;
    }
}

