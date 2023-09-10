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
            this.PatContactTb = new System.Windows.Forms.TextBox();
            this.AppoinmentDGV = new System.Windows.Forms.DataGridView();
            this.AppionmentFrm = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocNameCb = new System.Windows.Forms.ComboBox();
            this.RoomNumCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PatIdCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reSheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentDGV)).BeginInit();
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
            // PatContactTb
            // 
            this.PatContactTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatContactTb.ForeColor = System.Drawing.Color.Black;
            this.PatContactTb.Location = new System.Drawing.Point(529, 144);
            this.PatContactTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatContactTb.Name = "PatContactTb";
            this.PatContactTb.Size = new System.Drawing.Size(196, 34);
            this.PatContactTb.TabIndex = 111;
            // 
            // AppoinmentDGV
            // 
            this.AppoinmentDGV.BackgroundColor = System.Drawing.Color.White;
            this.AppoinmentDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AppoinmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppoinmentDGV.GridColor = System.Drawing.Color.White;
            this.AppoinmentDGV.Location = new System.Drawing.Point(37, 420);
            this.AppoinmentDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AppoinmentDGV.Name = "AppoinmentDGV";
            this.AppoinmentDGV.RowHeadersWidth = 62;
            this.AppoinmentDGV.RowTemplate.Height = 28;
            this.AppoinmentDGV.Size = new System.Drawing.Size(1088, 278);
            this.AppoinmentDGV.TabIndex = 110;
            // 
            // AppionmentFrm
            // 
            this.AppionmentFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppionmentFrm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppionmentFrm.Location = new System.Drawing.Point(37, 33);
            this.AppionmentFrm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AppionmentFrm.Name = "AppionmentFrm";
            this.AppionmentFrm.Size = new System.Drawing.Size(474, 367);
            this.AppionmentFrm.TabIndex = 109;
            this.AppionmentFrm.Text = "";
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
            // DocNameCb
            // 
            this.DocNameCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNameCb.FormattingEnabled = true;
            this.DocNameCb.Location = new System.Drawing.Point(531, 229);
            this.DocNameCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DocNameCb.Name = "DocNameCb";
            this.DocNameCb.Size = new System.Drawing.Size(193, 33);
            this.DocNameCb.TabIndex = 101;
            // 
            // RoomNumCb
            // 
            this.RoomNumCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumCb.FormattingEnabled = true;
            this.RoomNumCb.Location = new System.Drawing.Point(739, 229);
            this.RoomNumCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RoomNumCb.Name = "RoomNumCb";
            this.RoomNumCb.Size = new System.Drawing.Size(196, 33);
            this.RoomNumCb.TabIndex = 98;
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
            // PatNameTb
            // 
            this.PatNameTb.Enabled = false;
            this.PatNameTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.ForeColor = System.Drawing.Color.Black;
            this.PatNameTb.Location = new System.Drawing.Point(739, 61);
            this.PatNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(196, 34);
            this.PatNameTb.TabIndex = 96;
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
            // PatIdCb
            // 
            this.PatIdCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatIdCb.FormattingEnabled = true;
            this.PatIdCb.Location = new System.Drawing.Point(531, 62);
            this.PatIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatIdCb.Name = "PatIdCb";
            this.PatIdCb.Size = new System.Drawing.Size(193, 33);
            this.PatIdCb.TabIndex = 114;
            this.PatIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatIdCb_SelectionChangeCommitted);
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
            // AppointmentDate
            // 
            this.AppointmentDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDate.Location = new System.Drawing.Point(744, 143);
            this.AppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(196, 42);
            this.AppointmentDate.TabIndex = 115;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.White;
            this.viewBtn.BorderRadius = 8;
            this.viewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.viewBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(972, 116);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(180, 45);
            this.viewBtn.TabIndex = 121;
            this.viewBtn.Text = "Schedule";
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
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.reSheduleBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AppointmentDate);
            this.Controls.Add(this.PatIdCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatContactTb);
            this.Controls.Add(this.AppoinmentDGV);
            this.Controls.Add(this.AppionmentFrm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocNameCb);
            this.Controls.Add(this.RoomNumCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Appointments";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox PatContactTb;
        private System.Windows.Forms.DataGridView AppoinmentDGV;
        private System.Windows.Forms.RichTextBox AppionmentFrm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DocNameCb;
        private System.Windows.Forms.ComboBox RoomNumCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PatIdCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker AppointmentDate;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button reSheduleBtn;
    }
}