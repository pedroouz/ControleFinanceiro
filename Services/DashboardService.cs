using ControleFinanceiro.Models;
using ControleFinanceiro.Repository;
namespace ControleFinanceiro.Services
{
    internal class DashboardService
    {
        private TransacaoRepository TRepo = new TransacaoRepository();
        public List<Transacao> UltimasTransacoes()
        {
            List<Transacao> transacoes = TRepo.ObterTodas();
            if (transacoes.Count == 0)
            {
                return new List<Transacao>();
            }
            int tamanho_lista = transacoes.Count;
            int x = 5;
            int iInicial = tamanho_lista - x;
            if (tamanho_lista <= 5)
            {
                return transacoes;
            }
            List<Transacao> ultimasTransacoes = transacoes.GetRange(iInicial, x);
            ultimasTransacoes.Reverse();
            return ultimasTransacoes;
        }

        public decimal CalcularReceitas()
        {
            decimal totalreceita = 0;
            List<Transacao> transacoes = TRepo.ObterTodas();
            List<decimal> receitas = transacoes.Where(r => r.tipo == "Receita").Select(r => r.valor).ToList();
            if (receitas.Count == 0)
            {
                return 0;
            }
            foreach(decimal receita in receitas)
            {
                totalreceita += receita;
            }
            return totalreceita;
        }

        public decimal CalcularDespesas()
        {
            decimal totaldespesas = 0;
            List<Transacao> transacoes = TRepo.ObterTodas();
            List<decimal> despesas = transacoes.Where(d => d.tipo == "Despesa").Select(d => d.valor).ToList();
            if (despesas.Count == 0)
            {
                return 0;
            }
            foreach(decimal despesa in despesas)
            {
                totaldespesas += despesa;
            }
            return totaldespesas;
        }
    }
}
