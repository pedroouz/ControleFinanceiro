using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using ControleFinanceiro.Models;
namespace ControleFinanceiro.Repository
{
    internal class CategoriaRepository
    {
        private string caminho = "Data/categorias.json";
        
        public List<Categoria> ObterTodas()
        {
            if (!File.Exists(caminho))
            {
                return new List<Categoria>();
            }

            string json = File.ReadAllText(caminho);
            List<Categoria> categorias = JsonSerializer.Deserialize<List<Categoria>>(json);
            return categorias ?? new List<Categoria>();
        }

        public void Adicionar(Categoria categoria)
        {
            List<Categoria> categorias = ObterTodas();
            categoria.Id = GerarNovoId(categorias);
            categorias.Add(categoria);
            Salvar(categorias);
        }
       
        public bool Atualizar(Categoria categoriaAtualizada)
        {
            List<Categoria> categorias = ObterTodas();
            Categoria categoria = categorias.Find(c => c.Id == categoriaAtualizada.Id);
            if (categoria == null) 
            {
                return false;
            }

            categoria.Nome = categoriaAtualizada.Nome;
            Salvar(categorias);
            return true;
        }

        public void Deletar(int id)
        {
            List<Categoria> categorias = ObterTodas();
            Categoria categoria = categorias.Find(c => c.Id == id);
            if (categoria == null)
            {
                return;
            }
            categorias.Remove(categoria);
            Salvar(categorias);
        }

        private void Salvar(List<Categoria> categorias)
        {
            string json = JsonSerializer.Serialize(categorias, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, json, Encoding.UTF8);
        }
        private int GerarNovoId(List<Categoria> categorias)
        {
            if(categorias.Count == 0)
            {
                return 1;
            }
            else
            {
                return categorias.Max(c =>  c.Id) + 1;
            }
        }
    }
}
