using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Utility
    {
        public static Organization.DepartmentsDataTable GetDepartment()
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapater = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapater.Fill(dtDeptTable);

            return dtDeptTable;
        }

        public static Organization.EmployeesDataTable GetEmployee()
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            return dtEmpTable;
        }

        public static void SaveEmployee(string fname, string lname, string ssn, decimal salary, decimal commisionRate, decimal sales, 
            string addressLine1, string addressLine2, string city, string state, string zip, DateTime birthday, DateTime join, string maritalStatus, 
            string dept, string empType, int deptID)
        {
            // EmployeeTable and the New Row technique to have new row inserted inot the database

            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow newEmpRow = dtEmpTable.NewEmployeesRow();
            newEmpRow.FName = fname;
            newEmpRow.Lname = lname;
            newEmpRow.SSN = ssn;
            newEmpRow.Salary = salary;
            newEmpRow.Commission = commisionRate;
            newEmpRow.Sales = sales;
            newEmpRow.AddressLine1 = addressLine1;
            newEmpRow.AddressLine2 = addressLine2;
            newEmpRow.City = city;
            newEmpRow.State = state;
            newEmpRow.Zip = zip;
            newEmpRow.Birthday = birthday;
            newEmpRow.JoiningDate = join;
            newEmpRow.MaritalStatus = maritalStatus;
            newEmpRow.Department = dept;
            newEmpRow.EmployeeType = empType;
            newEmpRow.DeptID = deptID;

            dtEmpTable.AddEmployeesRow(newEmpRow);

            empAdapter.Update(dtEmpTable);
        }

        public static void SaveDepartment(string deptName, string location, string contactPerson, string addressLine1, string addressLine2, 
            string city, string state, string zip, string phoneNumber)
        {
            // DepartmentTable and the New Row technique to have new row inserted inot the database

            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapater = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapater.Fill(dtDeptTable);

            Organization.DepartmentsRow newDeptRow = dtDeptTable.NewDepartmentsRow();
            newDeptRow.DeptName = deptName;
            newDeptRow.Location = location;
            newDeptRow.ContactPerson = contactPerson;
            newDeptRow.AddressLine1 = addressLine1;
            newDeptRow.AddressLine2 = addressLine2;
            newDeptRow.City = city;
            newDeptRow.State = state;
            newDeptRow.Zip = zip;
            newDeptRow.PhoneNumber = phoneNumber;


            dtDeptTable.AddDepartmentsRow(newDeptRow);

            deptAdapater.Update(dtDeptTable);
        }

        public static void DeleteDepartment(int deptID)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapater = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapater.Fill(dtDeptTable);

            Organization.DepartmentsRow deleteDeptRow = dtDeptTable.NewDepartmentsRow();

            foreach (Organization.DepartmentsRow row in dtDeptTable)
            {
                if(row.DeptID == deptID)
                {
                    deleteDeptRow = row;
                }
            }

            deptAdapater.Delete(deleteDeptRow.DeptID, deleteDeptRow.DeptName, deleteDeptRow.Location, deleteDeptRow.ContactPerson, deleteDeptRow.AddressLine1,
                deleteDeptRow.AddressLine2, deleteDeptRow.City, deleteDeptRow.State, deleteDeptRow.Zip, deleteDeptRow.PhoneNumber);

        }

        public static void DeleteEmployee(int empID)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow deleteEmpRow = dtEmpTable.NewEmployeesRow();

            foreach (Organization.EmployeesRow row in dtEmpTable)
            {
                if (row.EmpID == empID)
                {
                    deleteEmpRow = row;
                }
            }

            empAdapter.Delete(deleteEmpRow.EmpID, deleteEmpRow.FName, deleteEmpRow.Lname, deleteEmpRow.SSN, deleteEmpRow.Salary, deleteEmpRow.Sales, 
                deleteEmpRow.Commission, deleteEmpRow.AddressLine1, deleteEmpRow.AddressLine2, deleteEmpRow.City, deleteEmpRow.State, deleteEmpRow.Zip, 
                deleteEmpRow.Birthday, deleteEmpRow.JoiningDate, deleteEmpRow.MaritalStatus, deleteEmpRow.Department, deleteEmpRow.EmployeeType, deleteEmpRow.DeptID);

        }

        public static void EditEmployee(string fname, string lname, string ssn, string dept, int empID)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow editEmpRow = dtEmpTable.NewEmployeesRow();

            foreach(Organization.EmployeesRow row in dtEmpTable)
            {
                if(row.EmpID == empID)
                {
                    editEmpRow = row;
                }
            }

            editEmpRow.FName = fname;
            editEmpRow.Lname = lname;
            editEmpRow.SSN = ssn;
            editEmpRow.Department = dept;

            empAdapter.Update(dtEmpTable);
        }

        public static void EditEmployee(string fname, string lname, string ssn, decimal salary, decimal commisionRate, decimal sales,
            string addressLine1, string addressLine2, string city, string state, string zip, DateTime birthday, DateTime join, string maritalStatus,
            string dept, string empType, int deptID, int empID)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow editEmpRow = dtEmpTable.NewEmployeesRow();

            foreach (Organization.EmployeesRow row in dtEmpTable)
            {
                if (row.EmpID == empID)
                {
                    editEmpRow = row;
                }
            }

            editEmpRow.FName = fname;
            editEmpRow.Lname = lname;
            editEmpRow.SSN = ssn;
            editEmpRow.Salary = salary;
            editEmpRow.Commission = commisionRate;
            editEmpRow.Sales = sales;
            editEmpRow.AddressLine1 = addressLine1;
            editEmpRow.AddressLine2 = addressLine2;
            editEmpRow.City = city;
            editEmpRow.State = state;
            editEmpRow.Zip = zip;
            editEmpRow.Birthday = birthday;
            editEmpRow.JoiningDate = join;
            editEmpRow.MaritalStatus = maritalStatus;
            editEmpRow.Department = dept;
            editEmpRow.EmployeeType = empType;
            editEmpRow.DeptID = deptID;
            editEmpRow.Department = dept;

            empAdapter.Update(dtEmpTable);
        }

        public static void EditDepartment(int deptID, string deptName)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapater = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapater.Fill(dtDeptTable);

            Organization.DepartmentsRow editDeptRow = dtDeptTable.NewDepartmentsRow();

            foreach (Organization.DepartmentsRow row in dtDeptTable)
            {
                if (row.DeptID == deptID)
                {
                    editDeptRow = row;
                }
            }

            editDeptRow.DeptName = deptName;

            deptAdapater.Update(dtDeptTable);
        }

        public static void EditDepartment(int deptID, string deptName, string location, string contactPerson, string addressLine1, string addressLine2, string city, string state, string zip, string phoneNumber)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapater = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapater.Fill(dtDeptTable);

            Organization.DepartmentsRow editDeptRow = dtDeptTable.NewDepartmentsRow();

            foreach (Organization.DepartmentsRow row in dtDeptTable)
            {
                if (row.DeptID == deptID)
                {
                    editDeptRow = row;
                }
            }

            editDeptRow.DeptName = deptName;
            editDeptRow.Location = location;
            editDeptRow.ContactPerson = contactPerson;
            editDeptRow.AddressLine1 = addressLine1;
            editDeptRow.AddressLine2 = addressLine2;
            editDeptRow.City = city;
            editDeptRow.State = state;
            editDeptRow.Zip = zip;
            editDeptRow.PhoneNumber = phoneNumber;

            deptAdapater.Update(dtDeptTable);
        }
    }
}
