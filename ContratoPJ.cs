using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public class ContratoPJ : Contrato
    {
        public string CNPJ;
        string inscricaoEstadual;

        public ContratoPJ(string contratante, decimal valor, int prazo, string CNPJ, string inscricaoEstadual)
        {
            idContrato = Guid.NewGuid();
            base.contratante = contratante;
            base.valor = valor;
            base.prazo = prazo;
            this.CNPJ = CNPJ;
            this.inscricaoEstadual = inscricaoEstadual;
        }

        public override decimal CalcularPrestacao()
        {
            decimal prestacao = base.CalcularPrestacao() + 3;
            return decimal.Round(prestacao, 2);
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"ID do Contrato: {idContrato}");
            Console.WriteLine($"Contratante: {contratante}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Inscrição Estadual: {inscricaoEstadual}");
            base.ExibirInfo();
            

        }
    }
}
