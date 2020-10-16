using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_CTHoaDonBan
    {
        private string SoHDB;
        private string MaHang;
        private int SoLuong;
        private float DonGia;
        private int GiamGia;
        private float ThanhTien;
        private string TenHang;

        public Obj_CTHoaDonBan(string soHDB, string maHang, int soLuong, float donGia, int giamGia, float thanhTien, string tenHang)
        {
            SoHDB1 = soHDB;
            MaHang1 = maHang;
            SoLuong1 = soLuong;
            DonGia1 = donGia;
            GiamGia1 = giamGia;
            ThanhTien1 = thanhTien;
            TenHang1 = tenHang;
        }

        public string SoHDB1 { get => SoHDB; set => SoHDB = value; }
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float DonGia1 { get => DonGia; set => DonGia = value; }
        public int GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
    }
}
