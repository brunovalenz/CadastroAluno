namespace projeto4
{
    partial class Curso
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
            cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            txtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            materialTabControl1.Size = new Size(635, 523);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(cboTipo);
            tabPage1.Controls.Add(txtAno);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(627, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            cboTipo.AutoResize = false;
            cboTipo.BackColor = Color.FromArgb(255, 255, 255);
            cboTipo.Depth = 0;
            cboTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipo.DropDownHeight = 174;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.DropDownWidth = 121;
            cboTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Hint = "Tipo";
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 43;
            cboTipo.Items.AddRange(new object[] { "Técnico", "Tecnólogo", "Bacharelado", "Licenciatura" });
            cboTipo.Location = new Point(204, 64);
            cboTipo.Margin = new Padding(3, 4, 3, 4);
            cboTipo.MaxDropDownItems = 4;
            cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(225, 49);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 4;
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
            txtNome.Size = new Size(419, 48);
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
            tabPage2.Size = new Size(627, 490);
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
            dataGridView1.Size = new Size(621, 426);
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
            btnEditar.Location = new Point(458, 442);
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
            btnExcluir.Location = new Point(539, 442);
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
            btnNovo.Location = new Point(384, 442);
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
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(227, 132);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseCompatibleTextRendering = true;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(353, 132);
            btnSalvar.Margin = new Padding(5, 8, 5, 8);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseCompatibleTextRendering = true;
            btnSalvar.UseVisualStyleBackColor = true;
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
            txtID.Location = new Point(10, 120);
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
            txtID.TabIndex = 11;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.TrailingIcon = null;
            txtID.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AllowPromptAsInput = true;
            txtAno.AnimateReadOnly = false;
            txtAno.AsciiOnly = false;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.BeepOnError = false;
            txtAno.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAno.Depth = 0;
            txtAno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAno.HidePromptOnLeave = false;
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano de Criação";
            txtAno.InsertKeyMode = InsertKeyMode.Default;
            txtAno.LeadingIcon = null;
            txtAno.Location = new Point(6, 64);
            txtAno.Margin = new Padding(3, 4, 3, 4);
            txtAno.Mask = "9999/";
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.PromptChar = '_';
            txtAno.ReadOnly = false;
            txtAno.RejectInputOnFirstFailure = false;
            txtAno.ResetOnPrompt = true;
            txtAno.ResetOnSpace = true;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new Size(192, 48);
            txtAno.SkipLiterals = true;
            txtAno.TabIndex = 3;
            txtAno.TabStop = false;
            txtAno.Text = "    /";
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            txtAno.ValidatingType = null;
            // 
            // Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 590);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "Curso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Curso";
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
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtID;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAno;
    }
}