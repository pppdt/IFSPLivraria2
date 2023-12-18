using IFSPLivraria.Domain.Base;

namespace IFSPLivraria.Domain.Entities
{
    public class Livro : BaseEntity<int>
    {
        public Livro()
        {

        }
        public Livro(int id, string? titulo, string? autor, string? anoProducao, Editora? editora) : base(id)
        {
            Titulo = titulo;
            Autor = autor;
            AnoProducao = anoProducao;
            Editora = editora;
        }

        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? AnoProducao { get; set; }

        public virtual Editora? Editora { get;set; }

    }
}