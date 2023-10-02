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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.roomDGV = new System.Windows.Forms.DataGridView();
            this.roomNoteTb = new System.Windows.Forms.TextBox();
            this.roomNumTb = new System.Windows.Forms.TextBox();
            this.roomFloorCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roomTypeCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDGV
            // 
            this.roomDGV.BackgroundColor = System.Drawing.Color.White;
            this.roomDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDGV.GridColor = System.Drawing.Color.White;
            this.roomDGV.Location = new System.Drawing.Point(90, 333);
            this.roomDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomDGV.Name = "roomDGV";
            this.roomDGV.RowHeadersWidth = 62;
            this.roomDGV.RowTemplate.Height = 28;
            this.roomDGV.Size = new System.Drawing.Size(1032, 328);
            this.roomDGV.TabIndex = 65;
            this.roomDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDGV_CellContentClick);
            // 
            // roomNoteTb
            // 
            this.roomNoteTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoteTb.ForeColor = System.Drawing.Color.Black;
            this.roomNoteTb.Location = new System.Drawing.Point(330, 168);
            this.roomNoteTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomNoteTb.Multiline = true;
            this.roomNoteTb.Name = "roomNoteTb";
            this.roomNoteTb.Size = new System.Drawing.Size(210, 42);
            this.roomNoteTb.TabIndex = 64;
            // 
            // roomNumTb
            // 
            this.roomNumTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumTb.ForeColor = System.Drawing.Color.Black;
            this.roomNumTb.Location = new System.Drawing.Point(90, 71);
            this.roomNumTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomNumTb.Name = "roomNumTb";
            this.roomNumTb.Size = new System.Drawing.Size(211, 42);
            this.roomNumTb.TabIndex = 63;
            // 
            // roomFloorCb
            // 
            this.roomFloorCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomFloorCb.FormattingEnabled = true;
            this.roomFloorCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.roomFloorCb.Location = new System.Drawing.Point(329, 71);
            this.roomFloorCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomFloorCb.Name = "roomFloorCb";
            this.roomFloorCb.Size = new System.Drawing.Size(211, 42);
            this.roomFloorCb.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(325, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Room Floor";
            // 
            // statusCb
            // 
            this.statusCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "Occupied",
            "Available"});
            this.statusCb.Location = new System.Drawing.Point(92, 168);
            this.statusCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(209, 42);
            this.statusCb.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(88, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(326, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Room Notice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Room Number";
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
            this.deleteBtn.Location = new System.Drawing.Point(942, 141);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 72;
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
            this.updateBtn.Location = new System.Drawing.Point(942, 90);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 71;
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
            this.addBtn.Location = new System.Drawing.Point(942, 39);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 70;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // roomTypeCb
            // 
            this.roomTypeCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeCb.FormattingEnabled = true;
            this.roomTypeCb.Items.AddRange(new object[] {
            "Regular",
            "ICU",
            "OperationTheater"});
            this.roomTypeCb.Location = new System.Drawing.Point(566, 71);
            this.roomTypeCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roomTypeCb.Name = "roomTypeCb";
            this.roomTypeCb.Size = new System.Drawing.Size(211, 42);
            this.roomTypeCb.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(562, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(801, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 112;
            this.label3.Text = "Search by Room Type";
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
            this.searchTb.Location = new System.Drawing.Point(806, 279);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(316, 46);
            this.searchTb.TabIndex = 111;
            this.searchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
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
            this.refreshBtn.Location = new System.Drawing.Point(942, 192);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(180, 45);
            this.refreshBtn.TabIndex = 114;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.roomTypeCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.roomDGV);
            this.Controls.Add(this.roomNoteTb);
            this.Controls.Add(this.roomNumTb);
            this.Controls.Add(this.roomFloorCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomDGV;
        private System.Windows.Forms.TextBox roomNoteTb;
        private System.Windows.Forms.TextBox roomNumTb;
        private System.Windows.Forms.ComboBox roomFloorCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.ComboBox roomTypeCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
    }
}