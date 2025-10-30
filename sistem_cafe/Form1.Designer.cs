namespace sistem_cafe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLihatKeranjang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanel.Location = new System.Drawing.Point(20, 95);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(767, 335);
            this.flowPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Cafe";
            // 
            // btnLihatKeranjang
            // 
            this.btnLihatKeranjang.BackColor = System.Drawing.Color.Transparent;
            this.btnLihatKeranjang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLihatKeranjang.BackgroundImage")));
            this.btnLihatKeranjang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLihatKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihatKeranjang.ForeColor = System.Drawing.Color.Transparent;
            this.btnLihatKeranjang.Location = new System.Drawing.Point(706, 6);
            this.btnLihatKeranjang.Name = "btnLihatKeranjang";
            this.btnLihatKeranjang.Size = new System.Drawing.Size(81, 63);
            this.btnLihatKeranjang.TabIndex = 2;
            this.btnLihatKeranjang.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btnLihatKeranjang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanel);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLihatKeranjang;
    }
}

