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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcCardapio = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodItemControl1 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl2 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl3 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl4 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl5 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl6 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl7 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl8 = new D.LAYONEBURGUERS.FoodItemControl();
            this.tbcCarrinho = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblVazio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 124);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 796);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcCardapio
            // 
            this.tbcCardapio.BackColor = System.Drawing.Color.Transparent;
            this.tbcCardapio.Controls.Add(this.flowLayoutPanel2);
            this.tbcCardapio.Location = new System.Drawing.Point(4, 25);
            this.tbcCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCardapio.Name = "tbcCardapio";
            this.tbcCardapio.Padding = new System.Windows.Forms.Padding(4);
            this.tbcCardapio.Size = new System.Drawing.Size(612, 767);
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
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl7);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl8);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(578, 770);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // foodItemControl1
            // 
            this.foodItemControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl1.Descricao = "label1";
            this.foodItemControl1.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_21;
            this.foodItemControl1.Location = new System.Drawing.Point(11, 10);
            this.foodItemControl1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl1.Name = "foodItemControl1";
            this.foodItemControl1.NomeProduto = "label1";
            this.foodItemControl1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl1.Preco = "R$:40.00";
            this.foodItemControl1.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl1.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl1.TabIndex = 0;
            // 
            // foodItemControl2
            // 
            this.foodItemControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl2.Descricao = "label1";
            this.foodItemControl2.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_301;
            this.foodItemControl2.Location = new System.Drawing.Point(11, 184);
            this.foodItemControl2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl2.Name = "foodItemControl2";
            this.foodItemControl2.NomeProduto = "label1";
            this.foodItemControl2.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl2.Preco = "R$:40.00";
            this.foodItemControl2.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl2.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl2.TabIndex = 1;
            // 
            // foodItemControl3
            // 
            this.foodItemControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl3.Descricao = "label1";
            this.foodItemControl3.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22;
            this.foodItemControl3.Location = new System.Drawing.Point(11, 358);
            this.foodItemControl3.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl3.Name = "foodItemControl3";
            this.foodItemControl3.NomeProduto = "label1";
            this.foodItemControl3.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl3.Preco = "R$:40.00";
            this.foodItemControl3.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl3.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl3.TabIndex = 2;
            // 
            // foodItemControl4
            // 
            this.foodItemControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl4.Descricao = "label1";
            this.foodItemControl4.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__2_;
            this.foodItemControl4.Location = new System.Drawing.Point(11, 532);
            this.foodItemControl4.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl4.Name = "foodItemControl4";
            this.foodItemControl4.NomeProduto = "label1";
            this.foodItemControl4.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl4.Preco = "R$:40.00";
            this.foodItemControl4.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl4.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl4.TabIndex = 3;
            // 
            // foodItemControl5
            // 
            this.foodItemControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl5.Descricao = "label1";
            this.foodItemControl5.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__1_;
            this.foodItemControl5.Location = new System.Drawing.Point(11, 706);
            this.foodItemControl5.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl5.Name = "foodItemControl5";
            this.foodItemControl5.NomeProduto = "label1";
            this.foodItemControl5.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl5.Preco = "R$:40.00";
            this.foodItemControl5.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl5.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl5.TabIndex = 4;
            // 
            // foodItemControl6
            // 
            this.foodItemControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl6.Descricao = "label1";
            this.foodItemControl6.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.WhatsApp_Image_2026_03_17_at_20_30_22__3_;
            this.foodItemControl6.Location = new System.Drawing.Point(11, 880);
            this.foodItemControl6.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl6.Name = "foodItemControl6";
            this.foodItemControl6.NomeProduto = "label1";
            this.foodItemControl6.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl6.Preco = "R$:40.00";
            this.foodItemControl6.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl6.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl6.TabIndex = 5;
            // 
            // foodItemControl7
            // 
            this.foodItemControl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl7.Descricao = "label1";
            this.foodItemControl7.Imagem = null;
            this.foodItemControl7.Location = new System.Drawing.Point(11, 1054);
            this.foodItemControl7.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl7.Name = "foodItemControl7";
            this.foodItemControl7.NomeProduto = "label1";
            this.foodItemControl7.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl7.Preco = "R$:40.00";
            this.foodItemControl7.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl7.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl7.TabIndex = 6;
            // 
            // foodItemControl8
            // 
            this.foodItemControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl8.Descricao = "label1";
            this.foodItemControl8.Imagem = null;
            this.foodItemControl8.Location = new System.Drawing.Point(11, 1228);
            this.foodItemControl8.Margin = new System.Windows.Forms.Padding(11, 10, 11, 54);
            this.foodItemControl8.Name = "foodItemControl8";
            this.foodItemControl8.NomeProduto = "label1";
            this.foodItemControl8.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.foodItemControl8.Preco = "R$:40.00";
            this.foodItemControl8.Size = new System.Drawing.Size(588, 110);
            this.foodItemControl8.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.foodItemControl8.TabIndex = 7;
            // 
            // tbcCarrinho
            // 
            this.tbcCarrinho.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16;
            this.tbcCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCarrinho.Controls.Add(this.panel1);
            this.tbcCarrinho.Controls.Add(this.flowLayoutPanel3);
            this.tbcCarrinho.Location = new System.Drawing.Point(4, 25);
            this.tbcCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCarrinho.Name = "tbcCarrinho";
            this.tbcCarrinho.Padding = new System.Windows.Forms.Padding(7, 0, 7, 68);
            this.tbcCarrinho.Size = new System.Drawing.Size(612, 767);
            this.tbcCarrinho.TabIndex = 0;
            this.tbcCarrinho.Text = "Carrinho";
            this.tbcCarrinho.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblPrecoTotal);
            this.panel1.Controls.Add(this.lblVazio);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 597);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 102);
            this.panel1.TabIndex = 1;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.BackColor = System.Drawing.Color.White;
            this.lblPrecoTotal.Location = new System.Drawing.Point(523, 15);
            this.lblPrecoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(44, 16);
            this.lblPrecoTotal.TabIndex = 3;
            this.lblPrecoTotal.Text = "label1";
            this.lblPrecoTotal.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Location = new System.Drawing.Point(21, 15);
            this.lblVazio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(229, 16);
            this.lblVazio.TabIndex = 2;
            this.lblVazio.Text = "Nenhum item adicionado ao carrinho.";
            this.lblVazio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(598, 556);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.bANNER1;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(620, 119);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 846);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TabPage tbcCarrinho;
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
        private FoodItemControl foodItemControl7;
        private FoodItemControl foodItemControl8;
    }
}

