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
            Form1 frm = new Form1();
            Funcionarios func = new Funcionarios();
            func.LoginFuncionario = Login.Text;            
            string Loginfunc = func.LoginFuncionario;
            func.Senha = Senha.Text;            
            if (String.IsNullOrEmpty(func.LoginFuncionario)||(String.IsNullOrEmpty(func.Senha)))
            {
                MessageBox.Show("É necessário informar o login e a senha");
            }
            
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            conexao.Open();
            MySqlDataReader reader;
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = (" SELECT* FROM FUNCIONARIOS WHERE LOGINFUNC = '"+ func.LoginFuncionario + "' AND SENHAFUNC = '"+ func.Senha +"'");         
            reader = cmd.ExecuteReader();
            Boolean result = reader.HasRows;
            if (result == false)
            {
                MessageBox.Show("O usuário " + func.LoginFuncionario + " não está cadastrado ou a senha não confere ");
                conexao.Close();
            }
            else
            {
                SelecaoTarefa st = new SelecaoTarefa();                
                st.ShowDialog();                
            }            
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();            
            cadastrar.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.LoginFuncionario = Login.Text;
            var UsuarioLogado = new RedefinirSenha(Login.Text);                                   
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            conexao.Open();
            MySqlDataReader reader;
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (" SELECT* FROM FUNCIONARIOS WHERE LOGINFUNC = '" + func.LoginFuncionario +"'");
            reader = cmd.ExecuteReader();
            Boolean result = reader.HasRows;
            if (result == false)
            {
                MessageBox.Show("O usuário " + func.LoginFuncionario + " não está cadastrado ");
                conexao.Close();
            }
        
            else if (func.LoginFuncionario == "")
            {
                MessageBox.Show("Informe o login que deseja redefinir a senha");
            }
            else
            {                
                UsuarioLogado.Show();
                
            }
            
        }
    }
}
