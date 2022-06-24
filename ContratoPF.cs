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
        private DateTime DataNascimento { get; set; }
        private int idade { get; set; }

        public ContratoPF(string contratante, decimal valor, int prazo, string CPF, DateTime DataNascimento, int idade)
        {
            idContrato = Guid.NewGuid();
            base.contratante = contratante;
            base.valor = valor;
            base.prazo = prazo;
            this.CPF = CPF;
            this.DataNascimento = DataNascimento;
            this.idade = idade;
        }

        private int CalcularAdicional()
        {
            if (idade <= 30)
            {
                return 1;
            }
            else if (idade <= 40)
            {
                return 2;
            }
            else if (idade <= 50)
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
            Console.WriteLine($"ID do Contrato: {idContrato}");
            Console.WriteLine($"Contratante: {contratante}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")} ({idade} anos)");
            base.ExibirInfo();
            
        }
    }
}
