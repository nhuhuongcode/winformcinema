using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class The_loai_phim
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
			this.bt_luu = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.bt_chinhsua = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýLịchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýCụmRạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grw_tl = new System.Windows.Forms.DataGridView();
			this.bt_them = new System.Windows.Forms.Button();
			this.bt_xoa = new System.Windows.Forms.Button();
			this.bt_tim = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_tl)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(365, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "THỂ LOẠI PHIM";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// bt_luu
			// 
			this.bt_luu.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_luu.Location = new System.Drawing.Point(875, 135);
			this.bt_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_luu.Name = "bt_luu";
			this.bt_luu.Size = new System.Drawing.Size(125, 34);
			this.bt_luu.TabIndex = 123;
			this.bt_luu.Text = "Lưu";
			this.bt_luu.UseVisualStyleBackColor = false;
			this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button3.Location = new System.Drawing.Point(861, 95);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(0, 0);
			this.button3.TabIndex = 122;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// bt_chinhsua
			// 
			this.bt_chinhsua.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_chinhsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_chinhsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_chinhsua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_chinhsua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_chinhsua.Location = new System.Drawing.Point(715, 96);
			this.bt_chinhsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_chinhsua.Name = "bt_chinhsua";
			this.bt_chinhsua.Size = new System.Drawing.Size(125, 34);
			this.bt_chinhsua.TabIndex = 121;
			this.bt_chinhsua.Text = "Sửa";
			this.bt_chinhsua.UseVisualStyleBackColor = false;
			this.bt_chinhsua.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox1.Location = new System.Drawing.Point(13, 96);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(477, 31);
			this.textBox1.TabIndex = 124;
			this.textBox1.Text = "Tìm kiếm theo mã thể loại";
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1016, 33);
			this.menuStrip1.TabIndex = 125;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// trangChủToolStripMenuItem
			// 
			this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trangChủToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
			this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
			this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
			this.trangChủToolStripMenuItem.Text = "Trang chủ";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKếHoạchChiếuPhimToolStripMenuItem,
            this.quảnLýLịchChiếuPhimToolStripMenuItem,
            this.quảnLýPhimToolStripMenuItem,
            this.quảnLýCụmRạpToolStripMenuItem});
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
			// 
			// quảnLýLịchChiếuPhimToolStripMenuItem
			// 
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Name = "quảnLýLịchChiếuPhimToolStripMenuItem";
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýLịchChiếuPhimToolStripMenuItem.Text = "Quản lý lịch chiếu phim";
			// 
			// quảnLýPhimToolStripMenuItem
			// 
			this.quảnLýPhimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýPhimToolStripMenuItem.Name = "quảnLýPhimToolStripMenuItem";
			this.quảnLýPhimToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýPhimToolStripMenuItem.Text = "Quản lý phim";
			// 
			// quảnLýCụmRạpToolStripMenuItem
			// 
			this.quảnLýCụmRạpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quảnLýCụmRạpToolStripMenuItem.Name = "quảnLýCụmRạpToolStripMenuItem";
			this.quảnLýCụmRạpToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
			this.quảnLýCụmRạpToolStripMenuItem.Text = "Quản lý cụm rạp";
			// 
			// grw_tl
			// 
			this.grw_tl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grw_tl.Location = new System.Drawing.Point(13, 177);
			this.grw_tl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grw_tl.Name = "grw_tl";
			this.grw_tl.RowHeadersWidth = 51;
			this.grw_tl.RowTemplate.Height = 24;
			this.grw_tl.Size = new System.Drawing.Size(987, 372);
			this.grw_tl.TabIndex = 126;
			// 
			// bt_them
			// 
			this.bt_them.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_them.Location = new System.Drawing.Point(549, 96);
			this.bt_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_them.Name = "bt_them";
			this.bt_them.Size = new System.Drawing.Size(125, 34);
			this.bt_them.TabIndex = 127;
			this.bt_them.Text = "+ Thêm";
			this.bt_them.UseVisualStyleBackColor = false;
			this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
			// 
			// bt_xoa
			// 
			this.bt_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_xoa.Location = new System.Drawing.Point(875, 96);
			this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_xoa.Name = "bt_xoa";
			this.bt_xoa.Size = new System.Drawing.Size(125, 34);
			this.bt_xoa.TabIndex = 128;
			this.bt_xoa.Text = "Xóa";
			this.bt_xoa.UseVisualStyleBackColor = false;
			this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
			// 
			// bt_tim
			// 
			this.bt_tim.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_tim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_tim.Location = new System.Drawing.Point(13, 135);
			this.bt_tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_tim.Name = "bt_tim";
			this.bt_tim.Size = new System.Drawing.Size(125, 34);
			this.bt_tim.TabIndex = 129;
			this.bt_tim.Text = "Tìm";
			this.bt_tim.UseVisualStyleBackColor = false;
			this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã thể loại";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Tên thể loại";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// The_loai_phim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 562);
			this.Controls.Add(this.bt_tim);
			this.Controls.Add(this.bt_xoa);
			this.Controls.Add(this.bt_them);
			this.Controls.Add(this.grw_tl);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.bt_luu);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.bt_chinhsua);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "The_loai_phim";
			this.Text = "Thể loại phim";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_tl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_chinhsua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKếHoạchChiếuPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchChiếuPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCụmRạpToolStripMenuItem;
        private System.Windows.Forms.DataGridView grw_tl;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}


