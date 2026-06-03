using ControleFinanceiro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Models;
using ControleFinanceiro.Repository;

namespace ControleFinanceiro
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void CarregarCategorias()
        {
            label2.Visible = false;
            CategoriaRepository repo = new CategoriaRepository();
            List<Categoria> categorias = repo.ObterTodas();
            if (categorias.Count == 0)
            {
                label2.Visible = true;
                return;
            }
            CarregarGrid();
            dataGridView1.ClearSelection();
        }

        private void ApagarCategoria(int id)
        {
            CategoriaRepository repo = new CategoriaRepository();
            repo.Deletar(id);
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            CategoriaRepository repo = new CategoriaRepository();
            List<Categoria> categorias = repo.ObterTodas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categorias;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ClearSelection();
        }

        private void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNovaCategoria frm = new FrmNovaCategoria();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a categoria");
                return;
            }
            else
            { 
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                ApagarCategoria(id);
            }
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void FormCategorias_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
