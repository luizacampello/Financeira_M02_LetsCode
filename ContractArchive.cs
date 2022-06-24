using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public class ContractArchive
    {
        public List<ContratoPF> PFcontracts { get; private set; } = new List<ContratoPF>();
        public List<ContratoPJ> PJcontracts { get; private set; } = new List<ContratoPJ>();

        public void DisplayPFContractsList()
        {
            if (PFcontracts.Count > 0)
            {
                foreach (ContratoPF contract in PFcontracts)
                {
                    contract.ExibirInfo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(Messages.emptyPFContractsList);
            }
        }

        public void DisplayPJContractsList()
        {
            if (PJcontracts.Count > 0)
            {
                foreach (ContratoPJ contract in PJcontracts)
                {
                    contract.ExibirInfo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(Messages.emptyPJContractsList);
            }
        }

        public void NameSearchContrato(List <ContratoPJ> contractsList, string contratante)
        {
            bool found = false;
            foreach (ContratoPJ contract in contractsList)
            {
                if (contract.contratante == contratante)
                {
                    contract.ExibirInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(Messages.contratanteNotInContractsList);
            }
        }

        public void NameSearchContrato(List<ContratoPF> contractsList, string contratante)
        {
            bool found = false;
            foreach (ContratoPF contract in contractsList)
            {
                if (contract.contratante == contratante)
                {
                    contract.ExibirInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(Messages.contratanteNotInContractsList);
            }
        }

        public void CPFSearchContrato(string CPF)
        {
            bool found = false;
            foreach (ContratoPF contract in PFcontracts)
            {
                if (contract.CPF == CPF)
                {
                    contract.ExibirInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(Messages.CPFNotInContractsList);
            }
        }

        public void CNPJSearchContrato(string CNPJ)
        {
            bool found = false;
            foreach (ContratoPJ contract in PJcontracts)
            {
                if (contract.CNPJ == CNPJ)
                {
                    contract.ExibirInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(Messages.CNPJNotInContractsList);
            }
        }

        public void AddToContractList(ContratoPF newContract)
        {
            PFcontracts.Add(newContract);
        }

        public void AddToContractList(ContratoPJ newContract)
        {
            PJcontracts.Add(newContract);
        }
    }
}
