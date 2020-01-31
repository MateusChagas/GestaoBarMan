using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GestaoBarMan
{
    public partial class CadastrodeProdutos : Form
    {
        public CadastrodeProdutos()
        {
            InitializeComponent();
        }

        private void VoltarCadastro_Click(object sender, EventArgs e)
        {
            SelecaoTarefa sf = new SelecaoTarefa();
            this.Close();
        }

        private void CadastarProduto_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();           
            p.NomeProduto = NomeProduto.Text;            
            p.ValorProduto = double.Parse(ValorProduto.Text);                       
            p.QtdEstoque = Convert.ToInt32(QtdEstoque.Text);                       
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conexao.Open();
            cmd.CommandText = ("INSERT INTO PRODUTOS (NomeProduto,ValorProduto,QTDEstoque) VALUES ('" + p.NomeProduto + "','" + p.ValorProduto + "','" + p.QtdEstoque + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Cadastro realizado com sucesso ");
            conexao.Close();
            NomeProduto.Clear();
            ValorProduto.Clear();
            QtdEstoque.Clear();
        }
    }
}
