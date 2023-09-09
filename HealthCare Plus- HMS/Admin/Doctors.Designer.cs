namespace HealthCare_Plus__HMS.Admin
{
    partial class Doctors
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
            this.DoctorDGV = new System.Windows.Forms.DataGridView();
            this.DocPassWordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocExpTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DocSpecCb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DocDOB = new System.Windows.Forms.DateTimePicker();
            this.DocGenCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DocPhoneTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DocAddTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNumCb = new System.Windows.Forms.ComboBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorDGV
            // 
            this.DoctorDGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoctorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorDGV.GridColor = System.Drawing.Color.White;
            this.DoctorDGV.Location = new System.Drawing.Point(33, 335);
            this.DoctorDGV.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorDGV.Name = "DoctorDGV";
            this.DoctorDGV.RowHeadersWidth = 62;
            this.DoctorDGV.RowTemplate.Height = 28;
            this.DoctorDGV.Size = new System.Drawing.Size(1089, 345);
            this.DoctorDGV.TabIndex = 60;
            this.DoctorDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorDGV_CellContentClick);
            // 
            // DocPassWordTb
            // 
            this.DocPassWordTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPassWordTb.ForeColor = System.Drawing.Color.Black;
            this.DocPassWordTb.Location = new System.Drawing.Point(866, 162);
            this.DocPassWordTb.Margin = new System.Windows.Forms.Padding(2);
            this.DocPassWordTb.Name = "DocPassWordTb";
            this.DocPassWordTb.Size = new System.Drawing.Size(256, 42);
            this.DocPassWordTb.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(862, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Password";
            // 
            // DocExpTb
            // 
            this.DocExpTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocExpTb.ForeColor = System.Drawing.Color.Black;
            this.DocExpTb.Location = new System.Drawing.Point(611, 162);
            this.DocExpTb.Margin = new System.Windows.Forms.Padding(2);
            this.DocExpTb.Name = "DocExpTb";
            this.DocExpTb.Size = new System.Drawing.Size(218, 42);
            this.DocExpTb.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(607, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Experience";
            // 
            // DocSpecCb
            // 
            this.DocSpecCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSpecCb.FormattingEnabled = true;
            this.DocSpecCb.Items.AddRange(new object[] {
            "Urology",
            "Gynecology",
            "Surgery",
            "Ophtalmo",
            "Dermato",
            "Generalist"});
            this.DocSpecCb.Location = new System.Drawing.Point(319, 161);
            this.DocSpecCb.Margin = new System.Windows.Forms.Padding(2);
            this.DocSpecCb.Name = "DocSpecCb";
            this.DocSpecCb.Size = new System.Drawing.Size(258, 42);
            this.DocSpecCb.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(315, 133);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(158, 25);
            this.label22.TabIndex = 51;
            this.label22.Text = "Specialisation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(28, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "DOB";
            // 
            // DocDOB
            // 
            this.DocDOB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDOB.Location = new System.Drawing.Point(28, 160);
            this.DocDOB.Margin = new System.Windows.Forms.Padding(2);
            this.DocDOB.Name = "DocDOB";
            this.DocDOB.Size = new System.Drawing.Size(259, 42);
            this.DocDOB.TabIndex = 49;
            // 
            // DocGenCb
            // 
            this.DocGenCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocGenCb.FormattingEnabled = true;
            this.DocGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DocGenCb.Location = new System.Drawing.Point(611, 70);
            this.DocGenCb.Margin = new System.Windows.Forms.Padding(2);
            this.DocGenCb.Name = "DocGenCb";
            this.DocGenCb.Size = new System.Drawing.Size(218, 42);
            this.DocGenCb.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(607, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Gender";
            // 
            // DocPhoneTb
            // 
            this.DocPhoneTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPhoneTb.ForeColor = System.Drawing.Color.Black;
            this.DocPhoneTb.Location = new System.Drawing.Point(863, 68);
            this.DocPhoneTb.Margin = new System.Windows.Forms.Padding(2);
            this.DocPhoneTb.Name = "DocPhoneTb";
            this.DocPhoneTb.Size = new System.Drawing.Size(259, 42);
            this.DocPhoneTb.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(859, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Contact No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(315, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Address";
            // 
            // DNameTb
            // 
            this.DNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNameTb.ForeColor = System.Drawing.Color.Black;
            this.DNameTb.Location = new System.Drawing.Point(31, 70);
            this.DNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(259, 42);
            this.DNameTb.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Doctor Name";
            // 
            // DocAddTb
            // 
            this.DocAddTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAddTb.ForeColor = System.Drawing.Color.Black;
            this.DocAddTb.Location = new System.Drawing.Point(320, 70);
            this.DocAddTb.Margin = new System.Windows.Forms.Padding(2);
            this.DocAddTb.Name = "DocAddTb";
            this.DocAddTb.Size = new System.Drawing.Size(259, 42);
            this.DocAddTb.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Room No.";
            // 
            // RoomNumCb
            // 
            this.RoomNumCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumCb.FormattingEnabled = true;
            this.RoomNumCb.Location = new System.Drawing.Point(31, 263);
            this.RoomNumCb.Margin = new System.Windows.Forms.Padding(2);
            this.RoomNumCb.Name = "RoomNumCb";
            this.RoomNumCb.Size = new System.Drawing.Size(258, 42);
            this.RoomNumCb.TabIndex = 63;
            this.RoomNumCb.SelectedIndexChanged += new System.EventHandler(this.RoomNumCb_SelectedIndexChanged);
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
            this.addBtn.Location = new System.Drawing.Point(570, 273);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 64;
            this.addBtn.Text = "Add";
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
            this.updateBtn.Location = new System.Drawing.Point(756, 273);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 65;
            this.updateBtn.Text = "Update";
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
            this.deleteBtn.Location = new System.Drawing.Point(942, 273);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 66;
            this.deleteBtn.Text = "Delete";
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.RoomNumCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocAddTb);
            this.Controls.Add(this.DoctorDGV);
            this.Controls.Add(this.DocPassWordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocExpTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocSpecCb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocDOB);
            this.Controls.Add(this.DocGenCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DocPhoneTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Doctors";
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DoctorDGV;
        private System.Windows.Forms.TextBox DocPassWordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocExpTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DocSpecCb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DocDOB;
        private System.Windows.Forms.ComboBox DocGenCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DocPhoneTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DocAddTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoomNumCb;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
    }
}