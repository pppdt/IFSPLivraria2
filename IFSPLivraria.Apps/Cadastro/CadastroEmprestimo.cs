
//using IFSPLivraria.App.Base;
//using IFSPLivraria.App.Models;
//using IFSPLivraria.Domain.Base;
//using IFSPLivraria.Domain.Entities;
//using IFSPLivraria.Service.Validators;


//namespace IFSPLivraria.App.Cadastro
//{
//    public partial class CadastroEmprestimo : CadastroBase
//    {


//        private List<Emprestimo_LivroModel> _emprestimo_Livros;
//        private readonly IBaseService<Emprestimo> _emprestimoService;
//        private readonly IBaseService<Livro> _livroService;
//        private readonly IBaseService<Cliente> _clienteService;

//        private List<EmprestimoModel>? emprestimos;

//        public CadastroEmprestimo(IBaseService<Emprestimo> emprestimoService,
//                             IBaseService<Livro> livroService,
//                             IBaseService<Cliente> clienteService)

//        {
//            _emprestimoService = emprestimoService;
//            _livroService = livroService;
//            _clienteService = clienteService;
//            _emprestimo_Livros = new List<Emprestimo_LivroModel>();
//            InitializeComponent();
//            CarregarCombo();
//            CarregaGridEmprestimoLivro();
//            Novo();
//        }

//        private void CarregarCombo()
//        {

//            cboCliente.ValueMember = "Id";
//            cboCliente.DisplayMember = "Nome";
//            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

//            cboLivro.ValueMember = "Id";
//            cboLivro.DisplayMember = "Titulo";
//            cboLivro.DataSource = _livroService.Get<Cliente>().ToList();
//        }
//        //, Emprestimo_Livro emprestimo_Livro
//        private void PreencheObjeto(Emprestimo emprestimo)
//        {
//            if (DateTime.TryParse(txtDataDevolucao.Text, out var dataDevolucao))
//            {
//                emprestimo.DataDevolucao = dataDevolucao;
//            }

//            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
//            {
//                var cliente = _clienteService.GetById<Cliente>(idCliente);
//                emprestimo.Cliente = cliente;
//            }
//            /*
//                        if (int.TryParse(cboLivro.SelectedValue.ToString(), out var idLivro))
//                        {
//                            var livro = _livroService.GetById<Livro>(idLivro);
//                            emprestimo_Livro.Livro = livro;
//                        }
//            */
//            foreach (var empl in _emprestimo_Livros)
//            {
//                var emprestimoLivro = new Emprestimo_Livro
//                {
//                    Emprestimo = emprestimo,
//                    Livro = _livroService.GetById<Livro>(empl.IdLivro),
//                    Quantidade = empl.Quantidade
//                };

//                emprestimo.Empl.Add(emprestimoLivro);
//            }

//        }



//        protected override void Novo()
//        {
//            base.Novo();
//            _emprestimo_Livros.Clear();
//            CarregaGridEmprestimo_Livro();
//            txtDataDevolucao.Text = DateTime.Now.ToString("dd/MM/yyyy");
//        }

//        protected override void Salvar()
//        {
//            try
//            {
//                Empl;
//                if (IsAlteracao)
//                {
//                    if (int.TryParse(txtId.Text, out var id))
//                    {
//                        var emprestimo = _emprestimoService.GetById<Emprestimo>(id);
//                        PreencheObjeto(emprestimo);
//                        emprestimo = _emprestimoService.Update<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
//                    }
//                }
//                else
//                {
//                    var emprestimo = new Emprestimo();
//                    PreencheObjeto(emprestimo);
//                    emprestimo = _emprestimoService.Add<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);
//                }

//                materialTabControl.SelectedIndex = 1;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        protected override void Deletar(int id)
//        {
//            try
//            {
//                _emprestimoService.Delete(id);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        protected override void CarregaGrid()
//        {
//            var includes = new List<string>() { "Cliente" };
//            emprestimos = _emprestimoService.Get<EmprestimoModel>(includes).ToList();
//            dataGridViewConsulta.DataSource = emprestimos;
//            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
//            dataGridViewConsulta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
//        }

//        protected override void CarregaRegistro(DataGridViewRow? linha)
//        {
//            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
//            txtId.Text = linha?.Cells["Id"].Value.ToString();
//            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
//            txtDataEmprestimo.Text = DateTime.TryParse(linha?.Cells["DataDevoulucao"].Value.ToString(), out var dataC)
//                 ? dataC.ToString("g")
//                 : "";

//            var includes = new List<string>() { "Cliente", "Empl", "Empl.Livro" };
//            var emprestimo = _empresitimoservice.GetById<Emprestimo>(id, includes);
//            _emprestimo_Livros = new List<EmprestimoModel>();
//            foreach (var empl in emprestimo.Empl)
//            {
//                var emprestimo_livro = new EmprestimoModel
//                {
//                    Id = empl.Id,
//                    IdCliente = empl.Cliente!.Id,
//                    Cliente = empl.Cliente!.Nome,
//                    DataDevolucao = empl.DataDevolucao,
//                    DataEmprestimo = empl.DataEmprestimo,

//                };
//                _emprestimo_Livros.Add(emprestimo_livro);
//            }
//            CarregaGridEmprestimoLivro();
//        }
//        private void CarregaGridEmprestimoLivro()
//        {
//            var source = new BindingSource();
//            source.DataSource = _emprestimo_Livro.ToArray();
//            dataGridViewItens.DataSource = source;
//            dataGridViewItens.Columns["Id"]!.Visible = false;
//            dataGridViewItens.Columns["IdLivro"]!.HeaderText = @"Id.Livro";
//            dataGridViewItens.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//        }
//   }
//}