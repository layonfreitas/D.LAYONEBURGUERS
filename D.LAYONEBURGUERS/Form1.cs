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
    public partial class Form1 : Form
    {

        double precoitem1, precoitem2, precoitem3, precoitem4, precoitem5,precoitem6, precoTotal;
        
        

        
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tbcCarrinho);
            lblPrecoTotal.Text = "R$ 0.00";
           
            foodItemControl1.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem1, "lblItem1", "Layone Royale", foodItemControl1.numericUpDown1.Value, 37.00);
            };
            
            foodItemControl2.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem2, "lblItem2", "Layone Classic", foodItemControl2.numericUpDown1.Value, 36.00);
            };
            
            foodItemControl3.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem3, "lblItem3", "Don Layone", foodItemControl3.numericUpDown1.Value, 33.00);
            };
            
            foodItemControl4.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem4, "lblItem4", "American Way", foodItemControl4.numericUpDown1.Value, 36.00);
            };

            foodItemControl5.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem5, "lblItem5", "Layone Nature", foodItemControl5.numericUpDown1.Value, 40.00);
            }; 
            
            foodItemControl6.numericUpDown1.ValueChanged += (s, e) =>
            {
                GerenciarItemCarrinho(ref precoitem6, "lblItem6", "Coca Cola", foodItemControl6.numericUpDown1.Value, 6.00);
            };


        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbcCardapio_Click(object sender, EventArgs e)
        {

        }

        private void foodItemControl1_Load(object sender, EventArgs e)
        {

        }

        private void foodItemControl1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodItemControl6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void foodItemControl2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foodItemControl1.numericUpDown1.Value = 0;
            foodItemControl2.numericUpDown1.Value = 0;
            foodItemControl3.numericUpDown1.Value = 0;
            foodItemControl4.numericUpDown1.Value = 0;
            foodItemControl5.numericUpDown1.Value = 0;
            
        }

        private void foodItemControl1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodItemControl1_Load_3(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tbcCarrinho);
            tabControl1.TabPages.Remove(tbcCardapio);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tbcCardapio);
            tabControl1.TabPages.Remove(tbcCarrinho);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Controls.Count > 0)
            {
               
                if (MessageBox.Show("Tem certeza?", "Confirmar pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Close();
                }
            }


        }

        private void foodItemControl5_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AtualizaCarrinho()
        {
            if(flowLayoutPanel3.Controls.Count == 0)
            {
                lblVazio.Text = "Nenhum item adicionado ao carrinho.";
                btnConfirm.Enabled = false;
                btnCancel.Enabled = false;
              

            }

            else
            {
                lblVazio.Text = "Observações:";
                btnConfirm.Enabled = true;
                btnCancel.Enabled = true;

            }
            precoTotal = precoitem1 + precoitem2 + precoitem3 + precoitem4 + precoitem5 + precoitem6;
            lblPrecoTotal.Text = "R$ " + precoTotal.ToString("F2");

        }
        private void GerenciarItemCarrinho(ref double precoItem, string NomeLabel, string nomeproduto,decimal qtd,  double preco)
        {


            precoItem = Convert.ToDouble(qtd) * preco;
            Control umFoodItemControl = flowLayoutPanel3.Controls[NomeLabel];

            if (umFoodItemControl != null)
            {
                flowLayoutPanel3.Controls.Remove(umFoodItemControl);    

            }

            

            
            if (qtd>0){
                Label label = new Label();
                label.Text = $"{qtd}- {nomeproduto} R${precoItem}";
                label.Name = NomeLabel;
                label.AutoSize = true;
                label.ForeColor = Color.White;
                flowLayoutPanel3.Controls.Add(label);
            }
            

            AtualizaCarrinho();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}
