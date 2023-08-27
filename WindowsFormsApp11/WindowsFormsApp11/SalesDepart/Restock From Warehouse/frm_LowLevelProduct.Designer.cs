
namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    partial class frm_LowLevelProduct
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
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.warehousestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousestockTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.warehousestockTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.lstDetailofLowLevelStock = new System.Windows.Forms.ListBox();
            this.btnBackToInvertorypage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cobWarehouse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousestockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousestockBindingSource
            // 
            this.warehousestockBindingSource.DataMember = "warehousestock";
            this.warehousestockBindingSource.DataSource = this.sdpDataSet;
            // 
            // warehousestockTableAdapter
            // 
            this.warehousestockTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehousestockTableAdapter = this.warehousestockTableAdapter;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // lstDetailofLowLevelStock
            // 
            this.lstDetailofLowLevelStock.FormattingEnabled = true;
            this.lstDetailofLowLevelStock.ItemHeight = 12;
            this.lstDetailofLowLevelStock.Location = new System.Drawing.Point(10, 60);
            this.lstDetailofLowLevelStock.Name = "lstDetailofLowLevelStock";
            this.lstDetailofLowLevelStock.Size = new System.Drawing.Size(138, 292);
            this.lstDetailofLowLevelStock.TabIndex = 0;
            this.lstDetailofLowLevelStock.SelectedIndexChanged += new System.EventHandler(this.lstDetailofLowLevelStock_SelectedIndexChanged);
            // 
            // btnBackToInvertorypage
            // 
            this.btnBackToInvertorypage.Location = new System.Drawing.Point(49, 383);
            this.btnBackToInvertorypage.Name = "btnBackToInvertorypage";
            this.btnBackToInvertorypage.Size = new System.Drawing.Size(165, 21);
            this.btnBackToInvertorypage.TabIndex = 1;
            this.btnBackToInvertorypage.Text = "Back";
            this.btnBackToInvertorypage.UseVisualStyleBackColor = true;
            this.btnBackToInvertorypage.Click += new System.EventHandler(this.btnBackToInvertorypage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low-level Stock ID";
            // 
            // cobWarehouse
            // 
            this.cobWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobWarehouse.FormattingEnabled = true;
            this.cobWarehouse.Location = new System.Drawing.Point(166, 60);
            this.cobWarehouse.Name = "cobWarehouse";
            this.cobWarehouse.Size = new System.Drawing.Size(104, 20);
            this.cobWarehouse.TabIndex = 3;
            this.cobWarehouse.SelectedIndexChanged += new System.EventHandler(this.cobWarehouse_SelectedIndexChanged);
            // 
            // frm_LowLevelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 415);
            this.Controls.Add(this.cobWarehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToInvertorypage);
            this.Controls.Add(this.lstDetailofLowLevelStock);
            this.Name = "frm_LowLevelProduct";
            this.Text = "DetailOfLevel";
            this.Load += new System.EventHandler(this.DetailOfLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousestockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource warehousestockBindingSource;
        private sdpDataSetTableAdapters.warehousestockTableAdapter warehousestockTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox lstDetailofLowLevelStock;
        private System.Windows.Forms.Button btnBackToInvertorypage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobWarehouse;
    }
}