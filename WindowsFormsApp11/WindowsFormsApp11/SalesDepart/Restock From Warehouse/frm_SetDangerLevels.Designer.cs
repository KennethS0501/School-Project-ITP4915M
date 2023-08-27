
namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    partial class frm_SetDangerLevels
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
            this.cob_ShopID = new System.Windows.Forms.ComboBox();
            this.retailstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retailstoreTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.retailstoreTableAdapter();
            this.lbl_ShopID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(146, 130);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
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
            this.cobWarehouseProduct.Location = new System.Drawing.Point(212, 73);
            this.cobWarehouseProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobWarehouseProduct.Name = "cobWarehouseProduct";
            this.cobWarehouseProduct.Size = new System.Drawing.Size(121, 24);
            this.cobWarehouseProduct.TabIndex = 2;
            this.cobWarehouseProduct.ValueMember = "productID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productlistBindingSource, "name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(212, 127);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "WarehouseProductID";
            // 
            // txtSetReStockPoint
            // 
            this.txtSetReStockPoint.Location = new System.Drawing.Point(212, 196);
            this.txtSetReStockPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSetReStockPoint.Name = "txtSetReStockPoint";
            this.txtSetReStockPoint.Size = new System.Drawing.Size(100, 23);
            this.txtSetReStockPoint.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(56, 199);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(137, 16);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "type a reorder point:";
            // 
            // btnSetRestockPoint
            // 
            this.btnSetRestockPoint.Location = new System.Drawing.Point(149, 277);
            this.btnSetRestockPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetRestockPoint.Name = "btnSetRestockPoint";
            this.btnSetRestockPoint.Size = new System.Drawing.Size(121, 28);
            this.btnSetRestockPoint.TabIndex = 7;
            this.btnSetRestockPoint.Text = "Modify";
            this.btnSetRestockPoint.UseVisualStyleBackColor = true;
            this.btnSetRestockPoint.Click += new System.EventHandler(this.btnSetRestockPoint_Click);
            // 
            // cob_ShopID
            // 
            this.cob_ShopID.DataSource = this.retailstoreBindingSource;
            this.cob_ShopID.DisplayMember = "shopID";
            this.cob_ShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_ShopID.FormattingEnabled = true;
            this.cob_ShopID.Location = new System.Drawing.Point(212, 21);
            this.cob_ShopID.Name = "cob_ShopID";
            this.cob_ShopID.Size = new System.Drawing.Size(104, 24);
            this.cob_ShopID.TabIndex = 8;
            this.cob_ShopID.ValueMember = "shopID";
            // 
            // retailstoreBindingSource
            // 
            this.retailstoreBindingSource.DataMember = "retailstore";
            this.retailstoreBindingSource.DataSource = this.sdpDataSet;
            // 
            // retailstoreTableAdapter
            // 
            this.retailstoreTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_ShopID
            // 
            this.lbl_ShopID.AutoSize = true;
            this.lbl_ShopID.Location = new System.Drawing.Point(131, 24);
            this.lbl_ShopID.Name = "lbl_ShopID";
            this.lbl_ShopID.Size = new System.Drawing.Size(62, 16);
            this.lbl_ShopID.TabIndex = 9;
            this.lbl_ShopID.Text = "Shop ID:";
            // 
            // frm_SetDangerLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 367);
            this.Controls.Add(this.lbl_ShopID);
            this.Controls.Add(this.cob_ShopID);
            this.Controls.Add(this.btnSetRestockPoint);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtSetReStockPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cobWarehouseProduct);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SetDangerLevels";
            this.Text = "frmSetLangerLevels";
            this.Load += new System.EventHandler(this.frmSetDangerLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cob_ShopID;
        private System.Windows.Forms.BindingSource retailstoreBindingSource;
        private sdpDataSetTableAdapters.retailstoreTableAdapter retailstoreTableAdapter;
        private System.Windows.Forms.Label lbl_ShopID;
    }
}
