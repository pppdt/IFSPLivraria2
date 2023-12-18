using IFSPLivraria.App.Base;
using IFSPLivraria.App.Models;
using IFSPLivraria.Domain.Base;
using IFSPLivraria.Domain.Entities;
using IFSPLivraria.Service.Validators;


namespace IFSPLivraria.App.Cadastro
{
    public partial class CadastroEditora : CadastroBase
    {
        private readonly IBaseService<Editora> _editoraService;

        private List<EditoraModel>? editoras;

        public CadastroEditora(IBaseService<Editora> editoraService)
        {
            _editoraService = editoraService;
            InitializeComponent();
           
        }
 

        private void PreencheObjeto(Editora editora)
        {
            editora.Nome = txtNome.Text;
          
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
                        editora =  _editoraService.Update<Editora, Editora, EditoraValidator>(editora);
                    }
                }
                else
                {
                    var editora = new Editora();
                    PreencheObjeto(editora);
                    _editoraService.Add<Editora, Editora, EditoraValidator>(editora);

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
                _editoraService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            editoras = _editoraService.Get<EditoraModel>().ToList();
            dataGridViewConsulta.DataSource = editoras;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

    }

}

