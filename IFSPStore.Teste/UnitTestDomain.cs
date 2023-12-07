using System.Text.Json;
using IFSPLivraria.Domain.Entities;

namespace IFSPLivraria.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            var cidade = new Cidade
            {
                Nome = "Batatais",
                Estado = "SP"
            };

            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Batatais");
            Assert.AreEqual(cidade.Estado, "SP");

        }
        

        [TestMethod]
        public void TestCliente()
        {
            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";
            cliente.Documento = "4852542";

            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Giovanna");
            Assert.AreEqual(cliente.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(cliente.Bairro, "Centro");
            Assert.AreEqual(cliente.Endereco, "Rua Teste");
            Assert.AreEqual(cliente.Documento, "4852542");
            
        }
        

        [TestMethod]
        public void TesteEditora()
        {
            var editora = new Editora();

            editora.Nome = "Shazam";


            Console.WriteLine(JsonSerializer.Serialize(editora));
            Assert.AreEqual(editora.Nome, "Shazam");


        }
       
        [TestMethod]
        public void TesteLivro()
        {
            var livro = new Livro();

            livro.Titulo = "cronicas de narnia";
            livro.Autor = "Bru";
            livro.AnoProducao = "2015";
            
            Assert.AreEqual(livro.Titulo, "cronicas de narnia");
            Assert.AreEqual(livro.Autor, "Bru");
            Assert.AreEqual(livro.AnoProducao, "2015");
            // se for necessario Assert.AreEqual(usuario.DataCadastro, DateTime.Today);    
        }

        // emprestimo_Livro
        [TestMethod]
        public void TesteEmprestimo()
        {
            var emprestimo = new Emprestimo();
            var emprestimo_livro = new Emprestimo_Livro();

            var cidade = new Cidade(); 
            var cliente = new Cliente();

            var editora = new Editora();
            var livro = new Livro();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";
            cliente.Documento = "4852542";

            editora.Nome = "Shazam";

            livro.Titulo = "cronicas de narnia";
            livro.Autor = "Bru";
            livro.AnoProducao = "2015";

            emprestimo.DataEmprestimo = DateTime.Today;
            emprestimo.DataDevolucao = new DateTime(2023, 12, 07, 12, 15, 10);

            Console.WriteLine(JsonSerializer.Serialize(emprestimo));
           // Assert.AreEqual(emprestimo.Cliente, cliente);
            Assert.AreEqual(emprestimo.DataEmprestimo, DateTime.Today);
            Assert.AreEqual(emprestimo.DataDevolucao, DateTime.Today);

            emprestimo_livro.Quantidade = 1;
            emprestimo_livro.Emprestimo = emprestimo;
            emprestimo_livro.Livro = livro;

            Console.WriteLine(JsonSerializer.Serialize(emprestimo_livro));
            Assert.AreEqual(emprestimo_livro.Quantidade, 1);
            Assert.AreEqual(emprestimo_livro.Emprestimo, emprestimo);
            Assert.AreEqual(emprestimo_livro.Livro, livro);

            emprestimo.Empl.Add(emprestimo_livro);
            Console.WriteLine(JsonSerializer.Serialize(emprestimo));


        }

    }
}