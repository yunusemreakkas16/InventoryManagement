namespace InventoryManagement
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1012, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 400);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(331, 61);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(600, 400);
            this.dataGridView3.TabIndex = 4;
            // 
            // PersonnelLabel
            // 
            this.PersonnelLabel.AutoSize = true;
            this.PersonnelLabel.Location = new System.Drawing.Point(95, 36);
            this.PersonnelLabel.Name = "PersonnelLabel";
            this.PersonnelLabel.Size = new System.Drawing.Size(73, 13);
            this.PersonnelLabel.TabIndex = 1;
            this.PersonnelLabel.Text = "Personnel List";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(1126, 36);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(27, 13);
            this.ItemLabel.TabIndex = 3;
            this.ItemLabel.Text = "Item";
            // 
            // AssigmentLabel
            // 
            this.AssigmentLabel.AutoSize = true;
            this.AssigmentLabel.Location = new System.Drawing.Point(599, 36);
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
            // 
            // UnAssigment
            // 
            this.UnAssigment.Location = new System.Drawing.Point(685, 520);
            this.UnAssigment.Name = "UnAssigment";
            this.UnAssigment.Size = new System.Drawing.Size(120, 25);
            this.UnAssigment.TabIndex = 7;
            this.UnAssigment.Text = "Delete Assigment";
            this.UnAssigment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh Personnels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 10;
            this.button3.Text = "Refresh Assigments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "Form2";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}