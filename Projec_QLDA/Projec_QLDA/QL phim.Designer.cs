namespace WindowsFormsApp3
{
    partial class QL_Phim
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_tim = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýLịchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýCụmRạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýRạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bt_luu = new System.Windows.Forms.Button();
			this.bt_xoa = new System.Windows.Forms.Button();
			this.bt_them = new System.Windows.Forms.Button();
			this.bt_sua = new System.Windows.Forms.Button();
			this.bt_tim = new System.Windows.Forms.Button();
			this.grw_phim = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.tb_maphim = new System.Windows.Forms.TextBox();
			this.tb_tenphim = new System.Windows.Forms.TextBox();
			this.cb_tlc = new System.Windows.Forms.ComboBox();
			this.tb_thoiluong = new System.Windows.Forms.TextBox();
			this.lb_tlp = new System.Windows.Forms.ListBox();
			this.cb_tlp = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_phim)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(393, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 38);
			this.label1.TabIndex = 3;
			this.label1.Text = "QUẢN LÝ PHIM";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tb_tim
			// 
			this.tb_tim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_tim.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.tb_tim.Location = new System.Drawing.Point(655, 79);
			this.tb_tim.Margin = new System.Windows.Forms.Padding(4);
			this.tb_tim.Name = "tb_tim";
			this.tb_tim.Size = new System.Drawing.Size(215, 31);
			this.tb_tim.TabIndex = 112;
			this.tb_tim.Text = "Tìm kiếm theo mã phim";
			this.tb_tim.Click += new System.EventHandler(this.textBox1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1016, 33);
			this.menuStrip1.TabIndex = 113;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// trangChủToolStripMenuItem
			// 
			this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trangChủToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
			this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
			this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
			this.trangChủToolStripMenuItem.Text = "Trang chủ";
			this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKếHoạchChiếuPhimToolStripMenuItem,
            this.quảnLýLịchChiếuPhimToolStripMenuItem,
            this.quảnLýPhimToolStripMenuItem,
            this.quảnLýCụmRạpToolStripMenuItem,
            this.quảnLýThểLoạiToolStripMenuItem,
            this.quảnLýRạpToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chứcNăngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// quảnLýKếHoạchChiếuPhimToolStripMenuItem
			// 
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem.Name = "quảnLýKếHoạchChiếuPhimToolStripMenuItem";
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem.Text = "Quản lý kế hoạch chiếu phim";
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKếHoạchChiếuPhimToolStripMenuItem_Click);
			// 
			// quảnLýLịchChiếuPhimToolStripMenuItem
			// 
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Name = "quảnLýLịchChiếuPhimToolStripMenuItem";
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Text = "Quản lý lịch chiếu phim";
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLịchChiếuPhimToolStripMenuItem_Click);
			// 
			// quảnLýPhimToolStripMenuItem
			// 
			this.quảnLýPhimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýPhimToolStripMenuItem.Name = "quảnLýPhimToolStripMenuItem";
			this.quảnLýPhimToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýPhimToolStripMenuItem.Text = "Quản lý phim";
			this.quảnLýPhimToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhimToolStripMenuItem_Click);
			// 
			// quảnLýCụmRạpToolStripMenuItem
			// 
			this.quảnLýCụmRạpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýCụmRạpToolStripMenuItem.Name = "quảnLýCụmRạpToolStripMenuItem";
			this.quảnLýCụmRạpToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýCụmRạpToolStripMenuItem.Text = "Quản lý cụm rạp";
			this.quảnLýCụmRạpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCụmRạpToolStripMenuItem_Click);
			// 
			// quảnLýThểLoạiToolStripMenuItem
			// 
			this.quảnLýThểLoạiToolStripMenuItem.Name = "quảnLýThểLoạiToolStripMenuItem";
			this.quảnLýThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýThểLoạiToolStripMenuItem.Text = "Quản lý thể loại";
			this.quảnLýThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThểLoạiToolStripMenuItem_Click);
			// 
			// quảnLýRạpToolStripMenuItem
			// 
			this.quảnLýRạpToolStripMenuItem.Name = "quảnLýRạpToolStripMenuItem";
			this.quảnLýRạpToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýRạpToolStripMenuItem.Text = "Quản lý rạp";
			this.quảnLýRạpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýRạpToolStripMenuItem_Click);
			// 
			// bt_luu
			// 
			this.bt_luu.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_luu.Location = new System.Drawing.Point(509, 261);
			this.bt_luu.Name = "bt_luu";
			this.bt_luu.Size = new System.Drawing.Size(125, 35);
			this.bt_luu.TabIndex = 116;
			this.bt_luu.Text = "Lưu";
			this.bt_luu.UseVisualStyleBackColor = false;
			this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click_1);
			// 
			// bt_xoa
			// 
			this.bt_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_xoa.Location = new System.Drawing.Point(174, 261);
			this.bt_xoa.Name = "bt_xoa";
			this.bt_xoa.Size = new System.Drawing.Size(125, 35);
			this.bt_xoa.TabIndex = 115;
			this.bt_xoa.Text = "Xóa";
			this.bt_xoa.UseVisualStyleBackColor = false;
			this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
			// 
			// bt_them
			// 
			this.bt_them.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_them.Location = new System.Drawing.Point(13, 261);
			this.bt_them.Name = "bt_them";
			this.bt_them.Size = new System.Drawing.Size(125, 35);
			this.bt_them.TabIndex = 114;
			this.bt_them.Text = "+Thêm";
			this.bt_them.UseVisualStyleBackColor = false;
			this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
			// 
			// bt_sua
			// 
			this.bt_sua.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_sua.Location = new System.Drawing.Point(339, 261);
			this.bt_sua.Name = "bt_sua";
			this.bt_sua.Size = new System.Drawing.Size(125, 35);
			this.bt_sua.TabIndex = 117;
			this.bt_sua.Text = "Sửa";
			this.bt_sua.UseVisualStyleBackColor = false;
			this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
			// 
			// bt_tim
			// 
			this.bt_tim.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_tim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_tim.Location = new System.Drawing.Point(877, 79);
			this.bt_tim.Name = "bt_tim";
			this.bt_tim.Size = new System.Drawing.Size(125, 35);
			this.bt_tim.TabIndex = 118;
			this.bt_tim.Text = "Tìm";
			this.bt_tim.UseVisualStyleBackColor = false;
			this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click_1);
			// 
			// grw_phim
			// 
			this.grw_phim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grw_phim.Location = new System.Drawing.Point(13, 305);
			this.grw_phim.Name = "grw_phim";
			this.grw_phim.RowHeadersWidth = 51;
			this.grw_phim.RowTemplate.Height = 24;
			this.grw_phim.Size = new System.Drawing.Size(987, 244);
			this.grw_phim.TabIndex = 119;
			this.grw_phim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grw_phim_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 120;
			this.label2.Text = "Tên phim:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 121;
			this.label3.Text = "Mã phim:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 20);
			this.label4.TabIndex = 122;
			this.label4.Text = "Thể loại chính:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(687, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 20);
			this.label5.TabIndex = 123;
			this.label5.Text = "Thể loại phụ:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(335, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 20);
			this.label6.TabIndex = 124;
			this.label6.Text = "Thời lượng:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(359, 208);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(97, 24);
			this.checkBox1.TabIndex = 125;
			this.checkBox1.Text = "Có là 3D";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(525, 208);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(109, 24);
			this.checkBox2.TabIndex = 126;
			this.checkBox2.Text = "Lồng tiếng";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// tb_maphim
			// 
			this.tb_maphim.Location = new System.Drawing.Point(101, 88);
			this.tb_maphim.Name = "tb_maphim";
			this.tb_maphim.Size = new System.Drawing.Size(150, 22);
			this.tb_maphim.TabIndex = 127;
			// 
			// tb_tenphim
			// 
			this.tb_tenphim.Location = new System.Drawing.Point(101, 146);
			this.tb_tenphim.Name = "tb_tenphim";
			this.tb_tenphim.Size = new System.Drawing.Size(549, 22);
			this.tb_tenphim.TabIndex = 128;
			// 
			// cb_tlc
			// 
			this.cb_tlc.FormattingEnabled = true;
			this.cb_tlc.Location = new System.Drawing.Point(143, 205);
			this.cb_tlc.Name = "cb_tlc";
			this.cb_tlc.Size = new System.Drawing.Size(171, 24);
			this.cb_tlc.TabIndex = 129;
			// 
			// tb_thoiluong
			// 
			this.tb_thoiluong.Location = new System.Drawing.Point(436, 88);
			this.tb_thoiluong.Name = "tb_thoiluong";
			this.tb_thoiluong.Size = new System.Drawing.Size(150, 22);
			this.tb_thoiluong.TabIndex = 131;
			// 
			// lb_tlp
			// 
			this.lb_tlp.FormattingEnabled = true;
			this.lb_tlp.ItemHeight = 16;
			this.lb_tlp.Location = new System.Drawing.Point(832, 148);
			this.lb_tlp.Name = "lb_tlp";
			this.lb_tlp.Size = new System.Drawing.Size(168, 148);
			this.lb_tlp.TabIndex = 132;
			this.lb_tlp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_tlp_KeyDown);
			// 
			// cb_tlp
			// 
			this.cb_tlp.FormattingEnabled = true;
			this.cb_tlp.Location = new System.Drawing.Point(691, 180);
			this.cb_tlp.Name = "cb_tlp";
			this.cb_tlp.Size = new System.Drawing.Size(125, 24);
			this.cb_tlp.TabIndex = 134;
			this.cb_tlp.SelectedIndexChanged += new System.EventHandler(this.cb_tlp_SelectedIndexChanged);
			this.cb_tlp.Click += new System.EventHandler(this.cb_tlp_Click);
			// 
			// QL_Phim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 562);
			this.Controls.Add(this.cb_tlp);
			this.Controls.Add(this.lb_tlp);
			this.Controls.Add(this.tb_thoiluong);
			this.Controls.Add(this.cb_tlc);
			this.Controls.Add(this.tb_tenphim);
			this.Controls.Add(this.tb_maphim);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grw_phim);
			this.Controls.Add(this.bt_tim);
			this.Controls.Add(this.bt_sua);
			this.Controls.Add(this.bt_luu);
			this.Controls.Add(this.bt_xoa);
			this.Controls.Add(this.bt_them);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tb_tim);
			this.Controls.Add(this.label1);
			this.Name = "QL_Phim";
			this.Text = "QLPhim";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_phim)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKếHoạchChiếuPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchChiếuPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCụmRạpToolStripMenuItem;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView grw_phim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox tb_maphim;
        private System.Windows.Forms.TextBox tb_tenphim;
        private System.Windows.Forms.ComboBox cb_tlc;
        private System.Windows.Forms.TextBox tb_thoiluong;
        private System.Windows.Forms.ListBox lb_tlp;
        private System.Windows.Forms.ComboBox cb_tlp;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýRạpToolStripMenuItem;
    }
}


