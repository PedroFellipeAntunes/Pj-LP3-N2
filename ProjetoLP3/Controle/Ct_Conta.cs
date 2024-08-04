using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_Conta
    {


        public ResultadoValidacaoUsuario ValidarNome(string nome)
        {
            var resultado = new ResultadoValidacaoUsuario();

            if (string.IsNullOrWhiteSpace(nome))
            {
                resultado.AdicionarErro("O nome não pode estar em branco.");
            }
            else if (nome.Length < 3)
            {
                resultado.AdicionarErro("O nome deve ter pelo menos 3 caracteres.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
            {
                resultado.AdicionarErro("O nome não pode conter números ou símbolos.");
            }

            return resultado;
        }



        public ResultadoValidacaoUsuario ValidarEmail(string email)
        {
            var resultado = new ResultadoValidacaoUsuario();
            if (string.IsNullOrWhiteSpace(email))
            {
                resultado.AdicionarErro("O email não pode estar em branco.");
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    if (addr.Address != email)
                    {
                        resultado.AdicionarErro("O formato do email é inválido.");
                    }
                }
                catch
                {
                    resultado.AdicionarErro("O formato do email é inválido.");
                }
            }
            return resultado;
        }

        public ResultadoValidacaoUsuario ValidarIdade(String idade)
        {
            var resultado = new ResultadoValidacaoUsuario();
            if (string.IsNullOrWhiteSpace(idade))
            {
                resultado.AdicionarErro("Preencha o campo idade");
            }
            else
            {
                int idade1 = Convert.ToInt32(idade);
               
                if (idade1 <= 0)
                {
                    resultado.AdicionarErro("A idade deve ser maior que zero.");
                }
            }
            return resultado;
        }
    }
}
