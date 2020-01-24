using System;
using System.Configuration;

public class Funcionario
{
    public string NomeFuncionarios { get; set; }

    public string LoginFuncionario { get; set; }

    public string Senha { get; set; }

    public bool UsuarioMaster { get; set; }
}

public class BuscaFuncionario
{
    string conexao = ConfigurationSettings.AppSettings["conexao"];

    string Sqlformat = "SELECT * FROM FUNCIONARIOS WHERE NomeFuncionario = '{0}'",NomeFuncionarios;
   
    
}
