using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }
        List<Question> q = new List<Question>();
        int id_user;
        public FinalForm(int id,string kq,double tongdiem,int thoigian, List<Question> questions)
        {
            InitializeComponent();
            id_user = id;
            ketqua.Text = kq;
            tongDiem.Text = tongdiem.ToString();
            TimeSpan timeSpan = TimeSpan.FromSeconds(thoigian);
            thoiGian.Text = timeSpan.ToString(@"hh\:mm\:ss");
            q = questions;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewTest reviewTest = new ReviewTest(q,id_user);
            reviewTest.ShowDialog();
            this.Close();
        }
    }
}
