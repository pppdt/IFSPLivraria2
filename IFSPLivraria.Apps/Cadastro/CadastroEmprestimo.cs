using IFSPLivraria.App.Base;
using IFSPLivraria.App.Models;
using IFSPLivraria.Domain.Base;
using IFSPLivraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPLivraria.App.Cadastro
{
    public partial class CadastroEmprestimo : CadastroBase
    {
  
        
            private List<Emprestimo_Livro> _emprestimo_Livros;
            private readonly IBaseService<Emprestimo> _emprestimoService;
            private readonly IBaseService<Livro> _livroService;
            private readonly IBaseService<Cliente> _clienteService;

            private List<Emprestimo>? emprestimo;

            public CadastroEmprestimo(IBaseService<Emprestimo> emprestimoService,
                                 IBaseService<Livro> livroService,
                                 IBaseService<Cliente> clienteService )

            {
            _emprestimoService = emprestimoService;
            _livroService = livroService;
                _clienteService = clienteService;
                _emprestimo_Livros = new List<Emprestimo_LivroModel>();
                InitializeComponent();
                CarregarCombo();
                CarregaGridItensVenda();
                Novo();
        }
        private void CarregarCombo()
        {
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
            cboUsuario.DataSource = _usuarioService.Get<Usuario>().ToList();

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
            cboProduto.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Venda venda)
        {
            if (DateTime.TryParse(txtDataVenda.Text, out var dataVenda))
            {
                venda.Data = dataVenda;
            }

            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                venda.Usuario = usuario;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                venda.Cliente = cliente;
            }
            venda.ValorTotal = _vendaItems.Sum(x => x.ValorTotal);

            foreach (var item in _vendaItems)
            {
                var itemVenda = new VendaItem
                {
                    Venda = venda,
                    Produto = _produtoService.GetById<Produto>(item.IdProduto),
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                };

                venda.Items.Add(itemVenda);
            }

        }

        protected override void Novo()
        {
            base.Novo();
            _vendaItems.Clear();
            CarregaGridItensVenda();
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


    }

