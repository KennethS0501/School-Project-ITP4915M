
namespace WindowsFormsApp11.ITdepart.Account
{
    partial class frmRemoveAccount
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
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblStaffID;
            this.btuRemove = new System.Windows.Forms.Button();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.staffIDComboBox = new System.Windows.Forms.ComboBox();
            lblName = new System.Windows.Forms.Label();
            lblStaffID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new System.Drawing.Point(66, 124);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 16);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // btuRemove
            // 
            this.btuRemove.Location = new System.Drawing.Point(103, 189);
            this.btuRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuRemove.Name = "btuRemove";
            this.btuRemove.Size = new System.Drawing.Size(87, 31);
            this.btuRemove.TabIndex = 2;
            this.btuRemove.Text = "Remove";
            this.btuRemove.UseVisualStyleBackColor = true;
            this.btuRemove.Click += new System.EventHandler(this.btuRemove_Click);
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(117, 116);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(46, 23);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(160, 116);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(73, 23);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // staffIDComboBox
            // 
            this.staffIDComboBox.DataSource = this.staffBindingSource;
            this.staffIDComboBox.DisplayMember = "staffID";
            this.staffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffIDComboBox.FormattingEnabled = true;
            this.staffIDComboBox.Location = new System.Drawing.Point(117, 68);
            this.staffIDComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffIDComboBox.Name = "staffIDComboBox";
            this.staffIDComboBox.Size = new System.Drawing.Size(116, 24);
            this.staffIDComboBox.TabIndex = 10;
            this.staffIDComboBox.ValueMember = "staffID";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStaffID.Location = new System.Drawing.Point(57, 72);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new System.Drawing.Size(58, 16);
            lblStaffID.TabIndex = 5;
            lblStaffID.Text = "Staff ID:";
            // 
            // frmRemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(299, 305);
            this.Controls.Add(this.staffIDComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lblName);
            this.Controls.Add(lblStaffID);
            this.Controls.Add(this.btuRemove);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRemoveAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Account - Better Limited";
            this.Load += new System.EventHandler(this.frmRemoveAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btuRemove;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox staffIDComboBox;
    }
}