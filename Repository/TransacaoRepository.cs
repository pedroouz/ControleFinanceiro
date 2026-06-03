using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ControleFinanceiro.Models;

namespace ControleFinanceiro.Repository
{
    internal class TransacaoRepository
    {
        string caminho = "Data/transacoes.json";

        public List<Transacao> ObterTodas()
        {
            if (!File.Exists(caminho))
            {
                return new List<Transacao>();
            }
            string json = File.ReadAllText(caminho, Encoding.UTF8);
            List<Transacao> transacoes = JsonSerializer.Deserialize<List<Transacao>>(json);
            return transacoes ?? new List<Transacao>();
        }

        public void Adicionar(Transacao transacao)
        {
            List<Transacao> transacoes = ObterTodas();
            transacoes.Add(transacao);
            transacao.id = GerarId(transacoes);
            Salvar(transacoes);
        }
        
        public void Deletar(int id)
        {
            List<Transacao> transacoes = ObterTodas();
            Transacao transacao = transacoes.Find(c => c.id == id);
            if (id == null)
            {
                return;
            }
            transacoes.Remove(transacao);
            Salvar(transacoes);
        }

        private int GerarId(List<Transacao> transacoes)
        {
            if(transacoes.Count == 0)
            {
                return 1;
            }
            else
            {
                return transacoes.Max(c => c.id) + 1;
            }
        }
        private void Salvar(List<Transacao> transacoes)
        {
            string json = JsonSerializer.Serialize(transacoes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, json, Encoding.UTF8);
        }

    }
}
