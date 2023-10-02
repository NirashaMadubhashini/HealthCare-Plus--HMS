namespace HealthCare_Plus__HMS.Doctor
{
    partial class PatientRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRecords));
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.patRecordsDGV = new System.Windows.Forms.DataGridView();
            this.patMedicineTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patFullNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.patContactTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.patRecordsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.refreshBtn.Location = new System.Drawing.Point(945, 91);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 108;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(945, 40);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 107;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // patRecordsDGV
            // 
            this.patRecordsDGV.BackgroundColor = System.Drawing.Color.White;
            this.patRecordsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patRecordsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patRecordsDGV.GridColor = System.Drawing.Color.White;
            this.patRecordsDGV.Location = new System.Drawing.Point(36, 274);
            this.patRecordsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.patRecordsDGV.Name = "patRecordsDGV";
            this.patRecordsDGV.RowHeadersWidth = 62;
            this.patRecordsDGV.RowTemplate.Height = 28;
            this.patRecordsDGV.Size = new System.Drawing.Size(1089, 405);
            this.patRecordsDGV.TabIndex = 104;
            this.patRecordsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patRecordsDGV_CellContentClick);
            // 
            // patMedicineTb
            // 
            this.patMedicineTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patMedicineTb.ForeColor = System.Drawing.Color.Black;
            this.patMedicineTb.Location = new System.Drawing.Point(36, 165);
            this.patMedicineTb.Margin = new System.Windows.Forms.Padding(2);
            this.patMedicineTb.Multiline = true;
            this.patMedicineTb.Name = "patMedicineTb";
            this.patMedicineTb.Size = new System.Drawing.Size(552, 66);
            this.patMedicineTb.TabIndex = 103;
            this.patMedicineTb.TextChanged += new System.EventHandler(this.patMedicineTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Medicines";
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patIdCb.Location = new System.Drawing.Point(36, 69);
            this.patIdCb.Margin = new System.Windows.Forms.Padding(2);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(253, 42);
            this.patIdCb.TabIndex = 114;
            this.patIdCb.SelectedIndexChanged += new System.EventHandler(this.patIdCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "Patient ID";
            // 
            // patFullNameTb
            // 
            this.patFullNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patFullNameTb.ForeColor = System.Drawing.Color.Black;
            this.patFullNameTb.Location = new System.Drawing.Point(330, 69);
            this.patFullNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.patFullNameTb.Name = "patFullNameTb";
            this.patFullNameTb.Size = new System.Drawing.Size(259, 42);
            this.patFullNameTb.TabIndex = 116;
            this.patFullNameTb.TextChanged += new System.EventHandler(this.patNameTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(325, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 115;
            this.label9.Text = "Full Name";
            // 
            // patContactTb
            // 
            this.patContactTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patContactTb.ForeColor = System.Drawing.Color.Black;
            this.patContactTb.Location = new System.Drawing.Point(631, 69);
            this.patContactTb.Margin = new System.Windows.Forms.Padding(2);
            this.patContactTb.Name = "patContactTb";
            this.patContactTb.Size = new System.Drawing.Size(252, 42);
            this.patContactTb.TabIndex = 118;
            this.patContactTb.TextChanged += new System.EventHandler(this.patContactTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(626, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(785, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 23);
            this.label4.TabIndex = 179;
            this.label4.Text = "Search by Patient Id and Name";
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
            this.searchTb.Location = new System.Drawing.Point(789, 185);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(336, 46);
            this.searchTb.TabIndex = 178;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.patContactTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patFullNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.patRecordsDGV);
            this.Controls.Add(this.patMedicineTb);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PatientRecords";
            this.Text = "PatientRecords";
            ((System.ComponentModel.ISupportInitialize)(this.patRecordsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private System.Windows.Forms.DataGridView patRecordsDGV;
        private System.Windows.Forms.TextBox patMedicineTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patFullNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patContactTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
    }
}