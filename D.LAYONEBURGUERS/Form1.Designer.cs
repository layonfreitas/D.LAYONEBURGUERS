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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbcCarrinho = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEntre = new System.Windows.Forms.CheckBox();
            this.cbReti = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblVazio = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tbcCardapio.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcCarrinho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcCardapio);
            this.tabControl1.Controls.Add(this.tbcCarrinho);
            this.tabControl1.Location = new System.Drawing.Point(-6, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 664);
            this.tabControl1.TabIndex = 2;
            // 
            // tbcCardapio
            // 
            this.tbcCardapio.BackColor = System.Drawing.Color.Transparent;
            this.tbcCardapio.Controls.Add(this.flowLayoutPanel2);
            this.tbcCardapio.Controls.Add(this.panel3);
            this.tbcCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbcCardapio.Name = "tbcCardapio";
            this.tbcCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCardapio.Size = new System.Drawing.Size(494, 638);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(487, 350);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // foodItemControl1
            // 
            this.foodItemControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl1.Descricao = "Blend do D. Layone  de 170g, queijo mussarela, molho do D.Layone, farofa de bacon" +
    ", e pão brioche.";
            this.foodItemControl1.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.lr;
            this.foodItemControl1.Location = new System.Drawing.Point(4, 8);
            this.foodItemControl1.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl1.Name = "foodItemControl1";
            this.foodItemControl1.NomeProduto = "Layone Royale";
            this.foodItemControl1.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl1.Preco = "R$:37.00";
            this.foodItemControl1.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl1.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl1.TabIndex = 0;
            this.foodItemControl1.Load += new System.EventHandler(this.foodItemControl1_Load_3);
            // 
            // foodItemControl2
            // 
            this.foodItemControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl2.Descricao = "Blend do D. Layone de 180g, queijo mussarela, bacon, alface, tomate e pão brioche" +
    " selado na manteiga.";
            this.foodItemControl2.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.lc;
            this.foodItemControl2.Location = new System.Drawing.Point(4, 149);
            this.foodItemControl2.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl2.Name = "foodItemControl2";
            this.foodItemControl2.NomeProduto = "Layone Classic";
            this.foodItemControl2.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl2.Preco = "R$:36.00";
            this.foodItemControl2.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl2.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl2.TabIndex = 1;
            // 
            // foodItemControl3
            // 
            this.foodItemControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl3.Descricao = "Blend do D. Layone de 180g, queijo mussarela, farofa de bacon, chutney de manga e" +
    " pão brioche.";
            this.foodItemControl3.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.dl;
            this.foodItemControl3.Location = new System.Drawing.Point(4, 290);
            this.foodItemControl3.Margin = new System.Windows.Forms.Padding(4, 8, 0, 44);
            this.foodItemControl3.Name = "foodItemControl3";
            this.foodItemControl3.NomeProduto = "Don Layone";
            this.foodItemControl3.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl3.Preco = "R$:33.00";
            this.foodItemControl3.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl3.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl3.TabIndex = 2;
            // 
            // foodItemControl4
            // 
            this.foodItemControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl4.Descricao = "Blend do D. Layone de 180g, queijo mussarela, molho barbecue, bacon e alface no p" +
    "ão brioche.";
            this.foodItemControl4.Imagem = global::D.LAYONEBURGUERS.Properties.Resources.a;
            this.foodItemControl4.Location = new System.Drawing.Point(4, 431);
            this.foodItemControl4.Margin = new System.Windows.Forms.Padding(4, 8, 8, 44);
            this.foodItemControl4.Name = "foodItemControl4";
            this.foodItemControl4.NomeProduto = "American Way";
            this.foodItemControl4.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl4.Preco = "R$:36.00";
            this.foodItemControl4.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl4.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl4.TabIndex = 3;
            // 
            // foodItemControl5
            // 
            this.foodItemControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl5.Descricao = "Pão brioche, hambúrguer de plantas fazenda futuro, queijo cheddar, onion rings, a" +
    "lface e tomate.";
            this.foodItemControl5.Imagem = global::D.LAYONEBURGUERS.Properties.Resources._6c84348d90db0bf30c431408ad5ff6ec;
            this.foodItemControl5.Location = new System.Drawing.Point(8, 572);
            this.foodItemControl5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 44);
            this.foodItemControl5.Name = "foodItemControl5";
            this.foodItemControl5.NomeProduto = "Layone Nature";
            this.foodItemControl5.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl5.Preco = "R$:40.00";
            this.foodItemControl5.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl5.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl5.TabIndex = 4;
            // 
            // foodItemControl6
            // 
            this.foodItemControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.foodItemControl6.Descricao = "Coca Cola de 350ml";
            this.foodItemControl6.Imagem = global::D.LAYONEBURGUERS.Properties.Resources._7da3128ee79670fbc789ec68078ba489;
            this.foodItemControl6.Location = new System.Drawing.Point(8, 713);
            this.foodItemControl6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 44);
            this.foodItemControl6.Name = "foodItemControl6";
            this.foodItemControl6.NomeProduto = "Coca Cola ";
            this.foodItemControl6.Padding = new System.Windows.Forms.Padding(8);
            this.foodItemControl6.Preco = "R$:6.00";
            this.foodItemControl6.Size = new System.Drawing.Size(441, 89);
            this.foodItemControl6.SizeModeImagem = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodItemControl6.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Controls.Add(this.btnAddCarrinho);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-4, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 105);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.btnAddCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarrinho.Location = new System.Drawing.Point(331, 32);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(125, 23);
            this.btnAddCarrinho.TabIndex = 1;
            this.btnAddCarrinho.Text = "Adicionar ao carrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = false;
            this.btnAddCarrinho.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 6);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.tbcCarrinho.Size = new System.Drawing.Size(494, 638);
            this.tbcCarrinho.TabIndex = 0;
            this.tbcCarrinho.Text = "Carrinho";
            this.tbcCarrinho.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.cbEntre);
            this.panel1.Controls.Add(this.cbReti);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txbEndereco);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblPrecoTotal);
            this.panel1.Controls.Add(this.lblVazio);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 128);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbEntre
            // 
            this.cbEntre.AutoSize = true;
            this.cbEntre.Location = new System.Drawing.Point(9, 45);
            this.cbEntre.Name = "cbEntre";
            this.cbEntre.Size = new System.Drawing.Size(63, 17);
            this.cbEntre.TabIndex = 22;
            this.cbEntre.Text = "Entrega";
            this.cbEntre.UseVisualStyleBackColor = true;
            this.cbEntre.CheckedChanged += new System.EventHandler(this.cbEntre_CheckedChanged);
            // 
            // cbReti
            // 
            this.cbReti.AutoSize = true;
            this.cbReti.Location = new System.Drawing.Point(9, 19);
            this.cbReti.Name = "cbReti";
            this.cbReti.Size = new System.Drawing.Size(66, 17);
            this.cbReti.TabIndex = 21;
            this.cbReti.Text = "Retirada";
            this.cbReti.UseVisualStyleBackColor = true;
            this.cbReti.CheckedChanged += new System.EventHandler(this.cbReti_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(215, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(88, 19);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(105, 13);
            this.lblEndereco.TabIndex = 18;
            this.lblEndereco.Text = "Digite seu endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(90, 43);
            this.txbEndereco.Multiline = true;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(103, 17);
            this.txbEndereco.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 50);
            this.textBox1.TabIndex = 14;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.BackColor = System.Drawing.Color.White;
            this.lblPrecoTotal.Location = new System.Drawing.Point(46, 105);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(80, 13);
            this.lblPrecoTotal.TabIndex = 13;
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Location = new System.Drawing.Point(271, 11);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(183, 13);
            this.lblVazio.TabIndex = 12;
            this.lblVazio.Text = "Nenhum item adicionado ao carrinho.";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(296, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(377, 95);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(489, 293);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(455, 540);
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
            this.panel3.ResumeLayout(false);
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
        private FoodItemControl foodItemControl1;
        private FoodItemControl foodItemControl2;
        private FoodItemControl foodItemControl3;
        private FoodItemControl foodItemControl4;
        private FoodItemControl foodItemControl5;
        private FoodItemControl foodItemControl6;
        private System.Windows.Forms.TabPage tbcCarrinho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCarrinho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbEntre;
        private System.Windows.Forms.CheckBox cbReti;
    }
}

