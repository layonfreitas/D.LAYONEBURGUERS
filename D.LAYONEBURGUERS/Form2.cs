using D.LAYONEBURGUERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logindonlayone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if ((usuario == "Thiago123" && senha == "a7x1908050")|| (usuario == "layon" && senha == "layon") || (usuario == "caua" && senha == "caua")  )

            {
                Form1 novaTela = new Form1();
                novaTela.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("usuário ou senha incorretos");
            }
            if (usuario.Length > 10 && senha.Length > 10)
            {
                MessageBox.Show("o usuário e a senha só podem conter 10 caracteres");
                return;
            }


        }
    }
}
