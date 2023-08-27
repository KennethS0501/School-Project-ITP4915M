
namespace WindowsFormsApp11.InventoryDepart.Restock_From_Supplier
{
    partial class frm_RestockFromSupplier
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstRetailShopProduct = new System.Windows.Forms.ListBox();
            this.lstSelectedProduct = new System.Windows.Forms.ListBox();
            this.lstProductName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_suplierID = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmitRestockWarehoues = new System.Windows.Forms.Button();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.retailstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retailstoreTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.retailstoreTableAdapter();
            this.warehouseTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.warehouseTableAdapter();
            this.cbo_warehouseID = new System.Windows.Forms.ComboBox();
            this.cbo_supplierID = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.supplierTableAdapter();
            this.txtQTY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstRetailShopProduct
            // 
            this.lstRetailShopProduct.FormattingEnabled = true;
            this.lstRetailShopProduct.ItemHeight = 16;
            this.lstRetailShopProduct.Location = new System.Drawing.Point(152, 15);
            this.lstRetailShopProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstRetailShopProduct.Name = "lstRetailShopProduct";
            this.lstRetailShopProduct.Size = new System.Drawing.Size(135, 292);
            this.lstRetailShopProduct.TabIndex = 0;
            // 
            // lstSelectedProduct
            // 
            this.lstSelectedProduct.FormattingEnabled = true;
            this.lstSelectedProduct.ItemHeight = 16;
            this.lstSelectedProduct.Location = new System.Drawing.Point(607, 15);
            this.lstSelectedProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSelectedProduct.Name = "lstSelectedProduct";
            this.lstSelectedProduct.Size = new System.Drawing.Size(139, 292);
            this.lstSelectedProduct.TabIndex = 1;
            // 
            // lstProductName
            // 
            this.lstProductName.FormattingEnabled = true;
            this.lstProductName.ItemHeight = 16;
            this.lstProductName.Location = new System.Drawing.Point(114, 357);
            this.lstProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProductName.Name = "lstProductName";
            this.lstProductName.Size = new System.Drawing.Size(119, 116);
            this.lstProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Retail Shop Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_suplierID
            // 
            this.lbl_suplierID.AutoSize = true;
            this.lbl_suplierID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbl_suplierID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_suplierID.Location = new System.Drawing.Point(419, 357);
            this.lbl_suplierID.Name = "lbl_suplierID";
            this.lbl_suplierID.Size = new System.Drawing.Size(87, 16);
            this.lbl_suplierID.TabIndex = 4;
            this.lbl_suplierID.Text = "Supplier ID:";
            // 
            // cbo
            // 
            this.cbo.AutoSize = true;
            this.cbo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cbo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbo.Location = new System.Drawing.Point(246, 357);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(105, 16);
            this.cbo.TabIndex = 5;
            this.cbo.Text = "Warehouse ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(492, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleted Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(604, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "QTY";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl.Location = new System.Drawing.Point(12, 357);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(101, 16);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Product name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmitRestockWarehoues
            // 
            this.btnSubmitRestockWarehoues.Location = new System.Drawing.Point(335, 500);
            this.btnSubmitRestockWarehoues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitRestockWarehoues.Name = "btnSubmitRestockWarehoues";
            this.btnSubmitRestockWarehoues.Size = new System.Drawing.Size(75, 28);
            this.btnSubmitRestockWarehoues.TabIndex = 11;
            this.btnSubmitRestockWarehoues.Text = "Submit";
            this.btnSubmitRestockWarehoues.UseVisualStyleBackColor = true;
            this.btnSubmitRestockWarehoues.Click += new System.EventHandler(this.btnSubmitRestockWarehoues_Click);
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retailstoreBindingSource
            // 
            this.retailstoreBindingSource.DataMember = "retailstore";
            this.retailstoreBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSetBindingSource
            // 
            this.sdpDataSetBindingSource.DataSource = this.sdpDataSet;
            this.sdpDataSetBindingSource.Position = 0;
            // 
            // retailstoreTableAdapter
            // 
            this.retailstoreTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // cbo_warehouseID
            // 
            this.cbo_warehouseID.DataSource = this.warehouseBindingSource;
            this.cbo_warehouseID.DisplayMember = "warehouseID";
            this.cbo_warehouseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_warehouseID.FormattingEnabled = true;
            this.cbo_warehouseID.Location = new System.Drawing.Point(248, 379);
            this.cbo_warehouseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_warehouseID.Name = "cbo_warehouseID";
            this.cbo_warehouseID.Size = new System.Drawing.Size(98, 24);
            this.cbo_warehouseID.TabIndex = 15;
            this.cbo_warehouseID.ValueMember = "warehouseID";
            // 
            // cbo_supplierID
            // 
            this.cbo_supplierID.DataSource = this.supplierBindingSource;
            this.cbo_supplierID.DisplayMember = "SupplierID";
            this.cbo_supplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_supplierID.FormattingEnabled = true;
            this.cbo_supplierID.Location = new System.Drawing.Point(421, 379);
            this.cbo_supplierID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_supplierID.Name = "cbo_supplierID";
            this.cbo_supplierID.Size = new System.Drawing.Size(114, 24);
            this.cbo_supplierID.TabIndex = 16;
            this.cbo_supplierID.ValueMember = "SupplierID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.sdpDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(607, 380);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(120, 23);
            this.txtQTY.TabIndex = 17;
            // 
            // frm_RestockFromSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.cbo_supplierID);
            this.Controls.Add(this.cbo_warehouseID);
            this.Controls.Add(this.btnSubmitRestockWarehoues);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.lbl_suplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProductName);
            this.Controls.Add(this.lstSelectedProduct);
            this.Controls.Add(this.lstRetailShopProduct);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_RestockFromSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRestockFromWarehouse";
            this.Load += new System.EventHandler(this.frmRestockFromWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRetailShopProduct;
        private System.Windows.Forms.ListBox lstSelectedProduct;
        private System.Windows.Forms.ListBox lstProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_suplierID;
        private System.Windows.Forms.Label cbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmitRestockWarehoues;
        private System.Windows.Forms.BindingSource sdpDataSetBindingSource;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource retailstoreBindingSource;
        private sdpDataSetTableAdapters.retailstoreTableAdapter retailstoreTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private sdpDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbo_warehouseID;
        private System.Windows.Forms.ComboBox cbo_supplierID;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private sdpDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.NumericUpDown txtQTY;
    }
}