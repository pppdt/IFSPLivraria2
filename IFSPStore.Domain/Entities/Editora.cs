using IFSPLivraria.Domain.Base;


namespace IFSPLivraria.Domain.Entities
{
    public class Editora : BaseEntity<int>
    {
        public Editora()
        {

        }

        public Editora(int id, string? nome) : base(id)
        {
            Nome = nome;
           
        }

        public string? Nome { get; set; }
    }
}
