
namespace WindowsFormsApp11
{
    partial class frmAccountManagement
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btuAddAccount = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btuRemoveAccount = new System.Windows.Forms.Button();
            this.btuModifyAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lblTitle1.Location = new System.Drawing.Point(40, 36);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(297, 46);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Better Limited";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btuAddAccount
            // 
            this.btuAddAccount.Location = new System.Drawing.Point(111, 172);
            this.btuAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuAddAccount.Name = "btuAddAccount";
            this.btuAddAccount.Size = new System.Drawing.Size(140, 45);
            this.btuAddAccount.TabIndex = 1;
            this.btuAddAccount.Text = "Add Account";
            this.btuAddAccount.UseVisualStyleBackColor = true;
            this.btuAddAccount.Click += new System.EventHandler(this.btuAddAccount_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lblTitle2.Location = new System.Drawing.Point(47, 57);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(204, 64);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "\nIT Department";
            // 
            // btuRemoveAccount
            // 
            this.btuRemoveAccount.Location = new System.Drawing.Point(111, 241);
            this.btuRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuRemoveAccount.Name = "btuRemoveAccount";
            this.btuRemoveAccount.Size = new System.Drawing.Size(140, 43);
            this.btuRemoveAccount.TabIndex = 3;
            this.btuRemoveAccount.Text = "Remove Account";
            this.btuRemoveAccount.UseVisualStyleBackColor = true;
            this.btuRemoveAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btuModifyAccount
            // 
            this.btuModifyAccount.Location = new System.Drawing.Point(111, 309);
            this.btuModifyAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuModifyAccount.Name = "btuModifyAccount";
            this.btuModifyAccount.Size = new System.Drawing.Size(140, 47);
            this.btuModifyAccount.TabIndex = 4;
            this.btuModifyAccount.Text = "Modify Account";
            this.btuModifyAccount.UseVisualStyleBackColor = true;
            this.btuModifyAccount.Click += new System.EventHandler(this.btuModifyAccount_Click);
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(362, 443);
            this.Controls.Add(this.btuModifyAccount);
            this.Controls.Add(this.btuRemoveAccount);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btuAddAccount);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Department - Better Limited";
            this.Load += new System.EventHandler(this.SystemSecurity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btuAddAccount;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btuRemoveAccount;
        private System.Windows.Forms.Button btuModifyAccount;
    }
}