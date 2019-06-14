using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc {
        string mat;
        string tent;
        string maloait;
        string mancc;
        string congdung;
        int soluong;
        DateTime hsd;
        string noisx;

        public string MaT { get => mat; set => mat = value; }
        public string TenT { get => tent; set => tent = value; }
        public string MaLoaiT { get => maloait; set => maloait = value; }
        public string MaNCC { get => mancc; set => mancc = value; }
        public string Congdung { get => congdung; set => congdung = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
        public DateTime HSD { get => hsd; set => hsd = value; }
        public string NoiSX { get => noisx; set => noisx = value; }

        public Thuoc() { }
        public Thuoc(string mat, string tent, string maloait, string mancc, string congdung, int soluong, DateTime hsd, string noisx) {
            this.MaT = mat;
            this.TenT = tent;
            this.MaLoaiT = maloait;
            this.Mancc = mancc;
            this.Congdung = congdung;
            this.SoLuong = soluong;
            this.HSD = hsd;
            this.NoiSX = noisx;
        }
    }
}
