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
            this.label4 = new System.Windows.Forms.Label();
            this.patFirstNameTb = new System.Windows.Forms.TextBox();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reportGenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Specialization = new System.Windows.Forms.Label();
            this.docNameTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.appointmentDateDTP = new System.Windows.Forms.DateTimePicker();
            this.patLastNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patContactTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.docIdCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.specializationTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.docRoomTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.appoinmentSumTxt = new System.Windows.Forms.RichTextBox();
            this.docChargeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hospitalChargeTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.docAvailCb = new System.Windows.Forms.ComboBox();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 148;
            this.label4.Text = "Doctor Availabilty";
            // 
            // patFirstNameTb
            // 
            this.patFirstNameTb.Enabled = false;
            this.patFirstNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patFirstNameTb.ForeColor = System.Drawing.Color.Black;
            this.patFirstNameTb.Location = new System.Drawing.Point(267, 72);
            this.patFirstNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patFirstNameTb.Name = "patFirstNameTb";
            this.patFirstNameTb.Size = new System.Drawing.Size(325, 42);
            this.patFirstNameTb.TabIndex = 143;
            this.patFirstNameTb.TextChanged += new System.EventHandler(this.patIdTb_TextChanged);
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Location = new System.Drawing.Point(32, 72);
            this.patIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(209, 42);
            this.patIdCb.TabIndex = 142;
            this.patIdCb.SelectedIndexChanged += new System.EventHandler(this.patNameCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 141;
            this.label3.Text = "Patient Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(262, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 25);
            this.label12.TabIndex = 139;
            this.label12.Text = "First Name";
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
            this.sheduleBtn.Location = new System.Drawing.Point(639, 583);
            this.sheduleBtn.Name = "sheduleBtn";
            this.sheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.sheduleBtn.TabIndex = 137;
            this.sheduleBtn.Text = "Shedule";
            this.sheduleBtn.Click += new System.EventHandler(this.sheduleBtn_Click);
            // 
            // reportGenBtn
            // 
            this.reportGenBtn.BackColor = System.Drawing.Color.White;
            this.reportGenBtn.BorderRadius = 8;
            this.reportGenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportGenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportGenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportGenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportGenBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.reportGenBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportGenBtn.ForeColor = System.Drawing.Color.White;
            this.reportGenBtn.Location = new System.Drawing.Point(839, 583);
            this.reportGenBtn.Name = "reportGenBtn";
            this.reportGenBtn.Size = new System.Drawing.Size(221, 45);
            this.reportGenBtn.TabIndex = 135;
            this.reportGenBtn.Text = "Generate Report";
            this.reportGenBtn.Click += new System.EventHandler(this.reSheduleBtn_Click);
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization.ForeColor = System.Drawing.Color.Black;
            this.Specialization.Location = new System.Drawing.Point(262, 229);
            this.Specialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(158, 25);
            this.Specialization.TabIndex = 146;
            this.Specialization.Text = "Doctor Name";
            // 
            // docNameTb
            // 
            this.docNameTb.Enabled = false;
            this.docNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameTb.ForeColor = System.Drawing.Color.Black;
            this.docNameTb.Location = new System.Drawing.Point(267, 268);
            this.docNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameTb.Name = "docNameTb";
            this.docNameTb.Size = new System.Drawing.Size(325, 42);
            this.docNameTb.TabIndex = 147;
            this.docNameTb.TextChanged += new System.EventHandler(this.specializationTb_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(323, 452);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 25);
            this.label13.TabIndex = 153;
            this.label13.Text = "Appoinment Date";
            // 
            // appointmentDateDTP
            // 
            this.appointmentDateDTP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateDTP.Location = new System.Drawing.Point(323, 479);
            this.appointmentDateDTP.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentDateDTP.Name = "appointmentDateDTP";
            this.appointmentDateDTP.Size = new System.Drawing.Size(269, 42);
            this.appointmentDateDTP.TabIndex = 152;
            this.appointmentDateDTP.ValueChanged += new System.EventHandler(this.appointmentDateDTP_ValueChanged);
            // 
            // patLastNameTb
            // 
            this.patLastNameTb.Enabled = false;
            this.patLastNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patLastNameTb.ForeColor = System.Drawing.Color.Black;
            this.patLastNameTb.Location = new System.Drawing.Point(38, 173);
            this.patLastNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patLastNameTb.Name = "patLastNameTb";
            this.patLastNameTb.Size = new System.Drawing.Size(267, 42);
            this.patLastNameTb.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 154;
            this.label2.Text = "Last Name";
            // 
            // patContactTb
            // 
            this.patContactTb.Enabled = false;
            this.patContactTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patContactTb.ForeColor = System.Drawing.Color.Black;
            this.patContactTb.Location = new System.Drawing.Point(326, 173);
            this.patContactTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patContactTb.Name = "patContactTb";
            this.patContactTb.Size = new System.Drawing.Size(266, 42);
            this.patContactTb.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(321, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 156;
            this.label6.Text = "Contact No";
            // 
            // docIdCb
            // 
            this.docIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docIdCb.FormattingEnabled = true;
            this.docIdCb.Location = new System.Drawing.Point(38, 268);
            this.docIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docIdCb.Name = "docIdCb";
            this.docIdCb.Size = new System.Drawing.Size(209, 42);
            this.docIdCb.TabIndex = 159;
            this.docIdCb.SelectedIndexChanged += new System.EventHandler(this.docIdCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 158;
            this.label7.Text = "Doctor Id";
            // 
            // specializationTb
            // 
            this.specializationTb.Enabled = false;
            this.specializationTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specializationTb.ForeColor = System.Drawing.Color.Black;
            this.specializationTb.Location = new System.Drawing.Point(38, 375);
            this.specializationTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.specializationTb.Name = "specializationTb";
            this.specializationTb.Size = new System.Drawing.Size(318, 42);
            this.specializationTb.TabIndex = 161;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 160;
            this.label8.Text = "Specialization";
            // 
            // docRoomTb
            // 
            this.docRoomTb.Enabled = false;
            this.docRoomTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomTb.ForeColor = System.Drawing.Color.Black;
            this.docRoomTb.Location = new System.Drawing.Point(383, 375);
            this.docRoomTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docRoomTb.Name = "docRoomTb";
            this.docRoomTb.Size = new System.Drawing.Size(211, 42);
            this.docRoomTb.TabIndex = 163;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(378, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 162;
            this.label9.Text = "Room No";
            // 
            // appoinmentSumTxt
            // 
            this.appoinmentSumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appoinmentSumTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinmentSumTxt.Location = new System.Drawing.Point(626, 72);
            this.appoinmentSumTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appoinmentSumTxt.Name = "appoinmentSumTxt";
            this.appoinmentSumTxt.Size = new System.Drawing.Size(477, 449);
            this.appoinmentSumTxt.TabIndex = 164;
            this.appoinmentSumTxt.Text = "";
            this.appoinmentSumTxt.TextChanged += new System.EventHandler(this.appoinmentSumTxt_TextChanged);
            // 
            // docChargeTb
            // 
            this.docChargeTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docChargeTb.ForeColor = System.Drawing.Color.Black;
            this.docChargeTb.Location = new System.Drawing.Point(329, 586);
            this.docChargeTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docChargeTb.Name = "docChargeTb";
            this.docChargeTb.Size = new System.Drawing.Size(266, 42);
            this.docChargeTb.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(324, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 168;
            this.label1.Text = "Doctor Charge";
            // 
            // hospitalChargeTb
            // 
            this.hospitalChargeTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalChargeTb.ForeColor = System.Drawing.Color.Black;
            this.hospitalChargeTb.Location = new System.Drawing.Point(41, 586);
            this.hospitalChargeTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hospitalChargeTb.Name = "hospitalChargeTb";
            this.hospitalChargeTb.Size = new System.Drawing.Size(267, 42);
            this.hospitalChargeTb.TabIndex = 167;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 166;
            this.label5.Text = "Hospital Charge";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // docAvailCb
            // 
            this.docAvailCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docAvailCb.FormattingEnabled = true;
            this.docAvailCb.Location = new System.Drawing.Point(38, 479);
            this.docAvailCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docAvailCb.Name = "docAvailCb";
            this.docAvailCb.Size = new System.Drawing.Size(266, 42);
            this.docAvailCb.TabIndex = 170;
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
            this.refreshBtn.Location = new System.Drawing.Point(734, 643);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 171;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // AppointmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.docAvailCb);
            this.Controls.Add(this.docChargeTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hospitalChargeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appoinmentSumTxt);
            this.Controls.Add(this.docRoomTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specializationTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.docIdCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.patContactTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patLastNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.appointmentDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.docNameTb);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.patFirstNameTb);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sheduleBtn);
            this.Controls.Add(this.reportGenBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AppointmentBooking";
            this.Text = "Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patFirstNameTb;
        private System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button sheduleBtn;
        private Guna.UI2.WinForms.Guna2Button reportGenBtn;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.TextBox docNameTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker appointmentDateDTP;
        private System.Windows.Forms.TextBox patLastNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patContactTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox docIdCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox specializationTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox docRoomTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox appoinmentSumTxt;
        private System.Windows.Forms.TextBox docChargeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hospitalChargeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox docAvailCb;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
    }
}