namespace D.LAYONEBURGUERS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcCardapio = new System.Windows.Forms.TabPage();
            this.tbcCarrinho = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tbcCardapio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcCardapio);
            this.tabControl1.Controls.Add(this.tbcCarrinho);
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 647);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcCardapio
            // 
            this.tbcCardapio.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16__4_;
            this.tbcCardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCardapio.Controls.Add(this.flowLayoutPanel2);
            this.tbcCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbcCardapio.Name = "tbcCardapio";
            this.tbcCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCardapio.Size = new System.Drawing.Size(457, 621);
            this.tbcCardapio.TabIndex = 1;
            this.tbcCardapio.Text = "Cardápio";
            this.tbcCardapio.UseVisualStyleBackColor = true;
            // 
            // tbcCarrinho
            // 
            this.tbcCarrinho.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16__4_;
            this.tbcCarrinho.Location = new System.Drawing.Point(4, 22);
            this.tbcCarrinho.Name = "tbcCarrinho";
            this.tbcCarrinho.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCarrinho.Size = new System.Drawing.Size(457, 621);
            this.tbcCarrinho.TabIndex = 0;
            this.tbcCarrinho.Text = "Carrinho";
            this.tbcCarrinho.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.bANNER1;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(465, 97);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(457, 82);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcCardapio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcCarrinho;
        private System.Windows.Forms.TabPage tbcCardapio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

