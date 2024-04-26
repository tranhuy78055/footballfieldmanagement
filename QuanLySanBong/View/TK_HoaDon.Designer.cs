namespace QuanLySanBong.View
{
    partial class TK_HoaDon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_input = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_output = new System.Windows.Forms.DateTimePicker();
            this.btn_TK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 91);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1076, 569);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_input
            // 
            this.dtp_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_input.Location = new System.Drawing.Point(207, 29);
            this.dtp_input.Name = "dtp_input";
            this.dtp_input.Size = new System.Drawing.Size(200, 20);
            this.dtp_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_output
            // 
            this.dtp_output.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_output.Location = new System.Drawing.Point(561, 29);
            this.dtp_output.Name = "dtp_output";
            this.dtp_output.Size = new System.Drawing.Size(200, 20);
            this.dtp_output.TabIndex = 3;
            // 
            // btn_TK
            // 
            this.btn_TK.Location = new System.Drawing.Point(809, 26);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(132, 23);
            this.btn_TK.TabIndex = 5;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // TK_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 715);
            this.Controls.Add(this.btn_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_input);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "TK_HoaDon";
            this.Text = "TK_HoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dtp_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_output;
        private System.Windows.Forms.Button btn_TK;
    }
}