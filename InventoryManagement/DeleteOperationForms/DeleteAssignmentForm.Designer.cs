namespace InventoryManagement
{
    partial class DeleteAssignmentForm
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
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteAssignmenttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(305, 200);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 25);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteAssignmenttextBox
            // 
            this.DeleteAssignmenttextBox.Location = new System.Drawing.Point(270, 160);
            this.DeleteAssignmenttextBox.Name = "DeleteAssignmenttextBox";
            this.DeleteAssignmenttextBox.Size = new System.Drawing.Size(150, 20);
            this.DeleteAssignmenttextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assignment ID";
            // 
            // DeleteAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAssignmenttextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.BackButton);
            this.Name = "DeleteAssignmentForm";
            this.Text = "DeleteAssignmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox DeleteAssignmenttextBox;
        private System.Windows.Forms.Label label1;
    }
}