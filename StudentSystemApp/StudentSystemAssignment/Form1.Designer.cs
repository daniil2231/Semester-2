
namespace StudentSystemAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAddForm = new System.Windows.Forms.GroupBox();
            this.btnAddToAdministration = new System.Windows.Forms.Button();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblECs = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbPCN = new System.Windows.Forms.TextBox();
            this.tbECs = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbYearsAtSchool = new System.Windows.Forms.TextBox();
            this.lblYearAtSchool = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPCN = new System.Windows.Forms.Label();
            this.lbShowAll = new System.Windows.Forms.ListBox();
            this.cbShowPeople = new System.Windows.Forms.ComboBox();
            this.tbPartialName = new System.Windows.Forms.TextBox();
            this.btnShowPersons = new System.Windows.Forms.Button();
            this.btnSearchPartialName = new System.Windows.Forms.Button();
            this.gbActionForm = new System.Windows.Forms.GroupBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnAddECs = new System.Windows.Forms.Button();
            this.tbAddECs = new System.Windows.Forms.TextBox();
            this.btnStartNewSchoolyear = new System.Windows.Forms.Button();
            this.btnCelebrateBirthday = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.tbPCNActionForm = new System.Windows.Forms.TextBox();
            this.lblPCNActionForm = new System.Windows.Forms.Label();
            this.gbAddForm.SuspendLayout();
            this.gbActionForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddForm
            // 
            this.gbAddForm.Controls.Add(this.btnAddToAdministration);
            this.gbAddForm.Controls.Add(this.rbTeacher);
            this.gbAddForm.Controls.Add(this.rbStudent);
            this.gbAddForm.Controls.Add(this.lblType);
            this.gbAddForm.Controls.Add(this.lblSalary);
            this.gbAddForm.Controls.Add(this.lblECs);
            this.gbAddForm.Controls.Add(this.tbSalary);
            this.gbAddForm.Controls.Add(this.tbPCN);
            this.gbAddForm.Controls.Add(this.tbECs);
            this.gbAddForm.Controls.Add(this.tbName);
            this.gbAddForm.Controls.Add(this.tbAge);
            this.gbAddForm.Controls.Add(this.tbYearsAtSchool);
            this.gbAddForm.Controls.Add(this.lblYearAtSchool);
            this.gbAddForm.Controls.Add(this.lblAge);
            this.gbAddForm.Controls.Add(this.lblName);
            this.gbAddForm.Controls.Add(this.lblPCN);
            this.gbAddForm.Location = new System.Drawing.Point(12, 13);
            this.gbAddForm.Name = "gbAddForm";
            this.gbAddForm.Size = new System.Drawing.Size(264, 343);
            this.gbAddForm.TabIndex = 0;
            this.gbAddForm.TabStop = false;
            this.gbAddForm.Text = "Add form";
            // 
            // btnAddToAdministration
            // 
            this.btnAddToAdministration.Location = new System.Drawing.Point(11, 303);
            this.btnAddToAdministration.Name = "btnAddToAdministration";
            this.btnAddToAdministration.Size = new System.Drawing.Size(236, 29);
            this.btnAddToAdministration.TabIndex = 15;
            this.btnAddToAdministration.Text = "Add to administration";
            this.btnAddToAdministration.UseVisualStyleBackColor = true;
            this.btnAddToAdministration.Click += new System.EventHandler(this.btnAddToAdministration_Click);
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Location = new System.Drawing.Point(122, 68);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(81, 24);
            this.rbTeacher.TabIndex = 14;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(122, 37);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(81, 24);
            this.rbStudent.TabIndex = 13;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rbStudent_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(11, 268);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 20);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Salary:";
            // 
            // lblECs
            // 
            this.lblECs.AutoSize = true;
            this.lblECs.Location = new System.Drawing.Point(11, 231);
            this.lblECs.Name = "lblECs";
            this.lblECs.Size = new System.Drawing.Size(35, 20);
            this.lblECs.TabIndex = 10;
            this.lblECs.Text = "ECs:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(122, 261);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(125, 27);
            this.tbSalary.TabIndex = 9;
            // 
            // tbPCN
            // 
            this.tbPCN.Location = new System.Drawing.Point(122, 98);
            this.tbPCN.Name = "tbPCN";
            this.tbPCN.Size = new System.Drawing.Size(125, 27);
            this.tbPCN.TabIndex = 7;
            // 
            // tbECs
            // 
            this.tbECs.Location = new System.Drawing.Point(122, 228);
            this.tbECs.Name = "tbECs";
            this.tbECs.Size = new System.Drawing.Size(125, 27);
            this.tbECs.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(122, 131);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 6;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(122, 162);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(125, 27);
            this.tbAge.TabIndex = 5;
            // 
            // tbYearsAtSchool
            // 
            this.tbYearsAtSchool.Location = new System.Drawing.Point(122, 195);
            this.tbYearsAtSchool.Name = "tbYearsAtSchool";
            this.tbYearsAtSchool.Size = new System.Drawing.Size(125, 27);
            this.tbYearsAtSchool.TabIndex = 4;
            // 
            // lblYearAtSchool
            // 
            this.lblYearAtSchool.AutoSize = true;
            this.lblYearAtSchool.Location = new System.Drawing.Point(11, 195);
            this.lblYearAtSchool.Name = "lblYearAtSchool";
            this.lblYearAtSchool.Size = new System.Drawing.Size(104, 20);
            this.lblYearAtSchool.TabIndex = 3;
            this.lblYearAtSchool.Text = "Year at school:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(11, 163);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPCN
            // 
            this.lblPCN.AutoSize = true;
            this.lblPCN.Location = new System.Drawing.Point(11, 97);
            this.lblPCN.Name = "lblPCN";
            this.lblPCN.Size = new System.Drawing.Size(40, 20);
            this.lblPCN.TabIndex = 0;
            this.lblPCN.Text = "PCN:";
            // 
            // lbShowAll
            // 
            this.lbShowAll.FormattingEnabled = true;
            this.lbShowAll.HorizontalScrollbar = true;
            this.lbShowAll.ItemHeight = 20;
            this.lbShowAll.Location = new System.Drawing.Point(282, 24);
            this.lbShowAll.Name = "lbShowAll";
            this.lbShowAll.Size = new System.Drawing.Size(336, 264);
            this.lbShowAll.TabIndex = 16;
            // 
            // cbShowPeople
            // 
            this.cbShowPeople.FormattingEnabled = true;
            this.cbShowPeople.Items.AddRange(new object[] {
            "All",
            "Students",
            "Teachers"});
            this.cbShowPeople.Location = new System.Drawing.Point(283, 295);
            this.cbShowPeople.Name = "cbShowPeople";
            this.cbShowPeople.Size = new System.Drawing.Size(151, 28);
            this.cbShowPeople.TabIndex = 17;
            // 
            // tbPartialName
            // 
            this.tbPartialName.Location = new System.Drawing.Point(283, 330);
            this.tbPartialName.Name = "tbPartialName";
            this.tbPartialName.Size = new System.Drawing.Size(151, 27);
            this.tbPartialName.TabIndex = 18;
            // 
            // btnShowPersons
            // 
            this.btnShowPersons.Location = new System.Drawing.Point(441, 295);
            this.btnShowPersons.Name = "btnShowPersons";
            this.btnShowPersons.Size = new System.Drawing.Size(177, 29);
            this.btnShowPersons.TabIndex = 19;
            this.btnShowPersons.Text = "Show persons";
            this.btnShowPersons.UseVisualStyleBackColor = true;
            this.btnShowPersons.Click += new System.EventHandler(this.btnShowPersons_Click);
            // 
            // btnSearchPartialName
            // 
            this.btnSearchPartialName.Location = new System.Drawing.Point(441, 326);
            this.btnSearchPartialName.Name = "btnSearchPartialName";
            this.btnSearchPartialName.Size = new System.Drawing.Size(177, 29);
            this.btnSearchPartialName.TabIndex = 20;
            this.btnSearchPartialName.Text = "Search via partial name";
            this.btnSearchPartialName.UseVisualStyleBackColor = true;
            this.btnSearchPartialName.Click += new System.EventHandler(this.btnSearchPartialName_Click);
            // 
            // gbActionForm
            // 
            this.gbActionForm.Controls.Add(this.btnPromote);
            this.gbActionForm.Controls.Add(this.btnAddECs);
            this.gbActionForm.Controls.Add(this.tbAddECs);
            this.gbActionForm.Controls.Add(this.btnStartNewSchoolyear);
            this.gbActionForm.Controls.Add(this.btnCelebrateBirthday);
            this.gbActionForm.Controls.Add(this.btnShowInfo);
            this.gbActionForm.Controls.Add(this.tbPCNActionForm);
            this.gbActionForm.Controls.Add(this.lblPCNActionForm);
            this.gbActionForm.Location = new System.Drawing.Point(625, 24);
            this.gbActionForm.Name = "gbActionForm";
            this.gbActionForm.Size = new System.Drawing.Size(250, 251);
            this.gbActionForm.TabIndex = 21;
            this.gbActionForm.TabStop = false;
            this.gbActionForm.Text = "Action form";
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(22, 212);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(212, 29);
            this.btnPromote.TabIndex = 7;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnAddECs
            // 
            this.btnAddECs.Location = new System.Drawing.Point(154, 178);
            this.btnAddECs.Name = "btnAddECs";
            this.btnAddECs.Size = new System.Drawing.Size(80, 29);
            this.btnAddECs.TabIndex = 6;
            this.btnAddECs.Text = "Add ECs";
            this.btnAddECs.UseVisualStyleBackColor = true;
            this.btnAddECs.Click += new System.EventHandler(this.btnAddECs_Click);
            // 
            // tbAddECs
            // 
            this.tbAddECs.Location = new System.Drawing.Point(22, 178);
            this.tbAddECs.Name = "tbAddECs";
            this.tbAddECs.Size = new System.Drawing.Size(125, 27);
            this.tbAddECs.TabIndex = 5;
            // 
            // btnStartNewSchoolyear
            // 
            this.btnStartNewSchoolyear.Location = new System.Drawing.Point(22, 142);
            this.btnStartNewSchoolyear.Name = "btnStartNewSchoolyear";
            this.btnStartNewSchoolyear.Size = new System.Drawing.Size(212, 29);
            this.btnStartNewSchoolyear.TabIndex = 4;
            this.btnStartNewSchoolyear.Text = "Start new schoolyear";
            this.btnStartNewSchoolyear.UseVisualStyleBackColor = true;
            this.btnStartNewSchoolyear.Click += new System.EventHandler(this.btnStartNewSchoolyear_Click);
            // 
            // btnCelebrateBirthday
            // 
            this.btnCelebrateBirthday.Location = new System.Drawing.Point(22, 106);
            this.btnCelebrateBirthday.Name = "btnCelebrateBirthday";
            this.btnCelebrateBirthday.Size = new System.Drawing.Size(212, 29);
            this.btnCelebrateBirthday.TabIndex = 3;
            this.btnCelebrateBirthday.Text = "Celebrate birthday";
            this.btnCelebrateBirthday.UseVisualStyleBackColor = true;
            this.btnCelebrateBirthday.Click += new System.EventHandler(this.btnCelebrateBirthday_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(22, 70);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(212, 29);
            this.btnShowInfo.TabIndex = 2;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // tbPCNActionForm
            // 
            this.tbPCNActionForm.Location = new System.Drawing.Point(109, 26);
            this.tbPCNActionForm.Name = "tbPCNActionForm";
            this.tbPCNActionForm.Size = new System.Drawing.Size(125, 27);
            this.tbPCNActionForm.TabIndex = 1;
            // 
            // lblPCNActionForm
            // 
            this.lblPCNActionForm.AutoSize = true;
            this.lblPCNActionForm.Location = new System.Drawing.Point(22, 30);
            this.lblPCNActionForm.Name = "lblPCNActionForm";
            this.lblPCNActionForm.Size = new System.Drawing.Size(40, 20);
            this.lblPCNActionForm.TabIndex = 0;
            this.lblPCNActionForm.Text = "PCN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 368);
            this.Controls.Add(this.gbActionForm);
            this.Controls.Add(this.btnSearchPartialName);
            this.Controls.Add(this.btnShowPersons);
            this.Controls.Add(this.tbPartialName);
            this.Controls.Add(this.cbShowPeople);
            this.Controls.Add(this.lbShowAll);
            this.Controls.Add(this.gbAddForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddForm.ResumeLayout(false);
            this.gbAddForm.PerformLayout();
            this.gbActionForm.ResumeLayout(false);
            this.gbActionForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddForm;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblECs;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbECs;
        private System.Windows.Forms.TextBox tbPCN;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbYearsAtSchool;
        private System.Windows.Forms.Label lblYearAtSchool;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPCN;
        private System.Windows.Forms.ListBox lbShowAll;
        private System.Windows.Forms.Button btnAddToAdministration;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbShowPeople;
        private System.Windows.Forms.TextBox tbPartialName;
        private System.Windows.Forms.Button btnShowPersons;
        private System.Windows.Forms.Button btnSearchPartialName;
        private System.Windows.Forms.GroupBox gbActionForm;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnAddECs;
        private System.Windows.Forms.TextBox tbAddECs;
        private System.Windows.Forms.Button btnStartNewSchoolyear;
        private System.Windows.Forms.Button btnCelebrateBirthday;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.TextBox tbPCNActionForm;
        private System.Windows.Forms.Label lblPCNActionForm;
    }
}

