namespace CS3280WinEmployee
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
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioCommission = new System.Windows.Forms.RadioButton();
            this.radioBaseCommission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.epFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epZip = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBirthday = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSSN = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSSN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 123);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(45, 126);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(45, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 161);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(45, 200);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 5;
            this.lblSSN.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(146, 197);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(158, 20);
            this.txtSSN.TabIndex = 4;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(45, 235);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 7;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(146, 232);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(158, 20);
            this.txtAddressLine1.TabIndex = 6;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(45, 270);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 9;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(146, 267);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(158, 20);
            this.txtAddressLine2.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(45, 306);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "UT",
            "CA",
            "NV",
            "OR",
            "WA",
            "CO",
            "NY"});
            this.cmbState.Location = new System.Drawing.Point(146, 303);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(158, 21);
            this.cmbState.TabIndex = 11;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(44, 423);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(140, 17);
            this.chkMarried.TabIndex = 13;
            this.chkMarried.Text = "Is Married (For Taxation)";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckedChanged += new System.EventHandler(this.chkMarried_CheckedChanged);
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(6, 19);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(63, 17);
            this.radioSalaried.TabIndex = 14;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioCommission
            // 
            this.radioCommission.AutoSize = true;
            this.radioCommission.Location = new System.Drawing.Point(75, 19);
            this.radioCommission.Name = "radioCommission";
            this.radioCommission.Size = new System.Drawing.Size(80, 17);
            this.radioCommission.TabIndex = 15;
            this.radioCommission.TabStop = true;
            this.radioCommission.Text = "Commission";
            this.radioCommission.UseVisualStyleBackColor = true;
            this.radioCommission.CheckedChanged += new System.EventHandler(this.radioCommission_CheckedChanged);
            // 
            // radioBaseCommission
            // 
            this.radioBaseCommission.AutoSize = true;
            this.radioBaseCommission.Location = new System.Drawing.Point(161, 19);
            this.radioBaseCommission.Name = "radioBaseCommission";
            this.radioBaseCommission.Size = new System.Drawing.Size(102, 17);
            this.radioBaseCommission.TabIndex = 16;
            this.radioBaseCommission.TabStop = true;
            this.radioBaseCommission.Text = "Base+Comission";
            this.radioBaseCommission.UseVisualStyleBackColor = true;
            this.radioBaseCommission.CheckedChanged += new System.EventHandler(this.radioBaseCommission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalaried);
            this.groupBox1.Controls.Add(this.radioCommission);
            this.groupBox1.Controls.Add(this.radioBaseCommission);
            this.groupBox1.Location = new System.Drawing.Point(42, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 50);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Type";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(42, 534);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(45, 518);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(113, 15);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(167, 518);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(88, 13);
            this.lblCommission.TabIndex = 23;
            this.lblCommission.Text = "Commission Rate";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(164, 534);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(100, 20);
            this.txtCommission.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(289, 518);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(33, 13);
            this.lblSales.TabIndex = 25;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(310, 534);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(292, 592);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit Update ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(42, 594);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(222, 21);
            this.cmbDept.TabIndex = 28;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(41, 578);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "Department";
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(19, 621);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(660, 121);
            this.dgEmployee.TabIndex = 30;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(147, 339);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 20);
            this.txtCity.TabIndex = 31;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(45, 342);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 32;
            this.lblCity.Text = "City";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(45, 380);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 34;
            this.lblZip.Text = "Zip";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(147, 377);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(158, 20);
            this.txtZip.TabIndex = 33;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(446, 339);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 35;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // dtpJoin
            // 
            this.dtpJoin.Location = new System.Drawing.Point(446, 377);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(200, 20);
            this.dtpJoin.TabIndex = 36;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(374, 342);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 37;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Location = new System.Drawing.Point(353, 384);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(66, 13);
            this.lblJoin.TabIndex = 38;
            this.lblJoin.Text = "Joining Date";
            // 
            // epFName
            // 
            this.epFName.ContainerControl = this;
            // 
            // epLName
            // 
            this.epLName.ContainerControl = this;
            // 
            // epZip
            // 
            this.epZip.ContainerControl = this;
            // 
            // epBirthday
            // 
            this.epBirthday.ContainerControl = this;
            // 
            // epSSN
            // 
            this.epSSN.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(239, 760);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(344, 760);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "EmployeeID: ";
            this.label1.Visible = false;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(474, 130);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(13, 13);
            this.lblEmpID.TabIndex = 42;
            this.lblEmpID.Text = "0";
            this.lblEmpID.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 20);
            this.txtSearch.TabIndex = 47;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 803);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblJoin);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dtpJoin);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "EmployeeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSSN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioCommission;
        private System.Windows.Forms.RadioButton radioBaseCommission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.ErrorProvider epFName;
        private System.Windows.Forms.ErrorProvider epLName;
        private System.Windows.Forms.ErrorProvider epZip;
        private System.Windows.Forms.ErrorProvider epBirthday;
        private System.Windows.Forms.ErrorProvider epSSN;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

