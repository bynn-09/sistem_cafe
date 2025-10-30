using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem_cafe
{
    public partial class MenuItemControl : UserControl
    {
        public event EventHandler PesanClicked;
        public MenuItemControl()
        {
            InitializeComponent();
            this.Size = new Size(224, 271);
            this.BorderStyle = BorderStyle.FixedSingle;

            btn_pesan.Click += btn_pesan_Click;
        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {
            PesanClicked?.Invoke(this, e);
        }

        public string namaMenu
        {
            get => l_nama_menu.Text;
            set => l_nama_menu.Text = value;
        }

        private double _hargaMenu;
        public double hargaMenu
        {
            get => _hargaMenu;
            set
            {
                _hargaMenu = value;
                l_harga.Text = string.Format("Rp {0:N0}", value);
            }
        }

        public Image gambarMenu
        {
            get => pb_gambar_menu.Image;
            set
            {
                pb_gambar_menu.Image = value;
                pb_gambar_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public int IdMenu { get; set; }
    }
}
