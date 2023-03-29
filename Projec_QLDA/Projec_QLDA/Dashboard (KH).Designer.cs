namespace Projec_QLDA
{
	partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chưcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLichChiêuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyCumRapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyRapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThêLoaiPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySuâtChiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grw_kh = new System.Windows.Forms.DataGridView();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_chinhsua = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grw_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.chưcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // chưcNăngToolStripMenuItem
            // 
            this.chưcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyLichChiêuPhimToolStripMenuItem,
            this.quanLyCumRapToolStripMenuItem,
            this.quanLyRapToolStripMenuItem,
            this.quanLyPhimToolStripMenuItem,
            this.quanLyThêLoaiPhimToolStripMenuItem,
            this.quanLySuâtChiêuToolStripMenuItem});
            this.chưcNăngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chưcNăngToolStripMenuItem.Name = "chưcNăngToolStripMenuItem";
            this.chưcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chưcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quanLyLichChiêuPhimToolStripMenuItem
            // 
            this.quanLyLichChiêuPhimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quanLyLichChiêuPhimToolStripMenuItem.Name = "quanLyLichChiêuPhimToolStripMenuItem";
            this.quanLyLichChiêuPhimToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLyLichChiêuPhimToolStripMenuItem.Text = "Quản lý lịch chiếu phim";
            // 
            // quanLyCumRapToolStripMenuItem
            // 
            this.quanLyCumRapToolStripMenuItem.Name = "quanLyCumRapToolStripMenuItem";
            this.quanLyCumRapToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLyCumRapToolStripMenuItem.Text = "Quản lý cụm rạp";
            // 
            // quanLyRapToolStripMenuItem
            // 
            this.quanLyRapToolStripMenuItem.Name = "quanLyRapToolStripMenuItem";
            this.quanLyRapToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLyRapToolStripMenuItem.Text = "Quản lý rạp";
            // 
            // quanLyPhimToolStripMenuItem
            // 
            this.quanLyPhimToolStripMenuItem.Name = "quanLyPhimToolStripMenuItem";
            this.quanLyPhimToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLyPhimToolStripMenuItem.Text = "Quản lý phim";
            // 
            // quanLyThêLoaiPhimToolStripMenuItem
            // 
            this.quanLyThêLoaiPhimToolStripMenuItem.Name = "quanLyThêLoaiPhimToolStripMenuItem";
            this.quanLyThêLoaiPhimToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLyThêLoaiPhimToolStripMenuItem.Text = "Quản lý thể loại phim";
            // 
            // quanLySuâtChiêuToolStripMenuItem
            // 
            this.quanLySuâtChiêuToolStripMenuItem.Name = "quanLySuâtChiêuToolStripMenuItem";
            this.quanLySuâtChiêuToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quanLySuâtChiêuToolStripMenuItem.Text = "Quản lý suất chiếu";
            // 
            // grw_kh
            // 
            this.grw_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grw_kh.Location = new System.Drawing.Point(12, 178);
            this.grw_kh.Name = "grw_kh";
            this.grw_kh.RowHeadersWidth = 51;
            this.grw_kh.RowTemplate.Height = 24;
            this.grw_kh.Size = new System.Drawing.Size(987, 372);
            this.grw_kh.TabIndex = 127;
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_tim.Location = new System.Drawing.Point(12, 136);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(125, 35);
            this.bt_tim.TabIndex = 126;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_chinhsua
            // 
            this.bt_chinhsua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_chinhsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_chinhsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chinhsua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chinhsua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_chinhsua.Location = new System.Drawing.Point(713, 97);
            this.bt_chinhsua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_chinhsua.Name = "bt_chinhsua";
            this.bt_chinhsua.Size = new System.Drawing.Size(125, 35);
            this.bt_chinhsua.TabIndex = 125;
            this.bt_chinhsua.Text = "Sửa";
            this.bt_chinhsua.UseVisualStyleBackColor = false;
            this.bt_chinhsua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_luu.Location = new System.Drawing.Point(874, 136);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(125, 35);
            this.bt_luu.TabIndex = 124;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(874, 97);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(125, 35);
            this.bt_xoa.TabIndex = 123;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_them.Location = new System.Drawing.Point(548, 97);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(125, 35);
            this.bt_them.TabIndex = 122;
            this.bt_them.Text = "+Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(12, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 31);
            this.textBox1.TabIndex = 121;
            this.textBox1.Text = "Tìm kiếm theo mã phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 120;
            this.label2.Text = "KẾ HOẠCH CHIẾU PHIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 562);
            this.Controls.Add(this.grw_kh);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.bt_chinhsua);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grw_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;
<<<<<<< HEAD
=======
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.DateTimePicker dateTimePicker5;
		private System.Windows.Forms.DateTimePicker dateTimePicker6;
		private System.Windows.Forms.DateTimePicker dateTimePicker7;
		private System.Windows.Forms.DateTimePicker dateTimePicker8;
		private System.Windows.Forms.DateTimePicker dateTimePicker9;
		private System.Windows.Forms.DateTimePicker dateTimePicker10;
		private System.Windows.Forms.DateTimePicker dateTimePicker11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker12;
		private System.Windows.Forms.DateTimePicker dateTimePicker13;
		private System.Windows.Forms.DateTimePicker dateTimePicker14;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox21;
>>>>>>> 29c9126857a3d8236b423a40fe9bce99c62a97a7
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chưcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLyLichChiêuPhimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLyCumRapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLyRapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLyPhimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLyThêLoaiPhimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quanLySuâtChiêuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
<<<<<<< HEAD
		private System.Windows.Forms.DataGridView grw_kh;
		private System.Windows.Forms.Button bt_tim;
		private System.Windows.Forms.Button bt_chinhsua;
		private System.Windows.Forms.Button bt_luu;
		private System.Windows.Forms.Button bt_xoa;
		private System.Windows.Forms.Button bt_them;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
	}
=======
		private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.Label label13;
	}
>>>>>>> 29c9126857a3d8236b423a40fe9bce99c62a97a7
}


