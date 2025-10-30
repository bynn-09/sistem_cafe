using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_cafe
{
    public static class Cart
    {
        // List buat nyimpen semua OrderMenu
        private static List<OrderMenu> items = new List<OrderMenu>();

        // Event buat kasih tau kalo cart berubah
        public static event EventHandler CartChanged;

        // Ambil semua item di cart
        public static List<OrderMenu> GetItems()
        {
            return items;
        }

        // Tambah item ke cart
        public static void AddItem(int idMenu, string menuName, double hargaMenu)
        {
            // Cek apakah item udah ada di cart
            var existingItem = items.FirstOrDefault(x => x.idMenu == idMenu);
            // FirstOrDefault = cari item pertama yang idMenu-nya sama
            // Kalo gak ketemu, return null

            if (existingItem != null)
            {
                // Kalo udah ada, tambah jumlahPesan aja
                existingItem.jumlahPesan++;
            }
            else
            {
                // Kalo belum ada, bikin item baru
                var newItem = new OrderMenu(idMenu, menuName, hargaMenu, 1);
                items.Add(newItem);
            }

            // Trigger event (kasih tau ada perubahan)
            CartChanged?.Invoke(null, EventArgs.Empty);
        }

        // Update jumlahPesanan item
        public static void UpdatejumlahPesanan(int idMenu, int newjumlahPesanan)
        {
            var item = items.FirstOrDefault(x => x.idMenu == idMenu);

            if (item != null)
            {
                if (newjumlahPesanan <= 0)
                {
                    // Kalo jumlahPesanan 0 atau minus, hapus item
                    items.Remove(item);
                }
                else
                {
                    // Update jumlahPesanan
                    item.jumlahPesan = newjumlahPesanan;
                }

                CartChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        // Hapus item dari cart
        public static void RemoveItem(int idMenu)
        {
            var item = items.FirstOrDefault(x => x.idMenu == idMenu);

            if (item != null)
            {
                items.Remove(item);
                CartChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        // Hitung total semua pesanan
        public static double GetTotal()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.TotalHarga;
            }
            return total;

            // Atau pake LINQ (lebih singkat):
            // return items.Sum(x => x.TotalhargaMenu);
        }

        // Kosongkan cart (setelah checkout)
        public static void Clear()
        {
            items.Clear();
            CartChanged?.Invoke(null, EventArgs.Empty);
        }

        // Hitung total item (jumlah jenis item, bukan jumlahPesan)
        public static int GetItemCount()
        {
            return items.Count;
        }
    }
}
