using IFSPLivraria.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLivraria.Repository.Mapping
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
           

        }
    }
}