using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using ControleFinanceiro.Models;
using ControleFinanceiro.Repository;
namespace ControleFinanceiro.Forms
{
    public partial class FrmNovaCategoria : Form
    {
        public FrmNovaCategoria()
        {
            InitializeComponent();
        }

        private void CriarNovaCategoria(string nome)
        {
            CategoriaRepository repo = new CategoriaRepository();
            Categoria categoria = new Categoria();
            categoria.Nome = nome;
            repo.Adicionar(categoria);
            MessageBox.Show("Categoria criada com sucesso! Por favor atualize a página." );
        }

        private void FrmNovaCategoria_Load(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                string nome = txtNome.Text;
                CriarNovaCategoria(nome);
                this.Close();
            }
        }
    }
}
