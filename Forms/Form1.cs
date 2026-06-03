using System.Diagnostics;
using ControleFinanceiro.Services;
using ControleFinanceiro.Models;
namespace ControleFinanceiro
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;
        public Form1()
        {
            InitializeComponent();
            RecarregarDashboard();
        }

        private void MostrarUltimasTransacoes()
        {
            lblWarning.Visible = false;
            DashboardService s = new DashboardService();
            List<Transacao> ultimas = s.UltimasTransacoes();
            if (ultimas.Count == 0)
            {
                lblWarning.Visible = true;
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ultimas;
            dataGridView1.Columns["Valor"].DefaultCellStyle.Format = "C2";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void MostrarReceitas()
        {
            DashboardService s = new DashboardService();
            decimal receita = s.CalcularReceitas();
            lblReceita.Text = receita.ToString("C2");
        }

        private void MostrarDespesas()
        {
            DashboardService s =new DashboardService();
            decimal despesa = s.CalcularDespesas();
            lblDespesa.Text = despesa.ToString("C2");
        }

        private void MostrarSaldo()
        {
            DashboardService s =new DashboardService();
            decimal despesa = s.CalcularDespesas();
            decimal receita = s.CalcularReceitas();
            decimal saldo = receita - despesa;
            lblsaldo.Text = saldo.ToString("C2");
        }

        private void RecarregarDashboard()
        {
            MostrarUltimasTransacoes();
            ColorirLinhas();
            MostrarReceitas();
            MostrarDespesas();
            MostrarSaldo();
        }

        
        private void ColorirLinhas()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string tipo = row.Cells["Tipo"].Value.ToString();

                if (tipo == "Receita")
                {
                    row.Cells["Valor"].Style.ForeColor = Color.Green;
                }
                else if (tipo == "Despesa")
                {
                    row.Cells["Valor"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
            RecarregarDashboard();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormShow(new FormCategorias());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveFormClose();
            RecarregarDashboard();
        }

        private void txtSaldoValue_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow(new FormTransações());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
