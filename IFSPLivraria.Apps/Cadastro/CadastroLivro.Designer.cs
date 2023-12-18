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
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtAutor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtAnoProdrucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cboEditora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 383);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.cboEditora);
            this.tabPageCadastro.Controls.Add(this.txtAnoProdrucao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtAutor);
            this.tabPageCadastro.Controls.Add(this.txtTitulo);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 348);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtTitulo, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtAutor, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtAnoProdrucao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboEditora, 0);
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
            this.txtId.Location = new System.Drawing.Point(673, 23);
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
            this.txtId.Size = new System.Drawing.Size(89, 48);
            this.txtId.TabIndex = 15;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtAutor
            // 
            this.txtAutor.AnimateReadOnly = false;
            this.txtAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAutor.Depth = 0;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutor.HideSelection = true;
            this.txtAutor.Hint = "Autor";
            this.txtAutor.LeadingIcon = null;
            this.txtAutor.Location = new System.Drawing.Point(23, 77);
            this.txtAutor.MaxLength = 32767;
            this.txtAutor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.PrefixSuffixText = null;
            this.txtAutor.ReadOnly = false;
            this.txtAutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.ShortcutsEnabled = true;
            this.txtAutor.Size = new System.Drawing.Size(626, 48);
            this.txtAutor.TabIndex = 16;
            this.txtAutor.TabStop = false;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAutor.TrailingIcon = null;
            this.txtAutor.UseSystemPasswordChar = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AnimateReadOnly = false;
            this.txtTitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitulo.HideSelection = true;
            this.txtTitulo.Hint = "Titulo";
            this.txtTitulo.LeadingIcon = null;
            this.txtTitulo.Location = new System.Drawing.Point(23, 23);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PrefixSuffixText = null;
            this.txtTitulo.ReadOnly = false;
            this.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(626, 48);
            this.txtTitulo.TabIndex = 14;
            this.txtTitulo.TabStop = false;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitulo.TrailingIcon = null;
            this.txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtAnoProdrucao
            // 
            this.txtAnoProdrucao.AllowPromptAsInput = true;
            this.txtAnoProdrucao.AnimateReadOnly = false;
            this.txtAnoProdrucao.AsciiOnly = false;
            this.txtAnoProdrucao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAnoProdrucao.BeepOnError = false;
            this.txtAnoProdrucao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAnoProdrucao.Depth = 0;
            this.txtAnoProdrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnoProdrucao.HidePromptOnLeave = false;
            this.txtAnoProdrucao.HideSelection = true;
            this.txtAnoProdrucao.Hint = "Ano de Produção:";
            this.txtAnoProdrucao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAnoProdrucao.LeadingIcon = null;
            this.txtAnoProdrucao.Location = new System.Drawing.Point(23, 141);
            this.txtAnoProdrucao.Mask = "9999";
            this.txtAnoProdrucao.MaxLength = 32767;
            this.txtAnoProdrucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAnoProdrucao.Name = "txtAnoProdrucao";
            this.txtAnoProdrucao.PasswordChar = '\0';
            this.txtAnoProdrucao.PrefixSuffixText = null;
            this.txtAnoProdrucao.PromptChar = '_';
            this.txtAnoProdrucao.ReadOnly = false;
            this.txtAnoProdrucao.RejectInputOnFirstFailure = false;
            this.txtAnoProdrucao.ResetOnPrompt = true;
            this.txtAnoProdrucao.ResetOnSpace = true;
            this.txtAnoProdrucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnoProdrucao.SelectedText = "";
            this.txtAnoProdrucao.SelectionLength = 0;
            this.txtAnoProdrucao.SelectionStart = 0;
            this.txtAnoProdrucao.ShortcutsEnabled = true;
            this.txtAnoProdrucao.Size = new System.Drawing.Size(182, 48);
            this.txtAnoProdrucao.SkipLiterals = true;
            this.txtAnoProdrucao.TabIndex = 17;
            this.txtAnoProdrucao.TabStop = false;
            this.txtAnoProdrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAnoProdrucao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAnoProdrucao.TrailingIcon = null;
            this.txtAnoProdrucao.UseSystemPasswordChar = false;
            this.txtAnoProdrucao.ValidatingType = null;
            // 
            // cboEditora
            // 
            this.cboEditora.AutoResize = false;
            this.cboEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEditora.Depth = 0;
            this.cboEditora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEditora.DropDownHeight = 174;
            this.cboEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditora.DropDownWidth = 121;
            this.cboEditora.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEditora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.Hint = "Editora";
            this.cboEditora.IntegralHeight = false;
            this.cboEditora.ItemHeight = 43;
            this.cboEditora.Location = new System.Drawing.Point(23, 208);
            this.cboEditora.MaxDropDownItems = 4;
            this.cboEditora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(303, 49);
            this.cboEditora.StartIndex = 0;
            this.cboEditora.TabIndex = 18;
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroLivro";
            this.Text = "CadastroLivro";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAutor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAnoProdrucao;
        private ReaLTaiizor.Controls.MaterialComboBox cboEditora;
    }
}