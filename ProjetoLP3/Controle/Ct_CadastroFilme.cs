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

        public void adicionarFilmeAoCatalogo(List<Filme> catalogo, string nome, string descrição, int duração, int faixaEtaria, Image imagem, CheckedListBox.CheckedItemCollection paises, CheckedListBox.CheckedItemCollection generos)
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

            if (imagem != null)
            {
                novoFilme.Imagem = imagem;
            }

            //Adiciona ao catalogo OU gera catalogo e adiciona
            if (catalogo != null)
            {
                catalogo.Add(novoFilme);
            }
            else
            {
                catalogo = new List<Filme>() { novoFilme };
            }
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
