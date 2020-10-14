using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_HangHoa
    {
        private string MaHang;
        private string TenHang;
        private int SoLuong;
        private float DonGiaNhap;
        private float DonGiaBan;
        private string MaNhom;
        private string MaLoai;
        private string MaDonVi;
        private string MaChatLieu;
        private string MaNuocSX;
        private int ThoiGianBH;
        private string GhiChu;
        private byte[] Anh;

        public Obj_HangHoa(string maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string maNhom, string maLoai, string maDonVi, string maChatLieu, string maNuocSX, int thoiGianBH, string ghiChu, byte[] anh)
        {
            MaHang = maHang;
            TenHang = tenHang;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            MaNhom = maNhom;
            MaLoai = maLoai;
            MaDonVi = maDonVi;
            MaChatLieu = maChatLieu;
            MaNuocSX = maNuocSX;
            ThoiGianBH = thoiGianBH;
            GhiChu = ghiChu;
            Anh = anh;
        }

        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public float DonGiaBan1 { get => DonGiaBan; set => DonGiaBan = value; }
        public string MaNhom1 { get => MaNhom; set => MaNhom = value; }
        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string MaDonVi1 { get => MaDonVi; set => MaDonVi = value; }
        public string MaChatLieu1 { get => MaChatLieu; set => MaChatLieu = value; }
        public string MaNuocSX1 { get => MaNuocSX; set => MaNuocSX = value; }
        public int ThoiGianBH1 { get => ThoiGianBH; set => ThoiGianBH = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
        public byte[] Anh1 { get => Anh; set => Anh = value; }
    }
}
