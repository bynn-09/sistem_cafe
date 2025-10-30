namespace sistem_cafe
{
    partial class KonfirmasiPesanan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewCart = new System.Windows.Forms.ListView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.l_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCart
            // 
            this.listViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(0, 0);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(800, 450);
            this.listViewCart.TabIndex = 0;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(371, 203);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "button1";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(400, 288);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 2;
            this.btnBatal.Text = "button1";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Location = new System.Drawing.Point(440, 368);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(35, 13);
            this.l_total.TabIndex = 3;
            this.l_total.Text = "label1";
            // 
            // KonfirmasiPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.listViewCart);
            this.Name = "KonfirmasiPesanan";
            this.Text = "KonfirmasiPesanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label l_total;
    }
}