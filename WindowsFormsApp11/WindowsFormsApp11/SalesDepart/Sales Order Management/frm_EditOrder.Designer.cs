
namespace WindowsFormsApp11.SalesDepart.Sales_Order_Management
{
    partial class frm_EditOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_Install = new System.Windows.Forms.CheckBox();
            this.cbo_DeliverySession = new System.Windows.Forms.ComboBox();
            this.lbl_DeliverySession = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_EditOrder = new System.Windows.Forms.Label();
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.txt_CusAddress = new System.Windows.Forms.RichTextBox();
            this.lbl_CusAddress = new System.Windows.Forms.Label();
            this.lbl_Install = new System.Windows.Forms.Label();
            this.txt_CusPhone = new System.Windows.Forms.TextBox();
            this.lbl_CusPhone = new System.Windows.Forms.Label();
            this.lbl_dDate = new System.Windows.Forms.Label();
            this.dtp_dDate = new System.Windows.Forms.DateTimePicker();
            this.cbo_dMethod = new System.Windows.Forms.ComboBox();
            this.lbl_DeliveryMethod = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Move.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckb_Install);
            this.panel1.Controls.Add(this.cbo_DeliverySession);
            this.panel1.Controls.Add(this.lbl_DeliverySession);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.lbl_EditOrder);
            this.panel1.Controls.Add(this.lbl_OrderID);
            this.panel1.Controls.Add(this.txt_CusAddress);
            this.panel1.Controls.Add(this.lbl_CusAddress);
            this.panel1.Controls.Add(this.lbl_Install);
            this.panel1.Controls.Add(this.txt_CusPhone);
            this.panel1.Controls.Add(this.lbl_CusPhone);
            this.panel1.Controls.Add(this.lbl_dDate);
            this.panel1.Controls.Add(this.dtp_dDate);
            this.panel1.Controls.Add(this.cbo_dMethod);
            this.panel1.Controls.Add(this.lbl_DeliveryMethod);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.txt_CusName);
            this.panel1.Controls.Add(this.pnl_Move);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 477);
            this.panel1.TabIndex = 1;
            // 
            // ckb_Install
            // 
            this.ckb_Install.AutoSize = true;
            this.ckb_Install.Location = new System.Drawing.Point(364, 267);
            this.ckb_Install.Name = "ckb_Install";
            this.ckb_Install.Size = new System.Drawing.Size(15, 14);
            this.ckb_Install.TabIndex = 52;
            this.ckb_Install.UseVisualStyleBackColor = true;
            this.ckb_Install.Visible = false;
            // 
            // cbo_DeliverySession
            // 
            this.cbo_DeliverySession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.cbo_DeliverySession.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo_DeliverySession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DeliverySession.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DeliverySession.FormattingEnabled = true;
            this.cbo_DeliverySession.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbo_DeliverySession.Location = new System.Drawing.Point(194, 195);
            this.cbo_DeliverySession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_DeliverySession.Name = "cbo_DeliverySession";
            this.cbo_DeliverySession.Size = new System.Drawing.Size(185, 23);
            this.cbo_DeliverySession.TabIndex = 51;
            this.cbo_DeliverySession.Visible = false;
            // 
            // lbl_DeliverySession
            // 
            this.lbl_DeliverySession.AutoSize = true;
            this.lbl_DeliverySession.Location = new System.Drawing.Point(36, 198);
            this.lbl_DeliverySession.Name = "lbl_DeliverySession";
            this.lbl_DeliverySession.Size = new System.Drawing.Size(121, 16);
            this.lbl_DeliverySession.TabIndex = 50;
            this.lbl_DeliverySession.Text = "Delivery Session :";
            this.lbl_DeliverySession.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Location = new System.Drawing.Point(311, 409);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(87, 31);
            this.btn_Confirm.TabIndex = 49;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_EditOrder
            // 
            this.lbl_EditOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_EditOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditOrder.Location = new System.Drawing.Point(0, 37);
            this.lbl_EditOrder.Name = "lbl_EditOrder";
            this.lbl_EditOrder.Size = new System.Drawing.Size(433, 24);
            this.lbl_EditOrder.TabIndex = 44;
            this.lbl_EditOrder.Text = "Edit Order";
            this.lbl_EditOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderID.Location = new System.Drawing.Point(33, 73);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(105, 18);
            this.lbl_OrderID.TabIndex = 43;
            this.lbl_OrderID.Text = "Order Detail";
            this.lbl_OrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CusAddress
            // 
            this.txt_CusAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.txt_CusAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CusAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusAddress.Location = new System.Drawing.Point(136, 294);
            this.txt_CusAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CusAddress.Name = "txt_CusAddress";
            this.txt_CusAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txt_CusAddress.Size = new System.Drawing.Size(242, 52);
            this.txt_CusAddress.TabIndex = 42;
            this.txt_CusAddress.Text = "";
            this.txt_CusAddress.Visible = false;
            // 
            // lbl_CusAddress
            // 
            this.lbl_CusAddress.AutoSize = true;
            this.lbl_CusAddress.Location = new System.Drawing.Point(36, 295);
            this.lbl_CusAddress.Name = "lbl_CusAddress";
            this.lbl_CusAddress.Size = new System.Drawing.Size(68, 16);
            this.lbl_CusAddress.TabIndex = 41;
            this.lbl_CusAddress.Text = "Address :";
            this.lbl_CusAddress.Visible = false;
            // 
            // lbl_Install
            // 
            this.lbl_Install.AutoSize = true;
            this.lbl_Install.Location = new System.Drawing.Point(36, 265);
            this.lbl_Install.Name = "lbl_Install";
            this.lbl_Install.Size = new System.Drawing.Size(83, 16);
            this.lbl_Install.TabIndex = 39;
            this.lbl_Install.Text = "Installation :";
            this.lbl_Install.Visible = false;
            // 
            // txt_CusPhone
            // 
            this.txt_CusPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.txt_CusPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusPhone.Location = new System.Drawing.Point(282, 132);
            this.txt_CusPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CusPhone.Name = "txt_CusPhone";
            this.txt_CusPhone.Size = new System.Drawing.Size(97, 21);
            this.txt_CusPhone.TabIndex = 38;
            // 
            // lbl_CusPhone
            // 
            this.lbl_CusPhone.AutoSize = true;
            this.lbl_CusPhone.Location = new System.Drawing.Point(36, 134);
            this.lbl_CusPhone.Name = "lbl_CusPhone";
            this.lbl_CusPhone.Size = new System.Drawing.Size(57, 16);
            this.lbl_CusPhone.TabIndex = 37;
            this.lbl_CusPhone.Text = "Phone :";
            // 
            // lbl_dDate
            // 
            this.lbl_dDate.AutoSize = true;
            this.lbl_dDate.Location = new System.Drawing.Point(36, 232);
            this.lbl_dDate.Name = "lbl_dDate";
            this.lbl_dDate.Size = new System.Drawing.Size(101, 16);
            this.lbl_dDate.TabIndex = 36;
            this.lbl_dDate.Text = "Delivery Date :";
            this.lbl_dDate.Visible = false;
            // 
            // dtp_dDate
            // 
            this.dtp_dDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.dtp_dDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.dtp_dDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_dDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.dtp_dDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.dtp_dDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_dDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_dDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dDate.Location = new System.Drawing.Point(239, 230);
            this.dtp_dDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_dDate.Name = "dtp_dDate";
            this.dtp_dDate.Size = new System.Drawing.Size(139, 21);
            this.dtp_dDate.TabIndex = 35;
            this.dtp_dDate.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.dtp_dDate.Visible = false;
            // 
            // cbo_dMethod
            // 
            this.cbo_dMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.cbo_dMethod.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo_dMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dMethod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dMethod.FormattingEnabled = true;
            this.cbo_dMethod.Items.AddRange(new object[] {
            "Self_Service",
            "Local Shipping",
            "Cross-border Shipping"});
            this.cbo_dMethod.Location = new System.Drawing.Point(194, 162);
            this.cbo_dMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_dMethod.Name = "cbo_dMethod";
            this.cbo_dMethod.Size = new System.Drawing.Size(185, 23);
            this.cbo_dMethod.TabIndex = 34;
            this.cbo_dMethod.TextChanged += new System.EventHandler(this.cob_dMethod_TextChanged);
            // 
            // lbl_DeliveryMethod
            // 
            this.lbl_DeliveryMethod.AutoSize = true;
            this.lbl_DeliveryMethod.Location = new System.Drawing.Point(36, 164);
            this.lbl_DeliveryMethod.Name = "lbl_DeliveryMethod";
            this.lbl_DeliveryMethod.Size = new System.Drawing.Size(118, 16);
            this.lbl_DeliveryMethod.TabIndex = 33;
            this.lbl_DeliveryMethod.Text = "Delivery Method :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_Name.Location = new System.Drawing.Point(36, 105);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(52, 16);
            this.lbl_Name.TabIndex = 32;
            this.lbl_Name.Text = "Name :";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CusName
            // 
            this.txt_CusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.txt_CusName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusName.Location = new System.Drawing.Point(120, 103);
            this.txt_CusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(259, 21);
            this.txt_CusName.TabIndex = 31;
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.pnl_Move.Controls.Add(this.btn_Exit);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(0, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(433, 37);
            this.pnl_Move.TabIndex = 4;
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            this.pnl_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseMove);
            this.pnl_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btn_Exit.Location = new System.Drawing.Point(409, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "x";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(435, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_EditOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Move.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckb_Install;
        private System.Windows.Forms.ComboBox cbo_DeliverySession;
        private System.Windows.Forms.Label lbl_DeliverySession;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_EditOrder;
        private System.Windows.Forms.Label lbl_OrderID;
        private System.Windows.Forms.RichTextBox txt_CusAddress;
        private System.Windows.Forms.Label lbl_CusAddress;
        private System.Windows.Forms.Label lbl_Install;
        private System.Windows.Forms.TextBox txt_CusPhone;
        private System.Windows.Forms.Label lbl_CusPhone;
        private System.Windows.Forms.Label lbl_dDate;
        private System.Windows.Forms.DateTimePicker dtp_dDate;
        private System.Windows.Forms.ComboBox cbo_dMethod;
        private System.Windows.Forms.Label lbl_DeliveryMethod;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Button btn_Exit;
    }
}