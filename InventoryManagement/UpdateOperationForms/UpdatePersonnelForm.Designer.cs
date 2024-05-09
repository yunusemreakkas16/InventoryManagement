namespace InventoryManagement
{
    partial class UpdatePersonnelForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.PersonnelNametextBox = new System.Windows.Forms.TextBox();
            this.DepartmenttextBox = new System.Windows.Forms.TextBox();
            this.PersonnelSurnametextBox = new System.Windows.Forms.TextBox();
            this.PersonnelIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(305, 300);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // PersonnelNametextBox
            // 
            this.PersonnelNametextBox.Location = new System.Drawing.Point(270, 150);
            this.PersonnelNametextBox.Name = "PersonnelNametextBox";
            this.PersonnelNametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelNametextBox.TabIndex = 2;
            // 
            // DepartmenttextBox
            // 
            this.DepartmenttextBox.Location = new System.Drawing.Point(270, 250);
            this.DepartmenttextBox.Name = "DepartmenttextBox";
            this.DepartmenttextBox.Size = new System.Drawing.Size(150, 20);
            this.DepartmenttextBox.TabIndex = 3;
            // 
            // PersonnelSurnametextBox
            // 
            this.PersonnelSurnametextBox.Location = new System.Drawing.Point(270, 200);
            this.PersonnelSurnametextBox.Name = "PersonnelSurnametextBox";
            this.PersonnelSurnametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelSurnametextBox.TabIndex = 4;
            // 
            // PersonnelIdtextBox
            // 
            this.PersonnelIdtextBox.Location = new System.Drawing.Point(270, 100);
            this.PersonnelIdtextBox.Name = "PersonnelIdtextBox";
            this.PersonnelIdtextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelIdtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personnel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personnel Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personnel Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please Fill the boxes   you want to edit";
            // 
            // UpdatePersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonnelIdtextBox);
            this.Controls.Add(this.PersonnelSurnametextBox);
            this.Controls.Add(this.DepartmenttextBox);
            this.Controls.Add(this.PersonnelNametextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.BackButton);
            this.Name = "UpdatePersonnelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePersonnelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox PersonnelNametextBox;
        private System.Windows.Forms.TextBox DepartmenttextBox;
        private System.Windows.Forms.TextBox PersonnelSurnametextBox;
        private System.Windows.Forms.TextBox PersonnelIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}