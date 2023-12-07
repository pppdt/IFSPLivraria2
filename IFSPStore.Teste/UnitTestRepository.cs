using System.Text.Json;
using IFSPLivraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IFSPLivraria.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Editora> Editora { get; set; }
            public DbSet<Emprestimo> Emprestimo { get; set; }
            public DbSet<Emprestimo_Livro> Emprestimo_Livro { get; set; }
            public DbSet<Livro> Livro { get; set; }

            public MyDbContext()
            {

                Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPLivraria";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }

        [TestMethod]
        public void TestInsertCliente()
        {
            using (var context = new MyDbContext())
            {

                var cliente = new Cliente
                {
                    Nome = "Giovanna",
                    Bairro = "Centro",
                    Endereco = "Rua Teste",
                    Documento = "4852542"
                };
                context.Cliente.Add(cliente);

                  cliente = new Cliente
                {
                    Nome = "shazam",
                    Bairro = "pol",
                    Endereco = "Rua Tae",
                    Documento = "45852225"
                };
                context.Cliente.Add(cliente);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarCliente()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Cliente)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }
    }
}