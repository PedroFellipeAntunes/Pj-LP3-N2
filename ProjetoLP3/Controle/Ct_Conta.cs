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
        Ct_FormatarDados fd = new Ct_FormatarDados();

        public void atualizarConta(Usuario usuario, string nome, string email, string idade)
        {
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Idade = idade;

            // Eu sei que é valido pois ja fiz a verificação
            interfaceParaBDAsync(usuario);
        }

        // Conecta a interface com o controlador de serviço
        public async void interfaceParaBDAsync(Usuario usuario)
        {
            try
            {
                // Chama o serviço de filme para obter os filmes do bd
                var servico = new Sv_Usuario();

                // Faz pesquisa
                await servico.AtualizarDadosUsuarioAsync(usuario);
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao encontrar filmes: " + ex.Message);
            }
        }

        private async Task<bool> verificarEmailBdAsync(string email)
        {
            try
            {
                // Chama o serviço de filme para obter os filmes do bd
                var servico = new Sv_Usuario();

                // Faz pesquisa
                return await servico.VerificarEmailExistenteAsync(email);
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao verificar email: " + ex.Message);
            }
        }

        public async Task<ResultadoValidacao> verificarValidez(Usuario usuario, string nome, string email, string idade)
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
            else if (!usuario.Email.Equals(email)) // Apenas verificar se o email foi alterado
            {
                bool emailExiste = await verificarEmailBdAsync(email);

                if (emailExiste)
                {
                    resultado.AdicionarErro("O email já está em uso.");
                    resultado.Sucesso = false;
                }
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

        public int stringParaInt(string input)
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
