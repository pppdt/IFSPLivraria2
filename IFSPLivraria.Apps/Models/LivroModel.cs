using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLivraria.App.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? AnoProducao { get; set; }
        public int? IdEditora { get; set; }
        public string? Editora { get; set; }

    }
}
