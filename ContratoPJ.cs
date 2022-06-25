using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public class ContratoPJ : Contrato
    {
        public string CNPJ { get; private set; }
        private string inscricaoEstadual { get; set; }

        public ContratoPJ(string contratante, decimal valor, int prazo, string CNPJ, string inscricaoEstadual)
        {
            contractId = Guid.NewGuid();
            base.contractor = contratante;
            base.value = valor;
            base.deadline = prazo;
            this.CNPJ = CNPJ;
            this.inscricaoEstadual = inscricaoEstadual;
        }

        protected override decimal CalcularPrestacao()
        {
            decimal prestacao = base.CalcularPrestacao() + 3;
            return decimal.Round(prestacao, 2);
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"ID do Contrato: {contractId}");
            Console.WriteLine($"Contratante: {contractor}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Inscrição Estadual: {inscricaoEstadual}");
            base.ExibirInfo();
            

        }
    }
}
