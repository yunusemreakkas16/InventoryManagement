﻿namespace InventoryManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AssignmentIdcomboBox = new System.Windows.Forms.ComboBox();
            this.AssignmentEnddateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // AssignmentIdcomboBox
            // 
            this.AssignmentIdcomboBox.FormattingEnabled = true;
            this.AssignmentIdcomboBox.Location = new System.Drawing.Point(270, 150);
            this.AssignmentIdcomboBox.Name = "AssignmentIdcomboBox";
            this.AssignmentIdcomboBox.Size = new System.Drawing.Size(150, 21);
            this.AssignmentIdcomboBox.TabIndex = 6;
            // 
            // AssignmentEnddateTimePicker
            // 
            this.AssignmentEnddateTimePicker.Location = new System.Drawing.Point(270, 200);
            this.AssignmentEnddateTimePicker.Name = "AssignmentEnddateTimePicker";
            this.AssignmentEnddateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.AssignmentEnddateTimePicker.TabIndex = 7;
            this.AssignmentEnddateTimePicker.ValueChanged += new System.EventHandler(this.AssignmentEnddateTimePicker_ValueChanged);
            // 
            // UpdateAssignmentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.AssignmentEnddateTimePicker);
            this.Controls.Add(this.AssignmentIdcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Back);
            this.Name = "UpdateAssignmentRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAssignmentRecordForm";
            this.Load += new System.EventHandler(this.UpdateAssignmentRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AssignmentIdcomboBox;
        private System.Windows.Forms.DateTimePicker AssignmentEnddateTimePicker;
    }
}