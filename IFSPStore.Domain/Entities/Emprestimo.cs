using IFSPLivraria.Domain.Base;


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
        public Cliente? Cliente { get; set; }
        public List<Emprestimo_Livro> Empl { get; set; }

        public class Emprestimo_Livro : BaseEntity<int>
        {
            public Emprestimo_Livro()
            {

            }

            Emprestimo_Livro(int id, Livro? livro, int quantidade, Emprestimo? emprestimo) : base(id)
            {
                Livro = livro;
                Quantidade = quantidade;
                Emprestimo = emprestimo;
            }

            public Livro? Livro { get; set; }
            public int Quantidade { get; set; }
            public Emprestimo? Emprestimo {get; set;}
        }

    }

}