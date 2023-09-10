namespace HealthCare_Plus__HMS.Staff
{
    partial class Search_Doctor
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
            this.label13 = new System.Windows.Forms.Label();
            this.docAvailableDate = new System.Windows.Forms.DateTimePicker();
            this.serachBySpecTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorLoadDGV = new System.Windows.Forms.DataGridView();
            this.serachByNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLoadDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(31, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 25);
            this.label13.TabIndex = 92;
            this.label13.Text = "Search Here By Date";
            // 
            // docAvailableDate
            // 
            this.docAvailableDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docAvailableDate.Location = new System.Drawing.Point(31, 157);
            this.docAvailableDate.Margin = new System.Windows.Forms.Padding(2);
            this.docAvailableDate.Name = "docAvailableDate";
            this.docAvailableDate.Size = new System.Drawing.Size(318, 42);
            this.docAvailableDate.TabIndex = 91;
            this.docAvailableDate.ValueChanged += new System.EventHandler(this.DocAvailableDate_ValueChanged);
            // 
            // serachBySpecTb
            // 
            this.serachBySpecTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serachBySpecTb.ForeColor = System.Drawing.Color.Black;
            this.serachBySpecTb.Location = new System.Drawing.Point(421, 67);
            this.serachBySpecTb.Margin = new System.Windows.Forms.Padding(2);
            this.serachBySpecTb.Name = "serachBySpecTb";
            this.serachBySpecTb.Size = new System.Drawing.Size(318, 42);
            this.serachBySpecTb.TabIndex = 90;
            this.serachBySpecTb.TextChanged += new System.EventHandler(this.SerachBySpecTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(416, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Search Here By Specialization";
            // 
            // DoctorLoadDGV
            // 
            this.DoctorLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoctorLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorLoadDGV.GridColor = System.Drawing.Color.White;
            this.DoctorLoadDGV.Location = new System.Drawing.Point(36, 233);
            this.DoctorLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorLoadDGV.Name = "DoctorLoadDGV";
            this.DoctorLoadDGV.RowHeadersWidth = 62;
            this.DoctorLoadDGV.RowTemplate.Height = 28;
            this.DoctorLoadDGV.Size = new System.Drawing.Size(1089, 446);
            this.DoctorLoadDGV.TabIndex = 88;
            this.DoctorLoadDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorLoadDGV_CellContentClick);
            // 
            // serachByNameTb
            // 
            this.serachByNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serachByNameTb.ForeColor = System.Drawing.Color.Black;
            this.serachByNameTb.Location = new System.Drawing.Point(36, 70);
            this.serachByNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.serachByNameTb.Name = "serachByNameTb";
            this.serachByNameTb.Size = new System.Drawing.Size(318, 42);
            this.serachByNameTb.TabIndex = 86;
            this.serachByNameTb.TextChanged += new System.EventHandler(this.SerachByNameTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 25);
            this.label9.TabIndex = 85;
            this.label9.Text = "Search Here By Name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.BorderRadius = 8;
            this.refreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(945, 115);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 106;
            this.refreshBtn.Text = "Refresh";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.BorderRadius = 8;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(944, 64);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(180, 45);
            this.searchBtn.TabIndex = 105;
            this.searchBtn.Text = "Search";
            // 
            // Search_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.docAvailableDate);
            this.Controls.Add(this.serachBySpecTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorLoadDGV);
            this.Controls.Add(this.serachByNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Search_Doctor";
            this.Text = "Search_Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLoadDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker docAvailableDate;
        private System.Windows.Forms.TextBox serachBySpecTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DoctorLoadDGV;
        private System.Windows.Forms.TextBox serachByNameTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
    }
}