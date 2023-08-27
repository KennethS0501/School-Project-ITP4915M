
namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    partial class frm_ConfirmRestockOrderSales
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
            dateLabel.Location = new System.Drawing.Point(231, 51);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(56, 12);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 281);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbo_Date
            // 
            this.cbo_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Date.FormattingEnabled = true;
            this.cbo_Date.Location = new System.Drawing.Point(293, 48);
            this.cbo_Date.Name = "cbo_Date";
            this.cbo_Date.Size = new System.Drawing.Size(163, 20);
            this.cbo_Date.TabIndex = 4;
            this.cbo_Date.SelectedIndexChanged += new System.EventHandler(this.cbo_Date_SelectedIndexChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(489, 47);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_ConfirmRestockOrderSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.cbo_Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(dateLabel);
            this.Name = "frm_ConfirmRestockOrderSales";
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