using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    class Periculosidade
    {
        public static double Calcula(double salario, double horas)
        {
            var receberPericulosidade = salario * 0.03 * horas;

            return receberPericulosidade;
        }
    }
}
