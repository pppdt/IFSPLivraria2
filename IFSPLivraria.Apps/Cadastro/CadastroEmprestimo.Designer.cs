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
            txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboLivro = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQtd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 301);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtQtd);
            tabPageCadastro.Controls.Add(cboLivro);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDataDevolucao);
            tabPageCadastro.Size = new Size(786, 266);
            tabPageCadastro.Controls.SetChildIndex(txtDataDevolucao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboLivro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQtd, 0);
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
            txtDataDevolucao.Hint = "Data de Devolucao";
            txtDataDevolucao.InsertKeyMode = InsertKeyMode.Default;
            txtDataDevolucao.LeadingIcon = null;
            txtDataDevolucao.Location = new Point(522, 18);
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
            txtDataDevolucao.Size = new Size(140, 48);
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
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(683, 18);
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
            txtId.Size = new Size(75, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente:";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(55, 27);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(425, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 13;
            // 
            // cboLivro
            // 
            cboLivro.AutoResize = false;
            cboLivro.BackColor = Color.FromArgb(255, 255, 255);
            cboLivro.Depth = 0;
            cboLivro.DrawMode = DrawMode.OwnerDrawVariable;
            cboLivro.DropDownHeight = 174;
            cboLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLivro.DropDownWidth = 121;
            cboLivro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLivro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLivro.FormattingEnabled = true;
            cboLivro.Hint = "Livro";
            cboLivro.IntegralHeight = false;
            cboLivro.ItemHeight = 43;
            cboLivro.Location = new Point(55, 82);
            cboLivro.MaxDropDownItems = 4;
            cboLivro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboLivro.Name = "cboLivro";
            cboLivro.Size = new Size(425, 49);
            cboLivro.StartIndex = 0;
            cboLivro.TabIndex = 14;
            // 
            // txtQtd
            // 
            txtQtd.AnimateReadOnly = false;
            txtQtd.AutoCompleteMode = AutoCompleteMode.None;
            txtQtd.AutoCompleteSource = AutoCompleteSource.None;
            txtQtd.BackgroundImageLayout = ImageLayout.None;
            txtQtd.CharacterCasing = CharacterCasing.Normal;
            txtQtd.Depth = 0;
            txtQtd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQtd.HideSelection = true;
            txtQtd.Hint = "Quantidade de emprestimo";
            txtQtd.LeadingIcon = null;
            txtQtd.Location = new Point(55, 137);
            txtQtd.MaxLength = 32767;
            txtQtd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQtd.Name = "txtQtd";
            txtQtd.PasswordChar = '\0';
            txtQtd.PrefixSuffixText = null;
            txtQtd.ReadOnly = false;
            txtQtd.RightToLeft = RightToLeft.No;
            txtQtd.SelectedText = "";
            txtQtd.SelectionLength = 0;
            txtQtd.SelectionStart = 0;
            txtQtd.ShortcutsEnabled = true;
            txtQtd.Size = new Size(231, 48);
            txtQtd.TabIndex = 15;
            txtQtd.TabStop = false;
            txtQtd.TextAlign = HorizontalAlignment.Left;
            txtQtd.TrailingIcon = null;
            txtQtd.UseSystemPasswordChar = false;
            // 
            // CadastroEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Location = new Point(0, 0);
            Name = "CadastroEmprestimo";
            Text = "CadastroEmprestimo";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboLivro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQtd;
    }
}