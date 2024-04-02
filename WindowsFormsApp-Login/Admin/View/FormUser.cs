using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc monHoc = new MonHoc();
            monHoc.ShowDialog();
            this.Close();
        }
    }
}
