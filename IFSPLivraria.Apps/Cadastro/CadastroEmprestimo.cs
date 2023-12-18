using IFSPLivraria.App.Base;
using IFSPLivraria.App.Models;
using IFSPLivraria.Domain.Base;
using IFSPLivraria.Domain.Entities;
using IFSPLivraria.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPLivraria.App.Cadastro
{
    public partial class CadastroEmprestimo : CadastroBase
    {
        private List<Emprestimo_LivroModel> _emprestimo_Livro;

        private readonly IBaseService<Emprestimo> _emprestimoService;
        private readonly IBaseService<Cliente> _ClienteService;
        private readonly IBaseService<Livro> _LivroService;

        private List<EmprestimoModel> emprestimos;

        public CadastroEmprestimo(IBaseService<Emprestimo> emprestimoService, IBaseService<Cliente> clienteService, IBaseService<Livro> livroService)
        {
            _emprestimoService = emprestimoService;
            _ClienteService = clienteService;
            _LivroService = livroService;
            _emprestimo_Livro = new List<Emprestimo_LivroModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridLivro();
        }
        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _ClienteService.Get<Cliente>().ToList();

            cboLivro.ValueMember = "Id";
            cboLivro.DisplayMember = "Titulo";
            cboLivro.DataSource = _LivroService.Get<Livro>().ToList();
        }

        private void PreencheObjeto(Emprestimo emprestimo)
        {
            if (DateTime.TryParse(txtDataDevolucao.Text, out var dataDevolucao))
            {
                emprestimo.DataDevolucao = dataDevolucao;
            }
            if (DateTime.TryParse(txtDataEmprestimo.Text, out var dataemprestimo))
            {
                emprestimo.DataEmprestimo = dataemprestimo;
            }


            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                //var cliente = _ClienteService.GetById<Cliente>(idCliente, new[] { "Cidade" });
                emprestimo.Cliente = _ClienteService.GetById<Cliente>(idCliente);
            }

            foreach (var empl in _emprestimo_Livro)
            {
                var livroEmprestimo = new Emprestimo_Livro
                {
                    Emprestimo = emprestimo,
                    Quantidade= empl.Quantidade,
                    //Livro = _LivroService.GetById<Livro>(empl.IdLivro, new [] { "Editora" })
                    Livro = _LivroService.GetById<Livro>(empl.IdLivro)

                };
                emprestimo.Empl.Add(livroEmprestimo);
            }
        }


        protected override void Novo()
        {
            base.Novo();
            _emprestimo_Livro.Clear();
            CarregaGridLivro();
            txtDataDevolucao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataEmprestimo.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var emprestimo = _emprestimoService.GetById<Emprestimo>(id);
                        PreencheObjeto(emprestimo);
                        emprestimo = _emprestimoService.Update<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
                    }
                }
                else
                {
                    var emprestimo = new Emprestimo();
                    PreencheObjeto(emprestimo);
                    emprestimo = _emprestimoService.Add<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Livraria ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _emprestimoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente" };
            emprestimos = _emprestimoService.Get<EmprestimoModel>(includes).ToList();
            dataGridViewConsulta.DataSource = emprestimos;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {

            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            txtDataDevolucao.Text = DateTime.TryParse(linha?.Cells["DataDevolucao"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";
            txtDataEmprestimo.Text = DateTime.TryParse(linha?.Cells["dataemprestimo"].Value.ToString(), out var dataD)
               ? dataD.ToString("g")
               : "";

            var includes = new List<string>() { "Cliente", "Empl", "Empl.Livro" };
            var emprestimo = _emprestimoService.GetById<Emprestimo>(id, includes);
            _emprestimo_Livro = new List<Emprestimo_LivroModel>();
            foreach (var empl in emprestimo.Empl)
            {
                var emprestimo_Livro = new Emprestimo_LivroModel
                {
                    Id = empl.Id,
                    IdLivro = empl.Livro!.Id,
                    Livro = empl.Livro!.Titulo,
                    Quantidade = empl.Quantidade

                };
                _emprestimo_Livro.Add(emprestimo_Livro);
            }
            CarregaGridLivro();

        }

        private void CarregaGridLivro()
        {
            
         var source = new BindingSource();
         source.DataSource = _emprestimo_Livro.ToArray();
         dataGridViewLivros.DataSource = source;
            dataGridViewLivros.Columns["Id"]!.Visible = false;
            dataGridViewLivros.Columns["IdLivro"]!.HeaderText = @"Id.Livro";
            dataGridViewLivros.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          

        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var emprestimo_Livro = new Emprestimo_LivroModel();
                if (int.TryParse(cboLivro.SelectedValue.ToString(), out var idLivro))
                {
                    var livro = _LivroService.GetById<Livro>(idLivro);
                    emprestimo_Livro.IdLivro = livro.Id;
                    emprestimo_Livro.Livro = livro.Titulo;
                }

                if (int.TryParse(txtQuantidade.Text, out var qtd))
                {
                    emprestimo_Livro.Quantidade = qtd;
                }

                _emprestimo_Livro.Add(emprestimo_Livro);    
              
                CarregaGridLivro();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

    }
}
