namespace CS3280WinEmployee
{
    partial class DepartmentForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.dgDept = new System.Windows.Forms.DataGridView();
            this.gbDataEntry = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDept)).BeginInit();
            this.gbDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(9, 279);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 44;
            this.lblZip.Text = "Zip";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(111, 276);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(158, 20);
            this.txtZip.TabIndex = 43;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(9, 241);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(111, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 20);
            this.txtCity.TabIndex = 41;
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
            this.cmbState.Location = new System.Drawing.Point(110, 202);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(158, 21);
            this.cmbState.TabIndex = 40;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(9, 205);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 39;
            this.lblState.Text = "State";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(9, 169);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 38;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(110, 166);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(158, 20);
            this.txtAddress2.TabIndex = 37;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(9, 134);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 36;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(110, 131);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(158, 20);
            this.txtAddress1.TabIndex = 35;
            // 
            // dgDept
            // 
            this.dgDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDept.Location = new System.Drawing.Point(52, 83);
            this.dgDept.Name = "dgDept";
            this.dgDept.Size = new System.Drawing.Size(674, 150);
            this.dgDept.TabIndex = 45;
            // 
            // gbDataEntry
            // 
            this.gbDataEntry.Controls.Add(this.btnUpdate);
            this.gbDataEntry.Controls.Add(this.btnSubmit);
            this.gbDataEntry.Controls.Add(this.lblPhoneNumber);
            this.gbDataEntry.Controls.Add(this.txtPhoneNumber);
            this.gbDataEntry.Controls.Add(this.txtDept);
            this.gbDataEntry.Controls.Add(this.txtDeptName);
            this.gbDataEntry.Controls.Add(this.txtLocation);
            this.gbDataEntry.Controls.Add(this.lblLocation);
            this.gbDataEntry.Controls.Add(this.txtCP);
            this.gbDataEntry.Controls.Add(this.lblCP);
            this.gbDataEntry.Controls.Add(this.txtAddress1);
            this.gbDataEntry.Controls.Add(this.lblAddressLine1);
            this.gbDataEntry.Controls.Add(this.lblZip);
            this.gbDataEntry.Controls.Add(this.txtAddress2);
            this.gbDataEntry.Controls.Add(this.txtZip);
            this.gbDataEntry.Controls.Add(this.lblAddressLine2);
            this.gbDataEntry.Controls.Add(this.lblCity);
            this.gbDataEntry.Controls.Add(this.lblState);
            this.gbDataEntry.Controls.Add(this.txtCity);
            this.gbDataEntry.Controls.Add(this.cmbState);
            this.gbDataEntry.Location = new System.Drawing.Point(256, 312);
            this.gbDataEntry.Name = "gbDataEntry";
            this.gbDataEntry.Size = new System.Drawing.Size(274, 404);
            this.gbDataEntry.TabIndex = 46;
            this.gbDataEntry.TabStop = false;
            this.gbDataEntry.Text = "Data Entry";
            this.gbDataEntry.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(229, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 20);
            this.txtSearch.TabIndex = 45;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(110, 57);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(158, 20);
            this.txtLocation.TabIndex = 45;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 46;
            this.lblLocation.Text = "Location";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(110, 92);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(158, 20);
            this.txtCP.TabIndex = 47;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(9, 95);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(80, 13);
            this.lblCP.TabIndex = 48;
            this.lblCP.Text = "Contact Person";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(111, 19);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(158, 20);
            this.txtDept.TabIndex = 49;
            // 
            // txtDeptName
            // 
            this.txtDeptName.AutoSize = true;
            this.txtDeptName.Location = new System.Drawing.Point(10, 22);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(61, 13);
            this.txtDeptName.TabIndex = 50;
            this.txtDeptName.Text = "Dept Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 315);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 52;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(110, 312);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 20);
            this.txtPhoneNumber.TabIndex = 51;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(110, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 23);
            this.btnSubmit.TabIndex = 47;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 23);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(292, 252);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(158, 23);
            this.btnAddDept.TabIndex = 47;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click_1);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbDataEntry);
            this.Controls.Add(this.dgDept);
            this.Controls.Add(this.btnSearch);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDept)).EndInit();
            this.gbDataEntry.ResumeLayout(false);
            this.gbDataEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.DataGridView dgDept;
        private System.Windows.Forms.GroupBox gbDataEntry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label txtDeptName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Button btnAddDept;
    }
}