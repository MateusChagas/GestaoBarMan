using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

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

            if (String.IsNullOrEmpty(func.LoginFuncionario) || (String.IsNullOrEmpty(func.Senha)))
            {
                MessageBox.Show("É necessário informar usuário e senha!");
            }  
                   
            MySqlConnection conexao = new MySqlConnection(ConfigurationSettings.AppSettings["conexao"]);
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = "SELECT * FROM FUNCIONARIOS WHERE LOGINFUNC = " + func.LoginFuncionario + "";
            conexao.Open();
            cmd.CommandType = CommandType.Text;        
                      
            {
                MessageBox.Show("O Usuário " + func.LoginFuncionario + " não foi localizado ");
            }
            conexao.Close();
        }

    }
}
