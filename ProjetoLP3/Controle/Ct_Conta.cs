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
    internal class Ct_Conta
    {
        public void atualizarConta(Usuario usuario, string nome, string email, string idade)
        {
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Idade = stringParaInt(idade);
        }

        public bool verificarValidez(string nome, string email, string idade)
        {
            //Verifica se os valores estão nulos ou vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(idade))
            {
                return false;
            }

            if (!validarEmail(email))
            {
                return false;
            }

            return true;
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
