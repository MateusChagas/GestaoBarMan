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
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);                       
            string Query = "SELECT * FROM FUNCIONARIOS WHERE LOGINFUNC = " + func.LoginFuncionario + "";
            MySqlCommand cmd = new MySqlCommand(Query, conexao);
            cmd.CommandType = CommandType.Text;     
            conexao.Open();            
            string result = Query;
            conexao.Close();                        
            if (result == "")
            {
                MessageBox.Show("O Usuário "+ func.LoginFuncionario + " não foi localizado ");
            }
        }
    }
}
