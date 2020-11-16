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
        private int trangThai;
        private int phanQuyen;

        public TaiKhoan(string tenTaiKhoan, string matKhau, int trangThai, int phanQuyen)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.trangThai = trangThai;
            this.phanQuyen = phanQuyen;
        }

        public TaiKhoan()
        {
            this.tenTaiKhoan = "";
            this.matKhau = "";
            this.trangThai = 0;
            this.phanQuyen = 0;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
    }
}
