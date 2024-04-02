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
    public partial class ChangePassword : Form
    {
        private int id_User;
        public ChangePassword(int id_User)
        {
            InitializeComponent();
            this.id_User = id_User;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(rjButton1, -1 / 2 * rjButton1.Width, rjButton1.Height);
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH(id_User);
            bXH.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBai lamBai = new LamBai();
            lamBai.ShowDialog();
            this.Close();
        }


        private bool VerifyOldPassword(int id_User, string oldPassword)
        {     
            ExamModify examModify = new ExamModify();   
            List<TaiKhoan> users = examModify.GetInforUsers(id_User);

            if (users.Count > 0)
            {           
                string currentPassword = users[0].MatKhau;
                return currentPassword == oldPassword;
            }
            else
            {  
                return false;
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            string oldPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmNewPassword = textBox3.Text;
            
            bool isOldPasswordCorrect = VerifyOldPassword(id_User, oldPassword);
            if (!isOldPasswordCorrect)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                return; 
            }

            
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!");
                return; 
            }

            
            ExamModify examModify = new ExamModify();
            bool success = examModify.ChangePassword(id_User, newPassword);

            if (success)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }
    }
}
