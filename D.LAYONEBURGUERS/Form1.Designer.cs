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
            this.tbcCarrinho = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbcCardapio = new System.Windows.Forms.TabPage();
            this.foodItemControl6 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl5 = new D.LAYONEBURGUERS.FoodItemControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodItemControl4 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl3 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl1 = new D.LAYONEBURGUERS.FoodItemControl();
            this.foodItemControl2 = new D.LAYONEBURGUERS.FoodItemControl();
            this.tabControl1.SuspendLayout();
            this.tbcCardapio.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            // tbcCarrinho
            // 
            this.tbcCarrinho.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16;
            this.tbcCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCarrinho.Location = new System.Drawing.Point(4, 25);
            this.tbcCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCarrinho.Name = "tbcCarrinho";
            this.tbcCarrinho.Padding = new System.Windows.Forms.Padding(4);
            this.tbcCarrinho.Size = new System.Drawing.Size(612, 767);
            this.tbcCarrinho.TabIndex = 0;
            this.tbcCarrinho.Text = "Carrinho";
            this.tbcCarrinho.UseVisualStyleBackColor = true;
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
            // tbcCardapio
            // 
            this.tbcCardapio.BackgroundImage = global::D.LAYONEBURGUERS.Properties.Resources.ChatGPT_Image_16_de_mar__de_2026__10_45_16;
            this.tbcCardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbcCardapio.Controls.Add(this.flowLayoutPanel2);
            this.tbcCardapio.Location = new System.Drawing.Point(4, 25);
            this.tbcCardapio.Margin = new System.Windows.Forms.Padding(4);
            this.tbcCardapio.Name = "tbcCardapio";
            this.tbcCardapio.Padding = new System.Windows.Forms.Padding(4);
            this.tbcCardapio.Size = new System.Drawing.Size(612, 767);
            this.tbcCardapio.TabIndex = 1;
            this.tbcCardapio.Text = "Cardápio";
            this.tbcCardapio.UseVisualStyleBackColor = true;
            this.tbcCardapio.Click += new System.EventHandler(this.tbcCardapio_Click);
            // 
            // foodItemControl6
            // 
            this.foodItemControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl6.Descricao = "label1";
            this.foodItemControl6.Imagem = null;
            this.foodItemControl6.Location = new System.Drawing.Point(10, 1330);
            this.foodItemControl6.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl6.Name = "foodItemControl6";
            this.foodItemControl6.NomeProduto = "label1";
            this.foodItemControl6.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl6.Preco = "R$:40.00";
            this.foodItemControl6.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl6.TabIndex = 5;
            // 
            // foodItemControl5
            // 
            this.foodItemControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl5.Descricao = "label1";
            this.foodItemControl5.Imagem = null;
            this.foodItemControl5.Location = new System.Drawing.Point(10, 1066);
            this.foodItemControl5.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl5.Name = "foodItemControl5";
            this.foodItemControl5.NomeProduto = "label1";
            this.foodItemControl5.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl5.Preco = "R$:40.00";
            this.foodItemControl5.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl5.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl1);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl2);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl3);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl4);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl5);
            this.flowLayoutPanel2.Controls.Add(this.foodItemControl6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 509);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // foodItemControl4
            // 
            this.foodItemControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl4.Descricao = "label1";
            this.foodItemControl4.Imagem = null;
            this.foodItemControl4.Location = new System.Drawing.Point(10, 802);
            this.foodItemControl4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl4.Name = "foodItemControl4";
            this.foodItemControl4.NomeProduto = "label1";
            this.foodItemControl4.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl4.Preco = "R$:40.00";
            this.foodItemControl4.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl4.TabIndex = 3;
            // 
            // foodItemControl3
            // 
            this.foodItemControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl3.Descricao = "label1";
            this.foodItemControl3.Imagem = null;
            this.foodItemControl3.Location = new System.Drawing.Point(10, 538);
            this.foodItemControl3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl3.Name = "foodItemControl3";
            this.foodItemControl3.NomeProduto = "label1";
            this.foodItemControl3.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl3.Preco = "R$:40.00";
            this.foodItemControl3.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl3.TabIndex = 2;
            // 
            // foodItemControl1
            // 
            this.foodItemControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl1.Descricao = "Pão brioche, hambúrguer artesanal 150g, queijo cheddar, alface, tomate, molho esp" +
    "ecial da casa, maionese.";
            this.foodItemControl1.Imagem = null;
            this.foodItemControl1.Location = new System.Drawing.Point(10, 10);
            this.foodItemControl1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl1.Name = "foodItemControl1";
            this.foodItemControl1.NomeProduto = "Don Layone Clássico";
            this.foodItemControl1.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl1.Preco = "R$:34.50";
            this.foodItemControl1.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl1.TabIndex = 0;
            // 
            // foodItemControl2
            // 
            this.foodItemControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl2.Descricao = "Pão brioche tostado, hambúrguer artesanal 180g, cheddar duplo, bacon crocante, ce" +
    "bola caramelizada.";
            this.foodItemControl2.Imagem = null;
            this.foodItemControl2.Location = new System.Drawing.Point(10, 274);
            this.foodItemControl2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 127);
            this.foodItemControl2.Name = "foodItemControl2";
            this.foodItemControl2.NomeProduto = "label1";
            this.foodItemControl2.Padding = new System.Windows.Forms.Padding(10);
            this.foodItemControl2.Preco = "R$:40.00";
            this.foodItemControl2.Size = new System.Drawing.Size(588, 127);
            this.foodItemControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 922);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcCardapio.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcCarrinho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tbcCardapio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FoodItemControl foodItemControl1;
        private FoodItemControl foodItemControl2;
        private FoodItemControl foodItemControl3;
        private FoodItemControl foodItemControl4;
        private FoodItemControl foodItemControl5;
        private FoodItemControl foodItemControl6;
    }
}

