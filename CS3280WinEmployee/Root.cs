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
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
            //Form1 empForm = new Form1();
            //empForm.MdiParent = this;
            //DepartmentForm deptForm = new DepartmentForm();
            //deptForm.MdiParent = this;
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 empForm = new Form1();
            empForm.MdiParent = this;
            empForm.Show();
        }

        private void departmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm deptForm = new DepartmentForm();
            deptForm.MdiParent = this;
            deptForm.Show();
        }
    }
}
