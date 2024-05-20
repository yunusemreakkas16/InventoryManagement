namespace InventoryManagement
{
    partial class MainPanelForm
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

        private void InitializeComponent()
        {
            this.MaintenanceButton = new System.Windows.Forms.Button();
            this.AssigmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GetAuthenticatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaintenanceButton
            // 
            this.MaintenanceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MaintenanceButton.Location = new System.Drawing.Point(590, 400);
            this.MaintenanceButton.Name = "MaintenanceButton";
            this.MaintenanceButton.Size = new System.Drawing.Size(100, 50);
            this.MaintenanceButton.TabIndex = 1;
            this.MaintenanceButton.Text = "Maintenance";
            this.MaintenanceButton.UseVisualStyleBackColor = false;
            this.MaintenanceButton.Click += new System.EventHandler(this.MaintenanceButton_Click);
            // 
            // AssigmentButton
            // 
            this.AssigmentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AssigmentButton.Location = new System.Drawing.Point(590, 220);
            this.AssigmentButton.Name = "AssigmentButton";
            this.AssigmentButton.Size = new System.Drawing.Size(100, 50);
            this.AssigmentButton.TabIndex = 0;
            this.AssigmentButton.Text = "Assigment";
            this.AssigmentButton.UseVisualStyleBackColor = false;
            this.AssigmentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Personnel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GetAuthenticatebutton
            // 
            this.GetAuthenticatebutton.Location = new System.Drawing.Point(1132, 12);
            this.GetAuthenticatebutton.Name = "GetAuthenticatebutton";
            this.GetAuthenticatebutton.Size = new System.Drawing.Size(120, 25);
            this.GetAuthenticatebutton.TabIndex = 4;
            this.GetAuthenticatebutton.Text = "Get Authenticate";
            this.GetAuthenticatebutton.UseVisualStyleBackColor = true;
            this.GetAuthenticatebutton.Click += new System.EventHandler(this.GetAuthenticatebutton_Click);
            // 
            // MainPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GetAuthenticatebutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaintenanceButton);
            this.Controls.Add(this.AssigmentButton);
            this.MaximizeBox = false;
            this.Name = "MainPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MaintenanceButton;
        private System.Windows.Forms.Button AssigmentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GetAuthenticatebutton;
    }
}

