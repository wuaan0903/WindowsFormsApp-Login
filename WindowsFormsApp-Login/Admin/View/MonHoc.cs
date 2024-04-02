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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
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
    }
}
