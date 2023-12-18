using IFSPLivraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPLivraria.Repository.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Autor)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.AnoProducao)
                .IsRequired()
                .HasColumnType("varchar(4)");

            //chave
            builder.HasOne(prop => prop.Editora);
        }
    }
}