using System;

public class Bd_Conexao_Erro : Exception
{
    public Bd_Conexao_Erro(string message) : base(message) { }
}