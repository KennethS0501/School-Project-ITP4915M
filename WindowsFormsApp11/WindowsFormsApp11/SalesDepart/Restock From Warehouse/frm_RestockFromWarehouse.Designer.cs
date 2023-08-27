
namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    partial class frm_RestockFromWarehouse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmitRestockWarehoues = new System.Windows.Forms.Button();
            this.cobWarehouse = new System.Windows.Forms.ComboBox();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.cobDestinationshop = new System.Windows.Forms.ComboBox();
            this.retailstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retailstoreTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.retailstoreTableAdapter();
            this.warehouseTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.warehouseTableAdapter();
            this.txtQTY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 21);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstRetailShopProduct
            // 
            this.lstRetailShopProduct.FormattingEnabled = true;
            this.lstRetailShopProduct.ItemHeight = 12;
            this.lstRetailShopProduct.Location = new System.Drawing.Point(114, 11);
            this.lstRetailShopProduct.Name = "lstRetailShopProduct";
            this.lstRetailShopProduct.Size = new System.Drawing.Size(103, 220);
            this.lstRetailShopProduct.TabIndex = 0;
            // 
            // lstSelectedProduct
            // 
            this.lstSelectedProduct.FormattingEnabled = true;
            this.lstSelectedProduct.ItemHeight = 12;
            this.lstSelectedProduct.Location = new System.Drawing.Point(520, 11);
            this.lstSelectedProduct.Name = "lstSelectedProduct";
            this.lstSelectedProduct.Size = new System.Drawing.Size(103, 220);
            this.lstSelectedProduct.TabIndex = 1;
            // 
            // lstProductName
            // 
            this.lstProductName.FormattingEnabled = true;
            this.lstProductName.ItemHeight = 12;
            this.lstProductName.Location = new System.Drawing.Point(86, 268);
            this.lstProductName.Name = "lstProductName";
            this.lstProductName.Size = new System.Drawing.Size(103, 88);
            this.lstProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Retail Shop Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleted Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "QTY";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 268);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 12);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Product name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 21);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmitRestockWarehoues
            // 
            this.btnSubmitRestockWarehoues.Location = new System.Drawing.Point(287, 375);
            this.btnSubmitRestockWarehoues.Name = "btnSubmitRestockWarehoues";
            this.btnSubmitRestockWarehoues.Size = new System.Drawing.Size(64, 21);
            this.btnSubmitRestockWarehoues.TabIndex = 11;
            this.btnSubmitRestockWarehoues.Text = "Submit";
            this.btnSubmitRestockWarehoues.UseVisualStyleBackColor = true;
            this.btnSubmitRestockWarehoues.Click += new System.EventHandler(this.btnSubmitRestockWarehoues_Click);
            // 
            // cobWarehouse
            // 
            this.cobWarehouse.DataSource = this.warehouseBindingSource;
            this.cobWarehouse.DisplayMember = "warehouseID";
            this.cobWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobWarehouse.FormattingEnabled = true;
            this.cobWarehouse.Location = new System.Drawing.Point(362, 283);
            this.cobWarehouse.Name = "cobWarehouse";
            this.cobWarehouse.Size = new System.Drawing.Size(104, 20);
            this.cobWarehouse.TabIndex = 12;
            this.cobWarehouse.ValueMember = "warehouseID";
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
            // cobDestinationshop
            // 
            this.cobDestinationshop.DataSource = this.retailstoreBindingSource;
            this.cobDestinationshop.DisplayMember = "shopID";
            this.cobDestinationshop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDestinationshop.FormattingEnabled = true;
            this.cobDestinationshop.Location = new System.Drawing.Point(213, 283);
            this.cobDestinationshop.Name = "cobDestinationshop";
            this.cobDestinationshop.Size = new System.Drawing.Size(104, 20);
            this.cobDestinationshop.TabIndex = 13;
            this.cobDestinationshop.ValueMember = "shopID";
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
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(520, 284);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(120, 22);
            this.txtQTY.TabIndex = 15;
            this.txtQTY.ValueChanged += new System.EventHandler(this.txtQTY_ValueChanged);
            // 
            // frm_RestockFromWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 415);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.cobDestinationshop);
            this.Controls.Add(this.cobWarehouse);
            this.Controls.Add(this.btnSubmitRestockWarehoues);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProductName);
            this.Controls.Add(this.lstSelectedProduct);
            this.Controls.Add(this.lstRetailShopProduct);
            this.Name = "frm_RestockFromWarehouse";
            this.Text = "frmRestockFromWarehouse";
            this.Load += new System.EventHandler(this.frmRestockFromWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRetailShopProduct;
        private System.Windows.Forms.ListBox lstSelectedProduct;
        private System.Windows.Forms.ListBox lstProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmitRestockWarehoues;
        private System.Windows.Forms.ComboBox cobWarehouse;
        private System.Windows.Forms.ComboBox cobDestinationshop;
        private System.Windows.Forms.BindingSource sdpDataSetBindingSource;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource retailstoreBindingSource;
        private sdpDataSetTableAdapters.retailstoreTableAdapter retailstoreTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private sdpDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown txtQTY;
    }
}