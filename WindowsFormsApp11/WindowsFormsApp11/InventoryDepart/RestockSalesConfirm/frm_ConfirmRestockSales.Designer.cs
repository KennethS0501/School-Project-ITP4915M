
namespace WindowsFormsApp11.InventoryDepart.RestockSalesConfirm
{
    partial class frm_ConfirmRestockSales
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
            System.Windows.Forms.Label dateLabel;
            this.cbo_Date = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Date
            // 
            this.cbo_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Date.FormattingEnabled = true;
            this.cbo_Date.Location = new System.Drawing.Point(98, 26);
            this.cbo_Date.Name = "cbo_Date";
            this.cbo_Date.Size = new System.Drawing.Size(163, 20);
            this.cbo_Date.TabIndex = 7;
            this.cbo_Date.SelectedIndexChanged += new System.EventHandler(this.cbo_Date_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 378);
            this.dataGridView1.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            dateLabel.Location = new System.Drawing.Point(26, 29);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(66, 12);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date Time:";
            // 
            // frm_ConfirmRestockSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(959, 558);
            this.Controls.Add(this.cbo_Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ConfirmRestockSales";
            this.Text = "frm_ConfirmRestockSales";
            this.Load += new System.EventHandler(this.frm_ConfirmRestockSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Date;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}