﻿namespace InventoryManagement
{
    partial class AddNewMaintenanceRecordForm
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
            this.StatustextBox = new System.Windows.Forms.TextBox();
            this.MaintenanceDatetextBox = new System.Windows.Forms.TextBox();
            this.MaintenanceDateEndtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ItemIdcomboBox = new System.Windows.Forms.ComboBox();
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
            // StatustextBox
            // 
            this.StatustextBox.Location = new System.Drawing.Point(270, 150);
            this.StatustextBox.Name = "StatustextBox";
            this.StatustextBox.Size = new System.Drawing.Size(150, 20);
            this.StatustextBox.TabIndex = 2;
            // 
            // MaintenanceDatetextBox
            // 
            this.MaintenanceDatetextBox.Location = new System.Drawing.Point(270, 200);
            this.MaintenanceDatetextBox.Name = "MaintenanceDatetextBox";
            this.MaintenanceDatetextBox.Size = new System.Drawing.Size(150, 20);
            this.MaintenanceDatetextBox.TabIndex = 3;
            // 
            // MaintenanceDateEndtextBox
            // 
            this.MaintenanceDateEndtextBox.Location = new System.Drawing.Point(270, 250);
            this.MaintenanceDateEndtextBox.Name = "MaintenanceDateEndtextBox";
            this.MaintenanceDateEndtextBox.Size = new System.Drawing.Size(150, 20);
            this.MaintenanceDateEndtextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maintenance Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maintenance End Date";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(305, 299);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 25);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ItemIdcomboBox
            // 
            this.ItemIdcomboBox.FormattingEnabled = true;
            this.ItemIdcomboBox.Location = new System.Drawing.Point(270, 100);
            this.ItemIdcomboBox.Name = "ItemIdcomboBox";
            this.ItemIdcomboBox.Size = new System.Drawing.Size(150, 21);
            this.ItemIdcomboBox.TabIndex = 10;
            // 
            // AddNewMaintenanceRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.ItemIdcomboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaintenanceDateEndtextBox);
            this.Controls.Add(this.MaintenanceDatetextBox);
            this.Controls.Add(this.StatustextBox);
            this.Controls.Add(this.BackButton);
            this.Name = "AddNewMaintenanceRecordForm";
            this.Text = "AddNewMaintenanceRecordForm";
            this.Load += new System.EventHandler(this.AddNewMaintenanceRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox StatustextBox;
        private System.Windows.Forms.TextBox MaintenanceDatetextBox;
        private System.Windows.Forms.TextBox MaintenanceDateEndtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox ItemIdcomboBox;
    }
}