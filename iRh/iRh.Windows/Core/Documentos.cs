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
        public string Name { get; set; }

        public List<Documentos> ObterDocumentos()
        {
            var listaDocumentos = new List<Documentos>();

            listaDocumentos.Add(new Documentos
            {
                Id = 1,
                Name = "Carteira de Identidade"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 2,
                Name = "Carteira de Motorista"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 3,
                Name = "Carteira de Trabalho"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 4,
                Name = "Carteira Profissional"
            });
            listaDocumentos.Add(new Documentos
            {
                Id = 5,
                Name = "Registro Nacional de Estrangeiro e Passaporte."
            });

            return listaDocumentos;
        }
    }
}
