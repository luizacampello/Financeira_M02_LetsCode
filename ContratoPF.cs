using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public class ContratoPF : Contrato
    {
        public string CPF { get; private set; }
        private DateTime birthDate { get; set; }
        private int age { get; set; }

        public ContratoPF(string contratante, decimal value, int deadline, string CPF, DateTime DataNascimento, int age)
        {
            contractId = Guid.NewGuid();
            base.contractor = contratante;
            base.value = value;
            base.deadline = deadline;
            this.CPF = CPF;
            this.birthDate = DataNascimento;
            this.age = age;
        }

        private int CalcularAdicional()
        {
            if (age <= 30)
            {
                return 1;
            }
            else if (age <= 40)
            {
                return 2;
            }
            else if (age <= 50)
            {
                return 3;
            }
            else
            {
                return 4;
            }

        }

        protected override decimal CalcularPrestacao()
        {
            int adicionalIdade = CalcularAdicional();
            decimal prestacao = base.CalcularPrestacao() + adicionalIdade;
            return decimal.Round(prestacao, 2);
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"ID do Contrato: {contractId}");
            Console.WriteLine($"Contratante: {contractor}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Data de Nascimento: {birthDate.ToString("dd/MM/yyyy")} ({age} anos)");
            base.ExibirInfo();
            
        }
    }
}
