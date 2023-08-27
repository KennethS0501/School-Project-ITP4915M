
namespace WindowsFormsApp11
{
    partial class frmAddStaff
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblHire = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btuAdd = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.dateHire = new System.Windows.Forms.DateTimePicker();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.departmentTableAdapter();
            this.titlesTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.titlesTableAdapter();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDepart = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cobTitle = new System.Windows.Forms.ComboBox();
            this.titlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(59, 59);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(89, 16);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Your staff ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 96);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(69, 138);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(79, 16);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Last Name:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(73, 177);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(75, 16);
            this.lblBirth.TabIndex = 3;
            this.lblBirth.Text = "Birth Date:";
            // 
            // lblHire
            // 
            this.lblHire.AutoSize = true;
            this.lblHire.Location = new System.Drawing.Point(77, 225);
            this.lblHire.Name = "lblHire";
            this.lblHire.Size = new System.Drawing.Size(71, 16);
            this.lblHire.TabIndex = 4;
            this.lblHire.Text = "Hire Date:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 93);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 23);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(155, 135);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // btuAdd
            // 
            this.btuAdd.Location = new System.Drawing.Point(126, 424);
            this.btuAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuAdd.Name = "btuAdd";
            this.btuAdd.Size = new System.Drawing.Size(87, 31);
            this.btuAdd.TabIndex = 10;
            this.btuAdd.Text = "Add";
            this.btuAdd.UseVisualStyleBackColor = true;
            this.btuAdd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(91, 262);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 16);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender:";
            // 
            // cobGender
            // 
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cobGender.Location = new System.Drawing.Point(155, 262);
            this.cobGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(142, 24);
            this.cobGender.TabIndex = 12;
            this.cobGender.Text = "Male";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(156, 177);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(142, 23);
            this.dateBirth.TabIndex = 13;
            // 
            // dateHire
            // 
            this.dateHire.Location = new System.Drawing.Point(156, 220);
            this.dateHire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateHire.Name = "dateHire";
            this.dateHire.Size = new System.Drawing.Size(142, 23);
            this.dateHire.TabIndex = 14;
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
            // txtStaffID
            // 
            this.txtStaffID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "staffID", true));
            this.txtStaffID.Location = new System.Drawing.Point(156, 56);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(142, 23);
            this.txtStaffID.TabIndex = 16;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.sdpDataSet;
            // 
            // cobDepart
            // 
            this.cobDepart.DataSource = this.departmentBindingSource1;
            this.cobDepart.DisplayMember = "departName";
            this.cobDepart.FormattingEnabled = true;
            this.cobDepart.Location = new System.Drawing.Point(155, 304);
            this.cobDepart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobDepart.Name = "cobDepart";
            this.cobDepart.Size = new System.Drawing.Size(140, 24);
            this.cobDepart.TabIndex = 17;
            this.cobDepart.ValueMember = "departID";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.sdpDataSet;
            // 
            // cobTitle
            // 
            this.cobTitle.DataSource = this.titlesBindingSource1;
            this.cobTitle.DisplayMember = "title";
            this.cobTitle.FormattingEnabled = true;
            this.cobTitle.Location = new System.Drawing.Point(155, 351);
            this.cobTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobTitle.Name = "cobTitle";
            this.cobTitle.Size = new System.Drawing.Size(140, 24);
            this.cobTitle.TabIndex = 18;
            this.cobTitle.ValueMember = "titleID";
            // 
            // titlesBindingSource1
            // 
            this.titlesBindingSource1.DataMember = "titles";
            this.titlesBindingSource1.DataSource = this.sdpDataSet;
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "titles";
            this.titlesBindingSource.DataSource = this.sdpDataSet;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(65, 307);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(86, 16);
            this.lblDepart.TabIndex = 19;
            this.lblDepart.Text = "Department:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(110, 354);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title:";
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(374, 503);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.cobTitle);
            this.Controls.Add(this.cobDepart);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.dateHire);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.cobGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btuAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblHire);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStaffID);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff - Better Limited";
            this.Load += new System.EventHandler(this.frmAddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblHire;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btuAdd;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cobGender;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.DateTimePicker dateHire;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sdpDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtStaffID;
        private sdpDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private sdpDataSetTableAdapters.titlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.ComboBox cobDepart;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.ComboBox cobTitle;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private System.Windows.Forms.BindingSource titlesBindingSource1;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblTitle;
    }
}

