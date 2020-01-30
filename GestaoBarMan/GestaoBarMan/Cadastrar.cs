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
using MySql.Data.Common;
using System.Configuration;


namespace GestaoBarMan
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void VoltarCadastro_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();

        }

        private void SalvarCadastro_Click(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.NomeFuncionario = NomeFuncionarioCadastro.Text;
            func.LoginFuncionario = LoginCadastro.Text;
            func.Senha = SenhaCadastro.Text;
            func.UsuarioMaster = CheckboxCadastrar.Checked;
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);
            string Query = String.Format("INSERT INTO FUNCIONARIOS VALUES ('{0}','{1}','{2}',{3})", func.NomeFuncionario, func.LoginFuncionario, func.Senha, func.UsuarioMaster);
            MySqlCommand cmd = new MySqlCommand(Query, conexao);
            conexao.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuário " + func.NomeFuncionario + " inserido com sucesso");
            
        }

        private void CheckboxCadastrar_CheckedChanged(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.UsuarioMaster = CheckboxCadastrar.Checked;
        }
    }
}
