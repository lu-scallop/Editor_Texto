namespace Editor_Texto
{
    partial class Form1
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
            ms_Form1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            justificadoToolStripMenuItem = new ToolStripMenuItem();
            estiloDaFonteToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            corDoTextoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ampliarZoomToolStripMenuItem = new ToolStripMenuItem();
            aumentarToolStripMenuItem = new ToolStripMenuItem();
            diminuirToolStripMenuItem = new ToolStripMenuItem();
            restaurarPadrãoToolStripMenuItem = new ToolStripMenuItem();
            rtb_Form1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            pn_Form1 = new Panel();
            lb_controlaZoom = new Label();
            lb_Zoom = new Label();
            ms_Form1.SuspendLayout();
            pn_Form1.SuspendLayout();
            SuspendLayout();
            // 
            // ms_Form1
            // 
            ms_Form1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, formatarToolStripMenuItem, toolStripMenuItem1 });
            ms_Form1.Location = new Point(0, 0);
            ms_Form1.Name = "ms_Form1";
            ms_Form1.Size = new Size(514, 24);
            ms_Form1.TabIndex = 0;
            ms_Form1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, toolStripMenuItem2, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alinhamentoToolStripMenuItem, estiloDaFonteToolStripMenuItem, corDoTextoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { esquerdaToolStripMenuItem, direitaToolStripMenuItem, justificadoToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(151, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(122, 22);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(122, 22);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += direitaToolStripMenuItem_Click;
            // 
            // justificadoToolStripMenuItem
            // 
            justificadoToolStripMenuItem.Name = "justificadoToolStripMenuItem";
            justificadoToolStripMenuItem.Size = new Size(122, 22);
            justificadoToolStripMenuItem.Text = "Centro";
            justificadoToolStripMenuItem.Click += justificadoToolStripMenuItem_Click;
            // 
            // estiloDaFonteToolStripMenuItem
            // 
            estiloDaFonteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem });
            estiloDaFonteToolStripMenuItem.Name = "estiloDaFonteToolStripMenuItem";
            estiloDaFonteToolStripMenuItem.Size = new Size(151, 22);
            estiloDaFonteToolStripMenuItem.Text = "Estilo da Fonte";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(134, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(134, 22);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += itálicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(134, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // corDoTextoToolStripMenuItem
            // 
            corDoTextoToolStripMenuItem.Name = "corDoTextoToolStripMenuItem";
            corDoTextoToolStripMenuItem.Size = new Size(151, 22);
            corDoTextoToolStripMenuItem.Text = "Cor do texto...";
            corDoTextoToolStripMenuItem.Click += corDoTextoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ampliarZoomToolStripMenuItem, restaurarPadrãoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(48, 20);
            toolStripMenuItem1.Text = "Exibir";
            // 
            // ampliarZoomToolStripMenuItem
            // 
            ampliarZoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aumentarToolStripMenuItem, diminuirToolStripMenuItem });
            ampliarZoomToolStripMenuItem.Name = "ampliarZoomToolStripMenuItem";
            ampliarZoomToolStripMenuItem.Size = new Size(163, 22);
            ampliarZoomToolStripMenuItem.Text = "Zoom...";
            // 
            // aumentarToolStripMenuItem
            // 
            aumentarToolStripMenuItem.Name = "aumentarToolStripMenuItem";
            aumentarToolStripMenuItem.Size = new Size(127, 22);
            aumentarToolStripMenuItem.Text = "Aumentar";
            aumentarToolStripMenuItem.Click += aumentarToolStripMenuItem_Click;
            // 
            // diminuirToolStripMenuItem
            // 
            diminuirToolStripMenuItem.Name = "diminuirToolStripMenuItem";
            diminuirToolStripMenuItem.Size = new Size(127, 22);
            diminuirToolStripMenuItem.Text = "Diminuir";
            diminuirToolStripMenuItem.Click += diminuirToolStripMenuItem_Click;
            // 
            // restaurarPadrãoToolStripMenuItem
            // 
            restaurarPadrãoToolStripMenuItem.Name = "restaurarPadrãoToolStripMenuItem";
            restaurarPadrãoToolStripMenuItem.Size = new Size(163, 22);
            restaurarPadrãoToolStripMenuItem.Text = "Restaurar padrão";
            restaurarPadrãoToolStripMenuItem.Click += restaurarPadrãoToolStripMenuItem_Click;
            // 
            // rtb_Form1
            // 
            rtb_Form1.Location = new Point(0, 24);
            rtb_Form1.Name = "rtb_Form1";
            rtb_Form1.Size = new Size(516, 406);
            rtb_Form1.TabIndex = 1;
            rtb_Form1.Text = "";
            // 
            // pn_Form1
            // 
            pn_Form1.Controls.Add(lb_controlaZoom);
            pn_Form1.Controls.Add(lb_Zoom);
            pn_Form1.Dock = DockStyle.Bottom;
            pn_Form1.Location = new Point(0, 429);
            pn_Form1.Name = "pn_Form1";
            pn_Form1.Size = new Size(514, 22);
            pn_Form1.TabIndex = 2;
            // 
            // lb_controlaZoom
            // 
            lb_controlaZoom.AutoSize = true;
            lb_controlaZoom.Location = new Point(456, 5);
            lb_controlaZoom.Name = "lb_controlaZoom";
            lb_controlaZoom.Size = new Size(35, 15);
            lb_controlaZoom.TabIndex = 1;
            lb_controlaZoom.Text = "100%";
            // 
            // lb_Zoom
            // 
            lb_Zoom.AutoSize = true;
            lb_Zoom.Location = new Point(418, 5);
            lb_Zoom.Name = "lb_Zoom";
            lb_Zoom.Size = new Size(42, 15);
            lb_Zoom.TabIndex = 0;
            lb_Zoom.Text = "Zoom:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(514, 451);
            Controls.Add(pn_Form1);
            Controls.Add(rtb_Form1);
            Controls.Add(ms_Form1);
            MainMenuStrip = ms_Form1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Texto";
            ms_Form1.ResumeLayout(false);
            ms_Form1.PerformLayout();
            pn_Form1.ResumeLayout(false);
            pn_Form1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ms_Form1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripMenuItem justificadoToolStripMenuItem;
        private ToolStripMenuItem estiloDaFonteToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem ampliarZoomToolStripMenuItem;
        private ToolStripMenuItem restaurarPadrãoToolStripMenuItem;
        private ToolStripMenuItem corDoTextoToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Panel pn_Form1;
        private Label lb_controlaZoom;
        private Label lb_Zoom;
        private ToolStripMenuItem aumentarToolStripMenuItem;
        private ToolStripMenuItem diminuirToolStripMenuItem;
        public RichTextBox rtb_Form1;
    }
}