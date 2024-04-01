namespace WindowsFormsApp_Login.Admin.View
{
    partial class EditQuestion
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
            this.save = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.answerCorrect = new System.Windows.Forms.ComboBox();
            this.answerD = new System.Windows.Forms.TextBox();
            this.answerC = new System.Windows.Forms.TextBox();
            this.answerB = new System.Windows.Forms.TextBox();
            this.answerA = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cauHoi = new System.Windows.Forms.Label();
            this.tenDe = new System.Windows.Forms.Label();
            this.tenMon = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(380, 502);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(93, 38);
            this.save.TabIndex = 39;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(597, 502);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(93, 38);
            this.next.TabIndex = 38;
            this.next.Text = "Câu tiếp";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // quaylai
            // 
            this.quaylai.AutoSize = true;
            this.quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylai.Location = new System.Drawing.Point(151, 502);
            this.quaylai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(82, 38);
            this.quaylai.TabIndex = 37;
            this.quaylai.Text = "Câu sau";
            this.quaylai.UseVisualStyleBackColor = true;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // answerCorrect
            // 
            this.answerCorrect.FormattingEnabled = true;
            this.answerCorrect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.answerCorrect.Location = new System.Drawing.Point(236, 436);
            this.answerCorrect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerCorrect.Name = "answerCorrect";
            this.answerCorrect.Size = new System.Drawing.Size(68, 21);
            this.answerCorrect.TabIndex = 36;
            // 
            // answerD
            // 
            this.answerD.Location = new System.Drawing.Point(236, 393);
            this.answerD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerD.Multiline = true;
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(456, 30);
            this.answerD.TabIndex = 35;
            // 
            // answerC
            // 
            this.answerC.Location = new System.Drawing.Point(236, 349);
            this.answerC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerC.Multiline = true;
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(456, 30);
            this.answerC.TabIndex = 34;
            // 
            // answerB
            // 
            this.answerB.Location = new System.Drawing.Point(236, 306);
            this.answerB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerB.Multiline = true;
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(456, 30);
            this.answerB.TabIndex = 33;
            // 
            // answerA
            // 
            this.answerA.Location = new System.Drawing.Point(236, 256);
            this.answerA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerA.Multiline = true;
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(456, 34);
            this.answerA.TabIndex = 32;
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(236, 141);
            this.question.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(456, 102);
            this.question.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 442);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "ĐÚNG :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Đáp án D :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Đáp án C :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Đáp án B :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Đáp án A :";
            // 
            // cauHoi
            // 
            this.cauHoi.AutoSize = true;
            this.cauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauHoi.Location = new System.Drawing.Point(148, 141);
            this.cauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cauHoi.Name = "cauHoi";
            this.cauHoi.Size = new System.Drawing.Size(76, 17);
            this.cauHoi.TabIndex = 25;
            this.cauHoi.Text = "Câu hỏi 1 :";
            // 
            // tenDe
            // 
            this.tenDe.AutoSize = true;
            this.tenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDe.Location = new System.Drawing.Point(386, 98);
            this.tenDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenDe.Name = "tenDe";
            this.tenDe.Size = new System.Drawing.Size(97, 17);
            this.tenDe.TabIndex = 24;
            this.tenDe.Text = "ĐỀ THI SỐ : 1";
            // 
            // tenMon
            // 
            this.tenMon.AutoSize = true;
            this.tenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMon.Location = new System.Drawing.Point(272, 39);
            this.tenMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenMon.Name = "tenMon";
            this.tenMon.Size = new System.Drawing.Size(250, 26);
            this.tenMon.TabIndex = 23;
            this.tenMon.Text = "Môn học: Mạng máy tính";
            this.tenMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(10, 11);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 44);
            this.backbtn.TabIndex = 40;
            this.backbtn.Text = "Quay lại";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 585);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.save);
            this.Controls.Add(this.next);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.answerCorrect);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cauHoi);
            this.Controls.Add(this.tenDe);
            this.Controls.Add(this.tenMon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.ComboBox answerCorrect;
        private System.Windows.Forms.TextBox answerD;
        private System.Windows.Forms.TextBox answerC;
        private System.Windows.Forms.TextBox answerB;
        private System.Windows.Forms.TextBox answerA;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cauHoi;
        private System.Windows.Forms.Label tenDe;
        private System.Windows.Forms.Label tenMon;
        private System.Windows.Forms.Button backbtn;
    }
}