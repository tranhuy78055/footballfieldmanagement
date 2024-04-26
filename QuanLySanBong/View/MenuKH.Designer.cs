namespace QuanLySanBong.View
{
    partial class MenuKH
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_TC = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_datsan = new System.Windows.Forms.Button();
            this.label_chucvu = new System.Windows.Forms.Label();
            this.lb_tenql = new System.Windows.Forms.Label();
            this.btn_imgQL = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ten_ql = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.Controls.Add(this.label_TC);
            this.panel_top.Controls.Add(this.lb_tenql);
            this.panel_top.Controls.Add(this.label_chucvu);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1387, 145);
            this.panel_top.TabIndex = 5;
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TC.Location = new System.Drawing.Point(455, 80);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(199, 46);
            this.label_TC.TabIndex = 0;
            this.label_TC.Text = "Trang chủ";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_left.Controls.Add(this.menuStrip1);
            this.panel_left.Controls.Add(this.btn_datsan);
            this.panel_left.Controls.Add(this.btn_imgQL);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 744);
            this.panel_left.TabIndex = 8;
            // 
            // btn_datsan
            // 
            this.btn_datsan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datsan.Location = new System.Drawing.Point(0, 202);
            this.btn_datsan.Name = "btn_datsan";
            this.btn_datsan.Size = new System.Drawing.Size(200, 71);
            this.btn_datsan.TabIndex = 10;
            this.btn_datsan.Text = "Đặt Sân";
            this.btn_datsan.UseVisualStyleBackColor = true;
            this.btn_datsan.Click += new System.EventHandler(this.btn_datsan_Click);
            // 
            // label_chucvu
            // 
            this.label_chucvu.AutoSize = true;
            this.label_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chucvu.Location = new System.Drawing.Point(23, 45);
            this.label_chucvu.Name = "label_chucvu";
            this.label_chucvu.Size = new System.Drawing.Size(86, 17);
            this.label_chucvu.TabIndex = 2;
            this.label_chucvu.Text = "Khách Hàng";
            // 
            // lb_tenql
            // 
            this.lb_tenql.AutoSize = true;
            this.lb_tenql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenql.Location = new System.Drawing.Point(23, 12);
            this.lb_tenql.Name = "lb_tenql";
            this.lb_tenql.Size = new System.Drawing.Size(33, 17);
            this.lb_tenql.TabIndex = 1;
            this.lb_tenql.Text = "Tên";
            // 
            // btn_imgQL
            // 
            this.btn_imgQL.BackgroundImage = global::QuanLySanBong.Properties.Resources.user;
            this.btn_imgQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imgQL.Location = new System.Drawing.Point(3, 3);
            this.btn_imgQL.Name = "btn_imgQL";
            this.btn_imgQL.Size = new System.Drawing.Size(194, 139);
            this.btn_imgQL.TabIndex = 0;
            this.btn_imgQL.UseVisualStyleBackColor = true;
            this.btn_imgQL.Click += new System.EventHandler(this.btn_imgQL_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 145);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 54);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trangChủToolStripMenuItem.Image = global::QuanLySanBong.Properties.Resources.trangchu;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(194, 50);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản Lý";
            // 
            // ten_ql
            // 
            this.ten_ql.AutoSize = true;
            this.ten_ql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_ql.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ten_ql.Location = new System.Drawing.Point(87, 12);
            this.ten_ql.Name = "ten_ql";
            this.ten_ql.Size = new System.Drawing.Size(33, 17);
            this.ten_ql.TabIndex = 6;
            this.ten_ql.Text = "Tên";
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(200, 145);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1387, 599);
            this.panel_body.TabIndex = 9;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // MenuKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 744);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ten_ql);
            this.Controls.Add(this.button1);
            this.Name = "MenuKH";
            this.Text = "MenuKH";
            this.Load += new System.EventHandler(this.MenuKH_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label label_chucvu;
        private System.Windows.Forms.Label lb_tenql;
        private System.Windows.Forms.Button btn_imgQL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ten_ql;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btn_datsan;
        private System.Windows.Forms.Label label_TC;
    }
}