using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_Texto
{

    public partial class CarregarAnotacoes : Form
    {
        Form1 form1;
        public CarregarAnotacoes(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_fecharForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarAnotacoes_Load(object sender, EventArgs e)
        {
            dgv_formCarregar.DataSource = Banco.ObterNotas();
            dgv_formCarregar.Columns[0].Width = 100;

        }

        public void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (dgv_formCarregar.SelectedRows.Count > 0)
            {
                string textoSelecionado = dgv_formCarregar.SelectedRows[0].Cells["Seu texto"].Value.ToString();
                FontStyle fonte = (FontStyle)Enum.Parse(typeof(FontStyle), dgv_formCarregar.SelectedRows[0].Cells["Fonte"].Value.ToString());
                HorizontalAlignment alinhamento = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), dgv_formCarregar.SelectedRows[0].Cells["Alinhamento"].Value.ToString());
                Color corTexto = ColorTranslator.FromHtml(dgv_formCarregar.SelectedRows[0].Cells["CorTexto"].Value.ToString());

                form1.AtualizarRichTextBox(textoSelecionado, fonte, alinhamento, corTexto);

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione texto primeiro");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_formCarregar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_formCarregar.SelectedRows[0].Cells["ID"].Value);
                DialogResult res = MessageBox.Show("Deseja excluir este texto?", "Excluir", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Banco.DeletarNotas(id);
                    dgv_formCarregar.Rows.Remove(dgv_formCarregar.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }
    }
}
