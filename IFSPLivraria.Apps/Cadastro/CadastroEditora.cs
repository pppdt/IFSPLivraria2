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
    public partial class CadastroEditora : CadastroBase
    {
        private readonly IBaseService<Editora> _editoraService;
        private readonly IBaseService<Livro> _livroService;
        private List<EditoraModel>? editoras;
        public CadastroEditora(IBaseService<Editora> editoraService, IBaseService<Livro> livroService)
        {
            _editoraService = editoraService;
            _livroService = livroService;
            InitializeComponent();
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            cboLivro.ValueMember = "Id";
            cboLivro.DisplayMember = "Titulo";
            cboLivro.DataSource = _livroService.Get<LivroModel>().ToList();
        }

        private void PreencheObjeto(Editora editora)
        {
            editora.Nome = txtNome.Text;
          
            if (int.TryParse(cboLivro.SelectedValue.ToString(), out var idGrupo))
            {
                var livro = _livroService.GetById<Livro>(idGrupo);
                editora.Livro = livro;
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
                        var editora = _editoraService.GetById<Editora>(id);
                        PreencheObjeto(editora);
                        _editoraService.Update<Editora, Editora, EditoraValidator>(editora);
                    }
                }
                else
                {
                    var editora = new Editora();
                    PreencheObjeto(editora);
                    _editoraService.Update<Editora, Editora, EditoraValidator>(editora);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _editoraService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            editoras = _editoraService.Get<EditoraModel>(new[] { "Livro" }).ToList();
            dataGridViewConsulta.DataSource = editoras;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdLivro"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboLivro.SelectedValue = linha?.Cells["NomeLivro"].Value;
        }

    }
}
