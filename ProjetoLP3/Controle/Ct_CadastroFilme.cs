using ProjetoLP3.Banco.Serviço;
using ProjetoLP3.Dados;
using ProjetoLP3.Dados.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_CadastroFilme
    {
        // Conecta a interface com o controlador de serviço
        public async Task interfaceParaBDAsync(int opcao, Filme filme)
        {
            try
            {
                // Chama o serviço de filme para cadastrar/editar filme
                var servico = new Sv_Filme();

                // Define se faz cadastro ou editar
                if (opcao == 0)
                {
                    await servico.CadastrarNovoFilmeAsync(filme);
                }
                else if (opcao == 1)
                {
                    await servico.AtualizarFilmeAsync(filme);
                }
                else
                {
                    await servico.DeletarFilmeAsync(filme);
                }
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                if (opcao == 0)
                {
                    throw new Exception("Erro ao cadastrar filme: " + ex.Message);
                }
                else if(opcao == 1)
                {
                    throw new Exception("Erro ao atualizar filme: " + ex.Message);
                }
                else
                {
                    throw new Exception("Erro ao apagar filme: " + ex.Message);
                }
            }
        }

        public async Task editarDadosFilme(Filme filme, bool status, string nome, string descrição, int duração, int faixaEtaria, Image imagem, CheckedListBox.CheckedItemCollection paises, CheckedListBox.CheckedItemCollection generos)
        {
            //Converter
            List<Pais> listaPais = converterParaLista<Pais>(paises);
            List<Genero> listaGeneros = converterParaLista<Genero>(generos);

            //Editar
            filme.Nome = nome;
            filme.Descricao = descrição;
            filme.Duracao = duração;
            filme.Status = status;
            filme.FaixaEtaria = faixaEtaria;
            filme.ListaGenero = listaGeneros;
            filme.ListaLocaisLiberados = listaPais;

            //Adicionar imagem se existir
            if (imagem != null)
            {
                filme.Imagem = imagem;
            }

            // editar == 1
            await interfaceParaBDAsync(1, filme);
        }

        public void adicionarElementosCheckList<Tenum>(CheckedListBox checkedBox) where Tenum : Enum
        {
            var valores = Enum.GetValues(typeof(Tenum));

            foreach (var item in valores)
            {
                checkedBox.Items.Add(item);
            }
        }

        //Metodo para marcar os itens do CheckedListBox com base na lista de enums
        public void marcarItensExistentes<TEnum>(CheckedListBox checkedBox, List<TEnum> listaEnums) where TEnum : Enum
        {
            if (listaEnums == null)
            {
                return;
            }

            foreach (var enumValue in listaEnums)
            {
                //Verifica se o enumValue está presente nos itens do CheckedListBox
                if (checkedBox.Items.Contains(enumValue))
                {
                    checkedBox.SetItemChecked(checkedBox.Items.IndexOf(enumValue), true);
                }
            }
        }

        public async Task<bool> adicionarFilmeAoCatalogo(List<Filme> catalogo, bool status, string nome, string descrição, int duração, int faixaEtaria, Image imagem, CheckedListBox.CheckedItemCollection paises, CheckedListBox.CheckedItemCollection generos)
        {
            //Gera filme
            List<Pais> listaPais = converterParaLista<Pais>(paises);
            List<Genero> listaGeneros = converterParaLista<Genero>(generos);

            Filme novoFilme = new Filme(nome,
                descrição,
                duração,
                faixaEtaria,
                status,
                listaPais,
                listaGeneros);

            //TODO: REMOVER
            //Gerar id para o filme (sempre maior do que 0)
            //novoFilme.Id = "" + gerarId(catalogo);

            //Adicionar imagem se existir
            if (imagem != null)
            {
                novoFilme.Imagem = imagem;
            }

            //Adicionar ao banco
            //cadastrar == 0
            await interfaceParaBDAsync(0, novoFilme);

            //TODO: REMOVER CATALOGO LOCAL
            //Adiciona ao catalogo OU gera catalogo e adiciona
            if (catalogo != null)
            {
                //Verificar se já existe filme com este id
                if (!verificarExistenteID(catalogo, novoFilme))
                {
                    catalogo.Add(novoFilme);

                    return true;
                }
            }
            else
            {
                catalogo = new List<Filme>() { novoFilme };

                return true;
            }

            //Gerou erro!
            return false;
        }

        // TODO: REMOVER BD JA FAZ ISTO
        private bool verificarExistenteID(List<Filme> catalogo, Filme filme)
        {
            foreach (var atual in catalogo)
            {
                if (filme.Id.Equals(atual.Id))
                {
                    return true;
                }
            }

            return false;
        }

        private int gerarId(List<Filme> catalogo)
        {
            int id = 0;

            foreach (var item in catalogo)
            {
                id = int.Parse(item.Id);
            }

            return id + 1;
        }

        //Converter pra lista
        private List<Tenum> converterParaLista<Tenum>(CheckedListBox.CheckedItemCollection checkedListBoxItens) where Tenum : Enum
        {
            var listaItensMarcados = new List<Tenum>();

            foreach (Tenum item in checkedListBoxItens)
            {
                listaItensMarcados.Add(item);
            }

            return listaItensMarcados;
        }
    }
}
