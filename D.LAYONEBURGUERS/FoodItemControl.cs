using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.LAYONEBURGUERS
{
    public partial class FoodItemControl : UserControl
    {
        public string NomeProduto
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }

        }
        public string Descricao
        {
            get { return lblDescricao.Text; }
            set { lblDescricao.Text = value; }

        }
        public string Preco
        {
            get { return lblPreco.Text; }
            set { lblPreco.Text = value; }

        }
        public Image Imagem
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }

        }
        public PictureBoxSizeMode SizeModeImagem
        {
            get { return pictureBox1.SizeMode; }
            set { pictureBox1.SizeMode = value; }
        }

        public FoodItemControl()
        {
            InitializeComponent();


        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FoodItemControl_Load(object sender, EventArgs e)
        {

        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
