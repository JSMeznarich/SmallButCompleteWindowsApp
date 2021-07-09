namespace CS3280WinEmployee
{
    partial class Root
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeFormToolStripMenuItem,
            this.departmentFormToolStripMenuItem});
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            this.rootToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.rootToolStripMenuItem.Text = "Root";
            // 
            // employeeFormToolStripMenuItem
            // 
            this.employeeFormToolStripMenuItem.Name = "employeeFormToolStripMenuItem";
            this.employeeFormToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.employeeFormToolStripMenuItem.Text = "Employee Form";
            this.employeeFormToolStripMenuItem.Click += new System.EventHandler(this.employeeFormToolStripMenuItem_Click);
            // 
            // departmentFormToolStripMenuItem
            // 
            this.departmentFormToolStripMenuItem.Name = "departmentFormToolStripMenuItem";
            this.departmentFormToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.departmentFormToolStripMenuItem.Text = "Department Form";
            this.departmentFormToolStripMenuItem.Click += new System.EventHandler(this.departmentFormToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to my CS 3280 Small but Complete Windows Application";
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Root";
            this.Text = "Root";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentFormToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}