
namespace WindowsFormsApp11.SalesDepart.Sales_Order_Management
{
    partial class frm_SalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_SalesOrder_View = new System.Windows.Forms.TabPage();
            this.btu_defectItem = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_SearchName = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.lbl_SearchID = new System.Windows.Forms.Label();
            this.txt_SearchID = new System.Windows.Forms.TextBox();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_SalesOrder_Create = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prodID = new System.Windows.Forms.TextBox();
            this.pnl_Item = new System.Windows.Forms.Panel();
            this.lbl_ItemNum = new System.Windows.Forms.Label();
            this.lbl_ProdID = new System.Windows.Forms.Label();
            this.lbl_ProdName = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_ITEM = new System.Windows.Forms.Label();
            this.lbl_Underline = new System.Windows.Forms.Label();
            this.cob_Branch = new System.Windows.Forms.ComboBox();
            this.retailstoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Branch = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tab_SalesOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SearchDepositName = new System.Windows.Forms.TextBox();
            this.btn_DepositRefresh = new System.Windows.Forms.Button();
            this.btn_purchaseFinish = new System.Windows.Forms.Button();
            this.btn_DepositSearch = new System.Windows.Forms.Button();
            this.dgv_depositOrder = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SearchDepositID = new System.Windows.Forms.TextBox();
            this.lbl_SalesOrder = new System.Windows.Forms.Label();
            this.orderTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.orderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.retailstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retailstoreTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.retailstoreTableAdapter();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.receiptTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.customerTableAdapter();
            this.fKreceipt1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_SalesOrder_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tab_SalesOrder_Create.SuspendLayout();
            this.pnl_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource1)).BeginInit();
            this.tab_SalesOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depositOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKreceipt1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_SalesOrder_View
            // 
            this.tab_SalesOrder_View.AutoScroll = true;
            this.tab_SalesOrder_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.tab_SalesOrder_View.Controls.Add(this.btu_defectItem);
            this.tab_SalesOrder_View.Controls.Add(this.btn_cancel);
            this.tab_SalesOrder_View.Controls.Add(this.lbl_SearchName);
            this.tab_SalesOrder_View.Controls.Add(this.txt_SearchName);
            this.tab_SalesOrder_View.Controls.Add(this.btn_Refresh);
            this.tab_SalesOrder_View.Controls.Add(this.btn_Edit);
            this.tab_SalesOrder_View.Controls.Add(this.btn_Select);
            this.tab_SalesOrder_View.Controls.Add(this.dgv_Order);
            this.tab_SalesOrder_View.Controls.Add(this.lbl_SearchID);
            this.tab_SalesOrder_View.Controls.Add(this.txt_SearchID);
            this.tab_SalesOrder_View.Location = new System.Drawing.Point(4, 23);
            this.tab_SalesOrder_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_SalesOrder_View.Name = "tab_SalesOrder_View";
            this.tab_SalesOrder_View.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_SalesOrder_View.Size = new System.Drawing.Size(1026, 560);
            this.tab_SalesOrder_View.TabIndex = 1;
            this.tab_SalesOrder_View.Text = "View Order";
            // 
            // btu_defectItem
            // 
            this.btu_defectItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btu_defectItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btu_defectItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btu_defectItem.Location = new System.Drawing.Point(860, 45);
            this.btu_defectItem.Name = "btu_defectItem";
            this.btu_defectItem.Size = new System.Drawing.Size(137, 23);
            this.btu_defectItem.TabIndex = 11;
            this.btu_defectItem.Text = "Handle defect item";
            this.btu_defectItem.UseVisualStyleBackColor = false;
            this.btu_defectItem.Click += new System.EventHandler(this.btu_defectItem_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(922, 16);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(78, 21);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_SearchName
            // 
            this.lbl_SearchName.AutoSize = true;
            this.lbl_SearchName.Location = new System.Drawing.Point(6, 47);
            this.lbl_SearchName.Name = "lbl_SearchName";
            this.lbl_SearchName.Size = new System.Drawing.Size(92, 14);
            this.lbl_SearchName.TabIndex = 9;
            this.lbl_SearchName.Text = "Search Name :";
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(121, 44);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(100, 21);
            this.txt_SearchName.TabIndex = 8;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(547, 16);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(78, 21);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(333, 16);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(78, 21);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Location = new System.Drawing.Point(239, 16);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(78, 21);
            this.btn_Select.TabIndex = 5;
            this.btn_Select.Text = "Search";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.AllowUserToResizeColumns = false;
            this.dgv_Order.AllowUserToResizeRows = false;
            this.dgv_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.dgv_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Order.ColumnHeadersHeight = 50;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Order.EnableHeadersVisualStyles = false;
            this.dgv_Order.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Order.Location = new System.Drawing.Point(9, 73);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersVisible = false;
            this.dgv_Order.RowHeadersWidth = 10;
            this.dgv_Order.RowTemplate.Height = 24;
            this.dgv_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Order.Size = new System.Drawing.Size(1011, 480);
            this.dgv_Order.TabIndex = 4;
            this.dgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellContentClick);
            // 
            // lbl_SearchID
            // 
            this.lbl_SearchID.AutoSize = true;
            this.lbl_SearchID.Location = new System.Drawing.Point(6, 19);
            this.lbl_SearchID.Name = "lbl_SearchID";
            this.lbl_SearchID.Size = new System.Drawing.Size(109, 14);
            this.lbl_SearchID.TabIndex = 3;
            this.lbl_SearchID.Text = "Search Order ID :";
            // 
            // txt_SearchID
            // 
            this.txt_SearchID.Location = new System.Drawing.Point(121, 16);
            this.txt_SearchID.Name = "txt_SearchID";
            this.txt_SearchID.Size = new System.Drawing.Size(100, 21);
            this.txt_SearchID.TabIndex = 1;
            this.txt_SearchID.TextChanged += new System.EventHandler(this.txt_SearchID_TextChanged);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "order";
            this.orderBindingSource1.DataSource = this.sdpDataSetBindingSource;
            // 
            // sdpDataSetBindingSource
            // 
            this.sdpDataSetBindingSource.DataSource = this.sdpDataSet;
            this.sdpDataSetBindingSource.Position = 0;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.sdpDataSet;
            // 
            // tab_SalesOrder_Create
            // 
            this.tab_SalesOrder_Create.AutoScroll = true;
            this.tab_SalesOrder_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.tab_SalesOrder_Create.Controls.Add(this.label2);
            this.tab_SalesOrder_Create.Controls.Add(this.label3);
            this.tab_SalesOrder_Create.Controls.Add(this.label1);
            this.tab_SalesOrder_Create.Controls.Add(this.txt_prodID);
            this.tab_SalesOrder_Create.Controls.Add(this.pnl_Item);
            this.tab_SalesOrder_Create.Controls.Add(this.lbl_ITEM);
            this.tab_SalesOrder_Create.Controls.Add(this.lbl_Underline);
            this.tab_SalesOrder_Create.Controls.Add(this.cob_Branch);
            this.tab_SalesOrder_Create.Controls.Add(this.lbl_Branch);
            this.tab_SalesOrder_Create.Controls.Add(this.btn_Reset);
            this.tab_SalesOrder_Create.Controls.Add(this.btn_Checkout);
            this.tab_SalesOrder_Create.Controls.Add(this.btn_Remove);
            this.tab_SalesOrder_Create.Controls.Add(this.btn_Add);
            this.tab_SalesOrder_Create.Location = new System.Drawing.Point(4, 23);
            this.tab_SalesOrder_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_SalesOrder_Create.Name = "tab_SalesOrder_Create";
            this.tab_SalesOrder_Create.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_SalesOrder_Create.Size = new System.Drawing.Size(1026, 560);
            this.tab_SalesOrder_Create.TabIndex = 0;
            this.tab_SalesOrder_Create.Text = "Create Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "ADD ITEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1015, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Product ID :";
            // 
            // txt_prodID
            // 
            this.txt_prodID.Location = new System.Drawing.Point(105, 79);
            this.txt_prodID.Name = "txt_prodID";
            this.txt_prodID.Size = new System.Drawing.Size(100, 21);
            this.txt_prodID.TabIndex = 40;
            this.txt_prodID.TextChanged += new System.EventHandler(this.txt_prodID_TextChanged);
            // 
            // pnl_Item
            // 
            this.pnl_Item.AutoScroll = true;
            this.pnl_Item.Controls.Add(this.lbl_ItemNum);
            this.pnl_Item.Controls.Add(this.lbl_ProdID);
            this.pnl_Item.Controls.Add(this.lbl_ProdName);
            this.pnl_Item.Controls.Add(this.lbl_qty);
            this.pnl_Item.Location = new System.Drawing.Point(3, 145);
            this.pnl_Item.Name = "pnl_Item";
            this.pnl_Item.Size = new System.Drawing.Size(1017, 366);
            this.pnl_Item.TabIndex = 39;
            // 
            // lbl_ItemNum
            // 
            this.lbl_ItemNum.AutoSize = true;
            this.lbl_ItemNum.Location = new System.Drawing.Point(8, 10);
            this.lbl_ItemNum.Name = "lbl_ItemNum";
            this.lbl_ItemNum.Size = new System.Drawing.Size(56, 14);
            this.lbl_ItemNum.TabIndex = 38;
            this.lbl_ItemNum.Text = "Item No.";
            // 
            // lbl_ProdID
            // 
            this.lbl_ProdID.AutoSize = true;
            this.lbl_ProdID.Location = new System.Drawing.Point(72, 10);
            this.lbl_ProdID.Name = "lbl_ProdID";
            this.lbl_ProdID.Size = new System.Drawing.Size(69, 14);
            this.lbl_ProdID.TabIndex = 34;
            this.lbl_ProdID.Text = "Product ID";
            // 
            // lbl_ProdName
            // 
            this.lbl_ProdName.AutoSize = true;
            this.lbl_ProdName.Location = new System.Drawing.Point(156, 10);
            this.lbl_ProdName.Name = "lbl_ProdName";
            this.lbl_ProdName.Size = new System.Drawing.Size(90, 14);
            this.lbl_ProdName.TabIndex = 35;
            this.lbl_ProdName.Text = "Product Name";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(969, 10);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(26, 14);
            this.lbl_qty.TabIndex = 36;
            this.lbl_qty.Text = "qty";
            // 
            // lbl_ITEM
            // 
            this.lbl_ITEM.AutoSize = true;
            this.lbl_ITEM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ITEM.Location = new System.Drawing.Point(11, 112);
            this.lbl_ITEM.Name = "lbl_ITEM";
            this.lbl_ITEM.Size = new System.Drawing.Size(87, 18);
            this.lbl_ITEM.TabIndex = 27;
            this.lbl_ITEM.Text = "ITEM LIST";
            // 
            // lbl_Underline
            // 
            this.lbl_Underline.AutoSize = true;
            this.lbl_Underline.Location = new System.Drawing.Point(5, 125);
            this.lbl_Underline.Name = "lbl_Underline";
            this.lbl_Underline.Size = new System.Drawing.Size(1015, 14);
            this.lbl_Underline.TabIndex = 26;
            this.lbl_Underline.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______";
            this.lbl_Underline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cob_Branch
            // 
            this.cob_Branch.BackColor = System.Drawing.Color.White;
            this.cob_Branch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cob_Branch.DataSource = this.retailstoreBindingSource1;
            this.cob_Branch.DisplayMember = "address";
            this.cob_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Branch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Branch.FormattingEnabled = true;
            this.cob_Branch.Location = new System.Drawing.Point(73, 11);
            this.cob_Branch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_Branch.Name = "cob_Branch";
            this.cob_Branch.Size = new System.Drawing.Size(122, 23);
            this.cob_Branch.TabIndex = 17;
            this.cob_Branch.ValueMember = "shopID";
            // 
            // retailstoreBindingSource1
            // 
            this.retailstoreBindingSource1.DataMember = "retailstore";
            this.retailstoreBindingSource1.DataSource = this.sdpDataSet;
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.AutoSize = true;
            this.lbl_Branch.Location = new System.Drawing.Point(11, 15);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(56, 14);
            this.lbl_Branch.TabIndex = 16;
            this.lbl_Branch.Text = "Branch :";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Location = new System.Drawing.Point(96, 518);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(87, 31);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Checkout.Location = new System.Drawing.Point(933, 518);
            this.btn_Checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(87, 31);
            this.btn_Checkout.TabIndex = 4;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Location = new System.Drawing.Point(3, 518);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(87, 31);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(225, 74);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 31);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tab_SalesOrder
            // 
            this.tab_SalesOrder.Controls.Add(this.tab_SalesOrder_Create);
            this.tab_SalesOrder.Controls.Add(this.tab_SalesOrder_View);
            this.tab_SalesOrder.Controls.Add(this.tabPage1);
            this.tab_SalesOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_SalesOrder.Location = new System.Drawing.Point(12, 56);
            this.tab_SalesOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_SalesOrder.Name = "tab_SalesOrder";
            this.tab_SalesOrder.SelectedIndex = 0;
            this.tab_SalesOrder.Size = new System.Drawing.Size(1034, 587);
            this.tab_SalesOrder.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_SearchDepositName);
            this.tabPage1.Controls.Add(this.btn_DepositRefresh);
            this.tabPage1.Controls.Add(this.btn_purchaseFinish);
            this.tabPage1.Controls.Add(this.btn_DepositSearch);
            this.tabPage1.Controls.Add(this.dgv_depositOrder);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_SearchDepositID);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 560);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "View Deposit Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search Name :";
            // 
            // txt_SearchDepositName
            // 
            this.txt_SearchDepositName.Location = new System.Drawing.Point(121, 44);
            this.txt_SearchDepositName.Name = "txt_SearchDepositName";
            this.txt_SearchDepositName.Size = new System.Drawing.Size(100, 21);
            this.txt_SearchDepositName.TabIndex = 16;
            // 
            // btn_DepositRefresh
            // 
            this.btn_DepositRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_DepositRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DepositRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DepositRefresh.Location = new System.Drawing.Point(323, 16);
            this.btn_DepositRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DepositRefresh.Name = "btn_DepositRefresh";
            this.btn_DepositRefresh.Size = new System.Drawing.Size(78, 21);
            this.btn_DepositRefresh.TabIndex = 15;
            this.btn_DepositRefresh.Text = "Refresh";
            this.btn_DepositRefresh.UseVisualStyleBackColor = false;
            this.btn_DepositRefresh.Click += new System.EventHandler(this.btn_DepositRefresh_Click);
            // 
            // btn_purchaseFinish
            // 
            this.btn_purchaseFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_purchaseFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchaseFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseFinish.Location = new System.Drawing.Point(892, 45);
            this.btn_purchaseFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_purchaseFinish.Name = "btn_purchaseFinish";
            this.btn_purchaseFinish.Size = new System.Drawing.Size(113, 21);
            this.btn_purchaseFinish.TabIndex = 14;
            this.btn_purchaseFinish.Text = "Purchase Finish";
            this.btn_purchaseFinish.UseVisualStyleBackColor = false;
            this.btn_purchaseFinish.Click += new System.EventHandler(this.btn_purchaseFinish_Click);
            // 
            // btn_DepositSearch
            // 
            this.btn_DepositSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_DepositSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DepositSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DepositSearch.Location = new System.Drawing.Point(239, 16);
            this.btn_DepositSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DepositSearch.Name = "btn_DepositSearch";
            this.btn_DepositSearch.Size = new System.Drawing.Size(78, 21);
            this.btn_DepositSearch.TabIndex = 13;
            this.btn_DepositSearch.Text = "Search";
            this.btn_DepositSearch.UseVisualStyleBackColor = false;
            this.btn_DepositSearch.Click += new System.EventHandler(this.btn_DepositSearch_Click);
            // 
            // dgv_depositOrder
            // 
            this.dgv_depositOrder.AllowUserToAddRows = false;
            this.dgv_depositOrder.AllowUserToDeleteRows = false;
            this.dgv_depositOrder.AllowUserToResizeColumns = false;
            this.dgv_depositOrder.AllowUserToResizeRows = false;
            this.dgv_depositOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_depositOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_depositOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.dgv_depositOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_depositOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_depositOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_depositOrder.ColumnHeadersHeight = 50;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_depositOrder.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_depositOrder.EnableHeadersVisualStyles = false;
            this.dgv_depositOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_depositOrder.Location = new System.Drawing.Point(9, 73);
            this.dgv_depositOrder.Name = "dgv_depositOrder";
            this.dgv_depositOrder.ReadOnly = true;
            this.dgv_depositOrder.RowHeadersVisible = false;
            this.dgv_depositOrder.RowHeadersWidth = 10;
            this.dgv_depositOrder.RowTemplate.Height = 24;
            this.dgv_depositOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_depositOrder.Size = new System.Drawing.Size(1011, 480);
            this.dgv_depositOrder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Order ID :";
            // 
            // txt_SearchDepositID
            // 
            this.txt_SearchDepositID.Location = new System.Drawing.Point(121, 16);
            this.txt_SearchDepositID.Name = "txt_SearchDepositID";
            this.txt_SearchDepositID.Size = new System.Drawing.Size(100, 21);
            this.txt_SearchDepositID.TabIndex = 10;
            // 
            // lbl_SalesOrder
            // 
            this.lbl_SalesOrder.AutoSize = true;
            this.lbl_SalesOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_SalesOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesOrder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_SalesOrder.Location = new System.Drawing.Point(6, 20);
            this.lbl_SalesOrder.Name = "lbl_SalesOrder";
            this.lbl_SalesOrder.Size = new System.Drawing.Size(179, 32);
            this.lbl_SalesOrder.TabIndex = 3;
            this.lbl_SalesOrder.Text = "Sales Order";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
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
            // retailstoreBindingSource
            // 
            this.retailstoreBindingSource.DataMember = "retailstore";
            this.retailstoreBindingSource.DataSource = this.sdpDataSetBindingSource;
            // 
            // retailstoreTableAdapter
            // 
            this.retailstoreTableAdapter.ClearBeforeFill = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.sdpDataSetBindingSource;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.sdpDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // fKreceipt1BindingSource
            // 
            this.fKreceipt1BindingSource.DataMember = "FKreceipt1";
            this.fKreceipt1BindingSource.DataSource = this.orderBindingSource;
            // 
            // frm_SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1058, 656);
            this.Controls.Add(this.lbl_SalesOrder);
            this.Controls.Add(this.tab_SalesOrder);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SalesOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frm_SalesOrder";
            this.Load += new System.EventHandler(this.frm_SalesOrder_Load_1);
            this.tab_SalesOrder_View.ResumeLayout(false);
            this.tab_SalesOrder_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tab_SalesOrder_Create.ResumeLayout(false);
            this.tab_SalesOrder_Create.PerformLayout();
            this.pnl_Item.ResumeLayout(false);
            this.pnl_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource1)).EndInit();
            this.tab_SalesOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depositOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailstoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKreceipt1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tab_SalesOrder_View;
        private System.Windows.Forms.TabPage tab_SalesOrder_Create;
        private System.Windows.Forms.Label lbl_Branch;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TabControl tab_SalesOrder;
        private System.Windows.Forms.Label lbl_ITEM;
        private System.Windows.Forms.Label lbl_Underline;
        private System.Windows.Forms.Label lbl_SalesOrder;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_ProdName;
        private System.Windows.Forms.Label lbl_ProdID;
        private System.Windows.Forms.Panel pnl_Item;
        private System.Windows.Forms.Label lbl_ItemNum;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private sdpDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cob_Branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prodID;
        private System.Windows.Forms.Label lbl_SearchID;
        private System.Windows.Forms.TextBox txt_SearchID;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.BindingSource sdpDataSetBindingSource;
        private System.Windows.Forms.BindingSource retailstoreBindingSource;
        private sdpDataSetTableAdapters.retailstoreTableAdapter retailstoreTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private sdpDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource fKreceipt1BindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private sdpDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_SearchName;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.BindingSource retailstoreBindingSource1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SearchDepositName;
        private System.Windows.Forms.Button btn_DepositRefresh;
        private System.Windows.Forms.Button btn_purchaseFinish;
        private System.Windows.Forms.Button btn_DepositSearch;
        private System.Windows.Forms.DataGridView dgv_depositOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SearchDepositID;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btu_defectItem;
    }
}