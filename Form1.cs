using System.Data;

namespace Editor_Texto
{
    public partial class Form1 : Form
    {
        private float valorZoom = 1.0f;
        public Form1()
        {
            InitializeComponent();
        }
        public void Salvar()
        {
            Anotacao anotacao = new Anotacao();
            anotacao.Texto = rtb_Form1.Text;
            anotacao.Fonte = rtb_Form1.SelectionFont.Style;
            anotacao.Alinhamento = rtb_Form1.SelectionAlignment;
            anotacao.CorTexto = rtb_Form1.SelectionColor;

            Banco.NovaNota(anotacao);
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Form1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Form1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void justificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Form1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonteAtual = rtb_Form1.SelectionFont;
            if (fonteAtual == null)
            {
                rtb_Form1.SelectionFont = new Font(rtb_Form1.Font, FontStyle.Bold);
            }
            else
            {
                FontStyle fonteEstilo = fonteAtual.Style ^ FontStyle.Bold;
                rtb_Form1.SelectionFont = new Font(fonteAtual, fonteEstilo);
            }
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonteAtual = rtb_Form1.SelectionFont;
            if (fonteAtual == null)
            {
                rtb_Form1.SelectionFont = new Font(rtb_Form1.Font, FontStyle.Italic);

            }
            else
            {
                FontStyle fonteEstilo = fonteAtual.Style ^ FontStyle.Italic;
                rtb_Form1.SelectionFont = new Font(fonteAtual, fonteEstilo);
            }
        }
        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonteAtual = rtb_Form1.SelectionFont;
            if (fonteAtual == null)
            {
                rtb_Form1.SelectionFont = new Font(rtb_Form1.Font, FontStyle.Underline);
            }
            else
            {
                FontStyle fonteEstilo = fonteAtual.Style ^ FontStyle.Underline;
                rtb_Form1.SelectionFont = new Font(fonteAtual, fonteEstilo);
            }
        }
        private void corDoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                rtb_Form1.SelectionColor = color;
            }
        }
        private void AlterarZoom(float zoom)
        {
            valorZoom += zoom;

            if (valorZoom < 0.1f)
                valorZoom = 0.1f;

            rtb_Form1.ZoomFactor = valorZoom;

            lb_controlaZoom.Text = $"{Math.Round(valorZoom * 100)}%";
        }
        private void aumentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarZoom(0.1f);
        }
        private void diminuirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarZoom(-0.1f);
        }
        private void restaurarPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorZoom = 1.0f;

            rtb_Form1.ZoomFactor = valorZoom;

            lb_controlaZoom.Text = $"{Math.Round(valorZoom * 100)}%";
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarAnotacoes carregarAnotacoes = new CarregarAnotacoes(this);
            carregarAnotacoes.ShowDialog();
        }
        public void AtualizarRichTextBox(string texto, FontStyle fonte, HorizontalAlignment alinhamento, Color corTexto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                rtb_Form1.Clear();

                rtb_Form1.Text = texto;

                rtb_Form1.SelectAll();
                rtb_Form1.SelectionFont = new Font(rtb_Form1.SelectionFont, rtb_Form1.SelectionFont.Style | fonte);
                rtb_Form1.DeselectAll();

                rtb_Form1.SelectionAlignment = alinhamento;

                rtb_Form1.SelectAll();
                rtb_Form1.SelectionColor = corTexto;

            }
            else
            {

                MessageBox.Show("O texto recebido está vazio ou nulo.");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Form1.Clear();
            rtb_Form1.Focus();
        }
    }
}