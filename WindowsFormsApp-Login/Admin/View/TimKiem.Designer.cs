namespace WindowsFormsApp_Login.Admin.View
{
    partial class TimKiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listEx_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_searchEx = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).BeginInit();
            this.SuspendLayout();
            // 
            // listEx_table
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listEx_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.listEx_table.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.listEx_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEx_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listEx_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.listEx_table.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.listEx_table.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listEx_table.Location = new System.Drawing.Point(71, 189);
            this.listEx_table.Margin = new System.Windows.Forms.Padding(2);
            this.listEx_table.Name = "listEx_table";
            this.listEx_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listEx_table.RowHeadersWidth = 51;
            this.listEx_table.RowTemplate.Height = 24;
            this.listEx_table.Size = new System.Drawing.Size(610, 211);
            this.listEx_table.TabIndex = 20;
            this.listEx_table.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listEx_table_CellMouseDoubleClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // NameExam
            // 
            this.NameExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameExam.HeaderText = "Tên đề";
            this.NameExam.MinimumWidth = 6;
            this.NameExam.Name = "NameExam";
            // 
            // NumberExam
            // 
            this.NumberExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberExam.HeaderText = "Đề số";
            this.NumberExam.MinimumWidth = 6;
            this.NumberExam.Name = "NumberExam";
            // 
            // SoCau
            // 
            this.SoCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCau.HeaderText = "Số câu";
            this.SoCau.MinimumWidth = 6;
            this.SoCau.Name = "SoCau";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "Thời gian";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tìm cmn đề ở đây ";
            // 
            // cB_searchEx
            // 
            this.cB_searchEx.FormattingEnabled = true;
            this.cB_searchEx.Location = new System.Drawing.Point(466, 105);
            this.cB_searchEx.Name = "cB_searchEx";
            this.cB_searchEx.Size = new System.Drawing.Size(215, 21);
            this.cB_searchEx.TabIndex = 22;
            this.cB_searchEx.SelectedIndexChanged += new System.EventHandler(this.cB_searchEx_SelectedIndexChanged);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 44);
            this.backbtn.TabIndex = 23;
            this.backbtn.Text = "Quay lại";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 481);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.cB_searchEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEx_table);
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid listEx_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_searchEx;
        private System.Windows.Forms.Button backbtn;
    }
}