namespace InventoryManagement
{
    partial class GetAuthenticateForm
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
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.GetRolebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(225, 150);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(150, 20);
            this.UserNametextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(225, 200);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(150, 20);
            this.PasswordtextBox.TabIndex = 1;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(275, 130);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(60, 13);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "User Name";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(275, 180);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "Password";
            // 
            // GetRolebutton
            // 
            this.GetRolebutton.Location = new System.Drawing.Point(260, 250);
            this.GetRolebutton.Name = "GetRolebutton";
            this.GetRolebutton.Size = new System.Drawing.Size(75, 25);
            this.GetRolebutton.TabIndex = 4;
            this.GetRolebutton.Text = "Get  Role";
            this.GetRolebutton.UseVisualStyleBackColor = true;
            this.GetRolebutton.Click += new System.EventHandler(this.GetRolebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(13, 13);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 25);
            this.Backbutton.TabIndex = 5;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // GetAuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.GetRolebutton);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Name = "GetAuthenticateForm";
            this.Text = "GetAuthenticateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Button GetRolebutton;
        private System.Windows.Forms.Button Backbutton;
    }
}