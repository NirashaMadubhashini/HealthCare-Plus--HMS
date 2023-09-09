namespace HealthCare_Plus__HMS.Doctor
{
    partial class Appoinments
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
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PatientsLoadDGV = new System.Windows.Forms.DataGridView();
            this.SerachByNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DocDOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsLoadDGV)).BeginInit();
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
            this.refreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(939, 139);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 109;
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
            this.searchBtn.Location = new System.Drawing.Point(753, 139);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(180, 45);
            this.searchBtn.TabIndex = 108;
            this.searchBtn.Text = "Search";
            // 
            // PatientsLoadDGV
            // 
            this.PatientsLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientsLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsLoadDGV.GridColor = System.Drawing.Color.White;
            this.PatientsLoadDGV.Location = new System.Drawing.Point(35, 203);
            this.PatientsLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PatientsLoadDGV.Name = "PatientsLoadDGV";
            this.PatientsLoadDGV.RowHeadersWidth = 62;
            this.PatientsLoadDGV.RowTemplate.Height = 28;
            this.PatientsLoadDGV.Size = new System.Drawing.Size(1089, 475);
            this.PatientsLoadDGV.TabIndex = 107;
            // 
            // SerachByNameTb
            // 
            this.SerachByNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachByNameTb.ForeColor = System.Drawing.Color.Black;
            this.SerachByNameTb.Location = new System.Drawing.Point(35, 69);
            this.SerachByNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.SerachByNameTb.Name = "SerachByNameTb";
            this.SerachByNameTb.Size = new System.Drawing.Size(368, 42);
            this.SerachByNameTb.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "Search Here By Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(453, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 25);
            this.label13.TabIndex = 111;
            this.label13.Text = "Search Here By Date";
            // 
            // DocDOB
            // 
            this.DocDOB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDOB.Location = new System.Drawing.Point(453, 69);
            this.DocDOB.Margin = new System.Windows.Forms.Padding(2);
            this.DocDOB.Name = "DocDOB";
            this.DocDOB.Size = new System.Drawing.Size(368, 42);
            this.DocDOB.TabIndex = 110;
            // 
            // Appoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocDOB);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.PatientsLoadDGV);
            this.Controls.Add(this.SerachByNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Appoinments";
            this.Text = "Appoinments";
            ((System.ComponentModel.ISupportInitialize)(this.PatientsLoadDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private System.Windows.Forms.DataGridView PatientsLoadDGV;
        private System.Windows.Forms.TextBox SerachByNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DocDOB;
    }
}