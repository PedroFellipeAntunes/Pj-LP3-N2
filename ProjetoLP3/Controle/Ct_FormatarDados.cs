using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_FormatarDados
    {
        public int ConverterDataParaIdade(string dataNascimento)
        {
            DateTime dataNasc = DateTime.Parse(dataNascimento);
            int idade = DateTime.Now.Year - dataNasc.Year;

            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
            {
                idade--;
            }

            return idade;
        }

        public string ConverterIdadeParaData(int idade)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = dataAtual.AddYears(-idade);

            return dataNascimento.ToString("yyyy-MM-dd");
        }

        public string formatarHoraMinuto(int segundos)
        {
            //Converter a duração de segundos para horas e minutos
            int horas = segundos / 3600; //3600 segundos em uma hora
            int minutos = (segundos % 3600) / 60;

            return $"{horas:D2}:{minutos:D2}"; //Formato "hh:mm"
        }

        public string formatarDataHora(string data)
        {
            return data.Replace("_", " ");
        }
    }
}
