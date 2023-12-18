using IFSPLivraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static IFSPLivraria.Domain.Entities.Emprestimo;


namespace IFSPLivraria.Repository.Mapping
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataEmprestimo)
                .IsRequired();

            builder.Property(prop => prop.DataDevolucao)
                .IsRequired();

            builder.HasOne(prop => prop.Cliente);
            //muitos itens ... relacionamento de tabelas
            builder.HasMany(prop => prop.Empl)
                .WithOne(prop => prop.Emprestimo)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }

    public class Emprestimo_LivroMap : IEntityTypeConfiguration<Emprestimo_Livro>
    {
        public void Configure(EntityTypeBuilder<Emprestimo_Livro> builder)
        {
            builder.ToTable("Emprestimo_Livro");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Livro);
                
            builder.Property(prop => prop.Quantidade)
                .IsRequired();
            
            builder.HasOne(prop => prop.Emprestimo)
                .WithMany(prop => prop.Empl)
                .OnDelete(DeleteBehavior.Cascade); 
        }

    }
    
        

    
}
