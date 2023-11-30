using IFSPLivraria.Domain.Base;

public class Livro : BaseEntity<int>
{
    public Livro()
    {

    }
    public Livro(int id,string? titulo, string ? autor, string? anoProducao) : base(id)
    {
        Titulo = titulo;
        Autor = autor;
        AnoProducao = anoProducao;
    }

    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public string? AnoProducao { get; set;}
        
}