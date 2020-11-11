using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class TaiKhoan
    {
        private String tenTaiKhoan;
        private String matKhau;
        private String maNV;
        private int phanQuyen;

        public TaiKhoan()
        {
            this.tenTaiKhoan = "";
            this.matKhau = "";
            this.maNV = "";
            this.phanQuyen = -1;
        }
        public TaiKhoan(string tenTaiKhoan, string matKhau, int phanQuyen, string maNV)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.maNV = maNV;
            this.phanQuyen = phanQuyen;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
    }
}
