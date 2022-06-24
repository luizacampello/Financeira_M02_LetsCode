using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public abstract class Contrato
    {
        public Guid idContrato { get; set; }
        public string contratante { get; set; }
        public decimal valor { get; set; }
        public int prazo { get; set; }

        public virtual decimal CalcularPrestacao()
        {
            return valor / prazo;
        }

        public virtual void ExibirInfo()
        {
            
            Console.WriteLine($"Valor do contrato: {valor}");
            Console.WriteLine($"Prazo (meses): {prazo}");
            Console.WriteLine($"Valor da prestação: {CalcularPrestacao()}");
            Console.WriteLine();

        }
    }
}
