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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýLịchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýCụmRạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bt_luu = new System.Windows.Forms.Button();
			this.bt_xoa = new System.Windows.Forms.Button();
			this.bt_them = new System.Windows.Forms.Button();
			this.bt_sua = new System.Windows.Forms.Button();
			this.bt_tim = new System.Windows.Forms.Button();
			this.grw_cr1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_cr1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(366, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 38);
			this.label1.TabIndex = 3;
			this.label1.Text = "QUẢN LÝ PHIM";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox1.Location = new System.Drawing.Point(13, 95);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(477, 31);
			this.textBox1.TabIndex = 112;
			this.textBox1.Text = "Tìm kiếm theo mã rạp, mã cụm rạp...";
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
			// bt_luu
			// 
			this.bt_luu.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_luu.Location = new System.Drawing.Point(875, 135);
			this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
			this.bt_luu.Name = "bt_luu";
			this.bt_luu.Size = new System.Drawing.Size(125, 35);
			this.bt_luu.TabIndex = 116;
			this.bt_luu.Text = "Lưu";
			this.bt_luu.UseVisualStyleBackColor = false;
			// 
			// bt_xoa
			// 
			this.bt_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_xoa.Location = new System.Drawing.Point(875, 96);
			this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
			this.bt_xoa.Name = "bt_xoa";
			this.bt_xoa.Size = new System.Drawing.Size(125, 35);
			this.bt_xoa.TabIndex = 115;
			this.bt_xoa.Text = "Xóa";
			this.bt_xoa.UseVisualStyleBackColor = false;
			// 
			// bt_them
			// 
			this.bt_them.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_them.Location = new System.Drawing.Point(549, 96);
			this.bt_them.Margin = new System.Windows.Forms.Padding(4);
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
			this.bt_sua.Location = new System.Drawing.Point(714, 96);
			this.bt_sua.Margin = new System.Windows.Forms.Padding(4);
			this.bt_sua.Name = "bt_sua";
			this.bt_sua.Size = new System.Drawing.Size(125, 35);
			this.bt_sua.TabIndex = 117;
			this.bt_sua.Text = "Sửa";
			this.bt_sua.UseVisualStyleBackColor = false;
			// 
			// bt_tim
			// 
			this.bt_tim.BackColor = System.Drawing.SystemColors.HotTrack;
			this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_tim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_tim.Location = new System.Drawing.Point(13, 135);
			this.bt_tim.Margin = new System.Windows.Forms.Padding(4);
			this.bt_tim.Name = "bt_tim";
			this.bt_tim.Size = new System.Drawing.Size(125, 35);
			this.bt_tim.TabIndex = 118;
			this.bt_tim.Text = "Tìm";
			this.bt_tim.UseVisualStyleBackColor = false;
			// 
			// grw_cr1
			// 
			this.grw_cr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grw_cr1.Location = new System.Drawing.Point(13, 177);
			this.grw_cr1.Name = "grw_cr1";
			this.grw_cr1.RowHeadersWidth = 51;
			this.grw_cr1.RowTemplate.Height = 24;
			this.grw_cr1.Size = new System.Drawing.Size(987, 372);
			this.grw_cr1.TabIndex = 119;
			// 
			// QL_Phim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 562);
			this.Controls.Add(this.grw_cr1);
			this.Controls.Add(this.bt_tim);
			this.Controls.Add(this.bt_sua);
			this.Controls.Add(this.bt_luu);
			this.Controls.Add(this.bt_xoa);
			this.Controls.Add(this.bt_them);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "QL_Phim";
			this.Text = "QLPhim";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grw_cr1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
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
		private System.Windows.Forms.DataGridView grw_cr1;
	}
}
