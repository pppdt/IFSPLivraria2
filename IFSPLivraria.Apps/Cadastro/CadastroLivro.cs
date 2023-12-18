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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPLivraria.App.Cadastro
{
    public partial class CadastroLivro : CadastroBase

    {
        private readonly IBaseService<Livro> _LivroService;
        private readonly IBaseService<Editora> _EditoraService;
        private List<LivroModel>? livros;

        public CadastroLivro(IBaseService<Livro> livroService, IBaseService<Editora> editoraService)

        {
            _LivroService = livroService;
            _EditoraService = editoraService;
            InitializeComponent();
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            cboEditora.ValueMember = "Id";
            cboEditora.DisplayMember = "Nome";
            cboEditora.DataSource = _EditoraService.Get<Editora>().ToList();
        }

        private void PreencheObjeto(Livro livro)
        {
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.AnoProducao = txtAnoProdrucao.Text;
            

            if (int.TryParse(cboEditora.SelectedValue.ToString(), out var idEditora))
            {
                var editora = _EditoraService.GetById<Editora>(idEditora);
                livro.Editora = editora;
                //_produtoService.AttachObject(grupo);
            }

        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var livro = _LivroService.GetById<Livro>(id);
                        PreencheObjeto(livro);
                        livro = _LivroService.Update<Livro, Livro, LivroValidator>(livro);
                    }
                }
                else
                {
                    var livro = new Livro();
                    PreencheObjeto(livro);
                    _LivroService.Add<Livro, Livro, LivroValidator>(livro);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _LivroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            livros = _LivroService.Get<LivroModel>(new[] { "Editora" }).ToList();
            dataGridViewConsulta.DataSource = livros;
            dataGridViewConsulta.Columns["IdEditora"]!.Visible = false; ;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtAutor.Text = linha?.Cells["Autor"].Value.ToString();
            txtTitulo.Text = linha?.Cells["Titulo"].Value.ToString();
            txtAnoProdrucao.Text = linha?.Cells["AnoProducao"].Value.ToString();
            cboEditora.SelectedValue = linha?.Cells["IdEditora"].Value;
        }

    }
}
