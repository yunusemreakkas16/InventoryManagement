namespace InventoryManagement
{
    partial class AddNewItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.ItemTypetextBox = new System.Windows.Forms.TextBox();
            this.ItemStatustextBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Status";
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Location = new System.Drawing.Point(275, 100);
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(150, 20);
            this.ItemNametextBox.TabIndex = 7;
            // 
            // ItemTypetextBox
            // 
            this.ItemTypetextBox.Location = new System.Drawing.Point(275, 150);
            this.ItemTypetextBox.Name = "ItemTypetextBox";
            this.ItemTypetextBox.Size = new System.Drawing.Size(150, 20);
            this.ItemTypetextBox.TabIndex = 8;
            // 
            // ItemStatustextBox
            // 
            this.ItemStatustextBox.Location = new System.Drawing.Point(275, 200);
            this.ItemStatustextBox.Name = "ItemStatustextBox";
            this.ItemStatustextBox.Size = new System.Drawing.Size(150, 20);
            this.ItemStatustextBox.TabIndex = 9;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(307, 250);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ItemStatustextBox);
            this.Controls.Add(this.ItemTypetextBox);
            this.Controls.Add(this.ItemNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "AddNewItemForm";
            this.Text = "Add New Item Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.TextBox ItemTypetextBox;
        private System.Windows.Forms.TextBox ItemStatustextBox;
        private System.Windows.Forms.Button Save;
    }
}