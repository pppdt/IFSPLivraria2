
using IFSPLivraria.App.Base;
using IFSPLivraria.App.Models;
using IFSPLivraria.Domain.Base;
using IFSPLivraria.Domain.Entities;
using IFSPLivraria.Service.Validators;


namespace IFSPLivraria.App.Cadastro
{
    public partial class CadastroEmprestimo : CadastroBase
    {

        private List<Emprestimo_LivroModel> _emprestimo_Livros;
        private readonly IBaseService<Emprestimo> _emprestimoService;
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Cliente> _clienteService;

        private List<EmprestimoModel>? emprestimos;

        public CadastroEmprestimo(IBaseService<Emprestimo> emprestimoService,
                             IBaseService<Livro> livroService,
                              IBaseService<Cliente> clienteService)

        {
            _emprestimoService = emprestimoService;
            _livroService = livroService;
            _clienteService = clienteService;
            _emprestimo_Livros = new List<Emprestimo_LivroModel>();
            InitializeComponent();
            CarregarCombo();
            Novo();
        }

        private void CarregarCombo()
        {

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboLivro.ValueMember = "Id";
            cboLivro.DisplayMember = "Titulo";
            cboLivro.DataSource = _livroService.Get<Cliente>().ToList();
        }
        //, Emprestimo_Livro emprestimo_Livro
        private void PreencheObjeto(Emprestimo emprestimo)
        {
            if (DateTime.TryParse(txtDataDevolucao.Text, out var dataDevolucao))
            {
                emprestimo.DataDevolucao = dataDevolucao;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                emprestimo.Cliente = cliente;
                
            }
            
            
            foreach (var empl in _emprestimo_Livros)
            {
                var emprestimoLivro = new Emprestimo_Livro
                {
                    Emprestimo = emprestimo,
                    Livro = _livroService.GetById<Livro>(empl.IdLivro),
                    Quantidade = empl.Quantidade
                };

                emprestimo.Empl.Add(emprestimoLivro);
            }
        }

        protected override void Novo()
        {
            base.Novo();
            _emprestimo_Livros.Clear();
            txtDataDevolucao.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                MessageBox.Show(ex.Message, @"IFSP Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridViewConsulta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            txtDataEmprestimo.Text = DateTime.TryParse(linha?.Cells["DataDevoulucao"].Value.ToString(), out var dataC)
                 ? dataC.ToString("g")
                 : "";

            var includes = new List<string>() { "Cliente", "Empl", "Empl.Livro" };
            var emprestimo = _emprestimoService.GetById<Emprestimo>(id, includes);
            _emprestimo_Livros = new List<Emprestimo_LivroModel>();
            foreach (var empl in emprestimo.Empl)
            {
                var emprestimo_livro = new EmprestimoModel
                {
                    Id = empl.Id,
                    IdCliente = empl.Cliente!.Id,
                    Cliente = empl.Cliente!.Nome,
                    DataDevolucao = empl.DataDevolucao,
                    DataEmprestimo = empl.DataEmprestimo,

                };
                _emprestimo_Livros.Add(emprestimo_livro);
                
            }
        }
        /*
        private void CarregaGridEmprestimoLivro()
        {
            var source = new BindingSource();
            source.DataSource = _emprestimo_Livro.ToArray();
            dataGridViewItens.DataSource = source;
            dataGridViewItens.Columns["Id"]!.Visible = false;
            dataGridViewItens.Columns["IdLivro"]!.HeaderText = @"Id.Livro";
            dataGridViewItens.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        */

        private ReaLTaiizor.Controls.MaterialComboBox cboLivro;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;

        private void InitializeComponent()
        {
            txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataEmprestimo = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtDataEmprestimo);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDataDevolucao);
            tabPageCadastro.Controls.SetChildIndex(txtDataDevolucao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataEmprestimo, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(671, 416);
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.AllowPromptAsInput = true;
            txtDataDevolucao.AnimateReadOnly = false;
            txtDataDevolucao.AsciiOnly = false;
            txtDataDevolucao.BackgroundImageLayout = ImageLayout.None;
            txtDataDevolucao.BeepOnError = false;
            txtDataDevolucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.Depth = 0;
            txtDataDevolucao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataDevolucao.HidePromptOnLeave = false;
            txtDataDevolucao.HideSelection = true;
            txtDataDevolucao.Hint = "Data Devolucao";
            txtDataDevolucao.InsertKeyMode = InsertKeyMode.Default;
            txtDataDevolucao.LeadingIcon = null;
            txtDataDevolucao.Location = new Point(60, 164);
            txtDataDevolucao.Mask = "99/99/9999";
            txtDataDevolucao.MaxLength = 32767;
            txtDataDevolucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.PasswordChar = '\0';
            txtDataDevolucao.PrefixSuffixText = null;
            txtDataDevolucao.PromptChar = '_';
            txtDataDevolucao.ReadOnly = false;
            txtDataDevolucao.RejectInputOnFirstFailure = false;
            txtDataDevolucao.ResetOnPrompt = true;
            txtDataDevolucao.ResetOnSpace = true;
            txtDataDevolucao.RightToLeft = RightToLeft.No;
            txtDataDevolucao.SelectedText = "";
            txtDataDevolucao.SelectionLength = 0;
            txtDataDevolucao.SelectionStart = 0;
            txtDataDevolucao.ShortcutsEnabled = true;
            txtDataDevolucao.Size = new Size(250, 48);
            txtDataDevolucao.SkipLiterals = true;
            txtDataDevolucao.TabIndex = 11;
            txtDataDevolucao.TabStop = false;
            txtDataDevolucao.Text = "  /  /";
            txtDataDevolucao.TextAlign = HorizontalAlignment.Left;
            txtDataDevolucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.TrailingIcon = null;
            txtDataDevolucao.UseSystemPasswordChar = false;
            txtDataDevolucao.ValidatingType = null;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(593, 25);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(48, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDataEmprestimo
            // 
            txtDataEmprestimo.AllowPromptAsInput = true;
            txtDataEmprestimo.AnimateReadOnly = false;
            txtDataEmprestimo.AsciiOnly = false;
            txtDataEmprestimo.BackgroundImageLayout = ImageLayout.None;
            txtDataEmprestimo.BeepOnError = false;
            txtDataEmprestimo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.Depth = 0;
            txtDataEmprestimo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataEmprestimo.HidePromptOnLeave = false;
            txtDataEmprestimo.HideSelection = true;
            txtDataEmprestimo.Hint = "Data Emprestimo";
            txtDataEmprestimo.InsertKeyMode = InsertKeyMode.Default;
            txtDataEmprestimo.LeadingIcon = null;
            txtDataEmprestimo.Location = new Point(60, 231);
            txtDataEmprestimo.Mask = "99/99/9999";
            txtDataEmprestimo.MaxLength = 32767;
            txtDataEmprestimo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataEmprestimo.Name = "txtDataEmprestimo";
            txtDataEmprestimo.PasswordChar = '\0';
            txtDataEmprestimo.PrefixSuffixText = null;
            txtDataEmprestimo.PromptChar = '_';
            txtDataEmprestimo.ReadOnly = false;
            txtDataEmprestimo.RejectInputOnFirstFailure = false;
            txtDataEmprestimo.ResetOnPrompt = true;
            txtDataEmprestimo.ResetOnSpace = true;
            txtDataEmprestimo.RightToLeft = RightToLeft.No;
            txtDataEmprestimo.SelectedText = "";
            txtDataEmprestimo.SelectionLength = 0;
            txtDataEmprestimo.SelectionStart = 0;
            txtDataEmprestimo.ShortcutsEnabled = true;
            txtDataEmprestimo.Size = new Size(250, 48);
            txtDataEmprestimo.SkipLiterals = true;
            txtDataEmprestimo.TabIndex = 13;
            txtDataEmprestimo.TabStop = false;
            txtDataEmprestimo.Text = "  /  /";
            txtDataEmprestimo.TextAlign = HorizontalAlignment.Left;
            txtDataEmprestimo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.TrailingIcon = null;
            txtDataEmprestimo.UseSystemPasswordChar = false;
            txtDataEmprestimo.ValidatingType = null;
            // 
            // CadastroEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(685, 518);
            Location = new Point(0, 0);
            Name = "CadastroEmprestimo";
            tabPageCadastro.ResumeLayout(false);
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataEmprestimo;
    }
}
