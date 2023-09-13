namespace projeto4
{
    partial class principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            professorToolStripMenuItem = new ToolStripMenuItem();
            cursoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1322, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, professorToolStripMenuItem, cursoToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(82, 24);
            opçõesToolStripMenuItem.Text = "Cadastro";
            opçõesToolStripMenuItem.Click += opçõesToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(224, 26);
            cadastroToolStripMenuItem.Text = "Aluno";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // professorToolStripMenuItem
            // 
            professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            professorToolStripMenuItem.Size = new Size(224, 26);
            professorToolStripMenuItem.Text = "Professor";
            professorToolStripMenuItem.Click += professorToolStripMenuItem_Click;
            // 
            // cursoToolStripMenuItem
            // 
            cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            cursoToolStripMenuItem.Size = new Size(224, 26);
            cursoToolStripMenuItem.Text = "Curso";
            cursoToolStripMenuItem.Click += cursoToolStripMenuItem_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1328, 1011);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "principal";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += principal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem cursoToolStripMenuItem;
    }
}