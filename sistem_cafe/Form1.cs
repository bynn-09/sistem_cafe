using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistem_cafe  // GANTI ini sesuai nama project lu!
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Subscribe ke event Cart
            Cart.CartChanged += new EventHandler(this.Cart_CartChanged);

            // Load menu
            LoadMenuItems();

            // Update button pertama kali
            UpdateCartButton();

            // Wire up button click
            this.btnLihatKeranjang.Click += new EventHandler(this.btnLihatKeranjang_Click);
        }

        private void LoadMenuItems()
        {
            // Data menu (hard-code dulu)
            var menus = new[]
            {
                new { Id = 1, Name = "Nasi Goreng", harga = 25000.0, ImagePath = "nasigoreng.jpg" },
                new { Id = 2, Name = "Mie Ayam",     harga = 20000.0, ImagePath = "mieayam.jpg" },
                new { Id = 3, Name = "Bakso",        harga = 18000.0, ImagePath = "bakso.jpg" },
                new { Id = 4, Name = "Sate Ayam",    harga = 30000.0, ImagePath = "sate.jpg" },
                new { Id = 5, Name = "Es Teh",       harga = 5000.0,  ImagePath = "esteh.jpg" },
                new { Id = 6, Name = "Jus Jeruk",    harga = 10000.0, ImagePath = "jus.jpg" }
            };

            // Setup FlowLayoutPanel
            flowPanel.AutoScroll = true;
            flowPanel.WrapContents = true;

            // Loop tiap menu
            foreach (var menu in menus)
            {
                // Bikin MenuItemControl baru
                MenuItemControl menuItem = new MenuItemControl();

                // Set data
                menuItem.IdMenu = menu.Id;
                menuItem.namaMenu = menu.Name;
                menuItem.hargaMenu = menu.harga;
                menuItem.gambarMenu = LoadImage(menu.ImagePath);

                // Subscribe event
                menuItem.PesanClicked += new EventHandler(this.MenuItem_OrderClicked);

                // Tambahin ke panel
                flowPanel.Controls.Add(menuItem);
            }
        }

        private void MenuItem_OrderClicked(object sender, EventArgs e)
        {
            MenuItemControl menuItem = sender as MenuItemControl;

            if (menuItem != null)
            {
                // Tambahin ke cart
                Cart.AddItem(menuItem.IdMenu, menuItem.namaMenu, menuItem.hargaMenu);

                // Kasih feedback
                MessageBox.Show(
                    menuItem.namaMenu + " berhasil ditambahkan ke keranjang!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Cart_CartChanged(object sender, EventArgs e)
        {
            UpdateCartButton();
        }

        private void UpdateCartButton()
        {
            int itemCount = Cart.GetItemCount();
            btnLihatKeranjang.Text = "Lihat Keranjang (" + itemCount.ToString() + ")";
        }

        private void btnLihatKeranjang_Click(object sender, EventArgs e)
        {
            KonfirmasiPesanan formKonfirmasi = new KonfirmasiPesanan();
            formKonfirmasi.ShowDialog();
        }

        private Image LoadImage(string filename)
        {
            try
            {
                string path = Application.StartupPath + "\\Images\\" + filename;
                return Image.FromFile(path);
            }
            catch
            {
                return null;
            }
        }
    }
}