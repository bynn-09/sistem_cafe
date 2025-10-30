namespace sistem_cafe
{
    partial class MenuItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.l_harga = new System.Windows.Forms.Label();
            this.l_nama_menu = new System.Windows.Forms.Label();
            this.pb_gambar_menu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambar_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_pesan);
            this.panel1.Controls.Add(this.l_harga);
            this.panel1.Controls.Add(this.l_nama_menu);
            this.panel1.Controls.Add(this.pb_gambar_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 271);
            this.panel1.TabIndex = 1;
            // 
            // btn_pesan
            // 
            this.btn_pesan.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_pesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesan.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pesan.Location = new System.Drawing.Point(22, 216);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(180, 36);
            this.btn_pesan.TabIndex = 4;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = false;
            this.btn_pesan.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // l_harga
            // 
            this.l_harga.AutoSize = true;
            this.l_harga.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_harga.ForeColor = System.Drawing.Color.Green;
            this.l_harga.Location = new System.Drawing.Point(19, 185);
            this.l_harga.Name = "l_harga";
            this.l_harga.Size = new System.Drawing.Size(40, 17);
            this.l_harga.TabIndex = 3;
            this.l_harga.Text = "Rp 0";
            // 
            // l_nama_menu
            // 
            this.l_nama_menu.AutoSize = true;
            this.l_nama_menu.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nama_menu.Location = new System.Drawing.Point(18, 157);
            this.l_nama_menu.Name = "l_nama_menu";
            this.l_nama_menu.Size = new System.Drawing.Size(63, 19);
            this.l_nama_menu.TabIndex = 2;
            this.l_nama_menu.Text = "label1";
            // 
            // pb_gambar_menu
            // 
            this.pb_gambar_menu.Location = new System.Drawing.Point(22, 16);
            this.pb_gambar_menu.Name = "pb_gambar_menu";
            this.pb_gambar_menu.Size = new System.Drawing.Size(180, 120);
            this.pb_gambar_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gambar_menu.TabIndex = 1;
            this.pb_gambar_menu.TabStop = false;
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(224, 271);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambar_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_harga;
        private System.Windows.Forms.Label l_nama_menu;
        private System.Windows.Forms.PictureBox pb_gambar_menu;
        private System.Windows.Forms.Button btn_pesan;
    }
}
