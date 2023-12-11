    using IFSPLivraria.App.Base;
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
        private List<Livro>? livros;

        public CadastroLivro(IBaseService<Livro> livroService)

        {
            _LivroService = livroService;
            InitializeComponent();

        }
        private void PreencheObjeto(Livro livro)
        {
          

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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
