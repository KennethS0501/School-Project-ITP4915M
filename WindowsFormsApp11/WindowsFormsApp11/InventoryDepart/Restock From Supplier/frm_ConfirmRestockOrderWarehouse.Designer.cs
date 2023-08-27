
namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    partial class frm_ConfirmRestockOrderWarehouse
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
            System.Windows.Forms.Label dateLabel;
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.restockwarehousestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restockwarehousestockTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.restockwarehousestockTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbo_Date = new System.Windows.Forms.ComboBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockwarehousestockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            dateLabel.Location = new System.Drawing.Point(227, 65);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(109, 22);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date Time:";
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restockwarehousestockBindingSource
            // 
            this.restockwarehousestockBindingSource.DataMember = "restockwarehousestock";
            this.restockwarehousestockBindingSource.DataSource = this.sdpDataSet;
            // 
            // restockwarehousestockTableAdapter
            // 
            this.restockwarehousestockTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.restockwarehousestockTableAdapter = this.restockwarehousestockTableAdapter;
            this.tableAdapterManager.retailstorestockTableAdapter = null;
            this.tableAdapterManager.retailstoreTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehousestockTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbo_Date
            // 
            this.cbo_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Date.FormattingEnabled = true;
            this.cbo_Date.Location = new System.Drawing.Point(342, 64);
            this.cbo_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Date.Name = "cbo_Date";
            this.cbo_Date.Size = new System.Drawing.Size(189, 24);
            this.cbo_Date.TabIndex = 4;
            this.cbo_Date.SelectedIndexChanged += new System.EventHandler(this.cbo_Date_SelectedIndexChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(570, 63);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(87, 31);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_ConfirmRestockOrderWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.cbo_Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(dateLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ConfirmRestockOrderWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ConfirmRestockOrder";
            this.Load += new System.EventHandler(this.frm_ConfirmRestockOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockwarehousestockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource restockwarehousestockBindingSource;
        private sdpDataSetTableAdapters.restockwarehousestockTableAdapter restockwarehousestockTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_Date;
        private System.Windows.Forms.Button btn_Confirm;
    }
}
