namespace HealthCare_Plus__HMS.HospitalStaff
{
    partial class DoctorAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorAvailability));
            this.docRoomTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.docIdCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.docNameTb = new System.Windows.Forms.TextBox();
            this.Specialization = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.docSpecTb = new System.Windows.Forms.TextBox();
            this.docAvailableDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.startTimeCb = new System.Windows.Forms.DateTimePicker();
            this.endTimeCb = new System.Windows.Forms.DateTimePicker();
            this.mondayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tuesdayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.wednesdayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.saturdayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.fridayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.thursdayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sundayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.vacationCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.docAvailableDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // docRoomTb
            // 
            this.docRoomTb.Enabled = false;
            this.docRoomTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docRoomTb.ForeColor = System.Drawing.Color.Black;
            this.docRoomTb.Location = new System.Drawing.Point(35, 334);
            this.docRoomTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docRoomTb.Name = "docRoomTb";
            this.docRoomTb.Size = new System.Drawing.Size(252, 42);
            this.docRoomTb.TabIndex = 191;
            this.docRoomTb.TextChanged += new System.EventHandler(this.docRoomTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 190;
            this.label9.Text = "Room No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 188;
            this.label8.Text = "Specialization";
            // 
            // docIdCb
            // 
            this.docIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docIdCb.FormattingEnabled = true;
            this.docIdCb.Location = new System.Drawing.Point(32, 80);
            this.docIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docIdCb.Name = "docIdCb";
            this.docIdCb.Size = new System.Drawing.Size(255, 42);
            this.docIdCb.TabIndex = 187;
            this.docIdCb.SelectedIndexChanged += new System.EventHandler(this.docIdCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 186;
            this.label7.Text = "Doctor Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(322, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 25);
            this.label13.TabIndex = 181;
            this.label13.Text = "Week Days";
            // 
            // docNameTb
            // 
            this.docNameTb.Enabled = false;
            this.docNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameTb.ForeColor = System.Drawing.Color.Black;
            this.docNameTb.Location = new System.Drawing.Point(32, 166);
            this.docNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameTb.Name = "docNameTb";
            this.docNameTb.Size = new System.Drawing.Size(255, 42);
            this.docNameTb.TabIndex = 178;
            this.docNameTb.TextChanged += new System.EventHandler(this.docNameTb_TextChanged);
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization.ForeColor = System.Drawing.Color.Black;
            this.Specialization.Location = new System.Drawing.Point(27, 127);
            this.Specialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(158, 25);
            this.Specialization.TabIndex = 177;
            this.Specialization.Text = "Doctor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(532, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 179;
            this.label4.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(533, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 198;
            this.label2.Text = "End Time";
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
            this.deleteBtn.Location = new System.Drawing.Point(931, 143);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 201;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(931, 92);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 200;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.addBtn.Location = new System.Drawing.Point(931, 41);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 199;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // docSpecTb
            // 
            this.docSpecTb.Enabled = false;
            this.docSpecTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docSpecTb.ForeColor = System.Drawing.Color.Black;
            this.docSpecTb.Location = new System.Drawing.Point(35, 249);
            this.docSpecTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docSpecTb.Name = "docSpecTb";
            this.docSpecTb.Size = new System.Drawing.Size(252, 42);
            this.docSpecTb.TabIndex = 202;
            this.docSpecTb.TextChanged += new System.EventHandler(this.docSpecTb_TextChanged);
            // 
            // docAvailableDGV
            // 
            this.docAvailableDGV.BackgroundColor = System.Drawing.Color.White;
            this.docAvailableDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.docAvailableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docAvailableDGV.GridColor = System.Drawing.Color.White;
            this.docAvailableDGV.Location = new System.Drawing.Point(32, 395);
            this.docAvailableDGV.Margin = new System.Windows.Forms.Padding(2);
            this.docAvailableDGV.Name = "docAvailableDGV";
            this.docAvailableDGV.RowHeadersWidth = 62;
            this.docAvailableDGV.RowTemplate.Height = 28;
            this.docAvailableDGV.Size = new System.Drawing.Size(1079, 284);
            this.docAvailableDGV.TabIndex = 203;
            this.docAvailableDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docAvailableDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(710, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 23);
            this.label3.TabIndex = 205;
            this.label3.Text = "Search by Name,Date and Time";
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
            this.searchTb.Location = new System.Drawing.Point(715, 330);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(396, 46);
            this.searchTb.TabIndex = 204;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // startTimeCb
            // 
            this.startTimeCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeCb.Location = new System.Drawing.Point(537, 80);
            this.startTimeCb.Name = "startTimeCb";
            this.startTimeCb.Size = new System.Drawing.Size(256, 37);
            this.startTimeCb.TabIndex = 206;
            this.startTimeCb.Value = new System.DateTime(2023, 9, 14, 11, 3, 0, 0);
            this.startTimeCb.ValueChanged += new System.EventHandler(this.startTimeCb_ValueChanged);
            // 
            // endTimeCb
            // 
            this.endTimeCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeCb.Location = new System.Drawing.Point(537, 166);
            this.endTimeCb.Name = "endTimeCb";
            this.endTimeCb.Size = new System.Drawing.Size(256, 37);
            this.endTimeCb.TabIndex = 207;
            this.endTimeCb.Value = new System.DateTime(2023, 9, 14, 11, 3, 0, 0);
            this.endTimeCb.ValueChanged += new System.EventHandler(this.endTimeCb_ValueChanged);
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mondayCheckBox.CheckedState.BorderRadius = 0;
            this.mondayCheckBox.CheckedState.BorderThickness = 0;
            this.mondayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mondayCheckBox.Location = new System.Drawing.Point(327, 80);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(138, 34);
            this.mondayCheckBox.TabIndex = 210;
            this.mondayCheckBox.Text = "Monday";
            this.mondayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mondayCheckBox.UncheckedState.BorderRadius = 0;
            this.mondayCheckBox.UncheckedState.BorderThickness = 0;
            this.mondayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mondayCheckBox.CheckedChanged += new System.EventHandler(this.mondayCheckBox_CheckedChanged);
            // 
            // tuesdayCheckBox
            // 
            this.tuesdayCheckBox.AutoSize = true;
            this.tuesdayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tuesdayCheckBox.CheckedState.BorderRadius = 0;
            this.tuesdayCheckBox.CheckedState.BorderThickness = 0;
            this.tuesdayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tuesdayCheckBox.Location = new System.Drawing.Point(327, 127);
            this.tuesdayCheckBox.Name = "tuesdayCheckBox";
            this.tuesdayCheckBox.Size = new System.Drawing.Size(136, 34);
            this.tuesdayCheckBox.TabIndex = 211;
            this.tuesdayCheckBox.Text = "Tuesday";
            this.tuesdayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tuesdayCheckBox.UncheckedState.BorderRadius = 0;
            this.tuesdayCheckBox.UncheckedState.BorderThickness = 0;
            this.tuesdayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tuesdayCheckBox.CheckedChanged += new System.EventHandler(this.tuesdayCheckBox_CheckedChanged);
            // 
            // wednesdayCheckBox
            // 
            this.wednesdayCheckBox.AutoSize = true;
            this.wednesdayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wednesdayCheckBox.CheckedState.BorderRadius = 0;
            this.wednesdayCheckBox.CheckedState.BorderThickness = 0;
            this.wednesdayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wednesdayCheckBox.Location = new System.Drawing.Point(327, 174);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(180, 34);
            this.wednesdayCheckBox.TabIndex = 212;
            this.wednesdayCheckBox.Text = "Wednesday";
            this.wednesdayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wednesdayCheckBox.UncheckedState.BorderRadius = 0;
            this.wednesdayCheckBox.UncheckedState.BorderThickness = 0;
            this.wednesdayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wednesdayCheckBox.CheckedChanged += new System.EventHandler(this.wednesdayCheckBox_CheckedChanged);
            // 
            // saturdayCheckBox
            // 
            this.saturdayCheckBox.AutoSize = true;
            this.saturdayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saturdayCheckBox.CheckedState.BorderRadius = 0;
            this.saturdayCheckBox.CheckedState.BorderThickness = 0;
            this.saturdayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saturdayCheckBox.Location = new System.Drawing.Point(327, 308);
            this.saturdayCheckBox.Name = "saturdayCheckBox";
            this.saturdayCheckBox.Size = new System.Drawing.Size(142, 34);
            this.saturdayCheckBox.TabIndex = 215;
            this.saturdayCheckBox.Text = "Saturday";
            this.saturdayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.saturdayCheckBox.UncheckedState.BorderRadius = 0;
            this.saturdayCheckBox.UncheckedState.BorderThickness = 0;
            this.saturdayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.saturdayCheckBox.CheckedChanged += new System.EventHandler(this.saturdayCheckBox_CheckedChanged);
            // 
            // fridayCheckBox
            // 
            this.fridayCheckBox.AutoSize = true;
            this.fridayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fridayCheckBox.CheckedState.BorderRadius = 0;
            this.fridayCheckBox.CheckedState.BorderThickness = 0;
            this.fridayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fridayCheckBox.Location = new System.Drawing.Point(327, 261);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(109, 34);
            this.fridayCheckBox.TabIndex = 214;
            this.fridayCheckBox.Text = "Friday";
            this.fridayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fridayCheckBox.UncheckedState.BorderRadius = 0;
            this.fridayCheckBox.UncheckedState.BorderThickness = 0;
            this.fridayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fridayCheckBox.CheckedChanged += new System.EventHandler(this.fridayCheckBox_CheckedChanged);
            // 
            // thursdayCheckBox
            // 
            this.thursdayCheckBox.AutoSize = true;
            this.thursdayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thursdayCheckBox.CheckedState.BorderRadius = 0;
            this.thursdayCheckBox.CheckedState.BorderThickness = 0;
            this.thursdayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thursdayCheckBox.Location = new System.Drawing.Point(327, 214);
            this.thursdayCheckBox.Name = "thursdayCheckBox";
            this.thursdayCheckBox.Size = new System.Drawing.Size(142, 34);
            this.thursdayCheckBox.TabIndex = 213;
            this.thursdayCheckBox.Text = "Thursday";
            this.thursdayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.thursdayCheckBox.UncheckedState.BorderRadius = 0;
            this.thursdayCheckBox.UncheckedState.BorderThickness = 0;
            this.thursdayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.thursdayCheckBox.CheckedChanged += new System.EventHandler(this.thursdayCheckBox_CheckedChanged);
            // 
            // sundayCheckBox
            // 
            this.sundayCheckBox.AutoSize = true;
            this.sundayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sundayCheckBox.CheckedState.BorderRadius = 0;
            this.sundayCheckBox.CheckedState.BorderThickness = 0;
            this.sundayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sundayCheckBox.Location = new System.Drawing.Point(327, 348);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(126, 34);
            this.sundayCheckBox.TabIndex = 216;
            this.sundayCheckBox.Text = "Sunday";
            this.sundayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sundayCheckBox.UncheckedState.BorderRadius = 0;
            this.sundayCheckBox.UncheckedState.BorderThickness = 0;
            this.sundayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sundayCheckBox.CheckedChanged += new System.EventHandler(this.sundayCheckBox_CheckedChanged);
            // 
            // vacationCheckBox
            // 
            this.vacationCheckBox.AutoSize = true;
            this.vacationCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vacationCheckBox.CheckedState.BorderRadius = 0;
            this.vacationCheckBox.CheckedState.BorderThickness = 0;
            this.vacationCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vacationCheckBox.Location = new System.Drawing.Point(538, 229);
            this.vacationCheckBox.Name = "vacationCheckBox";
            this.vacationCheckBox.Size = new System.Drawing.Size(149, 34);
            this.vacationCheckBox.TabIndex = 217;
            this.vacationCheckBox.Text = "Vacation";
            this.vacationCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.vacationCheckBox.UncheckedState.BorderRadius = 0;
            this.vacationCheckBox.UncheckedState.BorderThickness = 0;
            this.vacationCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
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
            this.refreshBtn.Location = new System.Drawing.Point(931, 194);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 218;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // DoctorAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.vacationCheckBox);
            this.Controls.Add(this.sundayCheckBox);
            this.Controls.Add(this.saturdayCheckBox);
            this.Controls.Add(this.fridayCheckBox);
            this.Controls.Add(this.thursdayCheckBox);
            this.Controls.Add(this.wednesdayCheckBox);
            this.Controls.Add(this.tuesdayCheckBox);
            this.Controls.Add(this.mondayCheckBox);
            this.Controls.Add(this.endTimeCb);
            this.Controls.Add(this.startTimeCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.docAvailableDGV);
            this.Controls.Add(this.docSpecTb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docRoomTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.docIdCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.docNameTb);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DoctorAvailability";
            this.Text = "DoctorAvailability";
            ((System.ComponentModel.ISupportInitialize)(this.docAvailableDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox docRoomTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox docIdCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox docNameTb;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.TextBox docSpecTb;
        private System.Windows.Forms.DataGridView docAvailableDGV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private System.Windows.Forms.DateTimePicker startTimeCb;
        private System.Windows.Forms.DateTimePicker endTimeCb;
        private Guna.UI2.WinForms.Guna2CheckBox mondayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox tuesdayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox wednesdayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox saturdayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox fridayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox thursdayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox sundayCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox vacationCheckBox;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
    }
}