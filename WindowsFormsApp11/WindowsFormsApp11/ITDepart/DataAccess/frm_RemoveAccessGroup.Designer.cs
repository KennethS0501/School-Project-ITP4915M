
namespace WindowsFormsApp11.ITDepart.DataAccess
{
    partial class frm_RemoveAccessGroup
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
            this.cbo_AccessID = new System.Windows.Forms.ComboBox();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new WindowsFormsApp11.sdpDataSet();
            this.accessTableAdapter = new WindowsFormsApp11.sdpDataSetTableAdapters.accessTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            accessIDLabel = new System.Windows.Forms.Label();
            accessNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // accessIDLabel
            // 
            accessIDLabel.AutoSize = true;
            accessIDLabel.Location = new System.Drawing.Point(100, 103);
            accessIDLabel.Name = "accessIDLabel";
            accessIDLabel.Size = new System.Drawing.Size(74, 16);
            accessIDLabel.TabIndex = 3;
            accessIDLabel.Text = "Access ID:";
            // 
            // accessNameLabel
            // 
            accessNameLabel.AutoSize = true;
            accessNameLabel.Location = new System.Drawing.Point(83, 153);
            accessNameLabel.Name = "accessNameLabel";
            accessNameLabel.Size = new System.Drawing.Size(97, 16);
            accessNameLabel.TabIndex = 5;
            accessNameLabel.Text = "Access Name:";
            // 
            // cbo_AccessID
            // 
            this.cbo_AccessID.DataSource = this.accessBindingSource;
            this.cbo_AccessID.DisplayMember = "AccessID";
            this.cbo_AccessID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_AccessID.FormattingEnabled = true;
            this.cbo_AccessID.Location = new System.Drawing.Point(180, 100);
            this.cbo_AccessID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_AccessID.Name = "cbo_AccessID";
            this.cbo_AccessID.Size = new System.Drawing.Size(140, 24);
            this.cbo_AccessID.TabIndex = 0;
            this.cbo_AccessID.ValueMember = "AccessID";
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
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.accessBindingSource;
            this.comboBox2.DisplayMember = "AccessName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 150);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "AccessName";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(132, 213);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(87, 31);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // frm_RemoveAccessGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(accessNameLabel);
            this.Controls.Add(accessIDLabel);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cbo_AccessID);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_RemoveAccessGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_RemoveAccessGroup";
            this.Load += new System.EventHandler(this.frm_RemoveAccessGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_AccessID;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private sdpDataSetTableAdapters.accessTableAdapter accessTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_Remove;
    }
}