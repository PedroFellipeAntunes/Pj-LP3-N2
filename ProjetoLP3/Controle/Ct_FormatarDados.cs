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
        public string formatarHoraMinuto(int segundos)
        {
            //Converter a duração de segundos para horas e minutos
            int horas = segundos / 3600; //3600 segundos em uma hora
            int minutos = (segundos % 3600) / 60;

            return $"{horas:D2}:{minutos:D2}"; //Formato "hh:mm"
        }
    }
}
