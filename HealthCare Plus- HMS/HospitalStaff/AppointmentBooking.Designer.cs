namespace HealthCare_Plus__HMS.Staff
{
    partial class AppointmentBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentBooking));
            this.docRoomNumTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.docNameCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patContactTb = new System.Windows.Forms.TextBox();
            this.patNameCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appoinmentNoteTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reSheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.appoinmenysLoadDGV = new System.Windows.Forms.DataGridView();
            this.Specialization = new System.Windows.Forms.Label();
            this.specializationTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.appointmentDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmenysLoadDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // docRoomNumTb
            // 
            this.docRoomNumTb.Enabled = false;
            this.docRoomNumTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomNumTb.ForeColor = System.Drawing.Color.Black;
            this.docRoomNumTb.Location = new System.Drawing.Point(34, 163);
            this.docRoomNumTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docRoomNumTb.Name = "docRoomNumTb";
            this.docRoomNumTb.Size = new System.Drawing.Size(211, 42);
            this.docRoomNumTb.TabIndex = 151;
            this.docRoomNumTb.TextChanged += new System.EventHandler(this.docRoomNumTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 150;
            this.label5.Text = "Room No";
            // 
            // statusCb
            // 
            this.statusCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Cancelled"});
            this.statusCb.Location = new System.Drawing.Point(268, 163);
            this.statusCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(209, 42);
            this.statusCb.TabIndex = 149;
            this.statusCb.SelectedIndexChanged += new System.EventHandler(this.statusCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(263, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 148;
            this.label4.Text = "Status";
            // 
            // docNameCb
            // 
            this.docNameCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameCb.FormattingEnabled = true;
            this.docNameCb.Location = new System.Drawing.Point(490, 67);
            this.docNameCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameCb.Name = "docNameCb";
            this.docNameCb.Size = new System.Drawing.Size(209, 42);
            this.docNameCb.TabIndex = 145;
            this.docNameCb.SelectedIndexChanged += new System.EventHandler(this.docNameCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(486, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 144;
            this.label1.Text = "Doctor Name";
            // 
            // patContactTb
            // 
            this.patContactTb.Enabled = false;
            this.patContactTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patContactTb.ForeColor = System.Drawing.Color.Black;
            this.patContactTb.Location = new System.Drawing.Point(266, 67);
            this.patContactTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patContactTb.Name = "patContactTb";
            this.patContactTb.Size = new System.Drawing.Size(211, 42);
            this.patContactTb.TabIndex = 143;
            this.patContactTb.TextChanged += new System.EventHandler(this.patIdTb_TextChanged);
            // 
            // patNameCb
            // 
            this.patNameCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameCb.FormattingEnabled = true;
            this.patNameCb.Location = new System.Drawing.Point(36, 67);
            this.patNameCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameCb.Name = "patNameCb";
            this.patNameCb.Size = new System.Drawing.Size(209, 42);
            this.patNameCb.TabIndex = 142;
            this.patNameCb.SelectedIndexChanged += new System.EventHandler(this.patNameCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 141;
            this.label3.Text = "Patient Name";
            // 
            // appoinmentNoteTb
            // 
            this.appoinmentNoteTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinmentNoteTb.ForeColor = System.Drawing.Color.Black;
            this.appoinmentNoteTb.Location = new System.Drawing.Point(491, 163);
            this.appoinmentNoteTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appoinmentNoteTb.Multiline = true;
            this.appoinmentNoteTb.Name = "appoinmentNoteTb";
            this.appoinmentNoteTb.Size = new System.Drawing.Size(208, 42);
            this.appoinmentNoteTb.TabIndex = 140;
            this.appoinmentNoteTb.TextChanged += new System.EventHandler(this.appoinmentNoteTb_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(261, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 139;
            this.label12.Text = "Contact No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(487, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 25);
            this.label10.TabIndex = 138;
            this.label10.Text = "Appointment Notes";
            // 
            // sheduleBtn
            // 
            this.sheduleBtn.BackColor = System.Drawing.Color.White;
            this.sheduleBtn.BorderRadius = 8;
            this.sheduleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sheduleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sheduleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sheduleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sheduleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.sheduleBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheduleBtn.ForeColor = System.Drawing.Color.White;
            this.sheduleBtn.Location = new System.Drawing.Point(945, 41);
            this.sheduleBtn.Name = "sheduleBtn";
            this.sheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.sheduleBtn.TabIndex = 137;
            this.sheduleBtn.Text = "Shedule";
            this.sheduleBtn.Click += new System.EventHandler(this.sheduleBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.BorderRadius = 8;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(945, 143);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(180, 45);
            this.cancelBtn.TabIndex = 136;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // reSheduleBtn
            // 
            this.reSheduleBtn.BackColor = System.Drawing.Color.White;
            this.reSheduleBtn.BorderRadius = 8;
            this.reSheduleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reSheduleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reSheduleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reSheduleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reSheduleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.reSheduleBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reSheduleBtn.ForeColor = System.Drawing.Color.White;
            this.reSheduleBtn.Location = new System.Drawing.Point(945, 92);
            this.reSheduleBtn.Name = "reSheduleBtn";
            this.reSheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.reSheduleBtn.TabIndex = 135;
            this.reSheduleBtn.Text = "Re-Shedule";
            this.reSheduleBtn.Click += new System.EventHandler(this.reSheduleBtn_Click);
            // 
            // appoinmenysLoadDGV
            // 
            this.appoinmenysLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.appoinmenysLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appoinmenysLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmenysLoadDGV.GridColor = System.Drawing.Color.White;
            this.appoinmenysLoadDGV.Location = new System.Drawing.Point(36, 321);
            this.appoinmenysLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.appoinmenysLoadDGV.Name = "appoinmenysLoadDGV";
            this.appoinmenysLoadDGV.RowHeadersWidth = 62;
            this.appoinmenysLoadDGV.RowTemplate.Height = 28;
            this.appoinmenysLoadDGV.Size = new System.Drawing.Size(1089, 364);
            this.appoinmenysLoadDGV.TabIndex = 134;
            this.appoinmenysLoadDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appoinmenysLoadDGV_CellContentClick);
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization.ForeColor = System.Drawing.Color.Black;
            this.Specialization.Location = new System.Drawing.Point(714, 33);
            this.Specialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(158, 25);
            this.Specialization.TabIndex = 146;
            this.Specialization.Text = "Specialization";
            // 
            // specializationTb
            // 
            this.specializationTb.Enabled = false;
            this.specializationTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specializationTb.ForeColor = System.Drawing.Color.Black;
            this.specializationTb.Location = new System.Drawing.Point(719, 67);
            this.specializationTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.specializationTb.Name = "specializationTb";
            this.specializationTb.Size = new System.Drawing.Size(211, 42);
            this.specializationTb.TabIndex = 147;
            this.specializationTb.TextChanged += new System.EventHandler(this.specializationTb_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(719, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 153;
            this.label13.Text = "DOB";
            // 
            // appointmentDateDTP
            // 
            this.appointmentDateDTP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateDTP.Location = new System.Drawing.Point(719, 160);
            this.appointmentDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentDateDTP.Name = "appointmentDateDTP";
            this.appointmentDateDTP.Size = new System.Drawing.Size(211, 42);
            this.appointmentDateDTP.TabIndex = 152;
            this.appointmentDateDTP.ValueChanged += new System.EventHandler(this.appointmentDateDTP_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 155;
            this.label2.Text = "Search by Name";
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
            this.searchTb.Location = new System.Drawing.Point(38, 266);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(377, 46);
            this.searchTb.TabIndex = 154;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // AppointmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.appointmentDateDTP);
            this.Controls.Add(this.docRoomNumTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specializationTb);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.docNameCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patContactTb);
            this.Controls.Add(this.patNameCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appoinmentNoteTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sheduleBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.reSheduleBtn);
            this.Controls.Add(this.appoinmenysLoadDGV);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AppointmentBooking";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.appoinmenysLoadDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docRoomNumTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox docNameCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patContactTb;
        private System.Windows.Forms.ComboBox patNameCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appoinmentNoteTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button sheduleBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button reSheduleBtn;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.TextBox specializationTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker appointmentDateDTP;
        private System.Windows.Forms.DataGridView appoinmenysLoadDGV;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
    }
}