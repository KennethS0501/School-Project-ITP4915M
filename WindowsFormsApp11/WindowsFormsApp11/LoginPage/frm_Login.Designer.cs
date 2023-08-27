
namespace SDP
{
    partial class frm_Login
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
            this.lbl_PW = new System.Windows.Forms.Label();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_StaffID = new System.Windows.Forms.Label();
            this.txt_StaffID = new System.Windows.Forms.TextBox();
            this.lbl_BetterLimited = new System.Windows.Forms.Label();
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btu_forgetPassword = new System.Windows.Forms.Button();
            this.pnl_Move.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PW
            // 
            this.lbl_PW.AllowDrop = true;
            this.lbl_PW.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_PW.Location = new System.Drawing.Point(250, 294);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(153, 22);
            this.lbl_PW.TabIndex = 4;
            this.lbl_PW.Text = "Your Password:";
            // 
            // txt_PW
            // 
            this.txt_PW.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PW.Location = new System.Drawing.Point(409, 290);
            this.txt_PW.Margin = new System.Windows.Forms.Padding(0);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(252, 29);
            this.txt_PW.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Lavender;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(399, 387);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 29);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_StaffID
            // 
            this.lbl_StaffID.AllowDrop = true;
            this.lbl_StaffID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_StaffID.Location = new System.Drawing.Point(261, 230);
            this.lbl_StaffID.Name = "lbl_StaffID";
            this.lbl_StaffID.Size = new System.Drawing.Size(131, 22);
            this.lbl_StaffID.TabIndex = 0;
            this.lbl_StaffID.Text = "Your Staff ID:";
            // 
            // txt_StaffID
            // 
            this.txt_StaffID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StaffID.Location = new System.Drawing.Point(409, 226);
            this.txt_StaffID.Margin = new System.Windows.Forms.Padding(0);
            this.txt_StaffID.Name = "txt_StaffID";
            this.txt_StaffID.Size = new System.Drawing.Size(252, 29);
            this.txt_StaffID.TabIndex = 2;
            // 
            // lbl_BetterLimited
            // 
            this.lbl_BetterLimited.AllowDrop = true;
            this.lbl_BetterLimited.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BetterLimited.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BetterLimited.Location = new System.Drawing.Point(-1, 77);
            this.lbl_BetterLimited.Name = "lbl_BetterLimited";
            this.lbl_BetterLimited.Size = new System.Drawing.Size(935, 82);
            this.lbl_BetterLimited.TabIndex = 5;
            this.lbl_BetterLimited.Text = "Better Limited";
            this.lbl_BetterLimited.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnl_Move.Controls.Add(this.btn_Close);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(0, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(933, 25);
            this.pnl_Move.TabIndex = 8;
            this.pnl_Move.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Move_Paint);
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            this.pnl_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseMove);
            this.pnl_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Close.Location = new System.Drawing.Point(898, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "x";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.btn_changePassword);
            this.pnl_Main.Controls.Add(this.btu_forgetPassword);
            this.pnl_Main.Controls.Add(this.pnl_Move);
            this.pnl_Main.Controls.Add(this.lbl_BetterLimited);
            this.pnl_Main.Controls.Add(this.txt_StaffID);
            this.pnl_Main.Controls.Add(this.lbl_StaffID);
            this.pnl_Main.Controls.Add(this.btn_Login);
            this.pnl_Main.Controls.Add(this.txt_PW);
            this.pnl_Main.Controls.Add(this.lbl_PW);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(935, 577);
            this.pnl_Main.TabIndex = 8;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.BackColor = System.Drawing.Color.Lavender;
            this.btn_changePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePassword.FlatAppearance.BorderSize = 0;
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.Location = new System.Drawing.Point(498, 466);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(107, 45);
            this.btn_changePassword.TabIndex = 10;
            this.btn_changePassword.Text = "Change password";
            this.btn_changePassword.UseVisualStyleBackColor = false;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btu_forgetPassword
            // 
            this.btu_forgetPassword.BackColor = System.Drawing.Color.Lavender;
            this.btu_forgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btu_forgetPassword.FlatAppearance.BorderSize = 0;
            this.btu_forgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btu_forgetPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btu_forgetPassword.Location = new System.Drawing.Point(314, 466);
            this.btu_forgetPassword.Name = "btu_forgetPassword";
            this.btu_forgetPassword.Size = new System.Drawing.Size(107, 45);
            this.btu_forgetPassword.TabIndex = 9;
            this.btu_forgetPassword.Text = "Forgot password";
            this.btu_forgetPassword.UseVisualStyleBackColor = false;
            this.btu_forgetPassword.Click += new System.EventHandler(this.frm_forgotPassword_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(935, 577);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_Move.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_StaffID;
        private System.Windows.Forms.TextBox txt_StaffID;
        private System.Windows.Forms.Label lbl_BetterLimited;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btu_forgetPassword;
        private System.Windows.Forms.Button btn_changePassword;
    }
}

