using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class FormDeThi : Form
    {
        List<Exam> exams = new List<Exam>();
        List<Subject> subject = new List<Subject>();
        public FormDeThi()
        {
            InitializeComponent();
            ExamModify examModify = new ExamModify();
            subject = examModify.GetSubject("SELECT * FROM list_subject ");
            exams = examModify.GetExams("SELECT * FROM list_exam  ");
            ShowData();
            ShowSubject();
            
            
        }
        private void ShowData()
        {
            listEx_table.Rows.Clear();
            foreach (Exam ex in exams)
            {
                // Thêm một hàng mới vào CustomDataGridView với dữ liệu tương ứng
                listEx_table.Rows.Add(
                listEx_table.Rows.Count,
                ex.Id_exam,
                ex.Name_exam,
                ex.Exam_number,
                ex.Number_question,
                ex.Time
            );
            }
        }
        private void ShowSubject()
        {
            foreach (Subject subjects in subject)
            {
                cB_tende.Items.Add(subjects.NameExam);
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.ShowDialog();
            this.Close();
        }

        
        private int GetSelectedExamId()
        {
            int selectedRow = listEx_table.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                return Convert.ToInt32(listEx_table.Rows[selectedRow].Cells[1].Value);
            }
            else
            {
                return -1; 
            }
        }



        

        private void listEx_table_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Clicks == 2)
            {
                int id_ex = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["ID"].Value);
                string nameExam = (string)listEx_table.Rows[e.RowIndex].Cells["NameExam"].Value;
                int numberExam = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["NumberExam"].Value);
                int soCau = Convert.ToInt32(listEx_table.Rows[e.RowIndex].Cells["SoCau"].Value);
                this.Hide();
                EditQuestion editForm = new EditQuestion(id_ex, nameExam, numberExam, soCau);
                editForm.ShowDialog();
                this.Close();
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiem timKiem = new TimKiem();
            timKiem.ShowDialog();
            this.Close();
            
        }
        private void listEx_table_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) 
            {
                int rowIndex = listEx_table.HitTest(e.X, e.Y).RowIndex; 
                if (rowIndex >= 0) 
                {
                    DataGridViewRow row = listEx_table.Rows[rowIndex];

                    
                    int selectedId = Convert.ToInt32(row.Cells["ID"].Value);

                    
                    string query = "SELECT * FROM list_exam WHERE Id_Exam = " + selectedId;

                    
                    ExamModify examModify = new ExamModify();
                    List<Exam> selectedExamData = examModify.GetExams(query);

                    
                    if (selectedExamData.Count > 0)
                    { // Hiển thị thông tin của đề thi trong các điều khiển
                        cB_tende.Text = selectedExamData[0].Name_exam;
                        cB_socau.Text = selectedExamData[0].Number_question.ToString();
                        tB_deso.Text = selectedExamData[0].Exam_number.ToString();
                        cB_time.Text = selectedExamData[0].Time.ToString();
                    }
                }
            }
        }

        private void cB_tende_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cB_tende.SelectedItem.ToString();

            // Tìm kiếm trong danh sách đề thi với tên được chọn
            var matchingExams = exams.Where(ex => ex.Name_exam == selectedName).ToList();

            // Lấy số đề của đề thi được chọn
            int numberExam = matchingExams.Count + 1;

            // Hiển thị số đề lên textBox
            tB_deso.Text = numberExam.ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            FormDeThi fm = new FormDeThi();
            fm.ShowDialog();
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string selectedName = cB_tende.SelectedItem.ToString();
            string numberExamText = tB_deso.Text;
            if (string.IsNullOrEmpty(selectedName) || string.IsNullOrEmpty(numberExamText))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đề thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển đổi numberExamText sang số nguyên
            int number;
            if (!int.TryParse(numberExamText, out number))
            {
                MessageBox.Show("Số bài kiểm tra không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (Exam exm in exams)
            {
                if (exm.Name_exam.Equals(selectedName) && exm.Exam_number == number)
                {
                    MessageBox.Show("Đề thi với mã đề đã tồn tại trong " + selectedName + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int soCau = int.Parse(cB_socau.SelectedItem.ToString());
            int thoiGian = int.Parse(cB_time.SelectedItem.ToString());


            Exam ex = new Exam(selectedName, number, soCau, thoiGian);


            ExamModify examModify = new ExamModify();


            string querry = "SELECT * FROM list_exam ";
            ExamModify.InsertExam(ex);
            exams = examModify.GetExams(querry);
            int id_ex = exams[exams.Count - 1].Id_exam;
            this.Hide();
            AddQuestion addo = new AddQuestion(id_ex, selectedName, number, soCau);
            addo.ShowDialog();
            this.Close();
            ShowData();
        }


        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int examIdToDelete = GetSelectedExamId();
            string querry = "SELECT * FROM list_exam  ";
            ExamModify examModify = new ExamModify();
            if (examIdToDelete != -1)
            {
                DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa kỳ thi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    ExamModify.Delete(examIdToDelete);
                    ExamModify.DeleteQuestion(examIdToDelete);
                    exams = examModify.GetExams(querry);
                    listEx_table.Rows.Clear();
                    ShowData();
                    listEx_table.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn kỳ thi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeThi formDeThi = new FormDeThi();
            formDeThi.ShowDialog();
            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc monHoc = new MonHoc();
            monHoc.ShowDialog();
            this.Close();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rjCircularBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

