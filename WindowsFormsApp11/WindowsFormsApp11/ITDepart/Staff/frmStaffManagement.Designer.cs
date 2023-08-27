
namespace WindowsFormsApp11.ITdepart.Staff
{
    partial class frmStaffManagement
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
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btuModifyStaff = new System.Windows.Forms.Button();
            this.btuRemoveStaff = new System.Windows.Forms.Button();
            this.btuAddStaff = new System.Windows.Forms.Button();
            this.btuDetailofStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lblTitle1.Location = new System.Drawing.Point(45, 55);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(269, 44);
            this.lblTitle1.TabIndex = 3;
            this.lblTitle1.Text = "Better Limited";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.lblTitle2.Location = new System.Drawing.Point(50, 101);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(203, 25);
            this.lblTitle2.TabIndex = 4;
            this.lblTitle2.Text = "Staff Management";
            // 
            // btuModifyStaff
            // 
            this.btuModifyStaff.Location = new System.Drawing.Point(115, 307);
            this.btuModifyStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuModifyStaff.Name = "btuModifyStaff";
            this.btuModifyStaff.Size = new System.Drawing.Size(140, 47);
            this.btuModifyStaff.TabIndex = 7;
            this.btuModifyStaff.Text = "Modify Staff";
            this.btuModifyStaff.UseVisualStyleBackColor = true;
            this.btuModifyStaff.Click += new System.EventHandler(this.btuModifyStaff_Click);
            // 
            // btuRemoveStaff
            // 
            this.btuRemoveStaff.Location = new System.Drawing.Point(115, 240);
            this.btuRemoveStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuRemoveStaff.Name = "btuRemoveStaff";
            this.btuRemoveStaff.Size = new System.Drawing.Size(140, 43);
            this.btuRemoveStaff.TabIndex = 6;
            this.btuRemoveStaff.Text = "Remove Staff";
            this.btuRemoveStaff.UseVisualStyleBackColor = true;
            this.btuRemoveStaff.Click += new System.EventHandler(this.btuRemoveStaff_Click);
            // 
            // btuAddStaff
            // 
            this.btuAddStaff.Location = new System.Drawing.Point(115, 167);
            this.btuAddStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuAddStaff.Name = "btuAddStaff";
            this.btuAddStaff.Size = new System.Drawing.Size(140, 45);
            this.btuAddStaff.TabIndex = 5;
            this.btuAddStaff.Text = "Add Staff";
            this.btuAddStaff.UseVisualStyleBackColor = true;
            this.btuAddStaff.Click += new System.EventHandler(this.btuAddAccount_Click);
            // 
            // btuDetailofStaff
            // 
            this.btuDetailofStaff.Location = new System.Drawing.Point(113, 377);
            this.btuDetailofStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btuDetailofStaff.Name = "btuDetailofStaff";
            this.btuDetailofStaff.Size = new System.Drawing.Size(140, 47);
            this.btuDetailofStaff.TabIndex = 8;
            this.btuDetailofStaff.Text = "Detail Of Staff";
            this.btuDetailofStaff.UseVisualStyleBackColor = true;
            this.btuDetailofStaff.Click += new System.EventHandler(this.btuDetailofStaff_Click);
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(365, 460);
            this.Controls.Add(this.btuDetailofStaff);
            this.Controls.Add(this.btuModifyStaff);
            this.Controls.Add(this.btuRemoveStaff);
            this.Controls.Add(this.btuAddStaff);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblTitle2);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management - Better Limited";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btuModifyStaff;
        private System.Windows.Forms.Button btuRemoveStaff;
        private System.Windows.Forms.Button btuAddStaff;
        private System.Windows.Forms.Button btuDetailofStaff;
    }
}