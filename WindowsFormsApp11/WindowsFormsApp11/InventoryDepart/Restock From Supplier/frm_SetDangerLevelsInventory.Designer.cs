
namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    partial class frm_SetDangerLevelsInventory
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.productlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productlistTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.productlistTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.cobWarehouseProduct = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetReStockPoint = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnSetRestockPoint = new System.Windows.Forms.Button();
            this.cob_warehouseID = new System.Windows.Forms.ComboBox();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_warehouseID = new System.Windows.Forms.Label();
            this.warehouseTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.warehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(150, 135);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name:";
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productlistBindingSource
            // 
            this.productlistBindingSource.DataMember = "productlist";
            this.productlistBindingSource.DataSource = this.sdpDataSet;
            // 
            // productlistTableAdapter
            // 
            this.productlistTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.productlistTableAdapter = this.productlistTableAdapter;
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
            // cobWarehouseProduct
            // 
            this.cobWarehouseProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.cobWarehouseProduct.DataSource = this.productlistBindingSource;
            this.cobWarehouseProduct.DisplayMember = "productID";
            this.cobWarehouseProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobWarehouseProduct.FormattingEnabled = true;
            this.cobWarehouseProduct.Location = new System.Drawing.Point(203, 85);
            this.cobWarehouseProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobWarehouseProduct.Name = "cobWarehouseProduct";
            this.cobWarehouseProduct.Size = new System.Drawing.Size(121, 24);
            this.cobWarehouseProduct.TabIndex = 2;
            this.cobWarehouseProduct.ValueMember = "productID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productlistBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(203, 132);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warehouse Product ID:";
            // 
            // txtSetReStockPoint
            // 
            this.txtSetReStockPoint.Location = new System.Drawing.Point(203, 178);
            this.txtSetReStockPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSetReStockPoint.Name = "txtSetReStockPoint";
            this.txtSetReStockPoint.Size = new System.Drawing.Size(121, 23);
            this.txtSetReStockPoint.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(60, 181);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(138, 16);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "type a reorder point:";
            // 
            // btnSetRestockPoint
            // 
            this.btnSetRestockPoint.Location = new System.Drawing.Point(127, 241);
            this.btnSetRestockPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetRestockPoint.Name = "btnSetRestockPoint";
            this.btnSetRestockPoint.Size = new System.Drawing.Size(121, 28);
            this.btnSetRestockPoint.TabIndex = 7;
            this.btnSetRestockPoint.Text = "Modify";
            this.btnSetRestockPoint.UseVisualStyleBackColor = true;
            this.btnSetRestockPoint.Click += new System.EventHandler(this.btnSetRestockPoint_Click);
            // 
            // cob_warehouseID
            // 
            this.cob_warehouseID.DataSource = this.warehouseBindingSource;
            this.cob_warehouseID.DisplayMember = "warehouseID";
            this.cob_warehouseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_warehouseID.FormattingEnabled = true;
            this.cob_warehouseID.Location = new System.Drawing.Point(203, 41);
            this.cob_warehouseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_warehouseID.Name = "cob_warehouseID";
            this.cob_warehouseID.Size = new System.Drawing.Size(121, 24);
            this.cob_warehouseID.TabIndex = 8;
            this.cob_warehouseID.ValueMember = "warehouseID";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.sdpDataSet;
            // 
            // lbl_warehouseID
            // 
            this.lbl_warehouseID.AutoSize = true;
            this.lbl_warehouseID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouseID.Location = new System.Drawing.Point(96, 44);
            this.lbl_warehouseID.Name = "lbl_warehouseID";
            this.lbl_warehouseID.Size = new System.Drawing.Size(101, 16);
            this.lbl_warehouseID.TabIndex = 9;
            this.lbl_warehouseID.Text = "Warehouse ID:";
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // frm_SetDangerLevelsInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(386, 317);
            this.Controls.Add(this.lbl_warehouseID);
            this.Controls.Add(this.cob_warehouseID);
            this.Controls.Add(this.btnSetRestockPoint);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtSetReStockPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cobWarehouseProduct);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SetDangerLevelsInventory";
            this.Text = "frm_SetDangerLevelsInventory";
            this.Load += new System.EventHandler(this.frmSetDangerLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource productlistBindingSource;
        private sdpDataSetTableAdapters.productlistTableAdapter productlistTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cobWarehouseProduct;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetReStockPoint;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSetRestockPoint;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox cob_warehouseID;
        private System.Windows.Forms.Label lbl_warehouseID;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private sdpDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
    }
}