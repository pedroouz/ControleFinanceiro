using ControleFinanceiro.Models;
using System.Text.Json;
using System.Text.Encodings;
using ControleFinanceiro.Models;
using ControleFinanceiro.Repository;
using System.Globalization;
namespace ControleFinanceiro.Forms
{
    public partial class FormNovaTransacao : Form
    {

        public FormNovaTransacao()
        {
            InitializeComponent();
        }

        public void CriarNovaTransacao(Transacao transacao)
        {
            TransacaoRepository TRepos = new TransacaoRepository();
            TRepos.Adicionar(transacao);
            MessageBox.Show("Transação criada com sucesso!");
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxTipo.Text == "" || cboxCategoria.Text == "" || mtbData.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                Transacao transacao = new Transacao();
                transacao.tipo = cboxTipo.Text;
                transacao.categoria = cboxCategoria.Text;
                CultureInfo cultura = new CultureInfo("pt-BR");
                if(decimal.TryParse(txtValor.Text,cultura , out decimal valor))
                {
                    transacao.valor = valor;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                }
                if (!mtbData.MaskCompleted)
                {
                    MessageBox.Show("Data inválida!");
                    return;
                }
                transacao.data = Convert.ToDateTime(mtbData.Text);
                if (txtDescricao.Text == null || txtDescricao.Text == "")
                {
                    transacao.descricao = "Sem descrição";
                }
                else
                {
                    transacao.descricao = txtDescricao.Text;
                }
                CriarNovaTransacao(transacao);
            }
            this.Close();
        }
        private void FormNovaTransacao_Load(object sender, EventArgs e)
        {
            CategoriaRepository CRepo = new CategoriaRepository();
            List<Categoria> categorias = CRepo.ObterTodas();
            cboxCategoria.DataSource = null;
            cboxCategoria.DataSource = categorias;
            cboxCategoria.DisplayMember = "Nome";
            cboxCategoria.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txt.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void mtbData_Click(object sender, EventArgs e)
        {
            mtbData.SelectionStart = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mtbData.Text = DateTime.Now.ToString();
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (decimal.TryParse(
                txt.Text.Replace("R$", "").Trim(),
                out decimal valor))
            {
                txt.Text = valor.ToString("0.00");
            }
        }
    }
}
