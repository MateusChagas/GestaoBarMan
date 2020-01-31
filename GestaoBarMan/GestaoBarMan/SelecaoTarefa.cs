using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBarMan
{
    public partial class SelecaoTarefa : Form
    {
        public SelecaoTarefa()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();            
        }

        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastrodeProdutos cp = new CadastrodeProdutos();
            cp.ShowDialog();
        }

        private void IniciarVenda_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
            v.ShowDialog(); 
                      
        }
    }
}
