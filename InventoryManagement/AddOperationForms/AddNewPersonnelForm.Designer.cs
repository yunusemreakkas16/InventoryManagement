namespace InventoryManagement
{
    partial class AddNewPersonnelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PersonnelNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonnelSurnametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonnelDepartmenttextBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Personnel Name";
            // 
            // PersonnelNametextBox
            // 
            this.PersonnelNametextBox.Location = new System.Drawing.Point(275, 105);
            this.PersonnelNametextBox.Name = "PersonnelNametextBox";
            this.PersonnelNametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Personnel Surname";
            // 
            // PersonnelSurnametextBox
            // 
            this.PersonnelSurnametextBox.Location = new System.Drawing.Point(275, 160);
            this.PersonnelSurnametextBox.Name = "PersonnelSurnametextBox";
            this.PersonnelSurnametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelSurnametextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Department";
            // 
            // PersonnelDepartmenttextBox
            // 
            this.PersonnelDepartmenttextBox.Location = new System.Drawing.Point(275, 210);
            this.PersonnelDepartmenttextBox.Name = "PersonnelDepartmenttextBox";
            this.PersonnelDepartmenttextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelDepartmenttextBox.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(307, 265);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 25);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddNewPersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PersonnelDepartmenttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonnelSurnametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PersonnelNametextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPersonnelForm";
            this.Text = "AddNewPersonnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersonnelNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonnelSurnametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PersonnelDepartmenttextBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Save;
    }
}