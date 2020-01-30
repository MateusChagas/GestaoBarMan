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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
           
        }

        public RedefinirSenha(string texto)
        {
            InitializeComponent();
            LoginRedefinir.Text = texto;
        }
        private void senharedefinir_TextChanged(object sender, EventArgs e)
        {
                         
            
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
                        
            Funcionarios func = new Funcionarios();
            func.LoginFuncionario = LoginRedefinir.Text;
            func.Senha = NovaSenha.Text;

            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conexao.Open();
            cmd.CommandText = ("UPDATE FUNCIONARIOS SET SENHAFUNC = '"+func.Senha +"' WHERE LOGINFUNC = '"+func.LoginFuncionario +"' ");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Senha do funcionário " + func.LoginFuncionario + " alterada ");
            conexao.Close();

        }

        private void Rvoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
        }
    }
}
