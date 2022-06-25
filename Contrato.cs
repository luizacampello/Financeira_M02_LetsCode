using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public abstract class Contrato
    {
        protected Guid contractId { get; set; }
        public string contractor { get; protected set; }
        protected decimal value { get; set; }
        protected int deadline { get; set; }

        protected virtual decimal CalcularPrestacao()
        {
            return value / deadline;
        }

        public virtual void ExibirInfo()
        {
            
            Console.WriteLine($"Valor do contrato: {value}");
            Console.WriteLine($"Prazo (meses): {deadline}");
            Console.WriteLine($"Valor da prestação: {CalcularPrestacao()}");
            Console.WriteLine();

        }
    }
}
