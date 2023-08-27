
namespace WindowsFormsApp11.InventoryDepart.Installation_Management
{
    partial class frm_TrackInstallation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.deliveryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.installationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.installationTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.installationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // deliveryDataGridView
            // 
            this.deliveryDataGridView.AllowUserToAddRows = false;
            this.deliveryDataGridView.AllowUserToDeleteRows = false;
            this.deliveryDataGridView.AutoGenerateColumns = false;
            this.deliveryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.deliveryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.deliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.installationID,
            this.timeSession,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.status});
            this.deliveryDataGridView.DataSource = this.installationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.deliveryDataGridView.Location = new System.Drawing.Point(12, 32);
            this.deliveryDataGridView.Name = "deliveryDataGridView";
            this.deliveryDataGridView.ReadOnly = true;
            this.deliveryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.deliveryDataGridView.RowTemplate.Height = 24;
            this.deliveryDataGridView.ShowCellToolTips = false;
            this.deliveryDataGridView.ShowEditingIcon = false;
            this.deliveryDataGridView.ShowRowErrors = false;
            this.deliveryDataGridView.Size = new System.Drawing.Size(543, 488);
            this.deliveryDataGridView.TabIndex = 20;
            // 
            // installationID
            // 
            this.installationID.DataPropertyName = "installationID";
            this.installationID.HeaderText = "Installation ID";
            this.installationID.Name = "installationID";
            this.installationID.ReadOnly = true;
            // 
            // timeSession
            // 
            this.timeSession.DataPropertyName = "timeSession";
            this.timeSession.HeaderText = "Time Session";
            this.timeSession.Name = "timeSession";
            this.timeSession.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "staffID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Staff ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // installationBindingSource
            // 
            this.installationBindingSource.DataMember = "installation";
            this.installationBindingSource.DataSource = this.sdpDataSet;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(249, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // installationTableAdapter
            // 
            this.installationTableAdapter.ClearBeforeFill = true;
            // 
            // frm_TrackInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.deliveryDataGridView);
            this.Name = "frm_TrackInstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TrackDelivery";
            this.Load += new System.EventHandler(this.frm_ArrangeInstallationService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private sdpDataSetTableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView deliveryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.BindingSource installationBindingSource;
        private sdpDataSetTableAdapters.installationTableAdapter installationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}