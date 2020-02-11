using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GestaoBarMan
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            DataTable produtos = new DataTable();
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conexao.Open();
            cmd.CommandText = ("SELECT NomeProduto,ValorProduto FROM PRODUTOS");
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            produtos.Load(reader);
            Produtos.DataSource = produtos;
            Produtos.DisplayMember = "NomeProduto";
            Produtos.ValueMember = "ValorProduto";
            ValorItemVenda.Text = Convert.ToString(Produtos.SelectedValue);
            reader.Close();
            reader.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
            v.ValorItemVenda.Clear();
            v.TotalVenda.Clear();
            v.QtdItemVenda.Clear();
            v.ListaItemCompra.Clear();
            v.Produtos.Items.Clear();            
        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
