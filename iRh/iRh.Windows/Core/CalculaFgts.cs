using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class CalculaFgts
    {
        public static double calacula(double salario)
        {
            const double porcentagem = 0.08;

            var decontoFgts = salario * porcentagem;

            return decontoFgts;
        }
    }
}
