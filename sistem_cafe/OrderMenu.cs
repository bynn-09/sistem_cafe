using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_cafe
{
    public class OrderMenu
    {
        public int idMenu { get; set; }
        public string namaMenu { get; set; }
        public double hargaMenu { get; set; }
        public int jumlahPesan { get; set; }

        public double TotalHarga
        {
            get => hargaMenu * jumlahPesan;
        }

        public OrderMenu(int idMenu, string namaMenu, double hargaMenu, int jumlahPesan)
        {
            this.idMenu = idMenu;
            this.namaMenu = namaMenu;
            this.hargaMenu = hargaMenu;
            this.jumlahPesan = jumlahPesan;
        }
    }
}
