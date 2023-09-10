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
            this.docPassWordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.docExpTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.docSpecCb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.docDateCb = new System.Windows.Forms.DateTimePicker();
            this.docGenCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.docPhoneTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.docNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.docAddTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.docRoomNumCb = new System.Windows.Forms.ComboBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
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
            // docPassWordTb
            // 
            this.docPassWordTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docPassWordTb.ForeColor = System.Drawing.Color.Black;
            this.docPassWordTb.Location = new System.Drawing.Point(315, 260);
            this.docPassWordTb.Margin = new System.Windows.Forms.Padding(2);
            this.docPassWordTb.Name = "docPassWordTb";
            this.docPassWordTb.Size = new System.Drawing.Size(259, 42);
            this.docPassWordTb.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(315, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Password";
            // 
            // docExpTb
            // 
            this.docExpTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docExpTb.ForeColor = System.Drawing.Color.Black;
            this.docExpTb.Location = new System.Drawing.Point(32, 260);
            this.docExpTb.Margin = new System.Windows.Forms.Padding(2);
            this.docExpTb.Name = "docExpTb";
            this.docExpTb.Size = new System.Drawing.Size(258, 42);
            this.docExpTb.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Experience";
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
            this.docSpecCb.Location = new System.Drawing.Point(612, 161);
            this.docSpecCb.Margin = new System.Windows.Forms.Padding(2);
            this.docSpecCb.Name = "docSpecCb";
            this.docSpecCb.Size = new System.Drawing.Size(252, 42);
            this.docSpecCb.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(607, 133);
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
            this.label13.Location = new System.Drawing.Point(315, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "DOB";
            // 
            // docDateCb
            // 
            this.docDateCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docDateCb.Location = new System.Drawing.Point(315, 160);
            this.docDateCb.Margin = new System.Windows.Forms.Padding(2);
            this.docDateCb.Name = "docDateCb";
            this.docDateCb.Size = new System.Drawing.Size(259, 42);
            this.docDateCb.TabIndex = 49;
            // 
            // docGenCb
            // 
            this.docGenCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docGenCb.FormattingEnabled = true;
            this.docGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.docGenCb.Location = new System.Drawing.Point(611, 70);
            this.docGenCb.Margin = new System.Windows.Forms.Padding(2);
            this.docGenCb.Name = "docGenCb";
            this.docGenCb.Size = new System.Drawing.Size(253, 42);
            this.docGenCb.TabIndex = 48;
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
            // docPhoneTb
            // 
            this.docPhoneTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docPhoneTb.ForeColor = System.Drawing.Color.Black;
            this.docPhoneTb.Location = new System.Drawing.Point(31, 160);
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
            this.label11.Location = new System.Drawing.Point(27, 133);
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
            // docNameTb
            // 
            this.docNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameTb.ForeColor = System.Drawing.Color.Black;
            this.docNameTb.Location = new System.Drawing.Point(31, 70);
            this.docNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.docNameTb.Name = "docNameTb";
            this.docNameTb.Size = new System.Drawing.Size(259, 42);
            this.docNameTb.TabIndex = 42;
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
            // docAddTb
            // 
            this.docAddTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docAddTb.ForeColor = System.Drawing.Color.Black;
            this.docAddTb.Location = new System.Drawing.Point(315, 70);
            this.docAddTb.Margin = new System.Windows.Forms.Padding(2);
            this.docAddTb.Name = "docAddTb";
            this.docAddTb.Size = new System.Drawing.Size(259, 42);
            this.docAddTb.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(606, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Room No.";
            // 
            // docRoomNumCb
            // 
            this.docRoomNumCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomNumCb.FormattingEnabled = true;
            this.docRoomNumCb.Location = new System.Drawing.Point(612, 258);
            this.docRoomNumCb.Margin = new System.Windows.Forms.Padding(2);
            this.docRoomNumCb.Name = "docRoomNumCb";
            this.docRoomNumCb.Size = new System.Drawing.Size(252, 42);
            this.docRoomNumCb.TabIndex = 63;
            this.docRoomNumCb.SelectedIndexChanged += new System.EventHandler(this.RoomNumCb_SelectedIndexChanged);
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
            this.Controls.Add(this.docRoomNumCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docAddTb);
            this.Controls.Add(this.doctorDGV);
            this.Controls.Add(this.docPassWordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docExpTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docSpecCb);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.docDateCb);
            this.Controls.Add(this.docGenCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.docPhoneTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.docNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Doctors";
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.doctorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorDGV;
        private System.Windows.Forms.TextBox docPassWordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox docExpTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox docSpecCb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker docDateCb;
        private System.Windows.Forms.ComboBox docGenCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox docPhoneTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox docNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox docAddTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox docRoomNumCb;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
    }
}