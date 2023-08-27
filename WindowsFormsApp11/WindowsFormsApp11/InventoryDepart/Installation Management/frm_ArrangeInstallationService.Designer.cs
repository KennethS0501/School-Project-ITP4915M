
namespace WindowsFormsApp11.InventoryDepart.Installation_Management
{
    partial class frm_ArrangeInstallationService
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
            System.Windows.Forms.Label timeSessionLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_StateShow = new System.Windows.Forms.Label();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.deliveryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.cbo_InstallationID = new System.Windows.Forms.ComboBox();
            this.installationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Arrange = new System.Windows.Forms.Button();
            this.btn_backTo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_InstallationMan = new System.Windows.Forms.ComboBox();
            this.timeSessionLabel1 = new System.Windows.Forms.Label();
            this.InstallationDataGridView = new System.Windows.Forms.DataGridView();
            this.installationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.installationTableAdapter();
            timeSessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSessionLabel
            // 
            timeSessionLabel.AutoSize = true;
            timeSessionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            timeSessionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            timeSessionLabel.Location = new System.Drawing.Point(34, 153);
            timeSessionLabel.Name = "timeSessionLabel";
            timeSessionLabel.Size = new System.Drawing.Size(137, 22);
            timeSessionLabel.TabIndex = 24;
            timeSessionLabel.Text = "Time Session:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Installation ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(106, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "State:";
            // 
            // lbl_StateShow
            // 
            this.lbl_StateShow.AutoSize = true;
            this.lbl_StateShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lbl_StateShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_StateShow.Location = new System.Drawing.Point(175, 195);
            this.lbl_StateShow.Name = "lbl_StateShow";
            this.lbl_StateShow.Size = new System.Drawing.Size(46, 17);
            this.lbl_StateShow.TabIndex = 14;
            this.lbl_StateShow.Text = "State";
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.sdpDataSet;
            this.deliveryBindingSource.CurrentChanged += new System.EventHandler(this.deliveryBindingSource_CurrentChanged);
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accessTableAdapter = null;
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.deliveryTableAdapter = this.deliveryTableAdapter;
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
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehousestockTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "date", true));
            this.dateLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dateLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel1.Location = new System.Drawing.Point(175, 125);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateLabel1.TabIndex = 17;
            this.dateLabel1.Text = "Date";
            // 
            // cbo_InstallationID
            // 
            this.cbo_InstallationID.DataSource = this.installationBindingSource;
            this.cbo_InstallationID.DisplayMember = "installationID";
            this.cbo_InstallationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_InstallationID.FormattingEnabled = true;
            this.cbo_InstallationID.Location = new System.Drawing.Point(177, 88);
            this.cbo_InstallationID.Name = "cbo_InstallationID";
            this.cbo_InstallationID.Size = new System.Drawing.Size(116, 20);
            this.cbo_InstallationID.TabIndex = 20;
            this.cbo_InstallationID.ValueMember = "installationID";
            this.cbo_InstallationID.SelectedIndexChanged += new System.EventHandler(this.cbo_DeliveryID_SelectedIndexChanged);
            // 
            // installationBindingSource
            // 
            this.installationBindingSource.DataMember = "installation";
            this.installationBindingSource.DataSource = this.sdpDataSet;
            // 
            // btn_Arrange
            // 
            this.btn_Arrange.Location = new System.Drawing.Point(410, 189);
            this.btn_Arrange.Name = "btn_Arrange";
            this.btn_Arrange.Size = new System.Drawing.Size(75, 42);
            this.btn_Arrange.TabIndex = 21;
            this.btn_Arrange.Text = "Arrange";
            this.btn_Arrange.UseVisualStyleBackColor = true;
            this.btn_Arrange.Click += new System.EventHandler(this.btn_Arrange_Click);
            // 
            // btn_backTo
            // 
            this.btn_backTo.Location = new System.Drawing.Point(500, 189);
            this.btn_backTo.Name = "btn_backTo";
            this.btn_backTo.Size = new System.Drawing.Size(75, 51);
            this.btn_backTo.TabIndex = 22;
            this.btn_backTo.Text = "Back to \r\nto be installed";
            this.btn_backTo.UseVisualStyleBackColor = true;
            this.btn_backTo.Click += new System.EventHandler(this.btn_backTo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(429, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 44);
            this.label6.TabIndex = 23;
            this.label6.Text = "Installation Man\r\nID :";
            // 
            // cbo_InstallationMan
            // 
            this.cbo_InstallationMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_InstallationMan.FormattingEnabled = true;
            this.cbo_InstallationMan.Location = new System.Drawing.Point(433, 137);
            this.cbo_InstallationMan.Name = "cbo_InstallationMan";
            this.cbo_InstallationMan.Size = new System.Drawing.Size(121, 20);
            this.cbo_InstallationMan.TabIndex = 24;
            // 
            // timeSessionLabel1
            // 
            this.timeSessionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "timeSession", true));
            this.timeSessionLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.timeSessionLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeSessionLabel1.Location = new System.Drawing.Point(176, 157);
            this.timeSessionLabel1.Name = "timeSessionLabel1";
            this.timeSessionLabel1.Size = new System.Drawing.Size(100, 23);
            this.timeSessionLabel1.TabIndex = 25;
            this.timeSessionLabel1.Text = "Time";
            // 
            // InstallationDataGridView
            // 
            this.InstallationDataGridView.AllowUserToAddRows = false;
            this.InstallationDataGridView.AllowUserToDeleteRows = false;
            this.InstallationDataGridView.AutoGenerateColumns = false;
            this.InstallationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstallationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.installationIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeSessionDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.InstallationDataGridView.DataSource = this.installationBindingSource;
            this.InstallationDataGridView.Location = new System.Drawing.Point(51, 283);
            this.InstallationDataGridView.Name = "InstallationDataGridView";
            this.InstallationDataGridView.ReadOnly = true;
            this.InstallationDataGridView.RowTemplate.Height = 24;
            this.InstallationDataGridView.Size = new System.Drawing.Size(543, 259);
            this.InstallationDataGridView.TabIndex = 26;
            // 
            // installationIDDataGridViewTextBoxColumn
            // 
            this.installationIDDataGridViewTextBoxColumn.DataPropertyName = "installationID";
            this.installationIDDataGridViewTextBoxColumn.HeaderText = "Installation ID";
            this.installationIDDataGridViewTextBoxColumn.Name = "installationIDDataGridViewTextBoxColumn";
            this.installationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeSessionDataGridViewTextBoxColumn
            // 
            this.timeSessionDataGridViewTextBoxColumn.DataPropertyName = "timeSession";
            this.timeSessionDataGridViewTextBoxColumn.HeaderText = "Time Session";
            this.timeSessionDataGridViewTextBoxColumn.Name = "timeSessionDataGridViewTextBoxColumn";
            this.timeSessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installationTableAdapter
            // 
            this.installationTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ArrangeInstallationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(634, 614);
            this.Controls.Add(this.InstallationDataGridView);
            this.Controls.Add(timeSessionLabel);
            this.Controls.Add(this.timeSessionLabel1);
            this.Controls.Add(this.cbo_InstallationMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_backTo);
            this.Controls.Add(this.btn_Arrange);
            this.Controls.Add(this.cbo_InstallationID);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.lbl_StateShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ArrangeInstallationService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ArrangeService";
            this.Load += new System.EventHandler(this.frm_ArrangeInstallationService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_StateShow;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private sdpDataSetTableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.ComboBox cbo_InstallationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_Arrange;
        private System.Windows.Forms.Button btn_backTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_InstallationMan;
        private System.Windows.Forms.Label timeSessionLabel1;
        private System.Windows.Forms.DataGridView InstallationDataGridView;
        private System.Windows.Forms.BindingSource installationBindingSource;
        private sdpDataSetTableAdapters.installationTableAdapter installationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}