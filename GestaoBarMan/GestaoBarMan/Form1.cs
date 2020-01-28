using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GestaoBarMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.LoginFuncionario = Login.Text;
            func.Senha = Senha.Text;
            if (String.IsNullOrEmpty(func.LoginFuncionario)||(String.IsNullOrEmpty(func.Senha)))
            {
                MessageBox.Show("É necessário informar o login e a senha");

            }
            
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            string Query = ("SELECT * FROM FUNCIONARIOS WHERE LOGINFUNC = '" +func.LoginFuncionario + "'");
            MySqlCommand cmd = new MySqlCommand(Query, conexao);
            conexao.Open();
            MySqlDataReader reader;
            cmd.CommandType = CommandType.Text;            
            reader = cmd.ExecuteReader();
            Boolean result = reader.HasRows;
            if (result == false)
            {
                MessageBox.Show("O usuário "+ func.LoginFuncionario + " não foi encontrado ");
            }
            if("SENHA" != func.Senha)
            {
                MessageBox.Show("A senha não confere");
            }
                              
            conexao.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();            
            cadastrar.ShowDialog();
        }
    }
}
