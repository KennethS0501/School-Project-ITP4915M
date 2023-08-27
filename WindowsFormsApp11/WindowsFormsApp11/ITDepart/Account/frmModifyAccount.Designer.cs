
namespace WindowsFormsApp11.ITdepart.Account
{
    partial class frmModifyAccount
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSelectID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btuModify = new System.Windows.Forms.Button();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblFullName.Location = new System.Drawing.Point(32, 112);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 16);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Staff full name:";
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSelectID.Location = new System.Drawing.Point(33, 67);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(108, 16);
            this.lblSelectID.TabIndex = 9;
            this.lblSelectID.Text = "Select Staff ID:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(145, 157);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 23);
            this.txtPassword.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(62, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password:";
            // 
            // btuModify
            // 
            this.btuModify.Location = new System.Drawing.Point(122, 237);
            this.btuModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuModify.Name = "btuModify";
            this.btuModify.Size = new System.Drawing.Size(87, 31);
            this.btuModify.TabIndex = 15;
            this.btuModify.Text = "Modify";
            this.btuModify.UseVisualStyleBackColor = true;
            this.btuModify.Click += new System.EventHandler(this.btuModify_Click);
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.sdpDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
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
            // cboStaffID
            // 
            this.cboStaffID.DataSource = this.staffBindingSource;
            this.cboStaffID.DisplayMember = "staffID";
            this.cboStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(145, 67);
            this.cboStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(140, 24);
            this.cboStaffID.TabIndex = 16;
            this.cboStaffID.ValueMember = "staffID";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(144, 108);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(65, 23);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(205, 108);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(81, 23);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // frmModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(326, 314);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(this.btuModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblSelectID);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModifyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Account - Better Limited";
            this.Load += new System.EventHandler(this.frmModifyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblSelectID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btuModify;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}