
namespace WindowsFormsApp11.SalesDepart.Restock_From_Warehouse
{
    partial class frm_RestockIndex
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
            this.btnSetdangerlevels = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ConfirmOrder = new System.Windows.Forms.Button();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.lblNumOfLowLevelProduct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowLow_LevelProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetdangerlevels
            // 
            this.btnSetdangerlevels.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetdangerlevels.Location = new System.Drawing.Point(9, 40);
            this.btnSetdangerlevels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetdangerlevels.Name = "btnSetdangerlevels";
            this.btnSetdangerlevels.Size = new System.Drawing.Size(147, 36);
            this.btnSetdangerlevels.TabIndex = 31;
            this.btnSetdangerlevels.Text = "Set danger levels";
            this.btnSetdangerlevels.UseVisualStyleBackColor = true;
            this.btnSetdangerlevels.Click += new System.EventHandler(this.btnSetdangerlevels_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowLow_LevelProduct);
            this.groupBox1.Controls.Add(this.btn_ConfirmOrder);
            this.groupBox1.Controls.Add(this.btn_CreateOrder);
            this.groupBox1.Controls.Add(this.lblNumOfLowLevelProduct);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSetdangerlevels);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(166, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(321, 240);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Recording";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_ConfirmOrder
            // 
            this.btn_ConfirmOrder.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btn_ConfirmOrder.Location = new System.Drawing.Point(162, 89);
            this.btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            this.btn_ConfirmOrder.Size = new System.Drawing.Size(153, 41);
            this.btn_ConfirmOrder.TabIndex = 42;
            this.btn_ConfirmOrder.Text = "Confirm Restock Order";
            this.btn_ConfirmOrder.UseVisualStyleBackColor = true;
            this.btn_ConfirmOrder.Click += new System.EventHandler(this.btn_ConfirmOrder_Click);
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btn_CreateOrder.Location = new System.Drawing.Point(10, 89);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.Size = new System.Drawing.Size(146, 41);
            this.btn_CreateOrder.TabIndex = 41;
            this.btn_CreateOrder.Text = "Create Restock Order";
            this.btn_CreateOrder.UseVisualStyleBackColor = true;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
            // 
            // lblNumOfLowLevelProduct
            // 
            this.lblNumOfLowLevelProduct.AutoSize = true;
            this.lblNumOfLowLevelProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfLowLevelProduct.Location = new System.Drawing.Point(222, 156);
            this.lblNumOfLowLevelProduct.Name = "lblNumOfLowLevelProduct";
            this.lblNumOfLowLevelProduct.Size = new System.Drawing.Size(0, 20);
            this.lblNumOfLowLevelProduct.TabIndex = 34;
            this.lblNumOfLowLevelProduct.Click += new System.EventHandler(this.lblNumOfLowLevelProduct_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 8F);
            this.button1.Location = new System.Drawing.Point(7, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Low level product alert:";
            // 
            // btnShowLow_LevelProduct
            // 
            this.btnShowLow_LevelProduct.Font = new System.Drawing.Font("新細明體", 8F);
            this.btnShowLow_LevelProduct.Location = new System.Drawing.Point(111, 188);
            this.btnShowLow_LevelProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowLow_LevelProduct.Name = "btnShowLow_LevelProduct";
            this.btnShowLow_LevelProduct.Size = new System.Drawing.Size(143, 32);
            this.btnShowLow_LevelProduct.TabIndex = 43;
            this.btnShowLow_LevelProduct.Text = "Show low-level product";
            this.btnShowLow_LevelProduct.UseVisualStyleBackColor = true;
            this.btnShowLow_LevelProduct.Click += new System.EventHandler(this.btnShowLow_LevelProduct_Click_1);
            // 
            // frm_RestockIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(702, 438);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_RestockIndex";
            this.Text = "Inventory department - Better Limited";
            this.Load += new System.EventHandler(this.frmInventoryIndex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSetdangerlevels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumOfLowLevelProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ConfirmOrder;
        private System.Windows.Forms.Button btn_CreateOrder;
        private System.Windows.Forms.Button btnShowLow_LevelProduct;
    }
}