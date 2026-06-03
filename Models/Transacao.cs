using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Models
{
    public class Transacao
    {

        public int id { get; set; }
        public string tipo { get; set; }
        public string categoria { get; set; }
        public decimal valor {  get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; } 
    }

    
}
