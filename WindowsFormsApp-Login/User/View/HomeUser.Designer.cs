namespace WindowsFormsApp_Login.User.View
{
    partial class HomeUser
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullName = new RJCodeAdvance.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.vàoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 2;
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FullName.BorderRadius = 0;
            this.FullName.BorderSize = 0;
            this.FullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullName.FlatAppearance.BorderSize = 0;
            this.FullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.White;
            this.FullName.Location = new System.Drawing.Point(583, 25);
            this.FullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(198, 36);
            this.FullName.TabIndex = 5;
            this.FullName.Text = "Nguyễn Minh Quân";
            this.FullName.TextColor = System.Drawing.Color.White;
            this.FullName.UseVisualStyleBackColor = false;
            this.FullName.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xếp hạng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(371, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vào thi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trang chủ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuizPro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(281, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phát triển bởi nhóm 11 - Quân - Tươi - Tú - Cấp - Phúc";
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = true;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vàoThiToolStripMenuItem,
            this.thayĐổiThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Size = new System.Drawing.Size(189, 114);
            // 
            // vàoThiToolStripMenuItem
            // 
            this.vàoThiToolStripMenuItem.Name = "vàoThiToolStripMenuItem";
            this.vàoThiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.vàoThiToolStripMenuItem.Text = "Vào thi";
            this.vàoThiToolStripMenuItem.Click += new System.EventHandler(this.vàoThiToolStripMenuItem_Click);
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay đổi thông tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp_Login.Properties.Resources._21504082051;
            this.pictureBox2.Location = new System.Drawing.Point(1, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp_Login.Properties.Resources._4283739_1263;
            this.pictureBox1.Location = new System.Drawing.Point(1, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJButton FullName;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem vàoThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}