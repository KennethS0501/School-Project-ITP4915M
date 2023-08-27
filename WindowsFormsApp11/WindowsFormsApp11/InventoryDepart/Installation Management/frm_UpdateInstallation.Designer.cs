
namespace WindowsFormsApp11.InventoryDepart.Installation_Management
{
    partial class frm_UpdateInstallation
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
            this.cbo_installationID = new System.Windows.Forms.ComboBox();
            this.installationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_backTo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeSessionLabel1 = new System.Windows.Forms.Label();
            this.installationTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.installationTableAdapter();
            this.installationDataGridView = new System.Windows.Forms.DataGridView();
            this.installationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timeSessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSessionLabel
            // 
            timeSessionLabel.AutoSize = true;
            timeSessionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            timeSessionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            timeSessionLabel.Location = new System.Drawing.Point(37, 156);
            timeSessionLabel.Name = "timeSessionLabel";
            timeSessionLabel.Size = new System.Drawing.Size(137, 22);
            timeSessionLabel.TabIndex = 23;
            timeSessionLabel.Text = "Time Session:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 86);
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
            this.lbl_StateShow.Click += new System.EventHandler(this.lbl_StateShow_Click);
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
            // cbo_installationID
            // 
            this.cbo_installationID.DataSource = this.installationBindingSource;
            this.cbo_installationID.DisplayMember = "installationID";
            this.cbo_installationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_installationID.FormattingEnabled = true;
            this.cbo_installationID.Location = new System.Drawing.Point(177, 88);
            this.cbo_installationID.Name = "cbo_installationID";
            this.cbo_installationID.Size = new System.Drawing.Size(116, 20);
            this.cbo_installationID.TabIndex = 20;
            this.cbo_installationID.ValueMember = "installationID";
            this.cbo_installationID.SelectedIndexChanged += new System.EventHandler(this.cbo_DeliveryID_SelectedIndexChanged);
            // 
            // installationBindingSource
            // 
            this.installationBindingSource.DataMember = "installation";
            this.installationBindingSource.DataSource = this.sdpDataSet;
            // 
            // btn_backTo
            // 
            this.btn_backTo.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_backTo.Location = new System.Drawing.Point(464, 102);
            this.btn_backTo.Name = "btn_backTo";
            this.btn_backTo.Size = new System.Drawing.Size(90, 42);
            this.btn_backTo.TabIndex = 22;
            this.btn_backTo.Text = "Back to \r\nto be installed\r\n";
            this.btn_backTo.UseVisualStyleBackColor = true;
            this.btn_backTo.Click += new System.EventHandler(this.btn_backTo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.Location = new System.Drawing.Point(464, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Installation Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Shipped_Click);
            // 
            // timeSessionLabel1
            // 
            this.timeSessionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "timeSession", true));
            this.timeSessionLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.timeSessionLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeSessionLabel1.Location = new System.Drawing.Point(175, 159);
            this.timeSessionLabel1.Name = "timeSessionLabel1";
            this.timeSessionLabel1.Size = new System.Drawing.Size(100, 23);
            this.timeSessionLabel1.TabIndex = 24;
            this.timeSessionLabel1.Text = "Time";
            // 
            // installationTableAdapter
            // 
            this.installationTableAdapter.ClearBeforeFill = true;
            // 
            // installationDataGridView
            // 
            this.installationDataGridView.AllowUserToAddRows = false;
            this.installationDataGridView.AllowUserToDeleteRows = false;
            this.installationDataGridView.AutoGenerateColumns = false;
            this.installationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.installationIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeSessionDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.installationDataGridView.DataSource = this.installationBindingSource;
            this.installationDataGridView.Location = new System.Drawing.Point(61, 266);
            this.installationDataGridView.Name = "installationDataGridView";
            this.installationDataGridView.ReadOnly = true;
            this.installationDataGridView.RowTemplate.Height = 24;
            this.installationDataGridView.Size = new System.Drawing.Size(543, 229);
            this.installationDataGridView.TabIndex = 25;
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
            // frm_UpdateInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(662, 563);
            this.Controls.Add(this.installationDataGridView);
            this.Controls.Add(timeSessionLabel);
            this.Controls.Add(this.timeSessionLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_backTo);
            this.Controls.Add(this.cbo_installationID);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.lbl_StateShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_UpdateInstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UpdateService";
            this.Load += new System.EventHandler(this.frm_ArrangeInstallationService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox cbo_installationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_backTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timeSessionLabel1;
        private System.Windows.Forms.BindingSource installationBindingSource;
        private sdpDataSetTableAdapters.installationTableAdapter installationTableAdapter;
        private System.Windows.Forms.DataGridView installationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}