namespace WindowsFormsApp_Login.Admin.View
{
    partial class MonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjCircularBox1 = new CustomBox.RJControls.RJCircularBox();
            this.rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            this.BtnThem = new RJCodeAdvance.RJControls.RJButton();
            this.BtnXoa = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjCircularBox1);
            this.panel1.Controls.Add(this.rjButton5);
            this.panel1.Controls.Add(this.rjButton4);
            this.panel1.Controls.Add(this.rjButton3);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.rjButton6);
            this.panel1.Location = new System.Drawing.Point(0, -15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 628);
            this.panel1.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(107, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "@jackdz5trieu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(106, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Admin Dách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "THÔNG TIN MÔN HỌC";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(397, 201);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(542, 332);
            this.bunifuCustomDataGrid1.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Môn học";
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // rjCircularBox1
            // 
            this.rjCircularBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularBox1.BorderSize = 2;
            this.rjCircularBox1.GradientAngle = 50F;
            this.rjCircularBox1.Image = global::WindowsFormsApp_Login.Properties.Resources._333_18364548;
            this.rjCircularBox1.Location = new System.Drawing.Point(24, 36);
            this.rjCircularBox1.Name = "rjCircularBox1";
            this.rjCircularBox1.Size = new System.Drawing.Size(66, 66);
            this.rjCircularBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularBox1.TabIndex = 5;
            this.rjCircularBox1.TabStop = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(25)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(25)))));
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 22;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.rjButton5.Image = global::WindowsFormsApp_Login.Properties.Resources.log_out_circle_regular_24;
            this.rjButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton5.Location = new System.Drawing.Point(10, 551);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(243, 46);
            this.rjButton5.TabIndex = 4;
            this.rjButton5.Text = "Đăng xuất";
            this.rjButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 22;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Image = global::WindowsFormsApp_Login.Properties.Resources.stats_regular_24;
            this.rjButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton4.Location = new System.Drawing.Point(10, 320);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(243, 46);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.Text = "Thống kê";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(248)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(248)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 22;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Image = global::WindowsFormsApp_Login.Properties.Resources.book_regular_24;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.Location = new System.Drawing.Point(10, 268);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(243, 46);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.Text = "Quản lý môn học";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 22;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::WindowsFormsApp_Login.Properties.Resources.user_detail_solid_24;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(10, 216);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(243, 46);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Quản lý người dùng";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 22;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Image = global::WindowsFormsApp_Login.Properties.Resources.book_reader_regular_24;
            this.rjButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton6.Location = new System.Drawing.Point(10, 168);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(243, 46);
            this.rjButton6.TabIndex = 0;
            this.rjButton6.Text = "Quản lý đề thi";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.BtnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.BtnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(101)))));
            this.BtnThem.BorderRadius = 10;
            this.BtnThem.BorderSize = 2;
            this.BtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThem.FlatAppearance.BorderSize = 0;
            this.BtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Location = new System.Drawing.Point(397, 146);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(115, 32);
            this.BtnThem.TabIndex = 62;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.TextColor = System.Drawing.Color.White;
            this.BtnThem.UseVisualStyleBackColor = false;
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.BtnXoa.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnXoa.BorderColor = System.Drawing.Color.Brown;
            this.BtnXoa.BorderRadius = 10;
            this.BtnXoa.BorderSize = 2;
            this.BtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoa.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(824, 146);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(115, 32);
            this.BtnXoa.TabIndex = 63;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.TextColor = System.Drawing.Color.White;
            this.BtnXoa.UseVisualStyleBackColor = false;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 597);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonHoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomBox.RJControls.RJCircularBox rjCircularBox1;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private RJCodeAdvance.RJControls.RJButton BtnThem;
        private RJCodeAdvance.RJControls.RJButton BtnXoa;
    }
}