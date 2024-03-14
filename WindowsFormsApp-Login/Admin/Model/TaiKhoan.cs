using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login
{
    class TaiKhoan
    {
        private string tenTk;
        private string matKhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTk, string matKhau)
        {
            this.tenTk = tenTk;
            this.matKhau = matKhau;
        }

        public string TenTk { get => tenTk; set => tenTk = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }

}
