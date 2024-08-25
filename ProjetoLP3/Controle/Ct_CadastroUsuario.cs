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
    internal class Ct_CadastroUsuario
    {
        Ct_FormatarDados fd = new Ct_FormatarDados();

        public ResultadoValidacao verificarValidez(string nome, string email, string senha, string idade)
        {
            var resultado = new ResultadoValidacao();

            //Verifica se os valores estão nulos ou vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(idade))
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

            if (!validarSenha(senha))
            {
                resultado.AdicionarErro("Senha deve ter no mínimo 8 characteres.");
                resultado.Sucesso = false;
            }

            if (stringParaInt(idade) <= 0)
            {
                resultado.AdicionarErro("A idade deve ser maior que zero.");
                resultado.Sucesso = false;
            }

            return resultado;
        }

        //Verificar se senha é valida
        private bool validarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return false;
            }

            if (senha.Length < 8)
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

        // Conecta a interface com o controlador de serviço
        public async Task<bool> interfaceParaBDAsync(string email, string senha, string nome, string idade)
        {
            try
            {
                // Cria novo usuario
                // Deve sempre ser false
                Usuario usuario = new Usuario(nome, senha, email, idade, false);

                // Chama o serviço de usuário para buscar o usuário com email e senha fornecidos
                var servico = new Sv_Usuario();

                // Verifica se o email já está cadastrado
                if (await servico.VerificarEmailExistenteAsync(email))
                {
                    return true; // Usuário já existe
                }

                // Se o email não estiver cadastrado, realiza o cadastro
                await servico.CadastrarNovoUsuarioAsync(usuario);

                return false; // Cadastro realizado com sucesso
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao cadastrar usuário: " + ex.Message);
            }
        }
    }
}
