namespace HealthCare_Plus__HMS.Admin
{
    partial class Patients
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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.PatientsLoadDGV = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SerachByNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsLoadDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatAppearance.BorderSize = 10;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(974, 126);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(145, 38);
            this.RefreshBtn.TabIndex = 102;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // PatientsLoadDGV
            // 
            this.PatientsLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientsLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsLoadDGV.GridColor = System.Drawing.Color.White;
            this.PatientsLoadDGV.Location = new System.Drawing.Point(35, 205);
            this.PatientsLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PatientsLoadDGV.Name = "PatientsLoadDGV";
            this.PatientsLoadDGV.RowHeadersWidth = 62;
            this.PatientsLoadDGV.RowTemplate.Height = 28;
            this.PatientsLoadDGV.Size = new System.Drawing.Size(1089, 475);
            this.PatientsLoadDGV.TabIndex = 97;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 10;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(809, 126);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(145, 38);
            this.SearchBtn.TabIndex = 96;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SerachByNameTb
            // 
            this.SerachByNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerachByNameTb.ForeColor = System.Drawing.Color.Black;
            this.SerachByNameTb.Location = new System.Drawing.Point(35, 71);
            this.SerachByNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.SerachByNameTb.Name = "SerachByNameTb";
            this.SerachByNameTb.Size = new System.Drawing.Size(368, 42);
            this.SerachByNameTb.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 25);
            this.label9.TabIndex = 94;
            this.label9.Text = "Search Here By Name";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.PatientsLoadDGV);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SerachByNameTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Patients";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.PatientsLoadDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView PatientsLoadDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SerachByNameTb;
        private System.Windows.Forms.Label label9;
    }
}