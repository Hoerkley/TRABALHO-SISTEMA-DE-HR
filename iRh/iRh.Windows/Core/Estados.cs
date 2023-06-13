using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    class Estados
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Sigla { get; set; }
        public List<Estados> ObterTodosEstados()
        {
            var listaEstados = new List<Estados>();
            listaEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rndônia",
                Sigla = "RO"

            });
            listaEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC"

            });
            return listaEstados;

        }
    }
}
