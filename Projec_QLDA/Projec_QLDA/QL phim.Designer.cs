namespace WindowsFormsApp3
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýKếHoạchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýLịchChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýCụmRạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button4.Location = new System.Drawing.Point(875, 135);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(125, 35);
			this.button4.TabIndex = 116;
			this.button4.Text = "Lưu";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button3.Location = new System.Drawing.Point(875, 96);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 35);
			this.button3.TabIndex = 115;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(549, 96);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 35);
			this.button2.TabIndex = 114;
			this.button2.Text = "+Thêm";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(714, 96);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 35);
			this.button1.TabIndex = 117;
			this.button1.Text = "Sửa";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button5.Location = new System.Drawing.Point(13, 135);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(125, 35);
			this.button5.TabIndex = 118;
			this.button5.Text = "Tìm";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(987, 372);
			this.dataGridView1.TabIndex = 119;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 562);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
