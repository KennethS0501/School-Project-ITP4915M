
namespace WindowsFormsApp11.LoginPage
{
    partial class frm_forgotPassword
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.date_hire = new System.Windows.Forms.DateTimePicker();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_BetterLimited = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_StaffID = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_PW = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Move.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.date_hire);
            this.pnl_Main.Controls.Add(this.date_birth);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.button1);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.lbl_BetterLimited);
            this.pnl_Main.Controls.Add(this.txt_LastName);
            this.pnl_Main.Controls.Add(this.lbl_StaffID);
            this.pnl_Main.Controls.Add(this.btn_Submit);
            this.pnl_Main.Controls.Add(this.lbl_PW);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(378, 515);
            this.pnl_Main.TabIndex = 10;
            // 
            // date_hire
            // 
            this.date_hire.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.date_hire.Location = new System.Drawing.Point(189, 251);
            this.date_hire.Name = "date_hire";
            this.date_hire.Size = new System.Drawing.Size(143, 29);
            this.date_hire.TabIndex = 12;
            this.date_hire.Value = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            // 
            // date_birth
            // 
            this.date_birth.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.date_birth.Location = new System.Drawing.Point(189, 211);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(143, 29);
            this.date_birth.TabIndex = 11;
            this.date_birth.Value = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Hire Date:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pnl_Move);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 25);
            this.panel1.TabIndex = 8;
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnl_Move.Controls.Add(this.button3);
            this.pnl_Move.Controls.Add(this.button2);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(0, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(376, 25);
            this.pnl_Move.TabIndex = 9;
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            this.pnl_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseMove);
            this.pnl_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseUp);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(348, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 1;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(898, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_BetterLimited
            // 
            this.lbl_BetterLimited.AllowDrop = true;
            this.lbl_BetterLimited.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BetterLimited.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BetterLimited.Location = new System.Drawing.Point(3, 52);
            this.lbl_BetterLimited.Name = "lbl_BetterLimited";
            this.lbl_BetterLimited.Size = new System.Drawing.Size(370, 82);
            this.lbl_BetterLimited.TabIndex = 5;
            this.lbl_BetterLimited.Text = "Better Limited";
            this.lbl_BetterLimited.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(189, 171);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(0);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(143, 29);
            this.txt_LastName.TabIndex = 2;
            // 
            // lbl_StaffID
            // 
            this.lbl_StaffID.AllowDrop = true;
            this.lbl_StaffID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_StaffID.Location = new System.Drawing.Point(26, 174);
            this.lbl_StaffID.Name = "lbl_StaffID";
            this.lbl_StaffID.Size = new System.Drawing.Size(160, 22);
            this.lbl_StaffID.TabIndex = 0;
            this.lbl_StaffID.Text = "Your Last Name:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Lavender;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(135, 336);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(107, 29);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_PW
            // 
            this.lbl_PW.AllowDrop = true;
            this.lbl_PW.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_PW.Location = new System.Drawing.Point(26, 213);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(157, 22);
            this.lbl_PW.TabIndex = 4;
            this.lbl_PW.Text = "Your Birth Date:";
            // 
            // frm_forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(378, 515);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_forgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_forgotPassword";
            this.Load += new System.EventHandler(this.frm_forgotPassword_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_Move.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_BetterLimited;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_StaffID;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_hire;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Button button2;
    }
}