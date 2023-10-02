namespace HealthCare_Plus__HMS.HospitalStaff
{
    partial class ViewAppoinments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppoinments));
            this.patStatusCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patNameTb = new System.Windows.Forms.TextBox();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appoinNoteTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reSheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.appoinmenysLoadDGV = new System.Windows.Forms.DataGridView();
            this.iconPictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.appDateCb = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmenysLoadDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // patStatusCb
            // 
            this.patStatusCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patStatusCb.FormattingEnabled = true;
            this.patStatusCb.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Cancelled"});
            this.patStatusCb.Location = new System.Drawing.Point(491, 114);
            this.patStatusCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patStatusCb.Name = "patStatusCb";
            this.patStatusCb.Size = new System.Drawing.Size(209, 42);
            this.patStatusCb.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(486, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 142;
            this.label4.Text = "Status";
            // 
            // patNameTb
            // 
            this.patNameTb.Enabled = false;
            this.patNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameTb.ForeColor = System.Drawing.Color.Black;
            this.patNameTb.Location = new System.Drawing.Point(265, 116);
            this.patNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameTb.Name = "patNameTb";
            this.patNameTb.Size = new System.Drawing.Size(211, 42);
            this.patNameTb.TabIndex = 141;
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Location = new System.Drawing.Point(35, 116);
            this.patIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(209, 42);
            this.patIdCb.TabIndex = 140;
            this.patIdCb.SelectedIndexChanged += new System.EventHandler(this.patIdCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(260, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "Patient Name";
            // 
            // appoinNoteTb
            // 
            this.appoinNoteTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinNoteTb.ForeColor = System.Drawing.Color.Black;
            this.appoinNoteTb.Location = new System.Drawing.Point(712, 114);
            this.appoinNoteTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appoinNoteTb.Multiline = true;
            this.appoinNoteTb.Name = "appoinNoteTb";
            this.appoinNoteTb.Size = new System.Drawing.Size(210, 42);
            this.appoinNoteTb.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 137;
            this.label12.Text = "Patient Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(708, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 25);
            this.label10.TabIndex = 136;
            this.label10.Text = "Appointment Notes";
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
            this.refreshBtn.Location = new System.Drawing.Point(944, 162);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 135;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
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
            this.reSheduleBtn.Location = new System.Drawing.Point(944, 111);
            this.reSheduleBtn.Name = "reSheduleBtn";
            this.reSheduleBtn.Size = new System.Drawing.Size(180, 45);
            this.reSheduleBtn.TabIndex = 133;
            this.reSheduleBtn.Text = "Re-Shedule";
            this.reSheduleBtn.Click += new System.EventHandler(this.reSheduleBtn_Click);
            // 
            // appoinmenysLoadDGV
            // 
            this.appoinmenysLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.appoinmenysLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appoinmenysLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmenysLoadDGV.GridColor = System.Drawing.Color.White;
            this.appoinmenysLoadDGV.Location = new System.Drawing.Point(35, 330);
            this.appoinmenysLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.appoinmenysLoadDGV.Name = "appoinmenysLoadDGV";
            this.appoinmenysLoadDGV.RowHeadersWidth = 62;
            this.appoinmenysLoadDGV.RowTemplate.Height = 28;
            this.appoinmenysLoadDGV.Size = new System.Drawing.Size(1089, 355);
            this.appoinmenysLoadDGV.TabIndex = 132;
            this.appoinmenysLoadDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appoinmenysLoadDGV_CellContentClick);
            // 
            // iconPictureBoxClose
            // 
            this.iconPictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxClose.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.iconPictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconPictureBoxClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.iconPictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClose.IconSize = 31;
            this.iconPictureBoxClose.Location = new System.Drawing.Point(1111, 15);
            this.iconPictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.iconPictureBoxClose.Name = "iconPictureBoxClose";
            this.iconPictureBoxClose.Size = new System.Drawing.Size(31, 36);
            this.iconPictureBoxClose.TabIndex = 144;
            this.iconPictureBoxClose.TabStop = false;
            this.iconPictureBoxClose.Click += new System.EventHandler(this.iconPictureBoxClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(618, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 23);
            this.label2.TabIndex = 146;
            this.label2.Text = "Search by Name, Appoinetment Id or Dotor Name";
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
            this.searchTb.Location = new System.Drawing.Point(623, 256);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(501, 46);
            this.searchTb.TabIndex = 145;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(35, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 25);
            this.label13.TabIndex = 148;
            this.label13.Text = "Date";
            // 
            // appDateCb
            // 
            this.appDateCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDateCb.Location = new System.Drawing.Point(35, 206);
            this.appDateCb.Margin = new System.Windows.Forms.Padding(2);
            this.appDateCb.Name = "appDateCb";
            this.appDateCb.Size = new System.Drawing.Size(259, 37);
            this.appDateCb.TabIndex = 147;
            // 
            // ViewAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.appDateCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.iconPictureBoxClose);
            this.Controls.Add(this.patStatusCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patNameTb);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appoinNoteTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.reSheduleBtn);
            this.Controls.Add(this.appoinmenysLoadDGV);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ViewAppoinments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAppoinments";
            ((System.ComponentModel.ISupportInitialize)(this.appoinmenysLoadDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patStatusCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patNameTb;
        private System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appoinNoteTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button reSheduleBtn;
        private System.Windows.Forms.DataGridView appoinmenysLoadDGV;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClose;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker appDateCb;
    }
}