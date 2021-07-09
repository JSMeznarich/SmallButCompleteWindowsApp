using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class Form1 : Form
    {
        Color originalGroupBoxColor = Color.White;
        Color originalSubmitBtnColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            btnSubmit.BackColor = Color.Blue;
            originalGroupBoxColor = groupBox1.BackColor;
            groupBox1.BackColor = Color.Green;
            cmbState.SelectedIndex = 0;
            radioSalaried.Checked = true;
            originalSubmitBtnColor = btnSubmit.BackColor;

            #region Event intialization region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLastName.MouseEnter += TxtLastName_MouseEnter;
            txtLastName.MouseLeave += TxtLastName_MouseLeave;

            txtSSN.Leave += TxtSSN_Leave;
            txtZip.Leave += TxtZip_Leave;
            #endregion

            #region Data Bind Region
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartment();

            cmbDept.DataSource = dtDeptTable;
            
            // Display member
            // value member
            cmbDept.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName;
            cmbDept.ValueMember = dtDeptTable.DeptIDColumn.ColumnName;
            //cmbDept.DisplayMember = dtDeptTable.Columns["DeptName"].ColumnName;
            //cmbDept.ValueMember = dtDeptTable.Columns["DeptID"].ColumnName;

            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployee();
            dgEmployee.DataSource = dtEmpTable;

            // empid columns is invisible
            // column index, column name  0, EmpID
            // to find columns name
            // var x = dtEmpTable.Columns;
            dgEmployee.Columns["EmpID"].Visible = false;
            dgEmployee.Columns["Salary"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["Commission"].Visible = false;
            dgEmployee.Columns["AddressLine1"].Visible = false;
            dgEmployee.Columns["AddressLine2"].Visible = false;
            dgEmployee.Columns["City"].Visible = false;
            dgEmployee.Columns["State"].Visible = false;
            dgEmployee.Columns["Zip"].Visible = false;
            dgEmployee.Columns["Birthday"].Visible = false;
            dgEmployee.Columns["JoiningDate"].Visible = false;
            dgEmployee.Columns["MaritalStatus"].Visible = false;
            dgEmployee.Columns["EmployeeType"].Visible = false;
            dgEmployee.Columns["DeptID"].Visible = false;
            //dgEmployee.Columns[dtEmpTable.EmpIDColumn.ColumnName].Visible = false;
            //dgEmployee.Columns[0].Visible = false;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(deleteColumn);


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(editColumn);

            //dgEmployee.SelectionChanged += DgEmployee_SelectionChanged;
            //dgEmployee.SelectionChanged += new EventHandler(DgEmployee_SelectionChanged);
            dgEmployee.CellClick += DgEmployee_CellClick;

            #endregion
        }

        private void TxtZip_Leave(object sender, EventArgs e)
        {
            bool isZipCorrect = Regex.IsMatch(txtZip.Text, @"^\d{5}$");

            if (!isZipCorrect)
            {
                epZip.SetError(txtZip, "Invalid Zip.  Example = 12345");
            }
            else
            {
                epZip.Clear();
            }
        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if delete is clicked
            // DataGridViewCellEventArgs contains row index and column index
            int currentEmpId = -1;
            DataGridView dg = (DataGridView)sender;
            System.Diagnostics.Debug.WriteLine(dg);
            System.Diagnostics.Debug.WriteLine(e);


            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            currentEmpId = int.Parse(rowToBeOperatedUpon.Cells["EmpID"].Value.ToString());

            if(e.ColumnIndex == -1)
            {

                // handle logic here
                // show the current employee information in the control top
                txtFirstName.Text = rowToBeOperatedUpon.Cells["FName"].Value.ToString();
                txtLastName.Text = rowToBeOperatedUpon.Cells["LName"].Value.ToString();
                txtSSN.Text = rowToBeOperatedUpon.Cells["SSN"].Value.ToString();
                txtAddressLine1.Text = rowToBeOperatedUpon.Cells["AddressLine1"].Value.ToString();
                txtAddressLine2.Text = rowToBeOperatedUpon.Cells["AddressLine2"].Value.ToString();
                txtCity.Text = rowToBeOperatedUpon.Cells["City"].Value.ToString();
                txtZip.Text = rowToBeOperatedUpon.Cells["Zip"].Value.ToString();

                dtpBirthday.Value = DateTime.Parse(rowToBeOperatedUpon.Cells["Birthday"].Value.ToString());
                dtpJoin.Value = DateTime.Parse(rowToBeOperatedUpon.Cells["JoiningDate"].Value.ToString());

                if(rowToBeOperatedUpon.Cells["MaritalStatus"].Value.ToString() == "Married")
                {
                    chkMarried.Checked = true;
                }
                else
                {
                    chkMarried.Checked = false;
                }

                if(rowToBeOperatedUpon.Cells["EmployeeType"].Value.ToString() == "Salaried")
                {
                    radioSalaried.Checked = true;
                    radioCommission.Checked = false;
                    radioBaseCommission.Checked = false;
                    txtSalary.Text = rowToBeOperatedUpon.Cells["Salary"].Value.ToString();
                }
                else if (rowToBeOperatedUpon.Cells["EmployeeType"].Value.ToString() == "Commission")
                {
                    radioSalaried.Checked = false;
                    radioCommission.Checked = true;
                    radioBaseCommission.Checked = false;
                    txtCommission.Text = rowToBeOperatedUpon.Cells["Commission"].Value.ToString();
                    txtSales.Text = rowToBeOperatedUpon.Cells["Sales"].Value.ToString();
                }
                else if (rowToBeOperatedUpon.Cells["EmployeeType"].Value.ToString() == "Base+Commission")
                {
                    radioSalaried.Checked = false;
                    radioCommission.Checked = false;
                    radioBaseCommission.Checked = true;
                    txtSalary.Text = rowToBeOperatedUpon.Cells["Salary"].Value.ToString();
                    txtCommission.Text = rowToBeOperatedUpon.Cells["Commission"].Value.ToString();
                    txtSales.Text = rowToBeOperatedUpon.Cells["Sales"].Value.ToString();
                }

                cmbState.SelectedItem = rowToBeOperatedUpon.Cells["State"].Value.ToString();
                cmbDept.SelectedIndex = int.Parse(rowToBeOperatedUpon.Cells["DeptID"].Value.ToString());

                lblEmpID.Text = currentEmpId.ToString();
                lblEmpID.Visible = true;
                label1.Visible = true;
                return;
            }

            if(dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                    //System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    // Let user enter value
                    
                }
                else if(dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        
                        // use currentempId to delet the current employee
                        // have the employee deleted for the database.
                        // use dataAccessLayer to affect the change if the database.
                        // Rebind the grid or refresh the grid.
                        Utility.DeleteEmployee(currentEmpId);
                        RefreshGridData();
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        
                        // use current emp id to edit the employee in database.
                        // use DataAccessLayer to affect the change in the database.
                        string fName = rowToBeOperatedUpon.Cells["FName"].Value.ToString();
                        string lName = rowToBeOperatedUpon.Cells["LName"].Value.ToString();
                        string ssn = rowToBeOperatedUpon.Cells["SSN"].Value.ToString();
                        string department = rowToBeOperatedUpon.Cells["Department"].Value.ToString();
                        Utility.EditEmployee(fName, lName, ssn, department, currentEmpId);
                        RefreshGridData();
                    }
                }
                return;
            }
        }

        //private void DgEmployee_SelectionChanged(object sender, EventArgs e)
        //{
            
        //}

        

        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            bool isSSNCorrect = Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if(!isSSNCorrect)
            {
                MessageBox.Show("Enter valid SSN.  An example: XXX-XX-XXXX");
                epSSN.SetError(txtSSN, "Invalid SSN.  Example = 111-11-1111");
                txtSSN.Clear();
                txtSSN.Focus();
            }
            else
            {
                epSSN.Clear();
            }
        }

        private void TxtLastName_MouseLeave(object sender, EventArgs e)
        {
            txtLastName.Size = new Size(txtLastName.Size.Width - 10, txtLastName.Size.Height);
        }

        private void TxtLastName_MouseEnter(object sender, EventArgs e)
        {
            txtLastName.Size = new Size(txtLastName.Size.Width + 10, txtLastName.Size.Height);
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = originalSubmitBtnColor;
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Azure;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbState.SelectedItem.ToString());
            //MessageBox.Show(cmbState.SelectedIndex.ToString());
        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(chkMarried.Checked.ToString());
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommission.Checked.ToString());
            //MessageBox.Show(radioBaseCommission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblCommission.Visible = false;
            txtCommission.Visible = false;
            lblSales.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommission.Checked.ToString());
            //MessageBox.Show(radioBaseCommission.Checked.ToString());
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblCommission.Visible = true;
            txtCommission.Visible = true;
            lblSales.Visible = true;
            txtSales.Visible = true;
        }

        private void radioBaseCommission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommission.Checked.ToString());
            //MessageBox.Show(radioBaseCommission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblCommission.Visible = true;
            txtCommission.Visible = true;
            lblSales.Visible = true;
            txtSales.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string maritalStatus = string.Empty;
            string empType = string.Empty;
            string employeeInformation = string.Empty;

            if (txtSalary.Visible == true)
            {
                empType = "Salaried";
            }
            if (txtCommission.Visible == true)
            {
                empType = "Commission";
            }
            if (txtSales.Visible == true)
            {
                empType = "Base+Commission";
            }

            if (chkMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Not Married";
            }

            decimal salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : decimal.Parse(txtSalary.Text);
            decimal commission = string.IsNullOrEmpty(txtCommission.Text) ? 0 : decimal.Parse(txtCommission.Text);
            decimal sales = string.IsNullOrEmpty(txtSales.Text) ? 0 : decimal.Parse(txtSales.Text);

            string dept = string.Empty;
            string deptID = cmbDept.SelectedValue.ToString();
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartment();

            foreach (Organization.DepartmentsRow row in dtDeptTable)
            {
                if (int.Parse(deptID) == row.DeptID)
                {
                    dept = row.DeptName;
                    break;
                }
            }

            if (ErrorCheck()) { return; }

            Utility.EditEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, salary, commission, sales, txtAddressLine1.Text, txtAddressLine2.Text,
                txtCity.Text, cmbState.SelectedItem.ToString(), txtZip.Text, dtpBirthday.Value, dtpJoin.Value, maritalStatus, dept,
                empType, int.Parse(deptID), int.Parse(lblEmpID.Text));
            RefreshGridData();
        }

        private void RefreshGridData()
        {
            // get the current data from the database
            // and assign it to the grid.

            // One option: indeed a new employee
            // or 
            // updating existing employee

            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployee();
            dgEmployee.DataSource = dtEmpTable;
        }

        private bool ErrorCheck()
        {
            bool passCheck = false;
            bool isZipCorrect = Regex.IsMatch(txtZip.Text, @"^\d{5}$");
            bool isSSNCorrect = Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                epFName.SetError(txtFirstName, "You need a first name.");
                passCheck = true;
            }
            else
            {
                epFName.Clear();
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epLName.SetError(txtLastName, "You need a last name.");
                passCheck = true;
            }
            else
            {
                epLName.Clear();
            }

            if (!isZipCorrect)
            {
                epZip.SetError(txtZip, "Invalid Zip.  Example = 12345");
                passCheck = true;
            }
            else
            {
                epZip.Clear();
            }

            if (!isSSNCorrect)
            {
                epSSN.SetError(txtSSN, "Invalid SSN.  Example = 111-11-1111");
                passCheck = true;
            }
            else
            {
                epSSN.Clear();
            }

            return passCheck;
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            if (dtpBirthday.Value > today)
            {
                epBirthday.SetError(dtpBirthday, "You can't have a birthday in the future.");
            }
            else
            {
                epBirthday.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSSN.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            cmbState.SelectedIndex = 0;
            txtCity.Clear();
            txtZip.Clear();
            chkMarried.Checked = false;
            txtSalary.Clear();
            txtCommission.Clear();
            txtSales.Clear();
            radioSalaried.Checked = true;
            dtpBirthday.Value = DateTime.Now;
            dtpJoin.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maritalStatus = string.Empty;
            string empType = string.Empty;
            string employeeInformation = string.Empty;
            employeeInformation += txtFirstName.Text + " " + txtLastName.Text + "\r\n";
            employeeInformation += txtAddressLine1.Text + " " + txtAddressLine2.Text + " " + cmbState.SelectedItem.ToString() + "\r\n";
            employeeInformation += txtSSN.Text + "\r\n";
            if (txtSalary.Visible == true)
            {
                employeeInformation += "Salary : " + txtSalary.Text + "\r\n";
                empType = "Salaried";
            }
            if (txtCommission.Visible == true)
            {
                employeeInformation += "Commission : " + txtCommission.Text + "\r\n";
                empType = "Commission";
            }
            if (txtSales.Visible == true)
            {
                employeeInformation += "Sales : " + txtSales.Text + "\r\n";
                empType = "Base+Commission";
            }

            if (chkMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Not Married";
            }

            groupBox1.BackColor = originalGroupBoxColor;

            decimal salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : decimal.Parse(txtSalary.Text);
            decimal commission = string.IsNullOrEmpty(txtCommission.Text) ? 0 : decimal.Parse(txtCommission.Text);
            decimal sales = string.IsNullOrEmpty(txtSales.Text) ? 0 : decimal.Parse(txtSales.Text);

            string dept = string.Empty;
            string deptID = cmbDept.SelectedValue.ToString();
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartment();

            foreach (Organization.DepartmentsRow row in dtDeptTable)
            {
                if (int.Parse(deptID) == row.DeptID)
                {
                    dept = row.DeptName;
                    break;
                }
            }

            if (ErrorCheck()) { return; }

            Utility.SaveEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, salary, commission, sales, txtAddressLine1.Text, txtAddressLine2.Text,
                txtCity.Text, cmbState.SelectedItem.ToString(), txtZip.Text, dtpBirthday.Value, dtpJoin.Value, maritalStatus, dept,
                empType, int.Parse(deptID));
            RefreshGridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            foreach (DataGridViewRow row in dgEmployee.Rows)
            {
                if (row.Cells["LName"].Value != null)
                {
                    if (row.Cells["LName"].Value.ToString() == search)
                    {
                        dgEmployee.ClearSelection();
                        dgEmployee.Rows[row.Index].Selected = true;
                        return;
                    }
                }
            }
        }
    }
}
