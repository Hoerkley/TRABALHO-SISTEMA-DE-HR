using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Documentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Documentos> ObterDocumentos()
        {
            var listaDocumentos = new List<Documentos>();

            listaDocumentos.Add(new Documentos
            {
                Id = 0,
                Nome = ""
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 1,
                Nome = "Carteira de Identidade"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 2,
                Nome = "Carteira de Motorista"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 3,
                Nome = "Carteira de Trabalho"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 4,
                Nome = "Carteira Profissional"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 5,
                Nome = "Registro Nacional de Estrangeiro e Passaporte."
            });

            return listaDocumentos;
        }
    }
}
