
namespace WindowsFormsApp11.ITDepart.DataAccess
{
    partial class frm_ModifyAccessGroup
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
            System.Windows.Forms.Label accessIDLabel;
            System.Windows.Forms.Label accessNameLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            this.label15 = new System.Windows.Forms.Label();
            this.removeAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.addAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.cbo_AccessID = new System.Windows.Forms.ComboBox();
            this.accessTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.accessTableAdapter();
            this.cbo_AccessName = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.removeProductCheckBox = new System.Windows.Forms.CheckBox();
            this.addProductCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyProductCheckBox = new System.Windows.Forms.CheckBox();
            this.addStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.removeStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.detailStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setDangerLevelsSalesCheckBox = new System.Windows.Forms.CheckBox();
            this.cofirmSalesRestockCheckBox = new System.Windows.Forms.CheckBox();
            this.restockFromWarehouseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.cancelOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.editOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restockIndexCheckBox = new System.Windows.Forms.CheckBox();
            accessIDLabel = new System.Windows.Forms.Label();
            accessNameLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accessIDLabel
            // 
            accessIDLabel.AutoSize = true;
            accessIDLabel.Location = new System.Drawing.Point(270, 60);
            accessIDLabel.Name = "accessIDLabel";
            accessIDLabel.Size = new System.Drawing.Size(74, 16);
            accessIDLabel.TabIndex = 2;
            accessIDLabel.Text = "Access ID:";
            // 
            // accessNameLabel
            // 
            accessNameLabel.AutoSize = true;
            accessNameLabel.Location = new System.Drawing.Point(252, 107);
            accessNameLabel.Name = "accessNameLabel";
            accessNameLabel.Size = new System.Drawing.Size(97, 16);
            accessNameLabel.TabIndex = 4;
            accessNameLabel.Text = "Access Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 9.75F);
            label6.Location = new System.Drawing.Point(7, 167);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 16);
            label6.TabIndex = 34;
            label6.Text = "Set Danger Levels:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 9.75F);
            label5.Location = new System.Drawing.Point(7, 145);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(144, 16);
            label5.TabIndex = 33;
            label5.Text = "Confirm Restock Order:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 9.75F);
            label4.Location = new System.Drawing.Point(7, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 16);
            label4.TabIndex = 32;
            label4.Text = "Restock from warehouse :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 9.75F);
            label2.Location = new System.Drawing.Point(6, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 16);
            label2.TabIndex = 18;
            label2.Text = "Edit Order:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 9.75F);
            label3.Location = new System.Drawing.Point(6, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 16);
            label3.TabIndex = 19;
            label3.Text = "Cancel Order:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 9.75F);
            label7.Location = new System.Drawing.Point(6, 87);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 16);
            label7.TabIndex = 13;
            label7.Text = "Remove Product:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 9.75F);
            label8.Location = new System.Drawing.Point(12, 127);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(99, 16);
            label8.TabIndex = 15;
            label8.Text = "Modify Product:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 9.75F);
            label9.Location = new System.Drawing.Point(28, 47);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 16);
            label9.TabIndex = 11;
            label9.Text = "Add Product:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial", 9.75F);
            label10.Location = new System.Drawing.Point(21, 72);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(88, 16);
            label10.TabIndex = 19;
            label10.Text = "Remove Staff:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Arial", 9.75F);
            label11.Location = new System.Drawing.Point(43, 38);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(65, 16);
            label11.TabIndex = 17;
            label11.Text = "Add Staff:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Arial", 9.75F);
            label12.Location = new System.Drawing.Point(25, 112);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(80, 16);
            label12.TabIndex = 21;
            label12.Text = "Modify Staff:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Arial", 9.75F);
            label13.Location = new System.Drawing.Point(35, 152);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(75, 16);
            label13.TabIndex = 23;
            label13.Text = "Detail Staff:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(this.label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(this.removeAccountCheckBox);
            groupBox1.Controls.Add(this.addAccountCheckBox);
            groupBox1.Controls.Add(this.modifyAccountCheckBox);
            groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(23, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(166, 196);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Control";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(8, 94);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(109, 16);
            label14.TabIndex = 7;
            label14.Text = "Remove Account:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Add Account:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(16, 129);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(101, 16);
            label16.TabIndex = 9;
            label16.Text = "Modify Account:";
            // 
            // cbo_AccessID
            // removeAccountCheckBox
            // 
            this.removeAccountCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RemoveAccount", true));
            this.removeAccountCheckBox.Location = new System.Drawing.Point(118, 85);
            this.removeAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeAccountCheckBox.Name = "removeAccountCheckBox";
            this.removeAccountCheckBox.Size = new System.Drawing.Size(27, 32);
            this.removeAccountCheckBox.TabIndex = 7;
            this.removeAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // accessBindingSource
            // 
            this.accessBindingSource.DataMember = "access";
            this.accessBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addAccountCheckBox
            // 
            this.addAccountCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "AddAccount", true));
            this.addAccountCheckBox.Location = new System.Drawing.Point(118, 45);
            this.addAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAccountCheckBox.Name = "addAccountCheckBox";
            this.addAccountCheckBox.Size = new System.Drawing.Size(27, 32);
            this.addAccountCheckBox.TabIndex = 5;
            this.addAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyAccountCheckBox
            // 
            this.modifyAccountCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "ModifyAccount", true));
            this.modifyAccountCheckBox.Location = new System.Drawing.Point(118, 125);
            this.modifyAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyAccountCheckBox.Name = "modifyAccountCheckBox";
            this.modifyAccountCheckBox.Size = new System.Drawing.Size(27, 32);
            this.modifyAccountCheckBox.TabIndex = 9;
            this.modifyAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // cbo_AccessID
            // 
            this.cbo_AccessID.DataSource = this.accessBindingSource;
            this.cbo_AccessID.DisplayMember = "AccessID";
            this.cbo_AccessID.FormattingEnabled = true;
            this.cbo_AccessID.Location = new System.Drawing.Point(350, 57);
            this.cbo_AccessID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_AccessID.Name = "cbo_AccessID";
            this.cbo_AccessID.Size = new System.Drawing.Size(140, 24);
            this.cbo_AccessID.TabIndex = 0;
            this.cbo_AccessID.ValueMember = "AccessID";
            // 
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
            // 
            // cbo_AccessName
            // 
            this.cbo_AccessName.DataSource = this.accessBindingSource;
            this.cbo_AccessName.DisplayMember = "AccessName";
            this.cbo_AccessName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_AccessName.FormattingEnabled = true;
            this.cbo_AccessName.Location = new System.Drawing.Point(350, 104);
            this.cbo_AccessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_AccessName.Name = "cbo_AccessName";
            this.cbo_AccessName.Size = new System.Drawing.Size(140, 24);
            this.cbo_AccessName.TabIndex = 1;
            this.cbo_AccessName.ValueMember = "AccessName";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accessTableAdapter = this.accessTableAdapter;
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
            this.tableAdapterManager.warehousestockTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // removeProductCheckBox
            // 
            this.removeProductCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RemoveProduct", true));
            this.removeProductCheckBox.Location = new System.Drawing.Point(112, 80);
            this.removeProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductCheckBox.Name = "removeProductCheckBox";
            this.removeProductCheckBox.Size = new System.Drawing.Size(24, 32);
            this.removeProductCheckBox.TabIndex = 11;
            this.removeProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // addProductCheckBox
            // 
            this.addProductCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "AddProduct", true));
            this.addProductCheckBox.Location = new System.Drawing.Point(112, 40);
            this.addProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductCheckBox.Name = "addProductCheckBox";
            this.addProductCheckBox.Size = new System.Drawing.Size(24, 32);
            this.addProductCheckBox.TabIndex = 13;
            this.addProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyProductCheckBox
            // 
            this.modifyProductCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "ModifyProduct", true));
            this.modifyProductCheckBox.Location = new System.Drawing.Point(112, 120);
            this.modifyProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyProductCheckBox.Name = "modifyProductCheckBox";
            this.modifyProductCheckBox.Size = new System.Drawing.Size(24, 32);
            this.modifyProductCheckBox.TabIndex = 15;
            this.modifyProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // addStaffCheckBox
            // 
            this.addStaffCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "AddStaff", true));
            this.addStaffCheckBox.Location = new System.Drawing.Point(114, 28);
            this.addStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addStaffCheckBox.Name = "addStaffCheckBox";
            this.addStaffCheckBox.Size = new System.Drawing.Size(23, 32);
            this.addStaffCheckBox.TabIndex = 17;
            this.addStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeStaffCheckBox
            // 
            this.removeStaffCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RemoveStaff", true));
            this.removeStaffCheckBox.Location = new System.Drawing.Point(114, 68);
            this.removeStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeStaffCheckBox.Name = "removeStaffCheckBox";
            this.removeStaffCheckBox.Size = new System.Drawing.Size(23, 32);
            this.removeStaffCheckBox.TabIndex = 19;
            this.removeStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyStaffCheckBox
            // 
            this.modifyStaffCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "ModifyStaff", true));
            this.modifyStaffCheckBox.Location = new System.Drawing.Point(114, 108);
            this.modifyStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyStaffCheckBox.Name = "modifyStaffCheckBox";
            this.modifyStaffCheckBox.Size = new System.Drawing.Size(23, 32);
            this.modifyStaffCheckBox.TabIndex = 21;
            this.modifyStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // detailStaffCheckBox
            // 
            this.detailStaffCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "DetailStaff", true));
            this.detailStaffCheckBox.Location = new System.Drawing.Point(114, 148);
            this.detailStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailStaffCheckBox.Name = "detailStaffCheckBox";
            this.detailStaffCheckBox.Size = new System.Drawing.Size(23, 32);
            this.detailStaffCheckBox.TabIndex = 23;
            this.detailStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(label17);
            this.groupBox4.Controls.Add(this.restockIndexCheckBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(label6);
            this.groupBox4.Controls.Add(this.setDangerLevelsSalesCheckBox);
            this.groupBox4.Controls.Add(this.cofirmSalesRestockCheckBox);
            this.groupBox4.Controls.Add(this.restockFromWarehouseCheckBox1);
            this.groupBox4.Controls.Add(label5);
            this.groupBox4.Controls.Add(label4);
            this.groupBox4.Controls.Add(this.cancelOrderCheckBox);
            this.groupBox4.Controls.Add(this.editOrderCheckBox);
            this.groupBox4.Controls.Add(this.paymentCheckBox);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Controls.Add(label3);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox4.Location = new System.Drawing.Point(570, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 196);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sales Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Payment:";
            // 
            // setDangerLevelsSalesCheckBox
            // 
            this.setDangerLevelsSalesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "SetDangerLevelsSales", true));
            this.setDangerLevelsSalesCheckBox.Location = new System.Drawing.Point(125, 164);
            this.setDangerLevelsSalesCheckBox.Name = "setDangerLevelsSalesCheckBox";
            this.setDangerLevelsSalesCheckBox.Size = new System.Drawing.Size(28, 24);
            this.setDangerLevelsSalesCheckBox.TabIndex = 32;
            this.setDangerLevelsSalesCheckBox.UseVisualStyleBackColor = true;
            // 
            // cofirmSalesRestockCheckBox
            // 
            this.cofirmSalesRestockCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "CofirmSalesRestock", true));
            this.cofirmSalesRestockCheckBox.Location = new System.Drawing.Point(151, 142);
            this.cofirmSalesRestockCheckBox.Name = "cofirmSalesRestockCheckBox";
            this.cofirmSalesRestockCheckBox.Size = new System.Drawing.Size(20, 24);
            this.cofirmSalesRestockCheckBox.TabIndex = 32;
            this.cofirmSalesRestockCheckBox.UseVisualStyleBackColor = true;
            // 
            // restockFromWarehouseCheckBox1
            // 
            this.restockFromWarehouseCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RestockFromWarehouse", true));
            this.restockFromWarehouseCheckBox1.Location = new System.Drawing.Point(169, 121);
            this.restockFromWarehouseCheckBox1.Name = "restockFromWarehouseCheckBox1";
            this.restockFromWarehouseCheckBox1.Size = new System.Drawing.Size(31, 24);
            this.restockFromWarehouseCheckBox1.TabIndex = 32;
            this.restockFromWarehouseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // cancelOrderCheckBox
            // 
            this.cancelOrderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "CancelOrder", true));
            this.cancelOrderCheckBox.Location = new System.Drawing.Point(91, 69);
            this.cancelOrderCheckBox.Name = "cancelOrderCheckBox";
            this.cancelOrderCheckBox.Size = new System.Drawing.Size(28, 24);
            this.cancelOrderCheckBox.TabIndex = 31;
            this.cancelOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // editOrderCheckBox
            // 
            this.editOrderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "EditOrder", true));
            this.editOrderCheckBox.Location = new System.Drawing.Point(74, 49);
            this.editOrderCheckBox.Name = "editOrderCheckBox";
            this.editOrderCheckBox.Size = new System.Drawing.Size(29, 24);
            this.editOrderCheckBox.TabIndex = 31;
            this.editOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentCheckBox
            // 
            this.paymentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "Payment", true));
            this.paymentCheckBox.Location = new System.Drawing.Point(74, 28);
            this.paymentCheckBox.Name = "paymentCheckBox";
            this.paymentCheckBox.Size = new System.Drawing.Size(23, 24);
            this.paymentCheckBox.TabIndex = 31;
            this.paymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Controls.Add(label8);
            this.groupBox3.Controls.Add(label9);
            this.groupBox3.Controls.Add(this.removeProductCheckBox);
            this.groupBox3.Controls.Add(this.addProductCheckBox);
            this.groupBox3.Controls.Add(this.modifyProductCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(381, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 196);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label10);
            this.groupBox2.Controls.Add(label11);
            this.groupBox2.Controls.Add(label12);
            this.groupBox2.Controls.Add(label13);
            this.groupBox2.Controls.Add(this.addStaffCheckBox);
            this.groupBox2.Controls.Add(this.removeStaffCheckBox);
            this.groupBox2.Controls.Add(this.detailStaffCheckBox);
            this.groupBox2.Controls.Add(this.modifyStaffCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(205, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 196);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Control";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Arial", 9.75F);
            label17.Location = new System.Drawing.Point(8, 104);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(95, 16);
            label17.TabIndex = 37;
            label17.Text = "Restock Index:";
            // 
            // restockIndexCheckBox
            // 
            this.restockIndexCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RestockIndex", true));
            this.restockIndexCheckBox.Location = new System.Drawing.Point(105, 102);
            this.restockIndexCheckBox.Name = "restockIndexCheckBox";
            this.restockIndexCheckBox.Size = new System.Drawing.Size(28, 24);
            this.restockIndexCheckBox.TabIndex = 36;
            this.restockIndexCheckBox.UseVisualStyleBackColor = true;
            // 
            // frm_ModifyAccessGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(807, 493);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(accessNameLabel);
            this.Controls.Add(accessIDLabel);
            this.Controls.Add(this.cbo_AccessName);
            this.Controls.Add(this.cbo_AccessID);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ModifyAccessGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ModifyAccessGroup";
            this.Load += new System.EventHandler(this.frm_ModifyAccessGroup_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_AccessID;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private sdpDataSetTableAdapters.accessTableAdapter accessTableAdapter;
        private System.Windows.Forms.ComboBox cbo_AccessName;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox addAccountCheckBox;
        private System.Windows.Forms.CheckBox removeAccountCheckBox;
        private System.Windows.Forms.CheckBox modifyAccountCheckBox;
        private System.Windows.Forms.CheckBox removeProductCheckBox;
        private System.Windows.Forms.CheckBox addProductCheckBox;
        private System.Windows.Forms.CheckBox modifyProductCheckBox;
        private System.Windows.Forms.CheckBox addStaffCheckBox;
        private System.Windows.Forms.CheckBox removeStaffCheckBox;
        private System.Windows.Forms.CheckBox modifyStaffCheckBox;
        private System.Windows.Forms.CheckBox detailStaffCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox setDangerLevelsSalesCheckBox;
        private System.Windows.Forms.CheckBox cofirmSalesRestockCheckBox;
        private System.Windows.Forms.CheckBox restockFromWarehouseCheckBox1;
        private System.Windows.Forms.CheckBox cancelOrderCheckBox;
        private System.Windows.Forms.CheckBox editOrderCheckBox;
        private System.Windows.Forms.CheckBox paymentCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox restockIndexCheckBox;
    }
}
