﻿namespace WindowsFormsApp_Login.Admin.View
{
    partial class FormDeThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_tende = new System.Windows.Forms.ComboBox();
            this.tB_deso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_socau = new System.Windows.Forms.ComboBox();
            this.cB_time = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.listEx_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.BtnThem = new RJCodeAdvance.RJControls.RJButton();
            this.BtnXoa = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÔNG TIN ĐỀ THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đề :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đề số :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số câu :";
            // 
            // cB_tende
            // 
            this.cB_tende.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_tende.FormattingEnabled = true;
            this.cB_tende.Location = new System.Drawing.Point(194, 145);
            this.cB_tende.Margin = new System.Windows.Forms.Padding(2);
            this.cB_tende.Name = "cB_tende";
            this.cB_tende.Size = new System.Drawing.Size(194, 26);
            this.cB_tende.TabIndex = 9;
            this.cB_tende.SelectedIndexChanged += new System.EventHandler(this.cB_tende_SelectedIndexChanged);
            // 
            // tB_deso
            // 
            this.tB_deso.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_deso.Location = new System.Drawing.Point(194, 183);
            this.tB_deso.Margin = new System.Windows.Forms.Padding(2);
            this.tB_deso.Name = "tB_deso";
            this.tB_deso.Size = new System.Drawing.Size(194, 23);
            this.tB_deso.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phút";
            // 
            // cB_socau
            // 
            this.cB_socau.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_socau.FormattingEnabled = true;
            this.cB_socau.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cB_socau.Location = new System.Drawing.Point(194, 222);
            this.cB_socau.Margin = new System.Windows.Forms.Padding(2);
            this.cB_socau.Name = "cB_socau";
            this.cB_socau.Size = new System.Drawing.Size(76, 26);
            this.cB_socau.TabIndex = 13;
            this.cB_socau.Text = "5";
            // 
            // cB_time
            // 
            this.cB_time.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_time.FormattingEnabled = true;
            this.cB_time.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "45",
            "90"});
            this.cB_time.Location = new System.Drawing.Point(378, 222);
            this.cB_time.Margin = new System.Windows.Forms.Padding(2);
            this.cB_time.Name = "cB_time";
            this.cB_time.Size = new System.Drawing.Size(76, 26);
            this.cB_time.TabIndex = 14;
            this.cB_time.Text = "10";
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(549, 212);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(115, 26);
            this.btn_tim.TabIndex = 17;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(588, 248);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(76, 26);
            this.btn_huy.TabIndex = 18;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // listEx_table
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listEx_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.listEx_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.listEx_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEx_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listEx_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listEx_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEx_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.NameExam,
            this.NumberExam,
            this.SoCau,
            this.Time});
            this.listEx_table.DoubleBuffered = true;
            this.listEx_table.EnableHeadersVisualStyles = false;
            this.listEx_table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.listEx_table.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listEx_table.Location = new System.Drawing.Point(20, 338);
            this.listEx_table.Margin = new System.Windows.Forms.Padding(2);
            this.listEx_table.Name = "listEx_table";
            this.listEx_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listEx_table.RowHeadersWidth = 51;
            this.listEx_table.RowTemplate.Height = 24;
            this.listEx_table.Size = new System.Drawing.Size(741, 211);
            this.listEx_table.TabIndex = 19;
            this.listEx_table.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listEx_table_MouseDoubleClick);
            this.listEx_table.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listEx_table_MouseClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // NameExam
            // 
            this.NameExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameExam.FillWeight = 200F;
            this.NameExam.HeaderText = "Tên đề";
            this.NameExam.MinimumWidth = 6;
            this.NameExam.Name = "NameExam";
            // 
            // NumberExam
            // 
            this.NumberExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberExam.FillWeight = 80F;
            this.NumberExam.HeaderText = "Đề số";
            this.NumberExam.MinimumWidth = 6;
            this.NumberExam.Name = "NumberExam";
            // 
            // SoCau
            // 
            this.SoCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCau.FillWeight = 80F;
            this.SoCau.HeaderText = "Số câu";
            this.SoCau.MinimumWidth = 6;
            this.SoCau.Name = "SoCau";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.FillWeight = 80F;
            this.Time.HeaderText = "Thời gian";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "DANH SÁCH ĐỀ THI";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.Black;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.rjButton2.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(20, 20);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(98, 41);
            this.rjButton2.TabIndex = 21;
            this.rjButton2.Text = "  Quay lại";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
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
            this.BtnThem.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Location = new System.Drawing.Point(549, 124);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(115, 32);
            this.BtnThem.TabIndex = 45;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.TextColor = System.Drawing.Color.White;
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
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
            this.BtnXoa.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(549, 168);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(115, 32);
            this.BtnXoa.TabIndex = 46;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.TextColor = System.Drawing.Color.White;
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // FormDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(770, 597);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listEx_table);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.cB_time);
            this.Controls.Add(this.cB_socau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_deso);
            this.Controls.Add(this.cB_tende);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeThi";
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_tende;
        private System.Windows.Forms.TextBox tB_deso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_socau;
        private System.Windows.Forms.ComboBox cB_time;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_huy;
        private Bunifu.Framework.UI.BunifuCustomDataGrid listEx_table;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton BtnThem;
        private RJCodeAdvance.RJControls.RJButton BtnXoa;
    }
}