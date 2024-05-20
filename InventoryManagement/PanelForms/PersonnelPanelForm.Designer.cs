namespace InventoryManagement
{
    partial class PersonnelPanelForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.AddNewPersonnel = new System.Windows.Forms.Button();
            this.DeletePersonnel = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonnelCountlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddNewPersonnel
            // 
            this.AddNewPersonnel.Location = new System.Drawing.Point(440, 590);
            this.AddNewPersonnel.Name = "AddNewPersonnel";
            this.AddNewPersonnel.Size = new System.Drawing.Size(125, 25);
            this.AddNewPersonnel.TabIndex = 2;
            this.AddNewPersonnel.Text = "Add New Personnel";
            this.AddNewPersonnel.UseVisualStyleBackColor = true;
            this.AddNewPersonnel.Click += new System.EventHandler(this.AddNewPersonnel_Click);
            // 
            // DeletePersonnel
            // 
            this.DeletePersonnel.Location = new System.Drawing.Point(740, 590);
            this.DeletePersonnel.Name = "DeletePersonnel";
            this.DeletePersonnel.Size = new System.Drawing.Size(125, 25);
            this.DeletePersonnel.TabIndex = 3;
            this.DeletePersonnel.Text = "Delete Personnel";
            this.DeletePersonnel.UseVisualStyleBackColor = true;
            this.DeletePersonnel.Click += new System.EventHandler(this.DeletePersonnel_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(590, 590);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(125, 25);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personnel";
            // 
            // PersonnelCountlabel
            // 
            this.PersonnelCountlabel.AutoSize = true;
            this.PersonnelCountlabel.Location = new System.Drawing.Point(600, 570);
            this.PersonnelCountlabel.Name = "PersonnelCountlabel";
            this.PersonnelCountlabel.Size = new System.Drawing.Size(85, 13);
            this.PersonnelCountlabel.TabIndex = 6;
            this.PersonnelCountlabel.Text = "PersonnelCount:";
            // 
            // PersonnelPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.PersonnelCountlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeletePersonnel);
            this.Controls.Add(this.AddNewPersonnel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonnelPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel Panel";
            this.Load += new System.EventHandler(this.PersonnelPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button AddNewPersonnel;
        private System.Windows.Forms.Button DeletePersonnel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PersonnelCountlabel;
    }
}