namespace HealthCare_Plus__HMS.HospitalStaff
{
    partial class Medication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medication));
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.medicationDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.medSideEffectsTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medStockQuantityTb = new System.Windows.Forms.TextBox();
            this.medNameTb = new System.Windows.Forms.TextBox();
            this.medDescriptionTb = new System.Windows.Forms.TextBox();
            this.medDosageTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.medicationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.BorderRadius = 8;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(945, 145);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 88;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.BorderRadius = 8;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(945, 94);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 87;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.BorderRadius = 8;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(945, 40);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 86;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // medicationDGV
            // 
            this.medicationDGV.BackgroundColor = System.Drawing.Color.White;
            this.medicationDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicationDGV.GridColor = System.Drawing.Color.White;
            this.medicationDGV.Location = new System.Drawing.Point(36, 263);
            this.medicationDGV.Margin = new System.Windows.Forms.Padding(2);
            this.medicationDGV.Name = "medicationDGV";
            this.medicationDGV.RowHeadersWidth = 62;
            this.medicationDGV.RowTemplate.Height = 28;
            this.medicationDGV.Size = new System.Drawing.Size(1089, 416);
            this.medicationDGV.TabIndex = 82;
            this.medicationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicationDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Stock Quantity ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(605, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 25);
            this.label11.TabIndex = 70;
            this.label11.Text = "Medication Dosage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(317, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 25);
            this.label9.TabIndex = 67;
            this.label9.Text = "Medication Name";
            // 
            // medSideEffectsTb
            // 
            this.medSideEffectsTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medSideEffectsTb.ForeColor = System.Drawing.Color.Black;
            this.medSideEffectsTb.Location = new System.Drawing.Point(36, 160);
            this.medSideEffectsTb.Margin = new System.Windows.Forms.Padding(2);
            this.medSideEffectsTb.Multiline = true;
            this.medSideEffectsTb.Name = "medSideEffectsTb";
            this.medSideEffectsTb.Size = new System.Drawing.Size(259, 42);
            this.medSideEffectsTb.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 89;
            this.label4.Text = "Side Effects";
            // 
            // medStockQuantityTb
            // 
            this.medStockQuantityTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medStockQuantityTb.ForeColor = System.Drawing.Color.Black;
            this.medStockQuantityTb.Location = new System.Drawing.Point(322, 160);
            this.medStockQuantityTb.Margin = new System.Windows.Forms.Padding(2);
            this.medStockQuantityTb.Multiline = true;
            this.medStockQuantityTb.Name = "medStockQuantityTb";
            this.medStockQuantityTb.Size = new System.Drawing.Size(188, 42);
            this.medStockQuantityTb.TabIndex = 91;
            // 
            // medNameTb
            // 
            this.medNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameTb.ForeColor = System.Drawing.Color.Black;
            this.medNameTb.Location = new System.Drawing.Point(34, 69);
            this.medNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.medNameTb.Multiline = true;
            this.medNameTb.Name = "medNameTb";
            this.medNameTb.Size = new System.Drawing.Size(259, 42);
            this.medNameTb.TabIndex = 92;
            // 
            // medDescriptionTb
            // 
            this.medDescriptionTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDescriptionTb.ForeColor = System.Drawing.Color.Black;
            this.medDescriptionTb.Location = new System.Drawing.Point(322, 69);
            this.medDescriptionTb.Margin = new System.Windows.Forms.Padding(2);
            this.medDescriptionTb.Multiline = true;
            this.medDescriptionTb.Name = "medDescriptionTb";
            this.medDescriptionTb.Size = new System.Drawing.Size(259, 42);
            this.medDescriptionTb.TabIndex = 93;
            // 
            // medDosageTb
            // 
            this.medDosageTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDosageTb.ForeColor = System.Drawing.Color.Black;
            this.medDosageTb.Location = new System.Drawing.Point(610, 69);
            this.medDosageTb.Margin = new System.Windows.Forms.Padding(2);
            this.medDosageTb.Multiline = true;
            this.medDosageTb.Name = "medDosageTb";
            this.medDosageTb.Size = new System.Drawing.Size(259, 42);
            this.medDosageTb.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(543, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Search by Name";
            // 
            // searchTb
            // 
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.DefaultText = "";
            this.searchTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTb.IconLeft")));
            this.searchTb.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTb.Location = new System.Drawing.Point(548, 188);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(377, 46);
            this.searchTb.TabIndex = 109;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.medDosageTb);
            this.Controls.Add(this.medDescriptionTb);
            this.Controls.Add(this.medNameTb);
            this.Controls.Add(this.medStockQuantityTb);
            this.Controls.Add(this.medSideEffectsTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.medicationDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Medication";
            this.Text = "Medication";
            ((System.ComponentModel.ISupportInitialize)(this.medicationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.DataGridView medicationDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox medSideEffectsTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medStockQuantityTb;
        private System.Windows.Forms.TextBox medNameTb;
        private System.Windows.Forms.TextBox medDescriptionTb;
        private System.Windows.Forms.TextBox medDosageTb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
    }
}