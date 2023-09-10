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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.patContactTb = new System.Windows.Forms.TextBox();
            this.appoinmentDGV = new System.Windows.Forms.DataGridView();
            this.appionmentFrm = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.docNameCb = new System.Windows.Forms.ComboBox();
            this.roomNumCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.patNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.sheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reSheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // patContactTb
            // 
            this.patContactTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patContactTb.ForeColor = System.Drawing.Color.Black;
            this.patContactTb.Location = new System.Drawing.Point(529, 144);
            this.patContactTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patContactTb.Name = "patContactTb";
            this.patContactTb.Size = new System.Drawing.Size(196, 34);
            this.patContactTb.TabIndex = 111;
            // 
            // appoinmentDGV
            // 
            this.appoinmentDGV.BackgroundColor = System.Drawing.Color.White;
            this.appoinmentDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appoinmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmentDGV.GridColor = System.Drawing.Color.White;
            this.appoinmentDGV.Location = new System.Drawing.Point(37, 420);
            this.appoinmentDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appoinmentDGV.Name = "appoinmentDGV";
            this.appoinmentDGV.RowHeadersWidth = 62;
            this.appoinmentDGV.RowTemplate.Height = 28;
            this.appoinmentDGV.Size = new System.Drawing.Size(1088, 278);
            this.appoinmentDGV.TabIndex = 110;
            // 
            // appionmentFrm
            // 
            this.appionmentFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appionmentFrm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appionmentFrm.Location = new System.Drawing.Point(37, 33);
            this.appionmentFrm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appionmentFrm.Name = "appionmentFrm";
            this.appionmentFrm.Size = new System.Drawing.Size(474, 367);
            this.appionmentFrm.TabIndex = 109;
            this.appionmentFrm.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(529, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 106;
            this.label4.Text = "Contact Number";
            // 
            // docNameCb
            // 
            this.docNameCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameCb.FormattingEnabled = true;
            this.docNameCb.Location = new System.Drawing.Point(531, 229);
            this.docNameCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameCb.Name = "docNameCb";
            this.docNameCb.Size = new System.Drawing.Size(193, 33);
            this.docNameCb.TabIndex = 101;
            // 
            // roomNumCb
            // 
            this.roomNumCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumCb.FormattingEnabled = true;
            this.roomNumCb.Location = new System.Drawing.Point(739, 229);
            this.roomNumCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomNumCb.Name = "roomNumCb";
            this.roomNumCb.Size = new System.Drawing.Size(196, 33);
            this.roomNumCb.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(739, 201);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 25);
            this.label12.TabIndex = 97;
            this.label12.Text = "Room Number";
            // 
            // patNameTb
            // 
            this.patNameTb.Enabled = false;
            this.patNameTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameTb.ForeColor = System.Drawing.Color.Black;
            this.patNameTb.Location = new System.Drawing.Point(739, 61);
            this.patNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameTb.Name = "patNameTb";
            this.patNameTb.Size = new System.Drawing.Size(196, 34);
            this.patNameTb.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(739, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 25);
            this.label11.TabIndex = 95;
            this.label11.Text = "Patient Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(528, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 93;
            this.label9.Text = "Doctor Name";
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Location = new System.Drawing.Point(531, 62);
            this.patIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(193, 33);
            this.patIdCb.TabIndex = 114;
            this.patIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatIdCb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(528, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Patient Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(739, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 25);
            this.label13.TabIndex = 116;
            this.label13.Text = "Date";
            // 
            // appointmentDate
            // 
            this.appointmentDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDate.Location = new System.Drawing.Point(744, 143);
            this.appointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(196, 42);
            this.appointmentDate.TabIndex = 115;
            // 
            // sheduleBtn
            // 
            this.sheduleBtn.BackColor = System.Drawing.Color.White;
            this.sheduleBtn.BorderRadius = 8;
            this.sheduleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sheduleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sheduleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sheduleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sheduleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.sheduleBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheduleBtn.ForeColor = System.Drawing.Color.White;
            this.sheduleBtn.Location = new System.Drawing.Point(972, 116);
            this.sheduleBtn.Name = "sheduleBtn";
            this.sheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.sheduleBtn.TabIndex = 121;
            this.sheduleBtn.Text = "Schedule";
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
            this.cancelBtn.Location = new System.Drawing.Point(972, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(180, 45);
            this.cancelBtn.TabIndex = 120;
            this.cancelBtn.Text = "Cancel";
            // 
            // reSheduleBtn
            // 
            this.reSheduleBtn.BackColor = System.Drawing.Color.White;
            this.reSheduleBtn.BorderRadius = 8;
            this.reSheduleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reSheduleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reSheduleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reSheduleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reSheduleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.reSheduleBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reSheduleBtn.ForeColor = System.Drawing.Color.White;
            this.reSheduleBtn.Location = new System.Drawing.Point(972, 167);
            this.reSheduleBtn.Name = "reSheduleBtn";
            this.reSheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.reSheduleBtn.TabIndex = 119;
            this.reSheduleBtn.Text = "Re-Shedule";
            // 
            // AppointmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.sheduleBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.reSheduleBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patContactTb);
            this.Controls.Add(this.appoinmentDGV);
            this.Controls.Add(this.appionmentFrm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.docNameCb);
            this.Controls.Add(this.roomNumCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.patNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AppointmentBooking";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox patContactTb;
        private System.Windows.Forms.DataGridView appoinmentDGV;
        private System.Windows.Forms.RichTextBox appionmentFrm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox docNameCb;
        private System.Windows.Forms.ComboBox roomNumCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox patNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private Guna.UI2.WinForms.Guna2Button sheduleBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button reSheduleBtn;
    }
}