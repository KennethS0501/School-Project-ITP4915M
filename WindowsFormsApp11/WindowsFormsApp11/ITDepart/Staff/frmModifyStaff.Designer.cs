
namespace WindowsFormsApp11.ITdepart.Staff
{
    partial class frmModifyStaff
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label departIDLabel;
            System.Windows.Forms.Label titleIDLabel;
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.departmentTableAdapter();
            this.titlesTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.titlesTableAdapter();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btuModify = new System.Windows.Forms.Button();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.cboDepart = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboGender = new System.Windows.Forms.ComboBox();
            staffIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            departIDLabel = new System.Windows.Forms.Label();
            titleIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(49, 51);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(58, 16);
            staffIDLabel.TabIndex = 1;
            staffIDLabel.Text = "Staff ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(37, 88);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 16);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(37, 125);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(79, 16);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(57, 177);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 16);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender:";
            // 
            // departIDLabel
            // 
            departIDLabel.AutoSize = true;
            departIDLabel.Location = new System.Drawing.Point(28, 221);
            departIDLabel.Name = "departIDLabel";
            departIDLabel.Size = new System.Drawing.Size(90, 16);
            departIDLabel.TabIndex = 13;
            departIDLabel.Text = "Department :";
            // 
            // titleIDLabel
            // 
            titleIDLabel.AutoSize = true;
            titleIDLabel.Location = new System.Drawing.Point(66, 267);
            titleIDLabel.Name = "titleIDLabel";
            titleIDLabel.Size = new System.Drawing.Size(42, 16);
            titleIDLabel.TabIndex = 15;
            titleIDLabel.Text = "Title :";
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
            this.tableAdapterManager.departmentTableAdapter = this.departmentTableAdapter;
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
            this.tableAdapterManager.titlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehousestockTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "firstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(124, 86);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 23);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "lastName", true));
            this.txtLastName.Location = new System.Drawing.Point(124, 123);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // btuModify
            // 
            this.btuModify.Location = new System.Drawing.Point(140, 319);
            this.btuModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuModify.Name = "btuModify";
            this.btuModify.Size = new System.Drawing.Size(87, 31);
            this.btuModify.TabIndex = 17;
            this.btuModify.Text = "Modify";
            this.btuModify.UseVisualStyleBackColor = true;
            this.btuModify.Click += new System.EventHandler(this.btuModify_Click);
            // 
            // cboStaffID
            // 
            this.cboStaffID.DataSource = this.staffBindingSource;
            this.cboStaffID.DisplayMember = "staffID";
            this.cboStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(124, 49);
            this.cboStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(177, 24);
            this.cboStaffID.TabIndex = 18;
            this.cboStaffID.ValueMember = "staffID";
            // 
            // cboDepart
            // 
            this.cboDepart.DataSource = this.departmentBindingSource;
            this.cboDepart.DisplayMember = "departName";
            this.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepart.FormattingEnabled = true;
            this.cboDepart.Location = new System.Drawing.Point(124, 218);
            this.cboDepart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(177, 24);
            this.cboDepart.TabIndex = 20;
            this.cboDepart.ValueMember = "departID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.sdpDataSet;
            // 
            // cboTitle
            // 
            this.cboTitle.DataSource = this.titlesBindingSource;
            this.cboTitle.DisplayMember = "title";
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(124, 263);
            this.cboTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(177, 24);
            this.cboTitle.TabIndex = 21;
            this.cboTitle.ValueMember = "titleID";
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "titles";
            this.titlesBindingSource.DataSource = this.sdpDataSet;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(124, 175);
            this.cboGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(177, 24);
            this.cboGender.TabIndex = 19;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // frmModifyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(358, 392);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.cboDepart);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(this.btuModify);
            this.Controls.Add(staffIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(genderLabel);
            this.Controls.Add(departIDLabel);
            this.Controls.Add(titleIDLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModifyStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Staff - Better Limited";
            this.Load += new System.EventHandler(this.frmModifyStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btuModify;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.ComboBox cboDepart;
        private System.Windows.Forms.ComboBox cboTitle;
        private sdpDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private sdpDataSetTableAdapters.titlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private System.Windows.Forms.ComboBox cboGender;
    }
}