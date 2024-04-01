using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Login.User.View
{
    public partial class BXH : Form
    {
        int id_user;
        public BXH(int id)
        {
            InitializeComponent();
            id_user = id;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH(id_user);
            bXH.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_user);
            ketQua.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_user);
            homeUser.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
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
            InforUser inforUser = new InforUser(id_user);
            inforUser.ShowDialog();
            this.Close();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(id_user);
            changePassword.ShowDialog();
            this.Close();
        }
        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close();
        }
    }
}
