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

        public Obj_HangHoa(string maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan)
        {
            MaHang1 = maHang;
            TenHang1 = tenHang;
            SoLuong1 = soLuong;
            DonGiaNhap1 = donGiaNhap;
            DonGiaBan1 = donGiaBan;
        }

        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public float DonGiaBan1 { get => DonGiaBan; set => DonGiaBan = value; }
    }
}
