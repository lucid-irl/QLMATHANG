using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMATHANG
{
    class Item
    {
        public String MAHANG { set; get; }
        public String TENHANG { set; get; }
        public DateTime NGAYNHAP { set; get; }
        public Int64 SOLUONG { set; get; }
        public String MANCC { set; get; }
        public Item(String MAHANG, String TENHANG, DateTime NGAYNHAP, Int64 SOLUONG, String MANCC)
        {
            this.MAHANG = MAHANG;
            this.TENHANG = TENHANG;
            this.NGAYNHAP = NGAYNHAP;
            this.SOLUONG = SOLUONG;
            this.MANCC = MANCC;
        }
    }
}
