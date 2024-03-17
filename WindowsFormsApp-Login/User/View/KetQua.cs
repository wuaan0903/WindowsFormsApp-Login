﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Login.User.View
{
    public partial class KetQua : Form
    {
        public KetQua()
        {
            InitializeComponent();
            string[] row = new string[] { "1", "1","9","5 phút 30 giây", "14/3/2024" }; // Dữ liệu cần thêm
            KetQuaTable.Rows.Add(row); // Thêm dữ liệu vào DataGridView
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua();
            ketQua.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBai lamBai = new LamBai();
            lamBai.ShowDialog();
            this.Close();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
            if (MonHocOption.SelectedIndex != -1)
            {
                string Monhoc = MonHocOption.SelectedItem.ToString();
                // ComboBox đã được chọn
                MessageBox.Show(Monhoc);
            }
            else
            {
                MessageBox.Show(MonHocOption.Texts);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH();
            bXH.ShowDialog();
            this.Close();
        }
    }
}