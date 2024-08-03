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
        public void adicionarElementosCheckList<Tenum>(CheckedListBox checkedBox) where Tenum : Enum
        {
            var valores = Enum.GetValues(typeof(Tenum));

            foreach (var item in valores)
            {
                checkedBox.Items.Add(item);
            }
        }

        public bool adicionarFilmeAoCatalogo(List<Filme> catalogo, string nome, string descrição, int duração, int faixaEtaria, Image imagem, CheckedListBox.CheckedItemCollection paises, CheckedListBox.CheckedItemCollection generos)
        {
            //Gera filme
            List<Pais> listaPais = converterParaLista<Pais>(paises);
            List<Genero> listaGeneros = converterParaLista<Genero>(generos);

            Filme novoFilme = new Filme(nome,
                descrição,
                duração,
                faixaEtaria,
                true,
                listaPais,
                listaGeneros);

            //Gerar id para o filme (sempre maior do que 0)
            novoFilme.IdFilme = gerarId(catalogo);

            //Adicionar imagem se existir
            if (imagem != null)
            {
                novoFilme.Imagem = imagem;
            }

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

        private bool verificarExistenteID(List<Filme> catalogo, Filme filme)
        {
            foreach (var atual in catalogo)
            {
                if (filme.IdFilme == atual.IdFilme)
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
                id = item.IdFilme;
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
