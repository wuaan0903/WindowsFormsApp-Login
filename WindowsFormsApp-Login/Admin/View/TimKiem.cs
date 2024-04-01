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
    public partial class TimKiem : Form
    {
        List<Exam> exams = new List<Exam>();
        List<Subject> subject = new List<Subject>();
        public TimKiem()
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
                cB_searchEx.Items.Add(subjects.NameExam);
            }
        }

        private void cB_searchEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchName = cB_searchEx.Text;
            int numberExam = -1;
            ExamModify examModify = new ExamModify();
            List<Exam> exams = examModify.GetExams_Search(searchName, numberExam);

            listEx_table.Rows.Clear();
            foreach (Exam ex in exams)
            {
                // Thêm dữ liệu của đề thi vào DataGridView
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

        private void listEx_table_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeThi formDeThi = new FormDeThi();
            formDeThi.ShowDialog();
            this.Close();
        }
    }
}
