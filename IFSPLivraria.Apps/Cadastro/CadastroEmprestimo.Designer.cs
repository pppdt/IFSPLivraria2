namespace IFSPLivraria.App.Cadastro
{
    partial class CadastroEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdcionar = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.cboLivro = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataEmprestimo = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 510);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtDataEmprestimo);
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Controls.Add(this.cboCliente);
            this.tabPageCadastro.Controls.Add(this.txtDataDevolucao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 475);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataDevolucao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCliente, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.groupBox1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataEmprestimo, 0);
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Size = new System.Drawing.Size(671, 416);
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(712, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(53, 48);
            this.txtId.TabIndex = 2;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.AllowPromptAsInput = true;
            this.txtDataDevolucao.AnimateReadOnly = false;
            this.txtDataDevolucao.AsciiOnly = false;
            this.txtDataDevolucao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataDevolucao.BeepOnError = false;
            this.txtDataDevolucao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataDevolucao.Depth = 0;
            this.txtDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataDevolucao.HidePromptOnLeave = false;
            this.txtDataDevolucao.HideSelection = true;
            this.txtDataDevolucao.Hint = "Data De Devolucao";
            this.txtDataDevolucao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataDevolucao.LeadingIcon = null;
            this.txtDataDevolucao.Location = new System.Drawing.Point(231, 24);
            this.txtDataDevolucao.Mask = "99/99/9999";
            this.txtDataDevolucao.MaxLength = 32767;
            this.txtDataDevolucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.PasswordChar = '\0';
            this.txtDataDevolucao.PrefixSuffixText = null;
            this.txtDataDevolucao.PromptChar = '_';
            this.txtDataDevolucao.ReadOnly = false;
            this.txtDataDevolucao.RejectInputOnFirstFailure = false;
            this.txtDataDevolucao.ResetOnPrompt = true;
            this.txtDataDevolucao.ResetOnSpace = true;
            this.txtDataDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataDevolucao.SelectedText = "";
            this.txtDataDevolucao.SelectionLength = 0;
            this.txtDataDevolucao.SelectionStart = 0;
            this.txtDataDevolucao.ShortcutsEnabled = true;
            this.txtDataDevolucao.Size = new System.Drawing.Size(250, 48);
            this.txtDataDevolucao.SkipLiterals = true;
            this.txtDataDevolucao.TabIndex = 12;
            this.txtDataDevolucao.TabStop = false;
            this.txtDataDevolucao.Text = "  /  /";
            this.txtDataDevolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataDevolucao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataDevolucao.TrailingIcon = null;
            this.txtDataDevolucao.UseSystemPasswordChar = false;
            this.txtDataDevolucao.ValidatingType = null;
            // 
            // cboCliente
            // 
            this.cboCliente.AutoResize = false;
            this.cboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCliente.Depth = 0;
            this.cboCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCliente.DropDownHeight = 174;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.DropDownWidth = 121;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Hint = "Cliente";
            this.cboCliente.IntegralHeight = false;
            this.cboCliente.ItemHeight = 43;
            this.cboCliente.Location = new System.Drawing.Point(6, 88);
            this.cboCliente.MaxDropDownItems = 4;
            this.cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(271, 49);
            this.cboCliente.StartIndex = 0;
            this.cboCliente.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdcionar);
            this.groupBox1.Controls.Add(this.dataGridViewLivros);
            this.groupBox1.Controls.Add(this.cboLivro);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(6, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emprestimo";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdcionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdcionar.Depth = 0;
            this.btnAdcionar.HighEmphasis = true;
            this.btnAdcionar.Icon = null;
            this.btnAdcionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAdcionar.Location = new System.Drawing.Point(545, 31);
            this.btnAdcionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdcionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdcionar.Size = new System.Drawing.Size(94, 36);
            this.btnAdcionar.TabIndex = 2;
            this.btnAdcionar.Text = "Adcionar";
            this.btnAdcionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdcionar.UseAccentColor = false;
            this.btnAdcionar.UseVisualStyleBackColor = true;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Location = new System.Drawing.Point(6, 76);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.RowTemplate.Height = 25;
            this.dataGridViewLivros.Size = new System.Drawing.Size(753, 180);
            this.dataGridViewLivros.TabIndex = 2;
            // 
            // cboLivro
            // 
            this.cboLivro.AutoResize = false;
            this.cboLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLivro.Depth = 0;
            this.cboLivro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLivro.DropDownHeight = 174;
            this.cboLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLivro.DropDownWidth = 121;
            this.cboLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboLivro.FormattingEnabled = true;
            this.cboLivro.Hint = "Livro";
            this.cboLivro.IntegralHeight = false;
            this.cboLivro.ItemHeight = 43;
            this.cboLivro.Location = new System.Drawing.Point(32, 21);
            this.cboLivro.MaxDropDownItems = 4;
            this.cboLivro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboLivro.Name = "cboLivro";
            this.cboLivro.Size = new System.Drawing.Size(253, 49);
            this.cboLivro.StartIndex = 0;
            this.cboLivro.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.HideSelection = true;
            this.txtQuantidade.Hint = "Quantidade";
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.Location = new System.Drawing.Point(373, 21);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PrefixSuffixText = null;
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(137, 48);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtDataEmprestimo
            // 
            this.txtDataEmprestimo.AllowPromptAsInput = true;
            this.txtDataEmprestimo.AnimateReadOnly = false;
            this.txtDataEmprestimo.AsciiOnly = false;
            this.txtDataEmprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataEmprestimo.BeepOnError = false;
            this.txtDataEmprestimo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataEmprestimo.Depth = 0;
            this.txtDataEmprestimo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataEmprestimo.HidePromptOnLeave = false;
            this.txtDataEmprestimo.HideSelection = true;
            this.txtDataEmprestimo.Hint = "DataEmprestimo";
            this.txtDataEmprestimo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataEmprestimo.LeadingIcon = null;
            this.txtDataEmprestimo.Location = new System.Drawing.Point(12, 24);
            this.txtDataEmprestimo.Mask = "99/99/9999";
            this.txtDataEmprestimo.MaxLength = 32767;
            this.txtDataEmprestimo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataEmprestimo.Name = "txtDataEmprestimo";
            this.txtDataEmprestimo.PasswordChar = '\0';
            this.txtDataEmprestimo.PrefixSuffixText = null;
            this.txtDataEmprestimo.PromptChar = '_';
            this.txtDataEmprestimo.ReadOnly = false;
            this.txtDataEmprestimo.RejectInputOnFirstFailure = false;
            this.txtDataEmprestimo.ResetOnPrompt = true;
            this.txtDataEmprestimo.ResetOnSpace = true;
            this.txtDataEmprestimo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataEmprestimo.SelectedText = "";
            this.txtDataEmprestimo.SelectionLength = 0;
            this.txtDataEmprestimo.SelectionStart = 0;
            this.txtDataEmprestimo.ShortcutsEnabled = true;
            this.txtDataEmprestimo.Size = new System.Drawing.Size(158, 48);
            this.txtDataEmprestimo.SkipLiterals = true;
            this.txtDataEmprestimo.TabIndex = 3;
            this.txtDataEmprestimo.TabStop = false;
            this.txtDataEmprestimo.Text = "  /  /";
            this.txtDataEmprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataEmprestimo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataEmprestimo.TrailingIcon = null;
            this.txtDataEmprestimo.UseSystemPasswordChar = false;
            this.txtDataEmprestimo.ValidatingType = null;
            // 
            // CadastroEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEmprestimo";
            this.Text = "CadastroEmprestimo";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboLivro;
        private DataGridView dataGridViewLivros;
        private ReaLTaiizor.Controls.MaterialButton btnAdcionar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataEmprestimo;
    }
}