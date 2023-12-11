namespace IFSPLivraria.App.Cadastro
{
    partial class CadastroLivro
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAnoProdrucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtAnoProdrucao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtTitulo);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtTitulo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEndereco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAnoProdrucao, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(671, 416);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(673, 23);
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
            txtId.Size = new Size(89, 48);
            txtId.TabIndex = 15;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Autor";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(23, 77);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(626, 48);
            txtEndereco.TabIndex = 16;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Titulo";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(23, 23);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(626, 48);
            txtTitulo.TabIndex = 14;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtAnoProdrucao
            // 
            txtAnoProdrucao.AllowPromptAsInput = true;
            txtAnoProdrucao.AnimateReadOnly = false;
            txtAnoProdrucao.AsciiOnly = false;
            txtAnoProdrucao.BackgroundImageLayout = ImageLayout.None;
            txtAnoProdrucao.BeepOnError = false;
            txtAnoProdrucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoProdrucao.Depth = 0;
            txtAnoProdrucao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnoProdrucao.HidePromptOnLeave = false;
            txtAnoProdrucao.HideSelection = true;
            txtAnoProdrucao.Hint = "Ano de Produção:";
            txtAnoProdrucao.InsertKeyMode = InsertKeyMode.Default;
            txtAnoProdrucao.LeadingIcon = null;
            txtAnoProdrucao.Location = new Point(23, 141);
            txtAnoProdrucao.Mask = "9999";
            txtAnoProdrucao.MaxLength = 32767;
            txtAnoProdrucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAnoProdrucao.Name = "txtAnoProdrucao";
            txtAnoProdrucao.PasswordChar = '\0';
            txtAnoProdrucao.PrefixSuffixText = null;
            txtAnoProdrucao.PromptChar = '_';
            txtAnoProdrucao.ReadOnly = false;
            txtAnoProdrucao.RejectInputOnFirstFailure = false;
            txtAnoProdrucao.ResetOnPrompt = true;
            txtAnoProdrucao.ResetOnSpace = true;
            txtAnoProdrucao.RightToLeft = RightToLeft.No;
            txtAnoProdrucao.SelectedText = "";
            txtAnoProdrucao.SelectionLength = 0;
            txtAnoProdrucao.SelectionStart = 0;
            txtAnoProdrucao.ShortcutsEnabled = true;
            txtAnoProdrucao.Size = new Size(182, 48);
            txtAnoProdrucao.SkipLiterals = true;
            txtAnoProdrucao.TabIndex = 17;
            txtAnoProdrucao.TabStop = false;
            txtAnoProdrucao.TextAlign = HorizontalAlignment.Left;
            txtAnoProdrucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoProdrucao.TrailingIcon = null;
            txtAnoProdrucao.UseSystemPasswordChar = false;
            txtAnoProdrucao.ValidatingType = null;
            // 
            // CadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroLivro";
            Text = "CadastroLivro";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAnoProdrucao;
    }
}