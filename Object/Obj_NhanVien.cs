using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_NhanVien
    {
        private string MaNV;
        private string TenNV;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string DienThoai;
        private string DiaChi;
        private string MaCa;
        private string MaCV;

        public Obj_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string dienThoai, string diaChi, string maCa, string maCV)
        {
            MaNV1 = maNV;
            TenNV1 = tenNV;
            GioiTinh1 = gioiTinh;
            NgaySinh1 = ngaySinh;
            DienThoai1 = dienThoai;
            DiaChi1 = diaChi;
            MaCa1 = maCa;
            MaCV1 = maCV;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string MaCa1 { get => MaCa; set => MaCa = value; }
        public string MaCV1 { get => MaCV; set => MaCV = value; }
    }
}
