using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sistem_cafe
{
    public partial class KonfirmasiPesanan : Form
    {
        public KonfirmasiPesanan()
        {
            InitializeComponent();

            // Setup ListView
            SetupListView();

            // Load cart
            LoadCart();

            // Subscribe ke event
            Cart.CartChanged += new EventHandler(this.Cart_CartChanged);

            // Wire up events
            this.listViewCart.DoubleClick += new EventHandler(this.listViewCart_DoubleClick);
            this.btnCheckout.Click += new EventHandler(this.btnCheckout_Click);
            this.btnBatal.Click += new EventHandler(this.btnBatal_Click);
        }

        private void SetupListView()
        {
            listViewCart.Columns.Add("Menu", 200);
            listViewCart.Columns.Add("Harga", 100);
            listViewCart.Columns.Add("Qty", 80);
            listViewCart.Columns.Add("Total", 120);
            listViewCart.Columns.Add("Aksi", 100);
        }

        private void LoadCart()
        {
            listViewCart.Items.Clear();

            List<OrderMenu> items = Cart.GetItems();

            foreach (OrderMenu item in items)
            {
                ListViewItem listItem = new ListViewItem(item.namaMenu);

                listItem.SubItems.Add("Rp " + item.hargaMenu.ToString("N0"));
                listItem.SubItems.Add(item.jumlahPesan.ToString());
                listItem.SubItems.Add("Rp " + item.TotalHarga.ToString("N0"));
                listItem.SubItems.Add("[Edit]");

                listItem.Tag = item.idMenu;

                listViewCart.Items.Add(listItem);
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            double total = Cart.GetTotal();
            l_total.Text = "Total: Rp " + total.ToString("N0");
        }

        private void Cart_CartChanged(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void listViewCart_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCart.SelectedItems[0];
                int idMenu = (int)selectedItem.Tag;

                ShowItemOptions(idMenu);
            }
        }

        private void ShowItemOptions(int idMenu)
        {
            OrderMenu item = null;
            foreach (OrderMenu i in Cart.GetItems())
            {
                if (i.idMenu == idMenu)
                {
                    item = i;
                    break;
                }
            }

            if (item == null) return;

            string message = item.namaMenu + "\nJumlah: " + item.jumlahPesan + "\n\n";
            message += "Yes = Tambah\nNo = Kurangi\nCancel = Hapus";

            DialogResult result = MessageBox.Show(
                message,
                "Edit Item",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Tambah jumlahPesan
                Cart.UpdatejumlahPesanan(idMenu, item.jumlahPesan + 1);
            }
            else if (result == DialogResult.No)
            {
                // Kurangi jumlahPesan
                Cart.UpdatejumlahPesanan(idMenu, item.jumlahPesan - 1);
            }
            else if (result == DialogResult.Cancel)
            {
                // Hapus item
                DialogResult confirmDelete = MessageBox.Show(
                    "Hapus item ini dari keranjang?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmDelete == DialogResult.Yes)
                {
                    Cart.RemoveItem(idMenu);
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Cart.GetItemCount() == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = Cart.GetTotal();
            string message = "Total pesanan: Rp " + total.ToString("N0") + "\n\nLanjutkan checkout?";

            DialogResult result = MessageBox.Show(
                message,
                "Konfirmasi Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Pesanan berhasil! Terima kasih.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Cart.Clear();
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Cart.CartChanged -= Cart_CartChanged;
            base.OnFormClosing(e);
        }
    }
}