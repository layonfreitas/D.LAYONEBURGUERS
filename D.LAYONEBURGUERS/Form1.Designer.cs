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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodItemControl1 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl2 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl3 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl4 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl5 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl6 = new D.LAYONEBURGUERS.FoodItemControl();
            this.tbcCarrinho = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblVazio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbcCardapio.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tbcCarrinho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcCardapio);
            this.tabControl1.Controls.Add(this.tbcCarrinho);
            this.tabControl1.Location = new System.Drawing.Point(0, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 632);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcCardapio
            // 
            this.tbcCardapio.BackColor = System.Drawing.Color.Transparent;
            this.tbcCardapio.Controls.Add(this.flowLayoutPanel2);
            this.tbcCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbcCardapio.Name = "tbcCardapio";
            this.tbcCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCardapio.Size = new System.Drawing.Size(480, 606);
            this.tbcCardapio.TabIndex = 1;
            this.tbcCardapio.Text = "Cardápio";
            this.tbcCardapio.Click += new System.EventHandler(this.tbcCardapio_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl1);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl2);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl3);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl4);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl5);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(459, 610);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // foodItemControl1
            // 
            this.foodItemControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl1.Descricao = "label1";
            this.foodItemControl1.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_21;
            this.foodItemControl1.Location = new System.Drawing.Point(4, 8);
            this.foodItemControl1.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl1.Name = "foodItemControl1";
            this.foodItemControl1.NomeProduto = "label1";
            this.foodItemControl1.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl1.Preco = "R$:40.00";
            this.foodItemControl1.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl1.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl1.TabIndex = 0;
            // 
            // foodItemControl2
            // 
            this.foodItemControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl2.Descricao = "label1";
            this.foodItemControl2.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_301;
            this.foodItemControl2.Location = new System.Drawing.Point(4, 149);
            this.foodItemControl2.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl2.Name = "foodItemControl2";
            this.foodItemControl2.NomeProduto = "label1";
            this.foodItemControl2.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl2.Preco = "R$:40.00";
            this.foodItemControl2.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl2.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl2.TabIndex = 1;
            // 
            // foodItemControl3
            // 
            this.foodItemControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl3.Descricao = "label1";
            this.foodItemControl3.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22;
            this.foodItemControl3.Location = new System.Drawing.Point(4, 290);
            this.foodItemControl3.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl3.Name = "foodItemControl3";
            this.foodItemControl3.NomeProduto = "label1";
            this.foodItemControl3.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl3.Preco = "R$:40.00";
            this.foodItemControl3.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl3.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl3.TabIndex = 2;
            // 
            // foodItemControl4
            // 
            this.foodItemControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl4.Descricao = "label1";
            this.foodItemControl4.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__2_;
            this.foodItemControl4.Location = new System.Drawing.Point(4, 431);
            this.foodItemControl4.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl4.Name = "foodItemControl4";
            this.foodItemControl4.NomeProduto = "label1";
            this.foodItemControl4.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl4.Preco = "R$:40.00";
            this.foodItemControl4.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl4.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl4.TabIndex = 3;
            // 
            // foodItemControl5
            // 
            this.foodItemControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl5.Descricao = "label1";
            this.foodItemControl5.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__1_;
            this.foodItemControl5.Location = new System.Drawing.Point(8, 572);
            this.foodItemControl5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 44);
            this.foodItemControl5.Name = "foodItemControl5";
            this.foodItemControl5.NomeProduto = "label1";
            this.foodItemControl5.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl5.Preco = "R$:40.00";
            this.foodItemControl5.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl5.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl5.TabIndex = 4;
            // 
            // foodItemControl6
            // 
            this.foodItemControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl6.Descricao = "label1";
            this.foodItemControl6.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__3_;
            this.foodItemControl6.Location = new System.Drawing.Point(8, 713);
            this.foodItemControl6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 44);
            this.foodItemControl6.Name = "foodItemControl6";
            this.foodItemControl6.NomeProduto = "label1";
            this.foodItemControl6.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl6.Preco = "R$:40.00";
            this.foodItemControl6.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl6.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl6.TabIndex = 5;
            // 
            // tbcCarrinho
            // 
            this.tbcCarrinho.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16;
            this.tbcCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCarrinho.Controls.Add(this.panel1);
            this.tbcCarrinho.Controls.Add(this.flowLayoutPanel3);
            this.tbcCarrinho.Location = new System.Drawing.Point(4, 22);
            this.tbcCarrinho.Name = "tbcCarrinho";
            this.tbcCarrinho.Padding = new System.Windows.Forms.Padding(0, 0, 5, 55);
            this.tbcCarrinho.Size = new System.Drawing.Size(480, 606);
            this.tbcCarrinho.TabIndex = 0;
            this.tbcCarrinho.Text = "Carrinho";
            this.tbcCarrinho.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblPrecoTotal);
            this.panel1.Controls.Add(this.lblVazio);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 83);
            this.panel1.TabIndex = 1;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.BackColor = System.Drawing.Color.White;
            this.lblPrecoTotal.Location = new System.Drawing.Point(392, 12);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoTotal.TabIndex = 3;
            this.lblPrecoTotal.Text = "label1";
            this.lblPrecoTotal.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Location = new System.Drawing.Point(16, 12);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(183, 13);
            this.lblVazio.TabIndex = 2;
            this.lblVazio.Text = "Nenhum item adicionado ao carrinho.";
            this.lblVazio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(475, 435);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 50);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Don Layone Smoke House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcCardapio.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tbcCarrinho.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tbcCardapio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrecoTotal;
        private FoodItemControl foodItemControl1;
        private FoodItemControl foodItemControl2;
        private FoodItemControl foodItemControl3;
        private FoodItemControl foodItemControl4;
        private FoodItemControl foodItemControl5;
        private FoodItemControl foodItemControl6;
        private System.Windows.Forms.TabPage tbcCarrinho;
        private System.Windows.Forms.TextBox textBox1;
    }
}

