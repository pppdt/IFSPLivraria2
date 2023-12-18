using IFSPLivraria.Domain.Base;
using System.Text.Json.Serialization;

namespace IFSPLivraria.Domain.Entities
{
    public class Emprestimo : BaseEntity<int>
    {
        public Emprestimo()
        {
            Empl = new List<Emprestimo_Livro> ();
        }

        public Emprestimo(int id, DateTime dataEmprestimo, DateTime dataDevolucao, Cliente? cliente, List <Emprestimo_Livro> empl) : base(id)
        {
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Cliente = cliente;
            Empl = empl;
        }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<Emprestimo_Livro> Empl { get; set; }     
    }

    public class Emprestimo_Livro : BaseEntity<int>
    {
        public Emprestimo_Livro()
        {

        }

        public Emprestimo_Livro(int id, Livro? livro, int quantidade, Emprestimo? emprestimo) : base(id)
        {
            Livro = livro;
            Quantidade = quantidade;
            Emprestimo = emprestimo;
        }

        public virtual Livro? Livro { get; set; }
        public int Quantidade { get; set; }
        [JsonIgnore]
        public virtual Emprestimo? Emprestimo { get; set; }
    }


}