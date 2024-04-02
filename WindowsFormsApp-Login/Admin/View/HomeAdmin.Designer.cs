namespace WindowsFormsApp_Login
{
    partial class HomeAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjCircularBox1 = new CustomBox.RJControls.RJCircularBox();
            this.rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME, ADMIN !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rjCircularBox1);
            this.panel1.Controls.Add(this.rjButton5);
            this.panel1.Controls.Add(this.rjButton4);
            this.panel1.Controls.Add(this.rjButton3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 628);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(248)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(248)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 22;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 168);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(243, 46);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Quản lý đề thi";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 22;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(12, 216);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(243, 46);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.Text = "Quản lý người dùng";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 22;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(12, 268);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(243, 46);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.Text = "Quản lý môn học";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
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
            this.rjButton4.Location = new System.Drawing.Point(12, 320);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(243, 46);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.Text = "Thống kê";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "@admin123";
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
            this.rjCircularBox1.Location = new System.Drawing.Point(24, 26);
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
            this.rjButton5.Location = new System.Drawing.Point(12, 551);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(243, 46);
            this.rjButton5.TabIndex = 4;
            this.rjButton5.Text = "Đăng xuất";
            this.rjButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomBox.RJControls.RJCircularBox rjCircularBox1;
    }
}