namespace HealthCare_Plus__HMS.Admin
{
    partial class Rooms
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
            this.RoomDGV = new System.Windows.Forms.DataGridView();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.DocNameTb = new System.Windows.Forms.TextBox();
            this.DocIdCb = new System.Windows.Forms.ComboBox();
            this.PatIdCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.RDate = new System.Windows.Forms.DateTimePicker();
            this.RACb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomDGV
            // 
            this.RoomDGV.BackgroundColor = System.Drawing.Color.White;
            this.RoomDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDGV.GridColor = System.Drawing.Color.White;
            this.RoomDGV.Location = new System.Drawing.Point(90, 292);
            this.RoomDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RoomDGV.Name = "RoomDGV";
            this.RoomDGV.RowHeadersWidth = 62;
            this.RoomDGV.RowTemplate.Height = 28;
            this.RoomDGV.Size = new System.Drawing.Size(988, 369);
            this.RoomDGV.TabIndex = 65;
            // 
            // PatNameTb
            // 
            this.PatNameTb.Enabled = false;
            this.PatNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.ForeColor = System.Drawing.Color.Black;
            this.PatNameTb.Location = new System.Drawing.Point(819, 71);
            this.PatNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(259, 42);
            this.PatNameTb.TabIndex = 64;
            // 
            // DocNameTb
            // 
            this.DocNameTb.Enabled = false;
            this.DocNameTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNameTb.ForeColor = System.Drawing.Color.Black;
            this.DocNameTb.Location = new System.Drawing.Point(302, 71);
            this.DocNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(259, 42);
            this.DocNameTb.TabIndex = 63;
            // 
            // DocIdCb
            // 
            this.DocIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocIdCb.FormattingEnabled = true;
            this.DocIdCb.Location = new System.Drawing.Point(90, 72);
            this.DocIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DocIdCb.Name = "DocIdCb";
            this.DocIdCb.Size = new System.Drawing.Size(175, 42);
            this.DocIdCb.TabIndex = 62;
            // 
            // PatIdCb
            // 
            this.PatIdCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatIdCb.FormattingEnabled = true;
            this.PatIdCb.Location = new System.Drawing.Point(607, 71);
            this.PatIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PatIdCb.Name = "PatIdCb";
            this.PatIdCb.Size = new System.Drawing.Size(175, 42);
            this.PatIdCb.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(603, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Patient Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(85, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Doctor Id";
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Red;
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.FlatAppearance.BorderSize = 10;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(933, 221);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(145, 38);
            this.DelBtn.TabIndex = 58;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderSize = 10;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(767, 221);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(145, 38);
            this.EditBtn.TabIndex = 57;
            this.EditBtn.Text = "Update";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 10;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(598, 221);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(145, 38);
            this.AddBtn.TabIndex = 56;
            this.AddBtn.Text = "Save";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(85, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 55;
            this.label13.Text = "Admitted Date";
            // 
            // RDate
            // 
            this.RDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDate.Location = new System.Drawing.Point(90, 169);
            this.RDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RDate.Name = "RDate";
            this.RDate.Size = new System.Drawing.Size(259, 42);
            this.RDate.TabIndex = 54;
            // 
            // RACb
            // 
            this.RACb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RACb.FormattingEnabled = true;
            this.RACb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.RACb.Location = new System.Drawing.Point(391, 168);
            this.RACb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RACb.Name = "RACb";
            this.RACb.Size = new System.Drawing.Size(209, 42);
            this.RACb.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(387, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Available Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(815, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Current Patient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(298, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Doctor Name";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.RoomDGV);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.DocIdCb);
            this.Controls.Add(this.PatIdCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RDate);
            this.Controls.Add(this.RACb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomDGV;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.TextBox DocNameTb;
        private System.Windows.Forms.ComboBox DocIdCb;
        private System.Windows.Forms.ComboBox PatIdCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker RDate;
        private System.Windows.Forms.ComboBox RACb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}