using System;
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

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class AddQuestion : Form
    {
        List<Question> dataList = new List<Question>();
        int pos = 0;
        int id_exam;
        string nameExam;
        int numberExam;
        int soCau;
        public AddQuestion(int x, string s, int a, int b)
        {
            InitializeComponent();  
            id_exam = x;
            nameExam = s;
            soCau = b;
            numberExam = a;
            tenMon.Text = ("Môn học: " + nameExam);
            tenDe.Text = ("Đề số: " + a);
            cauHoi.Text = ("Câu số: " + (pos + 1));
            for (int i = 0; i < soCau; i++)
            {
                Question q = new Question();
                q.Status = i;
                dataList.Add(q);
            }
            View();

        }
        public void View()
        {
            cauHoi.Text = "Câu hỏi " + (pos + 1);
            if (dataList[pos].Status == 0)
            {
                question.Text = "";
                answerA.Text = "";
                answerB.Text = "";
                answerC.Text = "";
                answerD.Text = "";
                answerCorrect.SelectedItem = null;
            }
            else
            {
                question.Text = dataList[pos].Question1;
                answerA.Text = dataList[pos].AnswerA;
                answerB.Text = dataList[pos].AnswerB;
                answerC.Text = dataList[pos].AnswerC;
                answerD.Text = dataList[pos].AnswerD;
                answerCorrect.SelectedItem = dataList[pos].Answer.ToString();
            }
            Luu.Visible = (pos == soCau - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }





        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(question.Text)
                && !string.IsNullOrEmpty(answerA.Text)
                && !string.IsNullOrEmpty(answerB.Text)
                && !string.IsNullOrEmpty(answerC.Text)
                && !string.IsNullOrEmpty(answerD.Text)
                && answerCorrect.SelectedItem != null
                && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
            {
                string selectedAnswer = answerCorrect.SelectedItem.ToString();
                int answerValue;

                switch (selectedAnswer)
                {
                    case "A":
                        answerValue = 1;
                        break;
                    case "B":
                        answerValue = 2;
                        break;
                    case "C":
                        answerValue = 3;
                        break;
                    case "D":
                        answerValue = 4;
                        break;
                    default:
                        answerValue = 0;
                        break;
                }

                if (answerValue != 0)
                {
                    Question q = new Question(
                        id_exam,
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );
                    dataList[pos] = q;
                    if (pos + 1 < soCau)
                    {
                        pos++;
                        View();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chuyển sang câu hỏi tiếp theo. Hãy lưu câu hỏi nếu bạn đã nhập đủ câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị đúng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô trên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            if (pos - 1 >= 0)
            {
                if (!string.IsNullOrEmpty(question.Text)
                    && !string.IsNullOrEmpty(answerA.Text)
                    && !string.IsNullOrEmpty(answerB.Text)
                    && !string.IsNullOrEmpty(answerC.Text)
                    && !string.IsNullOrEmpty(answerD.Text)
                    && answerCorrect.SelectedItem != null
                    && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
                {
                    string selectedAnswer = answerCorrect.SelectedItem.ToString();
                    int answerValue = 0;

                    switch (selectedAnswer)
                    {
                        case "A":
                            answerValue = 1;
                            break;
                        case "B":
                            answerValue = 2;
                            break;
                        case "C":
                            answerValue = 3;
                            break;
                        case "D":
                            answerValue = 4;
                            break;
                        default:

                            MessageBox.Show("Giá trị đúng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    Question q = new Question(
                        id_exam,
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );

                    dataList[pos] = q;
                }

                pos--;
                View();
            }
        }

        private void Luu_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(question.Text)
                 && !string.IsNullOrEmpty(answerA.Text)
                 && !string.IsNullOrEmpty(answerB.Text)
                 && !string.IsNullOrEmpty(answerC.Text)
                 && !string.IsNullOrEmpty(answerD.Text)
                 && answerCorrect.SelectedItem != null
                 && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
            {
                string selectedAnswer = answerCorrect.SelectedItem.ToString();
                int answerValue;

                switch (selectedAnswer)
                {
                    case "A":
                        answerValue = 1;
                        break;
                    case "B":
                        answerValue = 2;
                        break;
                    case "C":
                        answerValue = 3;
                        break;
                    case "D":
                        answerValue = 4;
                        break;
                    default:
                        answerValue = 0;
                        break;
                }

                if (answerValue != 0)
                {
                    Question q = new Question(
                        id_exam,
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );
                    dataList[pos] = q;
                    foreach (Question c in dataList)
                    {
                        ExamModify.InsertQuestion(c);
                    }
                    MessageBox.Show("Thêm câu hỏi vào đề thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeThi fm = new FormDeThi();
            fm.ShowDialog();
            this.Close();
        }
    }
}
