using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NV
    {
        private int luong, sDT;
        private string tenNV, ngaySinh, gioiTinh, taiKhoan, matKhau, maNV, quyenNV;
        public NV() { }
        public NV(DataRow row)
        {
            this.MaNV = row[0].ToString();
            this.TenNV = row[1].ToString();
            this.NgaySinh = row[2].ToString();
            this.GioiTinh = row[3].ToString();
            this.luong = (int)row[4];
            this.SDT = (int)row[5];
            this.TaiKhoan = row[6].ToString();
            this.matKhau = row[7].ToString();
            this.quyenNV = row[8].ToString();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public int Luong { get => luong; set => luong = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string QuyenNV { get => quyenNV; set => quyenNV = value; }
    }
}
