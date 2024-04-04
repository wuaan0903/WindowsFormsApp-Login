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
    public partial class InforUser : Form
    {
        private int id_User;
        private ExamModify examModify;
        Modify modify = new Modify();
        public InforUser(int id_User)
        {
            InitializeComponent();
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string querry = "SELECT * FROM Users WHERE Id_User = '" + id_User + "'";
            taiKhoans = modify.TaiKhoans(querry);
            FullName.Text = taiKhoans[0].Fullname;


            this.examModify = new ExamModify();
            this.id_User = id_User;
            PopulateUserInfo(id_User);

        }

        private void PopulateUserInfo(int id_User)
        {
            List<TaiKhoan> userList = examModify.GetInforUsers(id_User);
            if (userList.Count > 0)
            {
                
                TaiKhoan user = userList[0];
                textBox1.Text = user.TenTk;
                textBox2.Text = user.Fullname;
                textBox3.Text = user.Email;
                textBox4.Text = user.Phone_number;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName, -1 / 2 * FullName.Width, FullName.Height);
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string fullname = textBox2.Text;
            string email = textBox3.Text;
            string phone_number = textBox4.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<TaiKhoan> updatedUsers = examModify.UpdateUserInfo(id_User, username, fullname, email, phone_number);

                if (updatedUsers != null && updatedUsers.Count > 0)
                {
                    TaiKhoan user = updatedUsers[0];
                    MessageBox.Show($"Thông tin của người dùng {user.TenTk} đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DisplayUserInfo()
        {
            List<TaiKhoan> users = examModify.GetInforUsers(id_User);
            if (users.Count > 0)
            {
                // Hiển thị thông tin của người dùng đầu tiên trong danh sách
                TaiKhoan user = users[0];
                textBox1.Text = user.TenTk;
                textBox2.Text = user.Fullname;
                textBox3.Text = user.Email;
                textBox4.Text = user.Phone_number;
            }
            else
            {
                MessageBox.Show("Không có thông tin người dùng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void rjButton2_Click(object sender, EventArgs e)
        {
            DisplayUserInfo();
        }
    }
}
