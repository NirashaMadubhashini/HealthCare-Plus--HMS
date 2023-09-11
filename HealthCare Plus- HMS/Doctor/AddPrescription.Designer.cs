namespace HealthCare_Plus__HMS.Doctor
{
    partial class AddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescription));
            this.label6 = new System.Windows.Forms.Label();
            this.medTb = new System.Windows.Forms.TextBox();
            this.prescriptionDGV = new System.Windows.Forms.DataGridView();
            this.prescSumTxt = new System.Windows.Forms.RichTextBox();
            this.costTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.testIdCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.docIdCb = new System.Windows.Forms.ComboBox();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.patNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.docNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(203, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 91;
            this.label6.Text = "PRESCRIPTION";
            // 
            // medTb
            // 
            this.medTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTb.ForeColor = System.Drawing.Color.Black;
            this.medTb.Location = new System.Drawing.Point(727, 308);
            this.medTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.medTb.Multiline = true;
            this.medTb.Name = "medTb";
            this.medTb.Size = new System.Drawing.Size(208, 92);
            this.medTb.TabIndex = 90;
            // 
            // prescriptionDGV
            // 
            this.prescriptionDGV.BackgroundColor = System.Drawing.Color.White;
            this.prescriptionDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prescriptionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionDGV.GridColor = System.Drawing.Color.White;
            this.prescriptionDGV.Location = new System.Drawing.Point(37, 420);
            this.prescriptionDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prescriptionDGV.Name = "prescriptionDGV";
            this.prescriptionDGV.RowHeadersWidth = 62;
            this.prescriptionDGV.RowTemplate.Height = 28;
            this.prescriptionDGV.Size = new System.Drawing.Size(1088, 278);
            this.prescriptionDGV.TabIndex = 89;
            this.prescriptionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionDGV_CellContentClick);
            // 
            // prescSumTxt
            // 
            this.prescSumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prescSumTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescSumTxt.Location = new System.Drawing.Point(37, 51);
            this.prescSumTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prescSumTxt.Name = "prescSumTxt";
            this.prescSumTxt.Size = new System.Drawing.Size(474, 336);
            this.prescSumTxt.TabIndex = 88;
            this.prescSumTxt.Text = "";
            this.prescSumTxt.TextChanged += new System.EventHandler(this.PrescSumTxt_TextChanged);
            // 
            // costTb
            // 
            this.costTb.Enabled = false;
            this.costTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTb.ForeColor = System.Drawing.Color.Black;
            this.costTb.Location = new System.Drawing.Point(557, 311);
            this.costTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.costTb.Name = "costTb";
            this.costTb.Size = new System.Drawing.Size(138, 34);
            this.costTb.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(554, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(727, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Medicines";
            // 
            // testIdCb
            // 
            this.testIdCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testIdCb.FormattingEnabled = true;
            this.testIdCb.Location = new System.Drawing.Point(557, 232);
            this.testIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.testIdCb.Name = "testIdCb";
            this.testIdCb.Size = new System.Drawing.Size(138, 33);
            this.testIdCb.TabIndex = 84;
            this.testIdCb.SelectionChangeCommitted += new System.EventHandler(this.TestIdCb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(554, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Test Id";
            // 
            // testNameTb
            // 
            this.testNameTb.Enabled = false;
            this.testNameTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testNameTb.ForeColor = System.Drawing.Color.Black;
            this.testNameTb.Location = new System.Drawing.Point(726, 231);
            this.testNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.testNameTb.Name = "testNameTb";
            this.testNameTb.Size = new System.Drawing.Size(208, 34);
            this.testNameTb.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(722, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Test Name";
            // 
            // docIdCb
            // 
            this.docIdCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docIdCb.FormattingEnabled = true;
            this.docIdCb.Location = new System.Drawing.Point(557, 80);
            this.docIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docIdCb.Name = "docIdCb";
            this.docIdCb.Size = new System.Drawing.Size(138, 33);
            this.docIdCb.TabIndex = 80;
            this.docIdCb.SelectedIndexChanged += new System.EventHandler(this.docIdCb_SelectedIndexChanged);
            this.docIdCb.SelectionChangeCommitted += new System.EventHandler(this.DocIdCb_SelectionChangeCommitted);
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Location = new System.Drawing.Point(557, 154);
            this.patIdCb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(138, 33);
            this.patIdCb.TabIndex = 77;
            this.patIdCb.SelectedIndexChanged += new System.EventHandler(this.PatIdCb_SelectedIndexChanged);
            this.patIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatIdCb_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(554, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 76;
            this.label12.Text = "Patient Id";
            // 
            // patNameTb
            // 
            this.patNameTb.Enabled = false;
            this.patNameTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameTb.ForeColor = System.Drawing.Color.Black;
            this.patNameTb.Location = new System.Drawing.Point(726, 153);
            this.patNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.patNameTb.Name = "patNameTb";
            this.patNameTb.Size = new System.Drawing.Size(208, 34);
            this.patNameTb.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(722, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 25);
            this.label11.TabIndex = 74;
            this.label11.Text = "Patient Name";
            // 
            // docNameTb
            // 
            this.docNameTb.Enabled = false;
            this.docNameTb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameTb.ForeColor = System.Drawing.Color.Black;
            this.docNameTb.Location = new System.Drawing.Point(726, 79);
            this.docNameTb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.docNameTb.Name = "docNameTb";
            this.docNameTb.Size = new System.Drawing.Size(208, 34);
            this.docNameTb.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(722, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Doctor Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(552, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Doctor Id";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.White;
            this.printBtn.BorderRadius = 8;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.printBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(945, 349);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 45);
            this.printBtn.TabIndex = 93;
            this.printBtn.Text = "Print";
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
            this.addBtn.Location = new System.Drawing.Point(945, 280);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 92;
            this.addBtn.Text = "Add";
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 719);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medTb);
            this.Controls.Add(this.prescriptionDGV);
            this.Controls.Add(this.prescSumTxt);
            this.Controls.Add(this.costTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testIdCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docIdCb);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.patNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.docNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medTb;
        private System.Windows.Forms.DataGridView prescriptionDGV;
        private System.Windows.Forms.RichTextBox prescSumTxt;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox testIdCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox docIdCb;
        private System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox patNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox docNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
    }
}