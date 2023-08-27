
namespace WindowsFormsApp11
{
    partial class frmAddAccount
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.lblSelectID = new System.Windows.Forms.Label();
            this.sdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSetPwd = new System.Windows.Forms.Label();
            this.btuAdd = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.cobSelectID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSelectID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectID.Location = new System.Drawing.Point(80, 87);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(108, 16);
            this.lblSelectID.TabIndex = 1;
            this.lblSelectID.Text = "Select Staff ID:";
            // 
            // sdpDataSetBindingSource
            // 
            this.sdpDataSetBindingSource.DataSource = this.sdpDataSet;
            this.sdpDataSetBindingSource.Position = 0;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullName.Location = new System.Drawing.Point(79, 137);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 16);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Staff full name:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accessTableAdapter = null;
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.deliveryTableAdapter = null;
            this.tableAdapterManager.departmentmanagerTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.installationTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.productlistTableAdapter = null;
            this.tableAdapterManager.receiptTableAdapter = null;
            this.tableAdapterManager.restockretailproductTableAdapter = null;
            this.tableAdapterManager.restockwarehousestockTableAdapter = null;
            this.tableAdapterManager.retailstorestockTableAdapter = null;
            this.tableAdapterManager.retailstoreTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehousestockTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(302, 133);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(96, 23);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(212, 187);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // lblSetPwd
            // 
            this.lblSetPwd.AutoSize = true;
            this.lblSetPwd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSetPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetPwd.Location = new System.Drawing.Point(86, 191);
            this.lblSetPwd.Name = "lblSetPwd";
            this.lblSetPwd.Size = new System.Drawing.Size(105, 16);
            this.lblSetPwd.TabIndex = 9;
            this.lblSetPwd.Text = "Set Password:";
            // 
            // btuAdd
            // 
            this.btuAdd.BackColor = System.Drawing.Color.Lavender;
            this.btuAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btuAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btuAdd.Location = new System.Drawing.Point(191, 277);
            this.btuAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuAdd.Name = "btuAdd";
            this.btuAdd.Size = new System.Drawing.Size(87, 31);
            this.btuAdd.TabIndex = 10;
            this.btuAdd.Text = "Add";
            this.btuAdd.UseVisualStyleBackColor = false;
            this.btuAdd.Click += new System.EventHandler(this.btuAdd_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "firstName", true));
            this.firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.firstNameTextBox.Location = new System.Drawing.Point(212, 133);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(91, 23);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // cobSelectID
            // 
            this.cobSelectID.DataSource = this.staffBindingSource;
            this.cobSelectID.DisplayMember = "staffID";
            this.cobSelectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSelectID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobSelectID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cobSelectID.FormattingEnabled = true;
            this.cobSelectID.Location = new System.Drawing.Point(211, 85);
            this.cobSelectID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobSelectID.Name = "cobSelectID";
            this.cobSelectID.Size = new System.Drawing.Size(187, 24);
            this.cobSelectID.TabIndex = 0;
            this.cobSelectID.ValueMember = "staffID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btuAdd);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.cobSelectID);
            this.panel1.Controls.Add(this.lblSetPwd);
            this.panel1.Controls.Add(this.lblSelectID);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 366);
            this.panel1.TabIndex = 11;
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(470, 367);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account - BetterLimited";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelectID;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource sdpDataSetBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Label lblFullName;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSetPwd;
        private System.Windows.Forms.Button btuAdd;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox cobSelectID;
        private System.Windows.Forms.Panel panel1;
    }
}