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

namespace WindowsFormsApp_Login.User.View
{
    public partial class LamBai : Form
    {
        List<Question> questions = new List<Question>();
        Question question = new Question();
        int pos = 0;
        Label DeBaiTxt = new Label();
        int choice = 0;
        public LamBai()
        {
            
            InitializeComponent();
            

            // Thiết lập kích thước cho nhãn
            DeBaiTxt.Size = new Size(415, 60);
            DeBaiTxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DeBaiTxt.Text = "label";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel1.Controls.Add(DeBaiTxt);
            DeBaiTxt.Parent = panel1;
            DeBaiTxt.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;


            

            // Thiết lập kích thước cho nhãn
            DapAnATxt.Size = new Size(415, 60);
            DapAnATxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DapAnATxt.Text = "A";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel2.Controls.Add(DapAnATxt);
            DapAnATxt.Parent = panel2;
            DapAnATxt.BackColor = Color.Transparent;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnBTxt.Size = new Size(415, 60);
            DapAnBTxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DapAnBTxt.Text = "B";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel3.Controls.Add(DapAnBTxt);
            DapAnBTxt.Parent = panel3;
            DapAnBTxt.BackColor = Color.Transparent;
            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnCTxt.Size = new Size(415, 60);
            DapAnCTxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DapAnCTxt.Text = "C";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel4.Controls.Add(DapAnCTxt);
            DapAnCTxt.Parent = panel4;
            DapAnCTxt.BackColor = Color.Transparent;
            panel4.Parent = pictureBox1;
            panel4.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnDTxt.Size = new Size(415, 60);
            DapAnDTxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DapAnDTxt.Text = "D";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel5.Controls.Add(DapAnDTxt);
            DapAnDTxt.Parent = panel5;
            DapAnDTxt.BackColor = Color.Transparent;
            panel5.Parent = pictureBox1;
            panel5.BackColor = Color.Transparent;





            string querry = "SELECT * FROM Question WHERE Id_Exam=1 ";

            ExamModify examModify = new ExamModify();

            questions = examModify.Questions(querry);

            View();
        }
        public void View()
        {
            
            question = questions[pos];
            DeBaiTxt.Text = question.Question1;
            DapAnATxt.Text = "A. " + question.AnswerA;
            DapAnBTxt.Text = "B. " + question.AnswerB;
            DapAnCTxt.Text = "C. " + question.AnswerC;
            DapAnDTxt.Text = "D. " + question.AnswerD;
            choice = question.Status;
            switch (question.Status)
            {
                case 1:
                    DapAnATxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 2:
                    DapAnBTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 3:
                    DapAnCTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 4:
                    DapAnDTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
            }
            
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser();
            homeUser.ShowDialog();
            this.Close();
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            
            if (pos < questions.Count - 1)
            {
                questions[pos].Status = choice;
                pos++;
                DapAnATxt.BackColor = Color.Transparent;
                DapAnBTxt.BackColor = Color.Transparent;
                DapAnCTxt.BackColor = Color.Transparent;
                DapAnDTxt.BackColor = Color.Transparent;
                View();
                
            }
            else
            {
                MessageBox.Show("KO THE CHUYEN SANG CAU HOI TIEP THEO");
            }

        }
        public void OnOff(Boolean a, Boolean b, Boolean c, Boolean d)
        {
            DapAnATxt.BackColor= Color.Transparent;

        }
        private void RjButton4_Click(object sender, EventArgs e)
        {
            if (pos >0)
            {
                questions[pos].Status = choice;
                pos--;
                DapAnATxt.BackColor = Color.Transparent;
                DapAnBTxt.BackColor = Color.Transparent;
                DapAnCTxt.BackColor = Color.Transparent;
                DapAnDTxt.BackColor = Color.Transparent;
                View();
                
            }
            else
            {
                MessageBox.Show("KO THE CHUYEN SANG CAU HOI TIEP THEO");
            }
        }

        private void LamBai_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DapAnATxt_Click(object sender, EventArgs e)
        {
            DapAnATxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 1;
        }

        private void DapAnBTxt_Click(object sender, EventArgs e)
        {
            DapAnBTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnATxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 2;
        }

        private void DapAnDTxt_Click(object sender, EventArgs e)
        {
            DapAnDTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnATxt.BackColor = Color.Transparent;
            choice = 4;
        }

        private void DapAnCTxt_Click(object sender, EventArgs e)
        {
            DapAnCTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnATxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 3;
        }
    }
}
