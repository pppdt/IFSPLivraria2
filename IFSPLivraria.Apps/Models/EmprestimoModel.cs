using IFSPLivraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IFSPLivraria.App.Models
{
    public class EmprestimoModel
    {
        public EmprestimoModel()
        {
        
            Empl = new List<Emprestimo_Livro>();
        }


        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }

        public List<Emprestimo_Livro> Empl { get; set; }
    }

    public class Emprestimo_LivroModel
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public String Livro { get; set; }
        public int Quantidade { get; set; }
        public Emprestimo? Emprestimo { get; set; }

    }

}
