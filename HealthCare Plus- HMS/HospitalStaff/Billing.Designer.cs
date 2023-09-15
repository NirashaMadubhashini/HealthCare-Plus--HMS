namespace HealthCare_Plus__HMS.BillingStaff
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.label2 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.patNameCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patNameTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.contactTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.docNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.docSpecializationTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.docRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doctorChargeTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hospitalChargeTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(785, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 23);
            this.label2.TabIndex = 177;
            this.label2.Text = "Search by Appoinment Number";
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
            this.searchTb.Location = new System.Drawing.Point(789, 268);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(336, 46);
            this.searchTb.TabIndex = 176;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patNameCb
            // 
            this.patNameCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameCb.FormattingEnabled = true;
            this.patNameCb.Location = new System.Drawing.Point(36, 67);
            this.patNameCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameCb.Name = "patNameCb";
            this.patNameCb.Size = new System.Drawing.Size(236, 42);
            this.patNameCb.TabIndex = 164;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 163;
            this.label3.Text = "Appoinment Number";
            // 
            // patNameTb
            // 
            this.patNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameTb.ForeColor = System.Drawing.Color.Black;
            this.patNameTb.Location = new System.Drawing.Point(292, 67);
            this.patNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameTb.Multiline = true;
            this.patNameTb.Name = "patNameTb";
            this.patNameTb.Size = new System.Drawing.Size(226, 42);
            this.patNameTb.TabIndex = 162;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(287, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 161;
            this.label12.Text = "Patient Name";
            // 
            // addBillBtn
            // 
            this.addBillBtn.BackColor = System.Drawing.Color.White;
            this.addBillBtn.BorderRadius = 8;
            this.addBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.addBillBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBillBtn.ForeColor = System.Drawing.Color.White;
            this.addBillBtn.Location = new System.Drawing.Point(945, 26);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(180, 45);
            this.addBillBtn.TabIndex = 159;
            this.addBillBtn.Text = "Add Bill";
            // 
            // deleteBillBtn
            // 
            this.deleteBillBtn.BackColor = System.Drawing.Color.White;
            this.deleteBillBtn.BorderRadius = 8;
            this.deleteBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBillBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBillBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBillBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBillBtn.Location = new System.Drawing.Point(945, 128);
            this.deleteBillBtn.Name = "deleteBillBtn";
            this.deleteBillBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBillBtn.TabIndex = 158;
            this.deleteBillBtn.Text = "Delete Bill";
            // 
            // updateBillBtn
            // 
            this.updateBillBtn.BackColor = System.Drawing.Color.White;
            this.updateBillBtn.BorderRadius = 8;
            this.updateBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.updateBillBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBillBtn.ForeColor = System.Drawing.Color.White;
            this.updateBillBtn.Location = new System.Drawing.Point(945, 77);
            this.updateBillBtn.Name = "updateBillBtn";
            this.updateBillBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBillBtn.TabIndex = 157;
            this.updateBillBtn.Text = "Update Bill";
            // 
            // BillDGV
            // 
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.GridColor = System.Drawing.Color.White;
            this.BillDGV.Location = new System.Drawing.Point(36, 321);
            this.BillDGV.Margin = new System.Windows.Forms.Padding(2);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersWidth = 62;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.Size = new System.Drawing.Size(1089, 364);
            this.BillDGV.TabIndex = 156;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.BorderRadius = 8;
            this.refreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshBtn.FillColor = System.Drawing.Color.Gray;
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(945, 179);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 178;
            this.refreshBtn.Text = "Refresh";
            // 
            // contactTb
            // 
            this.contactTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTb.ForeColor = System.Drawing.Color.Black;
            this.contactTb.Location = new System.Drawing.Point(542, 67);
            this.contactTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contactTb.Multiline = true;
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(226, 42);
            this.contactTb.TabIndex = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(537, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 179;
            this.label1.Text = "Contact";
            // 
            // docNameTb
            // 
            this.docNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameTb.ForeColor = System.Drawing.Color.Black;
            this.docNameTb.Location = new System.Drawing.Point(38, 146);
            this.docNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameTb.Multiline = true;
            this.docNameTb.Name = "docNameTb";
            this.docNameTb.Size = new System.Drawing.Size(226, 42);
            this.docNameTb.TabIndex = 182;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 181;
            this.label4.Text = "Doctor Name";
            // 
            // docSpecializationTb
            // 
            this.docSpecializationTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docSpecializationTb.ForeColor = System.Drawing.Color.Black;
            this.docSpecializationTb.Location = new System.Drawing.Point(292, 146);
            this.docSpecializationTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docSpecializationTb.Multiline = true;
            this.docSpecializationTb.Name = "docSpecializationTb";
            this.docSpecializationTb.Size = new System.Drawing.Size(226, 42);
            this.docSpecializationTb.TabIndex = 184;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(287, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 183;
            this.label5.Text = "Specialization";
            // 
            // docRoomNo
            // 
            this.docRoomNo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomNo.ForeColor = System.Drawing.Color.Black;
            this.docRoomNo.Location = new System.Drawing.Point(542, 146);
            this.docRoomNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docRoomNo.Multiline = true;
            this.docRoomNo.Name = "docRoomNo";
            this.docRoomNo.Size = new System.Drawing.Size(226, 42);
            this.docRoomNo.TabIndex = 186;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(537, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 185;
            this.label6.Text = "Room No";
            // 
            // totalTb
            // 
            this.totalTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTb.ForeColor = System.Drawing.Color.Black;
            this.totalTb.Location = new System.Drawing.Point(542, 237);
            this.totalTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.totalTb.Multiline = true;
            this.totalTb.Name = "totalTb";
            this.totalTb.Size = new System.Drawing.Size(226, 42);
            this.totalTb.TabIndex = 192;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(537, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 191;
            this.label7.Text = "Total Amount";
            // 
            // doctorChargeTb
            // 
            this.doctorChargeTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorChargeTb.ForeColor = System.Drawing.Color.Black;
            this.doctorChargeTb.Location = new System.Drawing.Point(292, 237);
            this.doctorChargeTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doctorChargeTb.Multiline = true;
            this.doctorChargeTb.Name = "doctorChargeTb";
            this.doctorChargeTb.Size = new System.Drawing.Size(226, 42);
            this.doctorChargeTb.TabIndex = 190;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(287, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 189;
            this.label8.Text = "Doctor Charge";
            // 
            // hospitalChargeTb
            // 
            this.hospitalChargeTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalChargeTb.ForeColor = System.Drawing.Color.Black;
            this.hospitalChargeTb.Location = new System.Drawing.Point(38, 237);
            this.hospitalChargeTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hospitalChargeTb.Multiline = true;
            this.hospitalChargeTb.Name = "hospitalChargeTb";
            this.hospitalChargeTb.Size = new System.Drawing.Size(226, 42);
            this.hospitalChargeTb.TabIndex = 188;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 187;
            this.label9.Text = "Hospital Charge";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.totalTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doctorChargeTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hospitalChargeTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.docRoomNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.docSpecializationTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.docNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contactTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.patNameCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patNameTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.deleteBillBtn);
            this.Controls.Add(this.updateBillBtn);
            this.Controls.Add(this.BillDGV);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private System.Windows.Forms.ComboBox patNameCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patNameTb;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button addBillBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBillBtn;
        private Guna.UI2.WinForms.Guna2Button updateBillBtn;
        private System.Windows.Forms.DataGridView BillDGV;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private System.Windows.Forms.TextBox contactTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox docNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox docSpecializationTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox docRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doctorChargeTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hospitalChargeTb;
        private System.Windows.Forms.Label label9;
    }
}