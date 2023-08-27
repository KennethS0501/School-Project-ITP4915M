
namespace WindowsFormsApp11.InventoryDepart
{
    partial class frm_DeliveryManagement
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
            this.btn_ArrangeDeliveryMan = new System.Windows.Forms.Button();
            this.btn_UpdateDeliveryMan = new System.Windows.Forms.Button();
            this.btn_TrackDeliveryService = new System.Windows.Forms.Button();
            this.btn_DeliveryListGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ArrangeDeliveryMan
            // 
            this.btn_ArrangeDeliveryMan.Location = new System.Drawing.Point(278, 165);
            this.btn_ArrangeDeliveryMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ArrangeDeliveryMan.Name = "btn_ArrangeDeliveryMan";
            this.btn_ArrangeDeliveryMan.Size = new System.Drawing.Size(115, 63);
            this.btn_ArrangeDeliveryMan.TabIndex = 0;
            this.btn_ArrangeDeliveryMan.Text = "Arrange\r\nDelivery Service";
            this.btn_ArrangeDeliveryMan.UseVisualStyleBackColor = true;
            this.btn_ArrangeDeliveryMan.Click += new System.EventHandler(this.btn_ArrangeDeliveryMan_Click);
            // 
            // btn_UpdateDeliveryMan
            // 
            this.btn_UpdateDeliveryMan.Location = new System.Drawing.Point(278, 275);
            this.btn_UpdateDeliveryMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_UpdateDeliveryMan.Name = "btn_UpdateDeliveryMan";
            this.btn_UpdateDeliveryMan.Size = new System.Drawing.Size(115, 63);
            this.btn_UpdateDeliveryMan.TabIndex = 1;
            this.btn_UpdateDeliveryMan.Text = "Update\r\nDelivery Service";
            this.btn_UpdateDeliveryMan.UseVisualStyleBackColor = true;
            this.btn_UpdateDeliveryMan.Click += new System.EventHandler(this.btn_UpdateDeliveryMan_Click);
            // 
            // btn_TrackDeliveryService
            // 
            this.btn_TrackDeliveryService.Location = new System.Drawing.Point(278, 387);
            this.btn_TrackDeliveryService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TrackDeliveryService.Name = "btn_TrackDeliveryService";
            this.btn_TrackDeliveryService.Size = new System.Drawing.Size(115, 63);
            this.btn_TrackDeliveryService.TabIndex = 2;
            this.btn_TrackDeliveryService.Text = "Track\r\nDelivery service";
            this.btn_TrackDeliveryService.UseVisualStyleBackColor = true;
            this.btn_TrackDeliveryService.Click += new System.EventHandler(this.btn_TrackDeliveryService_Click);
            // 
            // btn_DeliveryListGen
            // 
            this.btn_DeliveryListGen.Location = new System.Drawing.Point(478, 275);
            this.btn_DeliveryListGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeliveryListGen.Name = "btn_DeliveryListGen";
            this.btn_DeliveryListGen.Size = new System.Drawing.Size(115, 63);
            this.btn_DeliveryListGen.TabIndex = 3;
            this.btn_DeliveryListGen.Text = "Delivery List Generater";
            this.btn_DeliveryListGen.UseVisualStyleBackColor = true;
            this.btn_DeliveryListGen.Click += new System.EventHandler(this.btn_DeliveryListGen_Click);
            // 
            // frm_DeliveryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.btn_DeliveryListGen);
            this.Controls.Add(this.btn_TrackDeliveryService);
            this.Controls.Add(this.btn_UpdateDeliveryMan);
            this.Controls.Add(this.btn_ArrangeDeliveryMan);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DeliveryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DeliveryManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ArrangeDeliveryMan;
        private System.Windows.Forms.Button btn_UpdateDeliveryMan;
        private System.Windows.Forms.Button btn_TrackDeliveryService;
        private System.Windows.Forms.Button btn_DeliveryListGen;
    }
}