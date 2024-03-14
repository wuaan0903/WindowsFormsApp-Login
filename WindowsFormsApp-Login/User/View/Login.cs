using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.View;

namespace WindowsFormsApp_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close ();
            
        }
        Modify modify = new Modify();

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string chucvu = chucvuBox.SelectedItem.ToString();
            string tk = taikhoantxt.Text;
            string pass = passTxt.Text;
            if (tk.Trim() == "")
            {
                MessageBox.Show("Nhập cmm tk vào nhanh !");
                return;
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("Nhập cmm pass vào nhanh !");
                return;
            }
            else
            {
                string querry = "SELECT * FROM Taikhoan WHERE TenTk = '" + tk + "' AND matkhau = '" + pass + "' AND chucvu ='" + chucvu + "' ";
                if (modify.TaiKhoans(querry).Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    this.Hide();
                    if (chucvu == "Admin")
                    {
                        HomeAdmin home = new HomeAdmin();
                        home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        HomeUser user = new HomeUser();
                        user.ShowDialog();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Tk hoặc mật khẩu ko đúng");
                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
