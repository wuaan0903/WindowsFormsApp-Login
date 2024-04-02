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
    public partial class BXH : Form
    {
        private int id_User;
        private ExamModify examModify;
        public BXH(int id_User)
        {
            InitializeComponent();
            this.id_User = id_User;
            this.examModify = new ExamModify();
            LoadRankingData();

        }


        private void LoadRankingData()
        {           
            ExamModify examModify = new ExamModify();           
            List<Ranking> rankings = examModify.GetRanking();

            if (rankings != null && rankings.Count > 0)
            {
                KetQuaTable.Rows.Clear();
                
                for(int i = 0; i < rankings.Count; i++)
                {
                    Ranking ranking = rankings[i];
                    string[] row = new string[]
                    {
                       (i+1).ToString(),    
                       ranking.Id_User.ToString(),
                       ranking.Fullname.ToString(),
                       ranking.Completed_Exams.ToString(),
                       ranking.Total_Points.ToString(),
                        
                };
                    KetQuaTable.Rows.Add(row);
                
                }      
            }
            else
            { 
                MessageBox.Show("Dữ liệu bị lỗi xin vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH(id_User);
            bXH.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBai lamBai = new LamBai();
            lamBai.ShowDialog();
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

        private void BXH_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = examModify.GetSubjectNames();


            foreach (Subject subject in subjects)
            {
                MonHocOption.Items.Add(subject.NameExam);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
            if (MonHocOption.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn môn học trước khi hiển thị xếp hạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedSubject = MonHocOption.SelectedItem.ToString();    
            List<Ranking> rankings = examModify.GetRankTestBySubject(selectedSubject);
            if (rankings != null && rankings.Count > 0)
            {
               
                KetQuaTable.Rows.Clear();

                
                for (int i = 0; i < rankings.Count; i++)
                {
                    Ranking ranking = rankings[i];
                    string[] row = new string[]
                    {
                (i+1).ToString(),
                ranking.Id_User.ToString(),
                ranking.Fullname.ToString(),
                ranking.Completed_Exams.ToString(),
                ranking.Total_Points.ToString(),
                    };
                    KetQuaTable.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu xếp hạng cho môn học đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
