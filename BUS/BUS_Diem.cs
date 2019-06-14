using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS {
    public class BUS_Diem {
        DAL_Diem diem = new DAL_Diem();
        public void Insert(Diem d) {
            diem.Insert(d);
        }
        public void Update(Diem d) {
            diem.Update(d);
        }
        public void Delete(Diem d) {
            diem.Delete(d);
        }
        public DataTable Load2(string sql) {
            return diem.Load1(sql);
        }
    }
}
