using ProjetoLP3.Banco.Serviço;
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
    internal class Ct_Login
    {
        Ct_FormatarDados fd = new Ct_FormatarDados();

        public ResultadoValidacao verificarValidez(string email, string senha)
        {
            var resultado = new ResultadoValidacao();

            //Verifica se os valores estão nulos ou vazios
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
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

        public async Task<Usuario> verificarValidezBDAsync(string email, string senha)
        {
            try
            {
                // Chama o serviço de usuário para buscar o usuário com email e senha fornecidos
                var servico = new Sv_Usuario();

                return await servico.BuscarUsuarioPorEmailESenhaAsync(email, senha);
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }
        }
    }
}
