using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class HoraExtra
    {
        public static double Resultado(double salario, double horas100, double horas50)
        {
            double valorHora = salario / 220;

            var valorHoraExtra100 = valorHora * 2;
            var valorTotal100 = valorHoraExtra100 * horas100;

            var valorHora50 = valorHora * 0.5;
            var valorTotalHora50 = valorHora50 * horas50;

            var horaExtra = valorTotal100 + valorTotalHora50;
            return horaExtra;
        }
    }
}
