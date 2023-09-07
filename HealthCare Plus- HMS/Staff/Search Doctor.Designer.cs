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
            this.DocAvailableDate = new System.Windows.Forms.DateTimePicker();
            this.SerachBySpecTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorLoadDGV = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SerachByNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLoadDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(804, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 25);
            this.label13.TabIndex = 92;
            this.label13.Text = "Search Here By Date";
            // 
            // DocAvailableDate
            // 
            this.DocAvailableDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAvailableDate.Location = new System.Drawing.Point(804, 67);
            this.DocAvailableDate.Margin = new System.Windows.Forms.Padding(2);
            this.DocAvailableDate.Name = "DocAvailableDate";
            this.DocAvailableDate.Size = new System.Drawing.Size(318, 42);
            this.DocAvailableDate.TabIndex = 91;
            this.DocAvailableDate.ValueChanged += new System.EventHandler(this.DocAvailableDate_ValueChanged);
            // 
            // SerachBySpecTb
            // 
            this.SerachBySpecTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachBySpecTb.ForeColor = System.Drawing.Color.Black;
            this.SerachBySpecTb.Location = new System.Drawing.Point(421, 67);
            this.SerachBySpecTb.Margin = new System.Windows.Forms.Padding(2);
            this.SerachBySpecTb.Name = "SerachBySpecTb";
            this.SerachBySpecTb.Size = new System.Drawing.Size(318, 42);
            this.SerachBySpecTb.TabIndex = 90;
            this.SerachBySpecTb.TextChanged += new System.EventHandler(this.SerachBySpecTb_TextChanged);
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
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 10;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(665, 163);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(297, 38);
            this.SearchBtn.TabIndex = 87;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SerachByNameTb
            // 
            this.SerachByNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachByNameTb.ForeColor = System.Drawing.Color.Black;
            this.SerachByNameTb.Location = new System.Drawing.Point(36, 70);
            this.SerachByNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.SerachByNameTb.Name = "SerachByNameTb";
            this.SerachByNameTb.Size = new System.Drawing.Size(318, 42);
            this.SerachByNameTb.TabIndex = 86;
            this.SerachByNameTb.TextChanged += new System.EventHandler(this.SerachByNameTb_TextChanged);
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
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatAppearance.BorderSize = 10;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(976, 163);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(145, 38);
            this.RefreshBtn.TabIndex = 93;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Search_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocAvailableDate);
            this.Controls.Add(this.SerachBySpecTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorLoadDGV);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SerachByNameTb);
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
        private System.Windows.Forms.DateTimePicker DocAvailableDate;
        private System.Windows.Forms.TextBox SerachBySpecTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DoctorLoadDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SerachByNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RefreshBtn;
    }
}