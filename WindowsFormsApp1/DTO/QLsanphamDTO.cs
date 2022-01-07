using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class QLsanphamDTO
    {
        private string masp;
        private string tensp;
        private int gia;
        private string dvt;
        private string mannh;

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public string Mannh { get => mannh; set => mannh = value; }
    }
}
