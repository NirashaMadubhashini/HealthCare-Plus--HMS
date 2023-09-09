namespace HealthCare_Plus__HMS.Staff
{
    partial class Patients
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
            this.PatAddTb = new System.Windows.Forms.TextBox();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.PatAlTb = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.PatHIVCb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PatDOB = new System.Windows.Forms.DateTimePicker();
            this.PatGenCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PatPhoneTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PatAddTb
            // 
            this.PatAddTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddTb.ForeColor = System.Drawing.Color.Black;
            this.PatAddTb.Location = new System.Drawing.Point(328, 67);
            this.PatAddTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatAddTb.Name = "PatAddTb";
            this.PatAddTb.Size = new System.Drawing.Size(259, 42);
            this.PatAddTb.TabIndex = 78;
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.GridColor = System.Drawing.Color.White;
            this.PatientsDGV.Location = new System.Drawing.Point(33, 335);
            this.PatientsDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.RowHeadersWidth = 62;
            this.PatientsDGV.RowTemplate.Height = 28;
            this.PatientsDGV.Size = new System.Drawing.Size(1089, 345);
            this.PatientsDGV.TabIndex = 77;
            this.PatientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellContentClick);
            // 
            // PatAlTb
            // 
            this.PatAlTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAlTb.ForeColor = System.Drawing.Color.Black;
            this.PatAlTb.Location = new System.Drawing.Point(887, 67);
            this.PatAlTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatAlTb.Multiline = true;
            this.PatAlTb.Name = "PatAlTb";
            this.PatAlTb.Size = new System.Drawing.Size(235, 129);
            this.PatAlTb.TabIndex = 76;
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Red;
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.FlatAppearance.BorderSize = 10;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(958, 249);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(145, 38);
            this.DelBtn.TabIndex = 75;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderSize = 10;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(797, 249);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(145, 38);
            this.EditBtn.TabIndex = 74;
            this.EditBtn.Text = "Update";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 10;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(636, 249);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(145, 38);
            this.AddBtn.TabIndex = 73;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(884, 38);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 25);
            this.label23.TabIndex = 72;
            this.label23.Text = "Allergies";
            // 
            // PatHIVCb
            // 
            this.PatHIVCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatHIVCb.FormattingEnabled = true;
            this.PatHIVCb.Items.AddRange(new object[] {
            "Positive",
            "Nagative"});
            this.PatHIVCb.Location = new System.Drawing.Point(620, 161);
            this.PatHIVCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatHIVCb.Name = "PatHIVCb";
            this.PatHIVCb.Size = new System.Drawing.Size(207, 42);
            this.PatHIVCb.TabIndex = 71;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(617, 131);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 25);
            this.label22.TabIndex = 70;
            this.label22.Text = "HIV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(323, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 69;
            this.label13.Text = "DOB";
            // 
            // PatDOB
            // 
            this.PatDOB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatDOB.Location = new System.Drawing.Point(324, 159);
            this.PatDOB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatDOB.Name = "PatDOB";
            this.PatDOB.Size = new System.Drawing.Size(259, 42);
            this.PatDOB.TabIndex = 68;
            // 
            // PatGenCb
            // 
            this.PatGenCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGenCb.FormattingEnabled = true;
            this.PatGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGenCb.Location = new System.Drawing.Point(620, 66);
            this.PatGenCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatGenCb.Name = "PatGenCb";
            this.PatGenCb.Size = new System.Drawing.Size(207, 42);
            this.PatGenCb.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(617, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 66;
            this.label12.Text = "Gender";
            // 
            // PatPhoneTb
            // 
            this.PatPhoneTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhoneTb.ForeColor = System.Drawing.Color.Black;
            this.PatPhoneTb.Location = new System.Drawing.Point(35, 159);
            this.PatPhoneTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatPhoneTb.Name = "PatPhoneTb";
            this.PatPhoneTb.Size = new System.Drawing.Size(259, 42);
            this.PatPhoneTb.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(32, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Contact No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(324, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Address";
            // 
            // PatNameTb
            // 
            this.PatNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.ForeColor = System.Drawing.Color.Black;
            this.PatNameTb.Location = new System.Drawing.Point(37, 67);
            this.PatNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(259, 42);
            this.PatNameTb.TabIndex = 62;
            this.PatNameTb.TextChanged += new System.EventHandler(this.PatNameTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Patient Name";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.PatAddTb);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.PatAlTb);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PatHIVCb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PatDOB);
            this.Controls.Add(this.PatGenCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatPhoneTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Patients";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatAddTb;
        private System.Windows.Forms.DataGridView PatientsDGV;
        private System.Windows.Forms.TextBox PatAlTb;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox PatHIVCb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker PatDOB;
        private System.Windows.Forms.ComboBox PatGenCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatPhoneTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.Label label9;
    }
}