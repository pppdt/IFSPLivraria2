using IFSPLivraria.Domain.Base;


namespace IFSPLivraria.Domain.Entities
{
    public class Editora : BaseEntity<int>
    {
        public Editora()
        {

        }

        public Editora(int id, string? nome, Livro? livro) : base(id)
        {
            Nome = nome;
            Livro = livro;
        }

        public string? Nome { get; set; }
        public Livro? Livro { get; set;  }
    }
}
