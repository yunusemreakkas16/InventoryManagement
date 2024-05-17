namespace InventoryManagement
{
    partial class AssignmentForm
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

            private void InitializeComponent()
            {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.PersonnelLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.AssigmentLabel = new System.Windows.Forms.Label();
            this.NewAssigmentButton = new System.Windows.Forms.Button();
            this.UnAssigment = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(940, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(320, 400);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_ColumnHeaderMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(335, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(595, 400);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_ColumnHeaderMouseClick);
            // 
            // PersonnelLabel
            // 
            this.PersonnelLabel.AutoSize = true;
            this.PersonnelLabel.Location = new System.Drawing.Point(125, 35);
            this.PersonnelLabel.Name = "PersonnelLabel";
            this.PersonnelLabel.Size = new System.Drawing.Size(73, 13);
            this.PersonnelLabel.TabIndex = 1;
            this.PersonnelLabel.Text = "Personnel List";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(1090, 35);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(27, 13);
            this.ItemLabel.TabIndex = 3;
            this.ItemLabel.Text = "Item";
            // 
            // AssigmentLabel
            // 
            this.AssigmentLabel.AutoSize = true;
            this.AssigmentLabel.Location = new System.Drawing.Point(600, 35);
            this.AssigmentLabel.Name = "AssigmentLabel";
            this.AssigmentLabel.Size = new System.Drawing.Size(55, 13);
            this.AssigmentLabel.TabIndex = 5;
            this.AssigmentLabel.Text = "Assigment";
            // 
            // NewAssigmentButton
            // 
            this.NewAssigmentButton.Location = new System.Drawing.Point(455, 520);
            this.NewAssigmentButton.Name = "NewAssigmentButton";
            this.NewAssigmentButton.Size = new System.Drawing.Size(120, 25);
            this.NewAssigmentButton.TabIndex = 6;
            this.NewAssigmentButton.Text = "Add New Assigment";
            this.NewAssigmentButton.UseVisualStyleBackColor = true;
            this.NewAssigmentButton.Click += new System.EventHandler(this.NewAssigmentButton_Click);
            // 
            // UnAssigment
            // 
            this.UnAssigment.Location = new System.Drawing.Point(685, 520);
            this.UnAssigment.Name = "UnAssigment";
            this.UnAssigment.Size = new System.Drawing.Size(120, 25);
            this.UnAssigment.TabIndex = 7;
            this.UnAssigment.Text = "Delete Assigment";
            this.UnAssigment.UseVisualStyleBackColor = true;
            this.UnAssigment.Click += new System.EventHandler(this.UnAssigment_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(570, 475);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(120, 25);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UnAssigment);
            this.Controls.Add(this.NewAssigmentButton);
            this.Controls.Add(this.AssigmentLabel);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PersonnelLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assigment Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PersonnelLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label AssigmentLabel;
        private System.Windows.Forms.Button NewAssigmentButton;
        private System.Windows.Forms.Button UnAssigment;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button BackButton;
    }
}