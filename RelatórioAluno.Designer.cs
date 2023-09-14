namespace projeto4
{
    partial class RelatórioAluno
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
            this.bpFiltros = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gbAgrupamento = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gbImpressora = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            this.bpFiltros.SuspendLayout();
            this.gbAgrupamento.SuspendLayout();
            this.gbImpressora.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpFiltros
            // 
            this.bpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.bpFiltros.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bpFiltros.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bpFiltros.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bpFiltros.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.bpFiltros.Controls.Add(this.txtCidade);
            this.bpFiltros.Controls.Add(this.cboEstado);
            this.bpFiltros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bpFiltros.Location = new System.Drawing.Point(18, 81);
            this.bpFiltros.Name = "bpFiltros";
            this.bpFiltros.Size = new System.Drawing.Size(494, 121);
            this.bpFiltros.TabIndex = 0;
            this.bpFiltros.Text = "Filtros";
            // 
            // txtCidade
            // 
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.HideSelection = true;
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.Location = new System.Drawing.Point(17, 44);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PrefixSuffixText = null;
            this.txtCidade.ReadOnly = false;
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(311, 48);
            this.txtCidade.TabIndex = 2;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            this.cboEstado.AutoResize = false;
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEstado.Depth = 0;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEstado.DropDownHeight = 174;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.DropDownWidth = 121;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Hint = "Estado";
            this.cboEstado.IntegralHeight = false;
            this.cboEstado.ItemHeight = 43;
            this.cboEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(334, 44);
            this.cboEstado.MaxDropDownItems = 4;
            this.cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(145, 49);
            this.cboEstado.StartIndex = 0;
            this.cboEstado.TabIndex = 1;
            // 
            // gbAgrupamento
            // 
            this.gbAgrupamento.BackColor = System.Drawing.Color.Transparent;
            this.gbAgrupamento.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbAgrupamento.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gbAgrupamento.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.gbAgrupamento.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.gbAgrupamento.Controls.Add(this.cboAgrupamento);
            this.gbAgrupamento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbAgrupamento.Location = new System.Drawing.Point(18, 223);
            this.gbAgrupamento.Name = "gbAgrupamento";
            this.gbAgrupamento.Size = new System.Drawing.Size(493, 125);
            this.gbAgrupamento.TabIndex = 1;
            this.gbAgrupamento.Text = "Agrupamento";
            // 
            // cboAgrupamento
            // 
            this.cboAgrupamento.AutoResize = false;
            this.cboAgrupamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAgrupamento.Depth = 0;
            this.cboAgrupamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAgrupamento.DropDownHeight = 174;
            this.cboAgrupamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgrupamento.DropDownWidth = 121;
            this.cboAgrupamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAgrupamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAgrupamento.FormattingEnabled = true;
            this.cboAgrupamento.Hint = "Agrupamento";
            this.cboAgrupamento.IntegralHeight = false;
            this.cboAgrupamento.ItemHeight = 43;
            this.cboAgrupamento.Items.AddRange(new object[] {
            "Nenhum",
            "Cidade",
            "Estado"});
            this.cboAgrupamento.Location = new System.Drawing.Point(17, 46);
            this.cboAgrupamento.MaxDropDownItems = 4;
            this.cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAgrupamento.Name = "cboAgrupamento";
            this.cboAgrupamento.Size = new System.Drawing.Size(462, 49);
            this.cboAgrupamento.StartIndex = 0;
            this.cboAgrupamento.TabIndex = 2;
            // 
            // gbImpressora
            // 
            this.gbImpressora.BackColor = System.Drawing.Color.Transparent;
            this.gbImpressora.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbImpressora.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gbImpressora.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.gbImpressora.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.gbImpressora.Controls.Add(this.cboImpressora);
            this.gbImpressora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbImpressora.Location = new System.Drawing.Point(19, 372);
            this.gbImpressora.Name = "gbImpressora";
            this.gbImpressora.Size = new System.Drawing.Size(493, 125);
            this.gbImpressora.TabIndex = 2;
            this.gbImpressora.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressora";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(17, 46);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(462, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVisualizar.Depth = 0;
            this.btnVisualizar.HighEmphasis = true;
            this.btnVisualizar.Icon = null;
            this.btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVisualizar.Location = new System.Drawing.Point(408, 524);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(103, 36);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVisualizar.UseAccentColor = false;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnImprimir.Location = new System.Drawing.Point(288, 524);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(87, 36);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // RelatórioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 580);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.gbImpressora);
            this.Controls.Add(this.gbAgrupamento);
            this.Controls.Add(this.bpFiltros);
            this.Name = "RelatórioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatórioAluno";
            this.bpFiltros.ResumeLayout(false);
            this.gbAgrupamento.ResumeLayout(false);
            this.gbImpressora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ThunderGroupBox bpFiltros;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.ThunderGroupBox gbAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private ReaLTaiizor.Controls.ThunderGroupBox gbImpressora;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
    }
}