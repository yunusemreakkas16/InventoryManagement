namespace InventoryManagement
{
    partial class DeletePersonnelForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSurnamecomboBox = new System.Windows.Forms.ComboBox();
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
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(305, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personnel Name And Surname";
            // 
            // NameSurnamecomboBox
            // 
            this.NameSurnamecomboBox.FormattingEnabled = true;
            this.NameSurnamecomboBox.Location = new System.Drawing.Point(270, 150);
            this.NameSurnamecomboBox.Name = "NameSurnamecomboBox";
            this.NameSurnamecomboBox.Size = new System.Drawing.Size(150, 21);
            this.NameSurnamecomboBox.TabIndex = 7;
            // 
            // DeletePersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.NameSurnamecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Name = "DeletePersonnelForm";
            this.Text = "DeletePersonnelForm";
            this.Load += new System.EventHandler(this.DeletePersonnelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NameSurnamecomboBox;
    }
}