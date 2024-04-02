﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Login.User.View
{
    public partial class KetQua : Form
    {
        private int id_User;
        private ExamModify examModify;
        public KetQua(int id_User)
        {
            InitializeComponent();
            string[] row = new string[] { "1", "1", "9", "5 phút 30 giây", "14/3/2024" }; // Dữ liệu cần thêm
            KetQuaTable.Rows.Add(row); // Thêm dữ liệu vào DataGridView
            this.id_User = id_User;
            this.examModify = new ExamModify();
            DisplayHistoryTests();

        }

        private void DisplayHistoryTests()
        {
            
            List<History> historyTests = examModify.GetHistoryTests(id_User);         
            if (historyTests.Count > 0)
            {
                
                KetQuaTable.Rows.Clear();

                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(),
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };

                    
                    KetQuaTable.Rows.Add(row);
                }
            }
            else
            {
                
                MessageBox.Show("Bạn chưa làm đề thi nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBai lamBai = new LamBai();
            lamBai.ShowDialog();
            this.Close();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            
            List<Subject> subjects = examModify.GetSubjectNames();

            
            foreach (Subject subject in subjects)
            {
                MonHocOption.Items.Add(subject.NameExam);
            }

        }

        private void DisplayHistoryTests(List<History> historyTests)
        {       
            KetQuaTable.Rows.Clear();
            if (historyTests.Count > 0)
            {
                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(), // Thêm STT vào hàng
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };

                    KetQuaTable.Rows.Add(row);
                }
            }
            else
            {
               
                MessageBox.Show("Không có kết quả nào cho môn học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {

            if (MonHocOption.SelectedIndex != -1)
            {
                
                string monHoc = MonHocOption.SelectedItem.ToString();              
                List<History> historyTests = examModify.GetHistoryTestBySubject(id_User, monHoc);
                DisplayHistoryTests(historyTests);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH(id_User);
            bXH.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(rjButton1, -1 / 2 * rjButton1.Width, rjButton1.Height);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InforUser inforUser = new InforUser(id_User);
            inforUser.ShowDialog();
            this.Close();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(id_User);
            changePassword.ShowDialog();
            this.Close();
        }
        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBai lamBai = new LamBai();
            lamBai.ShowDialog();
            this.Close();
        }

        private void MonHocOption_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
