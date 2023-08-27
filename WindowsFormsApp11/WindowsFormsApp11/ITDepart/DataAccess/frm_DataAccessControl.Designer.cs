
namespace WindowsFormsApp11
{
    partial class frmDataAccessControl
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
            this.btn_AddAccess = new System.Windows.Forms.Button();
            this.btn_RemoveAccess = new System.Windows.Forms.Button();
            this.btn_ModifyAccess = new System.Windows.Forms.Button();
            this.btn_ChangeUserAccessGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddAccess
            // 
            this.btn_AddAccess.Location = new System.Drawing.Point(94, 132);
            this.btn_AddAccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddAccess.Name = "btn_AddAccess";
            this.btn_AddAccess.Size = new System.Drawing.Size(140, 45);
            this.btn_AddAccess.TabIndex = 0;
            this.btn_AddAccess.Text = "Add Access Group";
            this.btn_AddAccess.UseVisualStyleBackColor = true;
            this.btn_AddAccess.Click += new System.EventHandler(this.btn_AddAccess_Click);
            // 
            // btn_RemoveAccess
            // 
            this.btn_RemoveAccess.Location = new System.Drawing.Point(94, 269);
            this.btn_RemoveAccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RemoveAccess.Name = "btn_RemoveAccess";
            this.btn_RemoveAccess.Size = new System.Drawing.Size(140, 45);
            this.btn_RemoveAccess.TabIndex = 1;
            this.btn_RemoveAccess.Text = "Remove Access Group";
            this.btn_RemoveAccess.UseVisualStyleBackColor = true;
            this.btn_RemoveAccess.Click += new System.EventHandler(this.btn_DeleteAccess_Click);
            // 
            // btn_ModifyAccess
            // 
            this.btn_ModifyAccess.Location = new System.Drawing.Point(94, 201);
            this.btn_ModifyAccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyAccess.Name = "btn_ModifyAccess";
            this.btn_ModifyAccess.Size = new System.Drawing.Size(140, 45);
            this.btn_ModifyAccess.TabIndex = 2;
            this.btn_ModifyAccess.Text = "Modify Access Group";
            this.btn_ModifyAccess.UseVisualStyleBackColor = true;
            this.btn_ModifyAccess.Click += new System.EventHandler(this.btn_ModifyAccess_Click);
            // 
            // btn_ChangeUserAccessGroup
            // 
            this.btn_ChangeUserAccessGroup.Location = new System.Drawing.Point(261, 201);
            this.btn_ChangeUserAccessGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ChangeUserAccessGroup.Name = "btn_ChangeUserAccessGroup";
            this.btn_ChangeUserAccessGroup.Size = new System.Drawing.Size(140, 45);
            this.btn_ChangeUserAccessGroup.TabIndex = 3;
            this.btn_ChangeUserAccessGroup.Text = "Change User Access Group";
            this.btn_ChangeUserAccessGroup.UseVisualStyleBackColor = true;
            this.btn_ChangeUserAccessGroup.Click += new System.EventHandler(this.btn_ChangeUserAccessGroup_Click);
            // 
            // frmDataAccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(483, 448);
            this.Controls.Add(this.btn_ChangeUserAccessGroup);
            this.Controls.Add(this.btn_ModifyAccess);
            this.Controls.Add(this.btn_RemoveAccess);
            this.Controls.Add(this.btn_AddAccess);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDataAccessControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Access Control - Better Limited";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddAccess;
        private System.Windows.Forms.Button btn_RemoveAccess;
        private System.Windows.Forms.Button btn_ModifyAccess;
        private System.Windows.Forms.Button btn_ChangeUserAccessGroup;
    }
}