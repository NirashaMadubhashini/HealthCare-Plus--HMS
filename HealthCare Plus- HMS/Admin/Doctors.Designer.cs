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
            this.doctorDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.docEmailTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.docSpecCb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.docNameCb = new System.Windows.Forms.ComboBox();
            this.docPhoneTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.docIdTb = new System.Windows.Forms.TextBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.docexperienceTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.docRoomCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDGV
            // 
            this.doctorDGV.BackgroundColor = System.Drawing.Color.White;
            this.doctorDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDGV.GridColor = System.Drawing.Color.White;
            this.doctorDGV.Location = new System.Drawing.Point(33, 354);
            this.doctorDGV.Margin = new System.Windows.Forms.Padding(2);
            this.doctorDGV.Name = "doctorDGV";
            this.doctorDGV.RowHeadersWidth = 62;
            this.doctorDGV.RowTemplate.Height = 28;
            this.doctorDGV.Size = new System.Drawing.Size(1089, 326);
            this.doctorDGV.TabIndex = 60;
            this.doctorDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(609, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Room/Location";
            // 
            // docEmailTb
            // 
            this.docEmailTb.Enabled = false;
            this.docEmailTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docEmailTb.ForeColor = System.Drawing.Color.Black;
            this.docEmailTb.Location = new System.Drawing.Point(30, 153);
            this.docEmailTb.Margin = new System.Windows.Forms.Padding(2);
            this.docEmailTb.Name = "docEmailTb";
            this.docEmailTb.Size = new System.Drawing.Size(258, 42);
            this.docEmailTb.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "E-mail";
            // 
            // docSpecCb
            // 
            this.docSpecCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docSpecCb.FormattingEnabled = true;
            this.docSpecCb.Items.AddRange(new object[] {
            "Urology",
            "Gynecology",
            "Surgery",
            "Ophtalmo",
            "Dermato",
            "Generalist"});
            this.docSpecCb.Location = new System.Drawing.Point(315, 152);
            this.docSpecCb.Margin = new System.Windows.Forms.Padding(2);
            this.docSpecCb.Name = "docSpecCb";
            this.docSpecCb.Size = new System.Drawing.Size(252, 42);
            this.docSpecCb.TabIndex = 52;
            this.docSpecCb.SelectedIndexChanged += new System.EventHandler(this.docSpecCb_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(310, 124);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(158, 25);
            this.label22.TabIndex = 51;
            this.label22.Text = "Specialisation";
            // 
            // docNameCb
            // 
            this.docNameCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameCb.FormattingEnabled = true;
            this.docNameCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.docNameCb.Location = new System.Drawing.Point(31, 73);
            this.docNameCb.Margin = new System.Windows.Forms.Padding(2);
            this.docNameCb.Name = "docNameCb";
            this.docNameCb.Size = new System.Drawing.Size(253, 42);
            this.docNameCb.TabIndex = 48;
            this.docNameCb.SelectedIndexChanged += new System.EventHandler(this.docNameCb_SelectedIndexChanged);
            // 
            // docPhoneTb
            // 
            this.docPhoneTb.Enabled = false;
            this.docPhoneTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docPhoneTb.ForeColor = System.Drawing.Color.Black;
            this.docPhoneTb.Location = new System.Drawing.Point(611, 68);
            this.docPhoneTb.Margin = new System.Windows.Forms.Padding(2);
            this.docPhoneTb.Name = "docPhoneTb";
            this.docPhoneTb.Size = new System.Drawing.Size(259, 42);
            this.docPhoneTb.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(607, 41);
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
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Doctor Id";
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
            // docIdTb
            // 
            this.docIdTb.Enabled = false;
            this.docIdTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docIdTb.ForeColor = System.Drawing.Color.Black;
            this.docIdTb.Location = new System.Drawing.Point(315, 70);
            this.docIdTb.Margin = new System.Windows.Forms.Padding(2);
            this.docIdTb.Name = "docIdTb";
            this.docIdTb.Size = new System.Drawing.Size(259, 42);
            this.docIdTb.TabIndex = 61;
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
            this.addBtn.Location = new System.Drawing.Point(942, 70);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 64;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
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
            this.updateBtn.Location = new System.Drawing.Point(942, 133);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 65;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(942, 195);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 66;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // docexperienceTb
            // 
            this.docexperienceTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docexperienceTb.ForeColor = System.Drawing.Color.Black;
            this.docexperienceTb.Location = new System.Drawing.Point(32, 244);
            this.docexperienceTb.Margin = new System.Windows.Forms.Padding(2);
            this.docexperienceTb.Multiline = true;
            this.docexperienceTb.Name = "docexperienceTb";
            this.docexperienceTb.Size = new System.Drawing.Size(535, 71);
            this.docexperienceTb.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Experience/ Qualifications";
            // 
            // docRoomCb
            // 
            this.docRoomCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomCb.FormattingEnabled = true;
            this.docRoomCb.Items.AddRange(new object[] {
            "Urology",
            "Gynecology",
            "Surgery",
            "Ophtalmo",
            "Dermato",
            "Generalist"});
            this.docRoomCb.Location = new System.Drawing.Point(611, 153);
            this.docRoomCb.Margin = new System.Windows.Forms.Padding(2);
            this.docRoomCb.Name = "docRoomCb";
            this.docRoomCb.Size = new System.Drawing.Size(252, 42);
            this.docRoomCb.TabIndex = 69;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.docRoomCb);
            this.Controls.Add(this.docexperienceTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.docIdTb);
            this.Controls.Add(this.doctorDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docEmailTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docSpecCb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.docNameCb);
            this.Controls.Add(this.docPhoneTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox docEmailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox docSpecCb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox docNameCb;
        private System.Windows.Forms.TextBox docPhoneTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox docIdTb;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private System.Windows.Forms.TextBox docexperienceTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox docRoomCb;
    }
}