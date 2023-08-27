
namespace WindowsFormsApp11.ITdepart.Staff
{
    partial class frmRemoveStaff
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
            System.Windows.Forms.Label lblStaffID;
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblLastName;
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            lblStaffID = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new System.Drawing.Point(62, 63);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new System.Drawing.Size(58, 16);
            lblStaffID.TabIndex = 1;
            lblStaffID.Text = "Staff ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(62, 103);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(80, 16);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(62, 140);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(79, 16);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
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
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "firstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(148, 100);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(137, 23);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "lastName", true));
            this.txtLastName.Location = new System.Drawing.Point(148, 137);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(137, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // cboStaffID
            // 
            this.cboStaffID.DataSource = this.staffBindingSource;
            this.cboStaffID.DisplayMember = "staffID";
            this.cboStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(148, 58);
            this.cboStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(137, 24);
            this.cboStaffID.TabIndex = 17;
            this.cboStaffID.ValueMember = "staffID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRemoveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(355, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(lblStaffID);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRemoveStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Staff - Better Limited";
            this.Load += new System.EventHandler(this.frmRemoveStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.Button button1;
    }
}