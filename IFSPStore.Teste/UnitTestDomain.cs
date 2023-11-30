using System.Text.Json;
using System.Text.RegularExpressions;
using IFSPLivraria.Domain.Entities;
using NuGet.Frameworks;


namespace IFSPLivraria.Teste
{
    [TestClass]
    public class UnitTestDomain
    {/*
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
        */
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


            var produto = new Produto();
            var grupo = new Grupo();

            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            grupo.Nome = "Alimentos";

            produto.Nome = "Arroz";
            produto.UnidadeVenda = "BRI";
            produto.Quantidade = 2;
            produto.Grupo = grupo;

            venda.Cliente = cliente;
            venda.Data = DateTime.Today;

            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.Cliente, cliente);
            Assert.AreEqual(venda.Data, DateTime.Today);


            vendaItem.Quantidade = 2;
            vendaItem.Produto = produto;
            vendaItem.ValorUnitario = 5;
            vendaItem.Venda = venda;

            Console.WriteLine(JsonSerializer.Serialize(vendaItem));
            Assert.AreEqual(vendaItem.Quantidade, 2);
            Assert.AreEqual(vendaItem.Produto, produto);
            Assert.AreEqual(vendaItem.ValorUnitario, 5);
            Assert.AreEqual(vendaItem.Venda, venda);

            venda.Items.Add(vendaItem);


            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.Items[0].ValorUnitario, vendaItem.ValorUnitario);

        }

    }
}