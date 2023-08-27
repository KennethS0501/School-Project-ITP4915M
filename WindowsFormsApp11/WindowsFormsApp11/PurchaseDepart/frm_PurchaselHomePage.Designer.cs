
namespace WindowsFormsApp11
{
    partial class frm_PurchaseHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_StaffManagment = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_DataAccessControl = new System.Windows.Forms.Button();
            this.btn_AccountManagement = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_BetterLimited = new System.Windows.Forms.Label();
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_ChildForm = new System.Windows.Forms.Panel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Move.SuspendLayout();
            this.pnl_ChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pnl_Nav);
            this.panel1.Controls.Add(this.btn_StaffManagment);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_DataAccessControl);
            this.panel1.Controls.Add(this.btn_AccountManagement);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 681);
            this.panel1.TabIndex = 0;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.pnl_Nav.Location = new System.Drawing.Point(0, 214);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(3, 55);
            this.pnl_Nav.TabIndex = 5;
            // 
            // btn_StaffManagment
            // 
            this.btn_StaffManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_StaffManagment.FlatAppearance.BorderSize = 0;
            this.btn_StaffManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StaffManagment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StaffManagment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btn_StaffManagment.Location = new System.Drawing.Point(0, 260);
            this.btn_StaffManagment.Name = "btn_StaffManagment";
            this.btn_StaffManagment.Size = new System.Drawing.Size(206, 55);
            this.btn_StaffManagment.TabIndex = 6;
            this.btn_StaffManagment.Text = "Staff Managment";
            this.btn_StaffManagment.UseVisualStyleBackColor = true;
            this.btn_StaffManagment.Click += new System.EventHandler(this.btu_StaffManagment_Click);
            this.btn_StaffManagment.Leave += new System.EventHandler(this.btn_StaffManagment_Leave);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btn_Logout.Location = new System.Drawing.Point(0, 623);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(206, 58);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            this.btn_Logout.Leave += new System.EventHandler(this.btn_Logout_Leave);
            // 
            // btn_DataAccessControl
            // 
            this.btn_DataAccessControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DataAccessControl.FlatAppearance.BorderSize = 0;
            this.btn_DataAccessControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DataAccessControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DataAccessControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btn_DataAccessControl.Location = new System.Drawing.Point(0, 205);
            this.btn_DataAccessControl.Name = "btn_DataAccessControl";
            this.btn_DataAccessControl.Size = new System.Drawing.Size(206, 55);
            this.btn_DataAccessControl.TabIndex = 3;
            this.btn_DataAccessControl.Text = "Data Access Control";
            this.btn_DataAccessControl.UseVisualStyleBackColor = true;
            this.btn_DataAccessControl.Click += new System.EventHandler(this.btn_DataAccessControl_Click);
            this.btn_DataAccessControl.Leave += new System.EventHandler(this.btn_DataAccessControl_Leave);
            // 
            // btn_AccountManagement
            // 
            this.btn_AccountManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AccountManagement.FlatAppearance.BorderSize = 0;
            this.btn_AccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccountManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AccountManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btn_AccountManagement.Location = new System.Drawing.Point(0, 150);
            this.btn_AccountManagement.Name = "btn_AccountManagement";
            this.btn_AccountManagement.Size = new System.Drawing.Size(206, 55);
            this.btn_AccountManagement.TabIndex = 2;
            this.btn_AccountManagement.Text = "Account Management";
            this.btn_AccountManagement.UseVisualStyleBackColor = true;
            this.btn_AccountManagement.Click += new System.EventHandler(this.btu_AccountManagement_Click);
            this.btn_AccountManagement.Leave += new System.EventHandler(this.btu_AccountManagement_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Controls.Add(this.lbl_Department);
            this.panel2.Controls.Add(this.lbl_BetterLimited);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 150);
            this.panel2.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(157)))), ((int)(((byte)(172)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 111);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Title.Size = new System.Drawing.Size(206, 39);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.lbl_Name.Location = new System.Drawing.Point(0, 74);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Name.Size = new System.Drawing.Size(206, 37);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // lbl_Department
            // 
            this.lbl_Department.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Department.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lbl_Department.Location = new System.Drawing.Point(0, 37);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Department.Size = new System.Drawing.Size(206, 37);
            this.lbl_Department.TabIndex = 1;
            this.lbl_Department.Text = "Department";
            this.lbl_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BetterLimited
            // 
            this.lbl_BetterLimited.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_BetterLimited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_BetterLimited.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_BetterLimited.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lbl_BetterLimited.Location = new System.Drawing.Point(0, 0);
            this.lbl_BetterLimited.Name = "lbl_BetterLimited";
            this.lbl_BetterLimited.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_BetterLimited.Size = new System.Drawing.Size(206, 37);
            this.lbl_BetterLimited.TabIndex = 0;
            this.lbl_BetterLimited.Text = "Better Limited";
            this.lbl_BetterLimited.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnl_Move.Controls.Add(this.btn_Exit);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(206, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(1058, 25);
            this.pnl_Move.TabIndex = 3;
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            this.pnl_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseMove);
            this.pnl_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Exit.Location = new System.Drawing.Point(1033, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "x";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_ChildForm
            // 
            this.pnl_ChildForm.Controls.Add(this.lbl_Welcome);
            this.pnl_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ChildForm.Location = new System.Drawing.Point(206, 25);
            this.pnl_ChildForm.Name = "pnl_ChildForm";
            this.pnl_ChildForm.Size = new System.Drawing.Size(1058, 656);
            this.pnl_ChildForm.TabIndex = 4;
            this.pnl_ChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ChildForm_Paint);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Rage Italic", 100F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(299, 235);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(475, 168);
            this.lbl_Welcome.TabIndex = 2;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // frm_PurchaseHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_ChildForm);
            this.Controls.Add(this.pnl_Move);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_PurchaseHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_IThomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Move.ResumeLayout(false);
            this.pnl_ChildForm.ResumeLayout(false);
            this.pnl_ChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_DataAccessControl;
        private System.Windows.Forms.Button btn_AccountManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_BetterLimited;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Panel pnl_ChildForm;
        private System.Windows.Forms.Button btn_StaffManagment;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}