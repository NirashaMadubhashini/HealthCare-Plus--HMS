namespace HealthCare_Plus__HMS.Admin
{
    partial class Prescriptions
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
            this.PrescriptionLoadDGV = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DocNameSearchTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PatNameSearchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionLoadDGV)).BeginInit();
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
            this.RefreshBtn.Location = new System.Drawing.Point(974, 124);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(145, 38);
            this.RefreshBtn.TabIndex = 107;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // PrescriptionLoadDGV
            // 
            this.PrescriptionLoadDGV.BackgroundColor = System.Drawing.Color.White;
            this.PrescriptionLoadDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrescriptionLoadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionLoadDGV.GridColor = System.Drawing.Color.White;
            this.PrescriptionLoadDGV.Location = new System.Drawing.Point(35, 203);
            this.PrescriptionLoadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PrescriptionLoadDGV.Name = "PrescriptionLoadDGV";
            this.PrescriptionLoadDGV.RowHeadersWidth = 62;
            this.PrescriptionLoadDGV.RowTemplate.Height = 28;
            this.PrescriptionLoadDGV.Size = new System.Drawing.Size(1089, 475);
            this.PrescriptionLoadDGV.TabIndex = 106;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 10;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(809, 124);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(145, 38);
            this.SearchBtn.TabIndex = 105;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DocNameSearchTb
            // 
            this.DocNameSearchTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNameSearchTb.ForeColor = System.Drawing.Color.Black;
            this.DocNameSearchTb.Location = new System.Drawing.Point(35, 69);
            this.DocNameSearchTb.Margin = new System.Windows.Forms.Padding(2);
            this.DocNameSearchTb.Name = "DocNameSearchTb";
            this.DocNameSearchTb.Size = new System.Drawing.Size(368, 42);
            this.DocNameSearchTb.TabIndex = 104;
            this.DocNameSearchTb.TextChanged += new System.EventHandler(this.DocNameSearchTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Search Here By Doctor Name";
            // 
            // PatNameSearchTb
            // 
            this.PatNameSearchTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameSearchTb.ForeColor = System.Drawing.Color.Black;
            this.PatNameSearchTb.Location = new System.Drawing.Point(462, 69);
            this.PatNameSearchTb.Margin = new System.Windows.Forms.Padding(2);
            this.PatNameSearchTb.Name = "PatNameSearchTb";
            this.PatNameSearchTb.Size = new System.Drawing.Size(368, 42);
            this.PatNameSearchTb.TabIndex = 109;
            this.PatNameSearchTb.TextChanged += new System.EventHandler(this.PatNameSearchTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(457, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Search Here By Patient Name";
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.PatNameSearchTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.PrescriptionLoadDGV);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DocNameSearchTb);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Prescriptions";
            this.Text = "Prescriptions";
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionLoadDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView PrescriptionLoadDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox DocNameSearchTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PatNameSearchTb;
        private System.Windows.Forms.Label label1;
    }
}