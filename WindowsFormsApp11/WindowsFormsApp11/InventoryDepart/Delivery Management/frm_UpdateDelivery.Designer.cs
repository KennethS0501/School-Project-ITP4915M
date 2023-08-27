
namespace WindowsFormsApp11.InventoryDepart.Delivery_Management
{
    partial class frm_UpdateDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_StateShow = new System.Windows.Forms.Label();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.deliveryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.cbo_DeliveryID = new System.Windows.Forms.ComboBox();
            this.deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_backTo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeSessionLabel1 = new System.Windows.Forms.Label();
            timeSessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(55, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delivery ID:";
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
            // cbo_DeliveryID
            // 
            this.cbo_DeliveryID.DataSource = this.deliveryBindingSource;
            this.cbo_DeliveryID.DisplayMember = "deliveryID";
            this.cbo_DeliveryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DeliveryID.FormattingEnabled = true;
            this.cbo_DeliveryID.Location = new System.Drawing.Point(177, 88);
            this.cbo_DeliveryID.Name = "cbo_DeliveryID";
            this.cbo_DeliveryID.Size = new System.Drawing.Size(116, 20);
            this.cbo_DeliveryID.TabIndex = 20;
            this.cbo_DeliveryID.ValueMember = "deliveryID";
            this.cbo_DeliveryID.SelectedIndexChanged += new System.EventHandler(this.cbo_DeliveryID_SelectedIndexChanged);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.timeSession,
            this.dataGridViewTextBoxColumn5,
            this.status});
            this.deliveryDataGridView.DataSource = this.deliveryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.deliveryDataGridView.Location = new System.Drawing.Point(62, 274);
            this.deliveryDataGridView.Name = "deliveryDataGridView";
            this.deliveryDataGridView.ReadOnly = true;
            this.deliveryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.deliveryDataGridView.RowTemplate.Height = 24;
            this.deliveryDataGridView.ShowCellToolTips = false;
            this.deliveryDataGridView.ShowEditingIcon = false;
            this.deliveryDataGridView.ShowRowErrors = false;
            this.deliveryDataGridView.Size = new System.Drawing.Size(542, 247);
            this.deliveryDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "deliveryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Delivery ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // timeSession
            // 
            this.timeSession.DataPropertyName = "timeSession";
            this.timeSession.HeaderText = "TimeSession";
            this.timeSession.Name = "timeSession";
            this.timeSession.ReadOnly = true;
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
            // btn_backTo
            // 
            this.btn_backTo.Location = new System.Drawing.Point(464, 102);
            this.btn_backTo.Name = "btn_backTo";
            this.btn_backTo.Size = new System.Drawing.Size(75, 42);
            this.btn_backTo.TabIndex = 22;
            this.btn_backTo.Text = "Back to Invoiced";
            this.btn_backTo.UseVisualStyleBackColor = true;
            this.btn_backTo.Click += new System.EventHandler(this.btn_backTo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delivery Shipped";
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
            // frm_UpdateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(662, 555);
            this.Controls.Add(timeSessionLabel);
            this.Controls.Add(this.timeSessionLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_backTo);
            this.Controls.Add(this.deliveryDataGridView);
            this.Controls.Add(this.cbo_DeliveryID);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.lbl_StateShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_UpdateDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UpdateService";
            this.Load += new System.EventHandler(this.frm_ArrangeService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox cbo_DeliveryID;
        private System.Windows.Forms.DataGridView deliveryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_backTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label timeSessionLabel1;
    }
}