
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using IFSPLivraria.Domain.Entities;
using IFSPLivraria.Repository.Mapping;
using static IFSPLivraria.Domain.Entities.Emprestimo;

namespace IFSPLivraria.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            //VAI CRIAR O BANCO AUTOMATICO, FORÇA A CRIAÇÃO DO BD
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Editora>? Editora { get; set; }
        public DbSet<Livro>? Livro { get; set; }        
        public DbSet<Emprestimo>? Emprestimo { get; set; }
        public DbSet<Emprestimo_Livro>? Emprestimo_Livro { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Editora>(new EditoraMap().Configure);
            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<Emprestimo>(new EmprestimoMap().Configure);
            modelBuilder.Entity<Emprestimo_Livro>(new Emprestimo_LivroMap().Configure);
        }
        
    }
}
