using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();

            cmbState.SelectedIndex = 1;

            #region Data Bind Region
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartment();
            dgDept.DataSource = dtDeptTable;

            // DeptID columns is invisible
            // column index, column name  0, EmpID
            // to find columns name
            // var x = dtEmpTable.Columns;
            dgDept.Columns["DeptID"].Visible = false;
            dgDept.Columns["AddressLine1"].Visible = false;
            dgDept.Columns["AddressLine2"].Visible = false;
            dgDept.Columns["City"].Visible = false;
            dgDept.Columns["State"].Visible = false;
            dgDept.Columns["Zip"].Visible = false;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgDept.Columns.Add(deleteColumn);


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgDept.Columns.Add(editColumn);

            dgDept.CellClick += DgEmployee_CellClick;

            #endregion
        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentDeptId = -1;

            DataGridView dg = (DataGridView)sender;
            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            currentDeptId = int.Parse(rowToBeOperatedUpon.Cells["DeptID"].Value.ToString());

            // if user selects entire row
            if (e.ColumnIndex == -1)
            {
                //MessageBox.Show("You Selected the Entire Row. Current Emp ID is: " + currentDeptId);
                // handle logic here
                // show the current employee information in the control top\
                gbDataEntry.Visible = true;
                btnUpdate.Visible = true;
                btnSubmit.Visible = false;
                txtDept.Text = rowToBeOperatedUpon.Cells["DeptName"].Value.ToString();
                txtLocation.Text = rowToBeOperatedUpon.Cells["Location"].Value.ToString();
                txtCP.Text = rowToBeOperatedUpon.Cells["ContactPerson"].Value.ToString();
                txtAddress1.Text = rowToBeOperatedUpon.Cells["AddressLine1"].Value.ToString();
                txtAddress2.Text = rowToBeOperatedUpon.Cells["AddressLine2"].Value.ToString();
                txtCity.Text = rowToBeOperatedUpon.Cells["City"].Value.ToString();
                txtZip.Text = rowToBeOperatedUpon.Cells["Zip"].Value.ToString();
                txtPhoneNumber.Text = rowToBeOperatedUpon.Cells["PhoneNumber"].Value.ToString();
                cmbState.SelectedItem = rowToBeOperatedUpon.Cells["State"].Value.ToString();
                return;
            }

            // is user selects a single cell
            if (dg.SelectedCells.Count == 1)
            {

                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                    //System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    // Let user enter value

                }
                // if the user selects one of the buttons
                else if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        //MessageBox.Show("Delete is clicked. Current Emp ID is: " + currentDeptId);
                        // use currentdeptId to delet the current employee
                        // have the employee deleted for the database.
                        // use dataAccessLayer to affect the change if the database.
                        // Rebind the grid or refresh the grid.
                        Utility.DeleteDepartment(currentDeptId);
                        RefreshGridData();
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        //MessageBox.Show("Edit is clicked. Current Emp ID is: " + currentDeptId);
                        // use current emp id to edit the employee in database.
                        // use DataAccessLayer to affect the change in the database.
                        string deptName = rowToBeOperatedUpon.Cells["DeptName"].Value.ToString();
                        Utility.EditDepartment(currentDeptId, deptName);
                        RefreshGridData();
                    }
                }
                return;
            }
        }

        private void RefreshGridData()
        {
            // get the current data from the database
            // and assign it to the grid.

            // One option: indeed a new employee
            // or 
            // updating existing employee

            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartment();
            dgDept.DataSource = dtDeptTable;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            foreach (DataGridViewRow row in dgDept.Rows)
            {
                if (row.Cells["DeptName"].Value != null)
                {
                    if (row.Cells["DeptName"].Value.ToString() == search)
                    {
                        dgDept.ClearSelection();
                        dgDept.Rows[row.Index].Selected = true;
                        return;
                    }
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int deptID = -1;

            // find id
            string search = txtDept.Text;
            foreach (DataGridViewRow row in dgDept.Rows)
            {
                if (row.Cells["DeptName"].Value != null)
                {
                    if (row.Cells["DeptName"].Value.ToString() == search)
                    {
                        deptID = int.Parse(row.Cells["DeptID"].Value.ToString());
                    }
                }
            }

            Utility.EditDepartment(deptID, txtDept.Text, txtLocation.Text, txtCP.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text,
                cmbState.SelectedItem.ToString(), txtZip.Text, txtPhoneNumber.Text);
            RefreshGridData();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Utility.SaveDepartment(txtDept.Text, txtLocation.Text, txtCP.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text,
                cmbState.SelectedItem.ToString(), txtZip.Text, txtPhoneNumber.Text);
            RefreshGridData();
        }

        private void btnAddDept_Click_1(object sender, EventArgs e)
        {
            gbDataEntry.Visible = true;

            txtDept.Clear();
            txtLocation.Clear();
            txtCP.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtZip.Clear();
            txtPhoneNumber.Clear();
            cmbState.SelectedIndex = 1;

            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
        }
    }
}
