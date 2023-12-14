namespace Editor_Texto
{
    partial class CarregarAnotacoes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pn_carregaNotas = new Panel();
            btn_fecharForm = new Button();
            btn_excluir = new Button();
            btn_selecionar = new Button();
            dgv_formCarregar = new DataGridView();
            pn_carregaNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_formCarregar).BeginInit();
            SuspendLayout();
            // 
            // pn_carregaNotas
            // 
            pn_carregaNotas.Controls.Add(btn_fecharForm);
            pn_carregaNotas.Controls.Add(btn_excluir);
            pn_carregaNotas.Controls.Add(btn_selecionar);
            pn_carregaNotas.Dock = DockStyle.Bottom;
            pn_carregaNotas.Location = new Point(0, 413);
            pn_carregaNotas.Name = "pn_carregaNotas";
            pn_carregaNotas.Size = new Size(514, 38);
            pn_carregaNotas.TabIndex = 0;
            // 
            // btn_fecharForm
            // 
            btn_fecharForm.Location = new Point(336, 9);
            btn_fecharForm.Name = "btn_fecharForm";
            btn_fecharForm.Size = new Size(155, 23);
            btn_fecharForm.TabIndex = 2;
            btn_fecharForm.Text = "Fechar";
            btn_fecharForm.UseVisualStyleBackColor = true;
            btn_fecharForm.Click += btn_fecharForm_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(175, 9);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(155, 23);
            btn_excluir.TabIndex = 1;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_selecionar
            // 
            btn_selecionar.Location = new Point(14, 9);
            btn_selecionar.Name = "btn_selecionar";
            btn_selecionar.Size = new Size(155, 23);
            btn_selecionar.TabIndex = 0;
            btn_selecionar.Text = "Selecionar";
            btn_selecionar.UseVisualStyleBackColor = true;
            btn_selecionar.Click += btn_selecionar_Click;
            // 
            // dgv_formCarregar
            // 
            dgv_formCarregar.AllowUserToAddRows = false;
            dgv_formCarregar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_formCarregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_formCarregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_formCarregar.EnableHeadersVisualStyles = false;
            dgv_formCarregar.Location = new Point(0, -1);
            dgv_formCarregar.MultiSelect = false;
            dgv_formCarregar.Name = "dgv_formCarregar";
            dgv_formCarregar.ReadOnly = true;
            dgv_formCarregar.RowHeadersVisible = false;
            dgv_formCarregar.RowTemplate.Height = 25;
            dgv_formCarregar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_formCarregar.Size = new Size(514, 417);
            dgv_formCarregar.TabIndex = 1;
            // 
            // CarregarAnotacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 451);
            Controls.Add(dgv_formCarregar);
            Controls.Add(pn_carregaNotas);
            Name = "CarregarAnotacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Textos salvos";
            Load += CarregarAnotacoes_Load;
            pn_carregaNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_formCarregar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_carregaNotas;
        private DataGridView dgv_formCarregar;
        private Button btn_excluir;
        private Button btn_selecionar;
        private Button btn_fecharForm;
    }
}