namespace InventoryManagement
{
    partial class AddNewAssignmentForm
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
            this.Back = new System.Windows.Forms.Button();
            this.PersonnelNametextBox = new System.Windows.Forms.TextBox();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.AssignmentDatetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.PersonnelSurnametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AssignmentEndDatetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 25);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PersonnelNametextBox
            // 
            this.PersonnelNametextBox.Location = new System.Drawing.Point(275, 50);
            this.PersonnelNametextBox.Name = "PersonnelNametextBox";
            this.PersonnelNametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelNametextBox.TabIndex = 1;
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Location = new System.Drawing.Point(275, 150);
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(150, 20);
            this.ItemNametextBox.TabIndex = 2;
            // 
            // AssignmentDatetextBox
            // 
            this.AssignmentDatetextBox.Location = new System.Drawing.Point(275, 200);
            this.AssignmentDatetextBox.Name = "AssignmentDatetextBox";
            this.AssignmentDatetextBox.Size = new System.Drawing.Size(150, 20);
            this.AssignmentDatetextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personnel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personnel Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assignment Date";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(310, 300);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 25);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PersonnelSurnametextBox
            // 
            this.PersonnelSurnametextBox.Location = new System.Drawing.Point(275, 100);
            this.PersonnelSurnametextBox.Name = "PersonnelSurnametextBox";
            this.PersonnelSurnametextBox.Size = new System.Drawing.Size(150, 20);
            this.PersonnelSurnametextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Assignment End Date";
            // 
            // AssignmentEndDatetextBox
            // 
            this.AssignmentEndDatetextBox.Location = new System.Drawing.Point(275, 250);
            this.AssignmentEndDatetextBox.Name = "AssignmentEndDatetextBox";
            this.AssignmentEndDatetextBox.Size = new System.Drawing.Size(150, 20);
            this.AssignmentEndDatetextBox.TabIndex = 3;
            // 
            // AddNewAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PersonnelSurnametextBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssignmentDatetextBox);
            this.Controls.Add(this.AssignmentEndDatetextBox);
            this.Controls.Add(this.ItemNametextBox);
            this.Controls.Add(this.PersonnelNametextBox);
            this.Controls.Add(this.Back);
            this.Name = "AddNewAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Assignment Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox PersonnelNametextBox;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.TextBox AssignmentDatetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox PersonnelSurnametextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AssignmentEndDatetextBox;
    }
}