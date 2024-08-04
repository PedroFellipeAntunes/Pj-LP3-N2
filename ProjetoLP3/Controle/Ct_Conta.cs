using ProjetoLP3.Dados;
using ProjetoLP3.Dados.Enum;
using ProjetoLP3.Janelas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class ResultadoValidacao
    {
        public bool Sucesso { get; set; } = true;
        public List<string> MensagensErro { get; set; } = new List<string>();

        public void AdicionarErro(string mensagem)
        {
            Sucesso = true; //Tem que começar como true
            MensagensErro.Add(mensagem);
        }
    }

    internal class Ct_Conta
    {
        public void atualizarConta(Usuario usuario, string nome, string email, string idade)
        {
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Idade = stringParaInt(idade);
        }

        public ResultadoValidacao verificarValidez(string nome, string email, string idade)
        {
            var resultado = new ResultadoValidacao();

            //Verifica se os valores estão nulos ou vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(idade))
            {
                resultado.AdicionarErro("Campos não podem estar em branco.");
                resultado.Sucesso = false;
                return resultado;
            }

            if (!validarEmail(email))
            {
                resultado.AdicionarErro("O formato do email é inválido.");
                resultado.Sucesso = false;
            }

            if (stringParaInt(idade) <= 0)
            {
                resultado.AdicionarErro("A idade deve ser maior que zero.");
                resultado.Sucesso = false;
            }

            return resultado;
        }

        //Verificar se o e-mail é valido
        private bool validarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                //Normaliza o domínio do e-mail
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private int stringParaInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                //A conversão falhou, lançar uma exceção
                throw new ArgumentException("A string não pode ser convertida para um valor inteiro.");
            }
        }
    }
}
