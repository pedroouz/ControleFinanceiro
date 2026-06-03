using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Models;
using ControleFinanceiro.Forms;
using ControleFinanceiro.Repository;

namespace ControleFinanceiro
{
    public partial class FormTransações : Form
    {

        public FormTransações()
        {
            InitializeComponent();
            CarregarGrid();
            ColorirLinhas();
        }

        private void ApagarTransacao(int id)
        {
            TransacaoRepository TRepo = new TransacaoRepository();
            TRepo.Deletar(id);
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            TransacaoRepository TRepos = new TransacaoRepository();
            List<Transacao> transacoes = TRepos.ObterTodas();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["Valor"].DefaultCellStyle.Format = "C2";
            dataGridView1.DataSource = transacoes;
            ColorirLinhas();
            dataGridView1.ClearSelection();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNovaTransacao frm = new FormNovaTransacao();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void FormTransações_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ColorirLinhas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma transação. Se nao tiver uma crie porra!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            ApagarTransacao(id);
        }
    }
}
