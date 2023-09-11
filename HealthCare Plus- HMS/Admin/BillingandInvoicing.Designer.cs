namespace HealthCare_Plus__HMS.Admin
{
    partial class BillingandInvoicing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingandInvoicing));
            this.generateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.billTxt = new System.Windows.Forms.RichTextBox();
            this.payRollCb = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.White;
            this.generateBtn.BorderRadius = 8;
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(234)))));
            this.generateBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(941, 141);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(180, 45);
            this.generateBtn.TabIndex = 104;
            this.generateBtn.Text = "Generate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(333, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 103;
            this.label6.Text = "BILL";
            // 
            // billDGV
            // 
            this.billDGV.BackgroundColor = System.Drawing.Color.White;
            this.billDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.GridColor = System.Drawing.Color.White;
            this.billDGV.Location = new System.Drawing.Point(33, 418);
            this.billDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.billDGV.Name = "billDGV";
            this.billDGV.RowHeadersWidth = 62;
            this.billDGV.RowTemplate.Height = 28;
            this.billDGV.Size = new System.Drawing.Size(1088, 278);
            this.billDGV.TabIndex = 102;
            this.billDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDGV_CellContentClick);
            // 
            // billTxt
            // 
            this.billTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTxt.Location = new System.Drawing.Point(33, 76);
            this.billTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.billTxt.Name = "billTxt";
            this.billTxt.Size = new System.Drawing.Size(646, 336);
            this.billTxt.TabIndex = 101;
            this.billTxt.Text = "";
            this.billTxt.TextChanged += new System.EventHandler(this.billTxt_TextChanged);
            // 
            // payRollCb
            // 
            this.payRollCb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRollCb.FormattingEnabled = true;
            this.payRollCb.Items.AddRange(new object[] {
            "Total Income",
            "Patient Reports",
            "Resource Allocation"});
            this.payRollCb.Location = new System.Drawing.Point(833, 66);
            this.payRollCb.Margin = new System.Windows.Forms.Padding(2);
            this.payRollCb.Name = "payRollCb";
            this.payRollCb.Size = new System.Drawing.Size(288, 42);
            this.payRollCb.TabIndex = 100;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(829, 38);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 25);
            this.label22.TabIndex = 99;
            this.label22.Text = "Patient Name";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BillingandInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.billDGV);
            this.Controls.Add(this.billTxt);
            this.Controls.Add(this.payRollCb);
            this.Controls.Add(this.label22);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "BillingandInvoicing";
            this.Text = "Prescriptions";
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button generateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.RichTextBox billTxt;
        private System.Windows.Forms.ComboBox payRollCb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}