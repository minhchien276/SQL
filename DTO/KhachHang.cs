using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class KhachHang {
        string makh;
        string tenkh;
        int dt;
        string diachi;

        public string MaKH { get => makh; set => makh = value; }
        public string TenKH { get => tenkh; set => tenkh = value; }
        public int DienThoai { get => dt; set => dt = value; }
        public string DiaChi { get => diachi; set => diachi = value; }

        public KhachHang() { }
        public KhachHang(string makh, string tenkh, int dt, string diachi) {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.DienThoai = dt;
            this.DiaChi = diachi;
        }
    }
}
