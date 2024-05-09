namespace InventoryManagement
{
    partial class UpdateAssignmentRecordForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AssignmentEndDatetextBox = new System.Windows.Forms.TextBox();
            this.AssignmentIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(305, 250);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 25);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AssignmentEndDatetextBox
            // 
            this.AssignmentEndDatetextBox.Location = new System.Drawing.Point(270, 200);
            this.AssignmentEndDatetextBox.Name = "AssignmentEndDatetextBox";
            this.AssignmentEndDatetextBox.Size = new System.Drawing.Size(150, 20);
            this.AssignmentEndDatetextBox.TabIndex = 2;
            // 
            // AssignmentIdtextBox
            // 
            this.AssignmentIdtextBox.Location = new System.Drawing.Point(270, 150);
            this.AssignmentIdtextBox.Name = "AssignmentIdtextBox";
            this.AssignmentIdtextBox.Size = new System.Drawing.Size(150, 20);
            this.AssignmentIdtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assignment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assignment End Date";
            // 
            // UpdateAssignmentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssignmentIdtextBox);
            this.Controls.Add(this.AssignmentEndDatetextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Back);
            this.Name = "UpdateAssignmentRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAssignmentRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox AssignmentEndDatetextBox;
        private System.Windows.Forms.TextBox AssignmentIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}