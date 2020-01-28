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
<<<<<<< HEAD
            func.Senha = Senha.Text;            
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);                       
            string Query = "SELECT * FROM FUNCIONARIOS WHERE LOGINFUNC = " + func.LoginFuncionario + "";
            MySqlCommand cmd = new MySqlCommand(Query, conexao);
            cmd.CommandType = CommandType.Text;     
            conexao.Open();            
            string result = Query;
            conexao.Close();                        
            if (result == "")
=======
            func.Senha = Senha.Text;

            if (String.IsNullOrEmpty(func.LoginFuncionario) || (String.IsNullOrEmpty(func.Senha)))
            {
                MessageBox.Show("É necessário informar usuário e senha!");
            }  
                   
            MySqlConnection conexao = new MySqlConnection(ConfigurationSettings.AppSettings["conexao"]);
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = "SELECT * FROM FUNCIONARIOS WHERE LOGINFUNC = " + func.LoginFuncionario + "";
            conexao.Open();
            cmd.CommandType = CommandType.Text;        
                      
>>>>>>> 41ffbd73e67f8bd26f65dbc16e9134ea2500ed59
            {
                MessageBox.Show("O Usuário " + func.LoginFuncionario + " não foi localizado ");
            }
            conexao.Close();
        }

    }
}
