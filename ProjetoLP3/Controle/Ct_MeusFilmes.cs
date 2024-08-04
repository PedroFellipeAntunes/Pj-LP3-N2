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
    internal class Ct_MeusFilmes
    {
        //Adicionar metodos de controle de dados nesta classe
        public List<Filme> obterFilmesAlugados(Usuario usuario)
        {
            //Não tem alugueis
            if (usuario.ListaAlugueis == null)
            {
                return null;
            }

            List<Filme> filmesAtualmenteAlugados = new List<Filme>();

            foreach (var aluguel in usuario.ListaAlugueis)
            {
                //Se o aluguel foi pago e ainda esta em data deve ser adicionado a lista
                if (aluguel.Status.Equals(Status.Pago))
                {
                    filmesAtualmenteAlugados.AddRange(aluguel.ListaFilmes);
                }
            }

            return filmesAtualmenteAlugados;
        }
    }
}
