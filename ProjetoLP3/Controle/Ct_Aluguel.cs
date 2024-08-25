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
    internal class Ct_Aluguel
    {
        private Ct_FormatarDados fd = new Ct_FormatarDados();

        private float preçoPadrão = 5.3f;

        public void adicionarFilmesAoListView(ListView listView, List<Filme> listaFilmes)
        {
            foreach (Filme filme in listaFilmes)
            {
                ListViewItem novoItem = new ListViewItem(filme.Nome);
                novoItem.SubItems.Add(fd.formatarHoraMinuto(filme.Duracao));
                novoItem.SubItems.Add("" + filme.FaixaEtaria);

                listView.Items.Add(novoItem);
            }
        }

        public void removerFilmesDoListView(ListView listView, List<Filme> listaFilmes)
        {
            //Remove os items selecionados do ListView
            foreach (int selectedIndex in listView.SelectedIndices.Cast<int>().Reverse())
            {
                listView.Items.RemoveAt(selectedIndex);
                listaFilmes.RemoveAt(selectedIndex); //Atualiza também a lista de filmes nova
            }
        }

        public DateTime data7Dias(DateTime dataAtual)
        {
            //Adiciona 7 dias à data atual
            return dataAtual.AddDays(7);
        }

        public void adicionarElementosDropDownList(ComboBox comboBox)
        {
            var valoresPagamento = Enum.GetValues(typeof(Pagamento));

            //Adiciona cada valor do enum ao ComboBox
            foreach (var pagamento in valoresPagamento)
            {
                comboBox.Items.Add(pagamento);
            }
        }

        public float gerarPreço(List<Filme> listaFilmes)
        {
            return preçoPadrão * listaFilmes.Count;
        }

        public async void gerarAluguel(List<Filme> listaFilmes, Usuario usuario, DateTime dataAtual)
        {
            //Todo aluguel é pago
            Aluguel novoAluguel = new Aluguel(dataAtual.ToString("dd/MM/yyyy_HH:mm:ss"),
                data7Dias(dataAtual).ToString("dd/MM/yyyy_HH:mm:ss"),
                Status.Pago,
                listaFilmes);

            //TODO: REMOVER LISTA LOCAL
            //Verifica se usuario ja possui lista, adiciona OU cria e adiciona
            if (usuario.ListaAlugueis == null)
            {
                usuario.ListaAlugueis = new List<Aluguel> { novoAluguel };
            } else
            {
                usuario.ListaAlugueis.Add(novoAluguel);
            }

            // Conectar usuario e aluguel pelo id do usuario
            novoAluguel.Usuario = usuario.Id;

            await interfaceParaBDAsync(novoAluguel);
        }

        // Conecta a interface com o controlador de serviço
        public async Task interfaceParaBDAsync(Aluguel aluguel)
        {
            try
            {
                // Chama o serviço de aluguel para cadastrar
                var servico = new Sv_Aluguel();

                // Faz cadastro
                await servico.CadastrarNovoAluguelAsync(aluguel, aluguel.ListaFilmes);
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao cadastrar aluguel: " + ex.Message);
            }
        }

        public bool verificarIdade(Usuario usuario, List<Filme> listaFilmes) {
            foreach (var item in listaFilmes)
            {
                if (fd.ConverterDataParaIdade(usuario.Idade) < item.FaixaEtaria)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
