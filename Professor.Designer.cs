namespace projeto4
{
    partial class Professor
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
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataNasc = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereço = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.Margin = new Padding(3, 4, 3, 4);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1062, 492);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtAreaFormacao);
            tabPage1.Controls.Add(cboTitulacao);
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(cboEstado);
            tabPage1.Controls.Add(txtDataNasc);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtEndereço);
            tabPage1.Controls.Add(txtMatricula);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1054, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAreaFormacao
            // 
            txtAreaFormacao.AnimateReadOnly = false;
            txtAreaFormacao.AutoCompleteMode = AutoCompleteMode.None;
            txtAreaFormacao.AutoCompleteSource = AutoCompleteSource.None;
            txtAreaFormacao.BackgroundImageLayout = ImageLayout.None;
            txtAreaFormacao.CharacterCasing = CharacterCasing.Normal;
            txtAreaFormacao.Depth = 0;
            txtAreaFormacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAreaFormacao.HideSelection = true;
            txtAreaFormacao.Hint = "Área de Formação";
            txtAreaFormacao.LeadingIcon = null;
            txtAreaFormacao.LeaveOnEnterKey = true;
            txtAreaFormacao.Location = new Point(7, 232);
            txtAreaFormacao.Margin = new Padding(3, 4, 3, 4);
            txtAreaFormacao.MaxLength = 32767;
            txtAreaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAreaFormacao.Name = "txtAreaFormacao";
            txtAreaFormacao.PasswordChar = '\0';
            txtAreaFormacao.PrefixSuffixText = null;
            txtAreaFormacao.ReadOnly = false;
            txtAreaFormacao.RightToLeft = RightToLeft.No;
            txtAreaFormacao.SelectedText = "";
            txtAreaFormacao.SelectionLength = 0;
            txtAreaFormacao.SelectionStart = 0;
            txtAreaFormacao.ShortcutsEnabled = true;
            txtAreaFormacao.Size = new Size(575, 48);
            txtAreaFormacao.TabIndex = 8;
            txtAreaFormacao.TabStop = false;
            txtAreaFormacao.TextAlign = HorizontalAlignment.Left;
            txtAreaFormacao.TrailingIcon = null;
            txtAreaFormacao.UseSystemPasswordChar = false;
            // 
            // cboTitulacao
            // 
            cboTitulacao.AutoResize = false;
            cboTitulacao.BackColor = Color.FromArgb(255, 255, 255);
            cboTitulacao.Depth = 0;
            cboTitulacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboTitulacao.DropDownHeight = 174;
            cboTitulacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitulacao.DropDownWidth = 121;
            cboTitulacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTitulacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTitulacao.FormattingEnabled = true;
            cboTitulacao.Hint = "Titulação";
            cboTitulacao.IntegralHeight = false;
            cboTitulacao.ItemHeight = 43;
            cboTitulacao.Items.AddRange(new object[] { "Graduação", "Especialização", "Mestrado", "Doutorado" });
            cboTitulacao.Location = new Point(588, 232);
            cboTitulacao.Margin = new Padding(3, 4, 3, 4);
            cboTitulacao.MaxDropDownItems = 4;
            cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTitulacao.Name = "cboTitulacao";
            cboTitulacao.Size = new Size(241, 49);
            cboTitulacao.StartIndex = 0;
            cboTitulacao.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.AnimateReadOnly = false;
            txtID.AutoCompleteMode = AutoCompleteMode.None;
            txtID.AutoCompleteSource = AutoCompleteSource.None;
            txtID.BackgroundImageLayout = ImageLayout.None;
            txtID.CharacterCasing = CharacterCasing.Normal;
            txtID.Depth = 0;
            txtID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtID.HideSelection = true;
            txtID.Hint = "ID";
            txtID.LeadingIcon = null;
            txtID.LeaveOnEnterKey = true;
            txtID.Location = new Point(505, 315);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.MaxLength = 32767;
            txtID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtID.Name = "txtID";
            txtID.PasswordChar = '\0';
            txtID.PrefixSuffixText = null;
            txtID.ReadOnly = true;
            txtID.RightToLeft = RightToLeft.No;
            txtID.SelectedText = "";
            txtID.SelectionLength = 0;
            txtID.SelectionStart = 0;
            txtID.ShortcutsEnabled = true;
            txtID.Size = new Size(121, 48);
            txtID.TabIndex = 12;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.TrailingIcon = null;
            txtID.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(753, 327);
            btnSalvar.Margin = new Padding(5, 8, 5, 8);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseCompatibleTextRendering = true;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(647, 327);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseCompatibleTextRendering = true;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(682, 64);
            cboEstado.Margin = new Padding(3, 4, 3, 4);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(147, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 4;
            // 
            // txtDataNasc
            // 
            txtDataNasc.AllowPromptAsInput = true;
            txtDataNasc.AnimateReadOnly = false;
            txtDataNasc.AsciiOnly = false;
            txtDataNasc.BackgroundImageLayout = ImageLayout.None;
            txtDataNasc.BeepOnError = false;
            txtDataNasc.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNasc.Depth = 0;
            txtDataNasc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNasc.HidePromptOnLeave = false;
            txtDataNasc.HideSelection = true;
            txtDataNasc.Hint = "Data de nascimento";
            txtDataNasc.InsertKeyMode = InsertKeyMode.Default;
            txtDataNasc.LeadingIcon = null;
            txtDataNasc.Location = new Point(432, 64);
            txtDataNasc.Margin = new Padding(3, 4, 3, 4);
            txtDataNasc.Mask = "99/99/9999";
            txtDataNasc.MaxLength = 32767;
            txtDataNasc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.PasswordChar = '\0';
            txtDataNasc.PrefixSuffixText = null;
            txtDataNasc.PromptChar = '_';
            txtDataNasc.ReadOnly = false;
            txtDataNasc.RejectInputOnFirstFailure = false;
            txtDataNasc.ResetOnPrompt = true;
            txtDataNasc.ResetOnSpace = true;
            txtDataNasc.RightToLeft = RightToLeft.No;
            txtDataNasc.SelectedText = "";
            txtDataNasc.SelectionLength = 0;
            txtDataNasc.SelectionStart = 0;
            txtDataNasc.ShortcutsEnabled = true;
            txtDataNasc.Size = new Size(244, 48);
            txtDataNasc.SkipLiterals = true;
            txtDataNasc.TabIndex = 3;
            txtDataNasc.TabStop = false;
            txtDataNasc.Text = "  /  /";
            txtDataNasc.TextAlign = HorizontalAlignment.Left;
            txtDataNasc.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNasc.TrailingIcon = null;
            txtDataNasc.UseSystemPasswordChar = false;
            txtDataNasc.ValidatingType = null;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.LeaveOnEnterKey = true;
            txtBairro.Location = new Point(446, 176);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(383, 48);
            txtBairro.TabIndex = 7;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.LeaveOnEnterKey = true;
            txtCidade.Location = new Point(7, 176);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(431, 48);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtEndereço
            // 
            txtEndereço.AnimateReadOnly = false;
            txtEndereço.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereço.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereço.BackgroundImageLayout = ImageLayout.None;
            txtEndereço.CharacterCasing = CharacterCasing.Normal;
            txtEndereço.Depth = 0;
            txtEndereço.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereço.HideSelection = true;
            txtEndereço.Hint = "Endereço";
            txtEndereço.LeadingIcon = null;
            txtEndereço.LeaveOnEnterKey = true;
            txtEndereço.Location = new Point(7, 120);
            txtEndereço.Margin = new Padding(3, 4, 3, 4);
            txtEndereço.MaxLength = 32767;
            txtEndereço.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereço.Name = "txtEndereço";
            txtEndereço.PasswordChar = '\0';
            txtEndereço.PrefixSuffixText = null;
            txtEndereço.ReadOnly = false;
            txtEndereço.RightToLeft = RightToLeft.No;
            txtEndereço.SelectedText = "";
            txtEndereço.SelectionLength = 0;
            txtEndereço.SelectionStart = 0;
            txtEndereço.ShortcutsEnabled = true;
            txtEndereço.Size = new Size(822, 48);
            txtEndereço.TabIndex = 5;
            txtEndereço.TabStop = false;
            txtEndereço.TextAlign = HorizontalAlignment.Left;
            txtEndereço.TrailingIcon = null;
            txtEndereço.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matricula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.LeaveOnEnterKey = true;
            txtMatricula.Location = new Point(7, 64);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(419, 48);
            txtMatricula.TabIndex = 2;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.LeaveOnEnterKey = true;
            txtNome.Location = new Point(7, 8);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(822, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnExcluir);
            tabPage2.Controls.Add(btnNovo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1054, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Visualizar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1048, 385);
            dataGridView1.TabIndex = 20;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(886, 413);
            btnEditar.Margin = new Padding(5, 8, 5, 8);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseCompatibleTextRendering = true;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(967, 413);
            btnExcluir.Margin = new Padding(5, 8, 5, 8);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseCompatibleTextRendering = true;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(812, 413);
            btnNovo.Margin = new Padding(5, 8, 5, 8);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseCompatibleTextRendering = true;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // Professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 559);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "Professor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Professor";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtID;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNasc;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereço;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaFormacao;
    }
}