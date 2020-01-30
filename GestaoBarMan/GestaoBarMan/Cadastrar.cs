using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.AppSettings["conexao"]);            
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conexao.Open();
            cmd.CommandText = ("INSERT INTO FUNCIONARIOS (NomeFuncionario,LoginFunc,SenhaFunc,UsuarioMaster) VALUES ('" + NomeFuncionarioCadastro.Text + "','"+ LoginCadastro.Text + "','"+ SenhaCadastro.Text +"',"+ CheckboxCadastrar.Checked + ")");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuário " + func.NomeFuncionario + " inserido com sucesso");
            conexao.Close();
            
        }

        private void CheckboxCadastrar_CheckedChanged(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.UsuarioMaster = CheckboxCadastrar.Checked;
        }
    }
}
