
namespace WindowsFormsApp11.ITdepart.DataAccess
{
    partial class frmAddAccessGroup
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
            System.Windows.Forms.Label removeAccountLabel;
            System.Windows.Forms.Label modifyAccountLabel;
            System.Windows.Forms.Label addProductLabel;
            System.Windows.Forms.Label removeProductLabel;
            System.Windows.Forms.Label modifyProductLabel;
            System.Windows.Forms.Label addStaffLabel;
            System.Windows.Forms.Label removeStaffLabel;
            System.Windows.Forms.Label modifyStaffLabel;
            System.Windows.Forms.Label detailStaffLabel;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.addAccountLabel = new System.Windows.Forms.Label();
            this.modifyAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.addAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.removeAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.accessNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductCheckBox = new System.Windows.Forms.CheckBox();
            this.removeProductCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyProductCheckBox = new System.Windows.Forms.CheckBox();
            this.addStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.removeStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.detailStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setDangerLevelsSalesCheckBox = new System.Windows.Forms.CheckBox();
            this.cofirmSalesRestockCheckBox = new System.Windows.Forms.CheckBox();
            this.restockFromWarehouseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.cancelOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.editOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.accessTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.accessTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp11.sdpDataSetTableAdapters.TableAdapterManager();
            this.restockIndexCheckBox = new System.Windows.Forms.CheckBox();
            accessIDLabel = new System.Windows.Forms.Label();
            accessNameLabel = new System.Windows.Forms.Label();
            removeAccountLabel = new System.Windows.Forms.Label();
            modifyAccountLabel = new System.Windows.Forms.Label();
            addProductLabel = new System.Windows.Forms.Label();
            removeProductLabel = new System.Windows.Forms.Label();
            modifyProductLabel = new System.Windows.Forms.Label();
            addStaffLabel = new System.Windows.Forms.Label();
            removeStaffLabel = new System.Windows.Forms.Label();
            modifyStaffLabel = new System.Windows.Forms.Label();
            detailStaffLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // accessIDLabel
            // 
            accessIDLabel.AutoSize = true;
            accessIDLabel.Location = new System.Drawing.Point(286, 65);
            accessIDLabel.Name = "accessIDLabel";
            accessIDLabel.Size = new System.Drawing.Size(74, 16);
            accessIDLabel.TabIndex = 1;
            accessIDLabel.Text = "Access ID:";
            // 
            // accessNameLabel
            // 
            accessNameLabel.AutoSize = true;
            accessNameLabel.Location = new System.Drawing.Point(264, 108);
            accessNameLabel.Name = "accessNameLabel";
            accessNameLabel.Size = new System.Drawing.Size(97, 16);
            accessNameLabel.TabIndex = 3;
            accessNameLabel.Text = "Access Name:";
            // 
            // removeAccountLabel
            // 
            removeAccountLabel.AutoSize = true;
            removeAccountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            removeAccountLabel.Location = new System.Drawing.Point(8, 94);
            removeAccountLabel.Name = "removeAccountLabel";
            removeAccountLabel.Size = new System.Drawing.Size(109, 16);
            removeAccountLabel.TabIndex = 7;
            removeAccountLabel.Text = "Remove Account:";
            // 
            // modifyAccountLabel
            // 
            modifyAccountLabel.AutoSize = true;
            modifyAccountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modifyAccountLabel.Location = new System.Drawing.Point(16, 129);
            modifyAccountLabel.Name = "modifyAccountLabel";
            modifyAccountLabel.Size = new System.Drawing.Size(101, 16);
            modifyAccountLabel.TabIndex = 9;
            modifyAccountLabel.Text = "Modify Account:";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            addProductLabel.Location = new System.Drawing.Point(28, 47);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new System.Drawing.Size(84, 16);
            addProductLabel.TabIndex = 11;
            addProductLabel.Text = "Add Product:";
            // 
            // removeProductLabel
            // 
            removeProductLabel.AutoSize = true;
            removeProductLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            removeProductLabel.Location = new System.Drawing.Point(6, 87);
            removeProductLabel.Name = "removeProductLabel";
            removeProductLabel.Size = new System.Drawing.Size(107, 16);
            removeProductLabel.TabIndex = 13;
            removeProductLabel.Text = "Remove Product:";
            // 
            // modifyProductLabel
            // 
            modifyProductLabel.AutoSize = true;
            modifyProductLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            modifyProductLabel.Location = new System.Drawing.Point(12, 127);
            modifyProductLabel.Name = "modifyProductLabel";
            modifyProductLabel.Size = new System.Drawing.Size(99, 16);
            modifyProductLabel.TabIndex = 15;
            modifyProductLabel.Text = "Modify Product:";
            // 
            // addStaffLabel
            // 
            addStaffLabel.AutoSize = true;
            addStaffLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            addStaffLabel.Location = new System.Drawing.Point(43, 38);
            addStaffLabel.Name = "addStaffLabel";
            addStaffLabel.Size = new System.Drawing.Size(65, 16);
            addStaffLabel.TabIndex = 17;
            addStaffLabel.Text = "Add Staff:";
            // 
            // removeStaffLabel
            // 
            removeStaffLabel.AutoSize = true;
            removeStaffLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            removeStaffLabel.Location = new System.Drawing.Point(21, 72);
            removeStaffLabel.Name = "removeStaffLabel";
            removeStaffLabel.Size = new System.Drawing.Size(88, 16);
            removeStaffLabel.TabIndex = 19;
            removeStaffLabel.Text = "Remove Staff:";
            // 
            // modifyStaffLabel
            // 
            modifyStaffLabel.AutoSize = true;
            modifyStaffLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            modifyStaffLabel.Location = new System.Drawing.Point(25, 112);
            modifyStaffLabel.Name = "modifyStaffLabel";
            modifyStaffLabel.Size = new System.Drawing.Size(80, 16);
            modifyStaffLabel.TabIndex = 21;
            modifyStaffLabel.Text = "Modify Staff:";
            // 
            // detailStaffLabel
            // 
            detailStaffLabel.AutoSize = true;
            detailStaffLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            detailStaffLabel.Location = new System.Drawing.Point(35, 152);
            detailStaffLabel.Name = "detailStaffLabel";
            detailStaffLabel.Size = new System.Drawing.Size(75, 16);
            detailStaffLabel.TabIndex = 23;
            detailStaffLabel.Text = "Detail Staff:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(removeAccountLabel);
            groupBox1.Controls.Add(this.addAccountLabel);
            groupBox1.Controls.Add(this.modifyAccountCheckBox);
            groupBox1.Controls.Add(this.addAccountCheckBox);
            groupBox1.Controls.Add(modifyAccountLabel);
            groupBox1.Controls.Add(this.removeAccountCheckBox);
            groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(32, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(166, 196);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Control";
            // 
            // addAccountLabel
            // 
            this.addAccountLabel.AutoSize = true;
            this.addAccountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountLabel.Location = new System.Drawing.Point(30, 58);
            this.addAccountLabel.Name = "addAccountLabel";
            this.addAccountLabel.Size = new System.Drawing.Size(86, 16);
            this.addAccountLabel.TabIndex = 5;
            this.addAccountLabel.Text = "Add Account:";
            this.addAccountLabel.Click += new System.EventHandler(this.addAccountLabel_Click);
            // 
            // modifyAccountCheckBox
            // 
            this.modifyAccountCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAccountCheckBox.Location = new System.Drawing.Point(120, 122);
            this.modifyAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyAccountCheckBox.Name = "modifyAccountCheckBox";
            this.modifyAccountCheckBox.Size = new System.Drawing.Size(31, 32);
            this.modifyAccountCheckBox.TabIndex = 10;
            this.modifyAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // addAccountCheckBox
            // 
            this.addAccountCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountCheckBox.Location = new System.Drawing.Point(117, 52);
            this.addAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAccountCheckBox.Name = "addAccountCheckBox";
            this.addAccountCheckBox.Size = new System.Drawing.Size(31, 32);
            this.addAccountCheckBox.TabIndex = 6;
            this.addAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeAccountCheckBox
            // 
            this.removeAccountCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAccountCheckBox.Location = new System.Drawing.Point(120, 87);
            this.removeAccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeAccountCheckBox.Name = "removeAccountCheckBox";
            this.removeAccountCheckBox.Size = new System.Drawing.Size(31, 32);
            this.removeAccountCheckBox.TabIndex = 8;
            this.removeAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessBindingSource, "Payment", true));
            label1.Font = new System.Drawing.Font("Arial", 9.75F);
            label1.Location = new System.Drawing.Point(6, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 16);
            label1.TabIndex = 17;
            label1.Text = "Payment:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 9.75F);
            label4.Location = new System.Drawing.Point(7, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 16);
            label4.TabIndex = 32;
            label4.Text = "Restock from warehouse :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 9.75F);
            label5.Location = new System.Drawing.Point(7, 144);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(144, 16);
            label5.TabIndex = 33;
            label5.Text = "Confirm Restock Order:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 9.75F);
            label6.Location = new System.Drawing.Point(7, 166);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 16);
            label6.TabIndex = 34;
            label6.Text = "Set Danger Levels:";
            // 
            // accessNameTextBox
            // 
            this.accessNameTextBox.Location = new System.Drawing.Point(363, 105);
            this.accessNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accessNameTextBox.Name = "accessNameTextBox";
            this.accessNameTextBox.Size = new System.Drawing.Size(140, 23);
            this.accessNameTextBox.TabIndex = 4;
            // 
            // addProductCheckBox
            // 
            this.addProductCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.addProductCheckBox.Location = new System.Drawing.Point(116, 40);
            this.addProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductCheckBox.Name = "addProductCheckBox";
            this.addProductCheckBox.Size = new System.Drawing.Size(22, 32);
            this.addProductCheckBox.TabIndex = 12;
            this.addProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeProductCheckBox
            // 
            this.removeProductCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.removeProductCheckBox.Location = new System.Drawing.Point(117, 80);
            this.removeProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductCheckBox.Name = "removeProductCheckBox";
            this.removeProductCheckBox.Size = new System.Drawing.Size(22, 32);
            this.removeProductCheckBox.TabIndex = 14;
            this.removeProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyProductCheckBox
            // 
            this.modifyProductCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.modifyProductCheckBox.Location = new System.Drawing.Point(117, 120);
            this.modifyProductCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyProductCheckBox.Name = "modifyProductCheckBox";
            this.modifyProductCheckBox.Size = new System.Drawing.Size(22, 32);
            this.modifyProductCheckBox.TabIndex = 16;
            this.modifyProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // addStaffCheckBox
            // 
            this.addStaffCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffCheckBox.Location = new System.Drawing.Point(119, 31);
            this.addStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addStaffCheckBox.Name = "addStaffCheckBox";
            this.addStaffCheckBox.Size = new System.Drawing.Size(34, 32);
            this.addStaffCheckBox.TabIndex = 18;
            this.addStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeStaffCheckBox
            // 
            this.removeStaffCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStaffCheckBox.Location = new System.Drawing.Point(119, 65);
            this.removeStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeStaffCheckBox.Name = "removeStaffCheckBox";
            this.removeStaffCheckBox.Size = new System.Drawing.Size(18, 32);
            this.removeStaffCheckBox.TabIndex = 20;
            this.removeStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyStaffCheckBox
            // 
            this.modifyStaffCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyStaffCheckBox.Location = new System.Drawing.Point(119, 105);
            this.modifyStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyStaffCheckBox.Name = "modifyStaffCheckBox";
            this.modifyStaffCheckBox.Size = new System.Drawing.Size(34, 32);
            this.modifyStaffCheckBox.TabIndex = 22;
            this.modifyStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // detailStaffCheckBox
            // 
            this.detailStaffCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailStaffCheckBox.Location = new System.Drawing.Point(119, 145);
            this.detailStaffCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailStaffCheckBox.Name = "detailStaffCheckBox";
            this.detailStaffCheckBox.Size = new System.Drawing.Size(34, 32);
            this.detailStaffCheckBox.TabIndex = 24;
            this.detailStaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(removeStaffLabel);
            this.groupBox2.Controls.Add(this.addStaffCheckBox);
            this.groupBox2.Controls.Add(addStaffLabel);
            this.groupBox2.Controls.Add(this.removeStaffCheckBox);
            this.groupBox2.Controls.Add(this.modifyStaffCheckBox);
            this.groupBox2.Controls.Add(modifyStaffLabel);
            this.groupBox2.Controls.Add(this.detailStaffCheckBox);
            this.groupBox2.Controls.Add(detailStaffLabel);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(214, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 196);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(removeProductLabel);
            this.groupBox3.Controls.Add(modifyProductLabel);
            this.groupBox3.Controls.Add(this.modifyProductCheckBox);
            this.groupBox3.Controls.Add(this.addProductCheckBox);
            this.groupBox3.Controls.Add(this.removeProductCheckBox);
            this.groupBox3.Controls.Add(addProductLabel);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(390, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 196);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(this.restockIndexCheckBox);
            this.groupBox4.Controls.Add(label6);
            this.groupBox4.Controls.Add(this.setDangerLevelsSalesCheckBox);
            this.groupBox4.Controls.Add(this.cofirmSalesRestockCheckBox);
            this.groupBox4.Controls.Add(this.restockFromWarehouseCheckBox1);
            this.groupBox4.Controls.Add(label5);
            this.groupBox4.Controls.Add(label4);
            this.groupBox4.Controls.Add(label1);
            this.groupBox4.Controls.Add(this.cancelOrderCheckBox);
            this.groupBox4.Controls.Add(this.editOrderCheckBox);
            this.groupBox4.Controls.Add(this.paymentCheckBox);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Controls.Add(label3);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox4.Location = new System.Drawing.Point(579, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 196);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sales Control";
            // 
            // setDangerLevelsSalesCheckBox
            // 
            this.setDangerLevelsSalesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "SetDangerLevelsSales", true));
            this.setDangerLevelsSalesCheckBox.Location = new System.Drawing.Point(126, 163);
            this.setDangerLevelsSalesCheckBox.Name = "setDangerLevelsSalesCheckBox";
            this.setDangerLevelsSalesCheckBox.Size = new System.Drawing.Size(28, 24);
            this.setDangerLevelsSalesCheckBox.TabIndex = 32;
            this.setDangerLevelsSalesCheckBox.UseVisualStyleBackColor = true;
            // 
            // cofirmSalesRestockCheckBox
            // 
            this.cofirmSalesRestockCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "CofirmSalesRestock", true));
            this.cofirmSalesRestockCheckBox.Location = new System.Drawing.Point(151, 141);
            this.cofirmSalesRestockCheckBox.Name = "cofirmSalesRestockCheckBox";
            this.cofirmSalesRestockCheckBox.Size = new System.Drawing.Size(20, 24);
            this.cofirmSalesRestockCheckBox.TabIndex = 32;
            this.cofirmSalesRestockCheckBox.UseVisualStyleBackColor = true;
            // 
            // restockFromWarehouseCheckBox1
            // 
            this.restockFromWarehouseCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RestockFromWarehouse", true));
            this.restockFromWarehouseCheckBox1.Location = new System.Drawing.Point(169, 120);
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
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
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
            // restockIndexCheckBox
            // 
            this.restockIndexCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accessBindingSource, "RestockIndex", true));
            this.restockIndexCheckBox.Location = new System.Drawing.Point(103, 100);
            this.restockIndexCheckBox.Name = "restockIndexCheckBox";
            this.restockIndexCheckBox.Size = new System.Drawing.Size(28, 24);
            this.restockIndexCheckBox.TabIndex = 31;
            this.restockIndexCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 9.75F);
            label7.Location = new System.Drawing.Point(6, 102);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 16);
            label7.TabIndex = 35;
            label7.Text = "Restock Index:";
            // 
            // frmAddAccessGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(820, 533);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(accessNameLabel);
            this.Controls.Add(this.accessNameTextBox);
            this.Controls.Add(accessIDLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddAccessGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccessGroup";
            this.Load += new System.EventHandler(this.frmAddAccessGroup_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox accessNameTextBox;
        private System.Windows.Forms.CheckBox addAccountCheckBox;
        private System.Windows.Forms.CheckBox removeAccountCheckBox;
        private System.Windows.Forms.CheckBox modifyAccountCheckBox;
        private System.Windows.Forms.CheckBox addProductCheckBox;
        private System.Windows.Forms.CheckBox removeProductCheckBox;
        private System.Windows.Forms.CheckBox modifyProductCheckBox;
        private System.Windows.Forms.CheckBox addStaffCheckBox;
        private System.Windows.Forms.CheckBox removeStaffCheckBox;
        private System.Windows.Forms.CheckBox modifyStaffCheckBox;
        private System.Windows.Forms.CheckBox detailStaffCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addAccountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private sdpDataSetTableAdapters.accessTableAdapter accessTableAdapter;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox setDangerLevelsSalesCheckBox;
        private System.Windows.Forms.CheckBox cofirmSalesRestockCheckBox;
        private System.Windows.Forms.CheckBox restockFromWarehouseCheckBox1;
        private System.Windows.Forms.CheckBox cancelOrderCheckBox;
        private System.Windows.Forms.CheckBox editOrderCheckBox;
        private System.Windows.Forms.CheckBox paymentCheckBox;
        private System.Windows.Forms.CheckBox restockIndexCheckBox;
    }
}