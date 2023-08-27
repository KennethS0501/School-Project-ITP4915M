
namespace WindowsFormsApp11.ITdepart.DataAccess
{
    partial class frmChangeUserAccess
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
            System.Windows.Forms.Label staffIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label accessNameLabel;
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.accessTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.accessTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            staffIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            accessNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(104, 76);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(58, 16);
            staffIDLabel.TabIndex = 1;
            staffIDLabel.Text = "Staff ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(89, 126);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Full Name:";
            // 
            // accessNameLabel
            // 
            accessNameLabel.AutoSize = true;
            accessNameLabel.Location = new System.Drawing.Point(67, 176);
            accessNameLabel.Name = "accessNameLabel";
            accessNameLabel.Size = new System.Drawing.Size(97, 16);
            accessNameLabel.TabIndex = 8;
            accessNameLabel.Text = "Access Name:";
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
            this.tableAdapterManager.accessTableAdapter = this.accessTableAdapter;
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
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.staffBindingSource1;
            this.comboBox1.DisplayMember = "staffID";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "staffID";
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "staff";
            this.staffBindingSource1.DataSource = this.sdpDataSet;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(163, 123);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(53, 23);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(211, 123);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(66, 23);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // accessBindingSource
            // 
            this.accessBindingSource.DataMember = "access";
            this.accessBindingSource.DataSource = this.sdpDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.accessBindingSource;
            this.comboBox2.DisplayMember = "AccessName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(164, 171);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "AccessID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChangeUserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(339, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(accessNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(staffIDLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChangeUserAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change User Access Group";
            this.Load += new System.EventHandler(this.frmChangeUserAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private sdpDataSetTableAdapters.accessTableAdapter accessTableAdapter;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}