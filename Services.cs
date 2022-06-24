using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LMCFinanceira
{
    public static class Services
    {
        public const string MoneyPattern = @"(?=.*?\d)^\$?(([1-9]\d{0,2}(,\d{3})*)|\d+)?(\,\d{1,2})?$";

        public static void BeginFinanceiraProgram()
        {
            ContractArchive contractsArchive = new ContractArchive();
            
            MenuSelection(contractsArchive);
        }

        public static void MenuSelection(ContractArchive contractsArchive)
        {
            Console.Clear();
            Console.WriteLine(Messages.MainSelectionMenu);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":
                    Console.Clear();
                    SelectNewContractType(contractsArchive);
                    return;
                case "2":
                    Console.Clear();
                    SelectContractTypeToDisplay(contractsArchive);
                    return;
                case "3":
                    Console.Clear();
                    SelectContractTypeToSearch(contractsArchive);
                    return;
                case "4":
                    Console.Clear();
                    EndProgram();                  
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(Messages.invalidOption);
                    MenuSelection(contractsArchive);
                    return;
            }
        }

        static void SelectContractTypeToSearch(ContractArchive contractsArchive)
        {
            Console.WriteLine(Messages.searchHeaderMenu);
            Console.WriteLine(Messages.contractTypeSelection);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":
                    Console.Clear();
                    SelectSearchTypePFContracts(contractsArchive);
                    return;
                case "2":
                    Console.Clear();
                    SelectSearchTypePJContracts(contractsArchive);
                    return;
                case "3":
                    Console.Clear();
                    MenuSelection(contractsArchive);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(Messages.invalidOption);
                    SelectContractTypeToDisplay(contractsArchive);
                    return;
            }
        }

        static void SelectSearchTypePFContracts(ContractArchive contractsArchive)
        {
            Console.WriteLine(Messages.searchPFHeaderMenu);
            Console.WriteLine(Messages.PFContractSearchTypeSelection);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":
                    string contratante = NewContratante();
                    contractsArchive.NameSearchContrato(contractsArchive.PFcontracts, contratante);
                    ReturnProgram(contractsArchive);
                    return;
                case "2":
                    string cpf = NewCPF();
                    contractsArchive.CPFSearchContrato(cpf);
                    ReturnProgram(contractsArchive);
                    return;
                case "3":
                    SelectContractTypeToSearch(contractsArchive);
                    return;
                default:
                    Console.WriteLine(Messages.invalidOption);
                    SelectSearchTypePFContracts(contractsArchive);
                    return;
            }
        }

        static void SelectSearchTypePJContracts(ContractArchive contractsArchive)
        {
            Console.WriteLine(Messages.searchPFHeaderMenu);
            Console.WriteLine(Messages.PFContractSearchTypeSelection);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":
                    string contratante = NewContratante();
                    contractsArchive.NameSearchContrato(contractsArchive.PJcontracts, contratante);
                    ReturnProgram(contractsArchive);
                    return;
                case "2":
                    string cnpj = NewCNPJ();
                    contractsArchive.CNPJSearchContrato(cnpj);
                    ReturnProgram(contractsArchive);
                    return;
                case "3":
                    Console.Clear();
                    SelectContractTypeToSearch(contractsArchive);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(Messages.invalidOption);
                    SelectSearchTypePJContracts(contractsArchive);
                    return;
            }
        }

        static void SelectContractTypeToDisplay(ContractArchive contractsArchive)
        {
            Console.WriteLine(Messages.displayContractHeaderMenu);
            Console.WriteLine(Messages.contractTypeSelection);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":
                    contractsArchive.DisplayPFContractsList();
                    ReturnProgram(contractsArchive);
                    return;
                case "2":
                    contractsArchive.DisplayPJContractsList();
                    ReturnProgram(contractsArchive);
                    return;
                case "3":
                    MenuSelection(contractsArchive);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(Messages.invalidOption);
                    SelectContractTypeToDisplay(contractsArchive);
                    return;
            }
        }

        static void SelectNewContractType(ContractArchive contractsArchive)
        {
            Console.WriteLine(Messages.NewContractHeaderMenu);
            Console.WriteLine(Messages.contractTypeSelection);
            string UserSelection = UserInput();
            switch (UserSelection)
            {
                case "1":                 
                    NewPFContract(contractsArchive);
                    ReturnProgram(contractsArchive);
                    return;
                case "2":                    
                    NewPJContract(contractsArchive);
                    ReturnProgram(contractsArchive);
                    return;
                case "3":
                    MenuSelection(contractsArchive);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(Messages.invalidOption);
                    SelectNewContractType(contractsArchive);
                    return;
            }

        }

        static void NewPFContract(ContractArchive contractsArchive)
        {
            Console.Clear();
            Console.WriteLine(Messages.NewPFContractHeaderMenu);
            string contratante = "";
            DateTime birthDate = new ();
            int age = 0;

            while (age < 18)
            {
                contratante = NewContratante();
                birthDate = NewBirthDate();
                age = CalculateAge(birthDate);

                if (age < 18)
                {
                    Console.WriteLine(Messages.invalidAge);
                }
            }

            string CPF = NewCPF();
            decimal valor = NewValor();
            int prazo = NewPrazo();
            
            ContratoPF novoContratoPF = new ContratoPF(contratante, valor, prazo, CPF, birthDate, age);
            contractsArchive.AddToContractList(novoContratoPF);
            Console.WriteLine(Messages.sucessfullContract);
            novoContratoPF.ExibirInfo();
        }

        static void NewPJContract(ContractArchive contractsArchive)
        {
            Console.Clear();
            Console.WriteLine(Messages.NewPJContractHeaderMenu);
            string contratante = NewContratante();
            string CNPJ = NewCNPJ();
            string inscricaoEstadual = NewInscricaoEstadual();
            decimal valor = NewValor();
            int prazo = NewPrazo();

            ContratoPJ novoContratoPJ = new ContratoPJ(contratante, valor, prazo, CNPJ, inscricaoEstadual);
            contractsArchive.AddToContractList(novoContratoPJ);
            Console.WriteLine(Messages.sucessfullContract);
            novoContratoPJ.ExibirInfo();
        }

        static string NewContratante()
        {
            Console.Write(Messages.newEntryContratante);
            string userInput = UserInput();

            return userInput;
        }        

        static public decimal NewValor()
        {
            Console.Write(Messages.newEntryValor);
            string userInput = UserInput();
            userInput = userInput.Replace('.', ',');
            Regex MoneyRegex = new Regex(MoneyPattern);

            if (MoneyRegex.IsMatch(userInput))
            {
                bool isValidDecimal = decimal.TryParse(userInput, out decimal valor);
                if (isValidDecimal)
                {
                    return valor;
                }
            }

            Console.WriteLine(Messages.invalidInput);
            return NewValor();
        }

        static public int NewPrazo()
        {
            Console.Write(Messages.newEntryPrazo);
            bool isValidUserInput = int.TryParse(UserInput(), out int userInput);
            if (isValidUserInput)
            {
                if (userInput > 0)
                {
                    return userInput;
                }
            }
            Console.WriteLine(Messages.invalidInput);
            return NewPrazo();
        }

        static public string NewCPF()
        {
            Console.Write(Messages.newEntryCPF);
            string userInput = UserInput();
            userInput = FormatValidation.DocumentPontuationCleaner(userInput);

            if (FormatValidation.IsCPF(userInput))
            {
                return userInput;
            }
            Console.WriteLine(Messages.invalidInput);
            return NewCPF();
        }

        static public string NewCNPJ()
        {
            Console.Write(Messages.newEntryCNPJ);
            string userInput = UserInput();
            userInput = FormatValidation.DocumentPontuationCleaner(userInput);

            if (FormatValidation.IsCNPJ(userInput))
            {
                return userInput;
            }
            Console.WriteLine(Messages.invalidInput);
            return NewCNPJ();
        }

        static public DateTime NewBirthDate()
        {
            Console.Write(Messages.newEntryBirthDate);
            string userInput = UserInput();
            bool validDateFormat = DateTime.TryParse(userInput, out DateTime validDate);

            if (validDateFormat)
            {               
                return validDate;
            }
            Console.WriteLine(Messages.invalidInput);
            return NewBirthDate();
        }

        static public string NewInscricaoEstadual()
        {
            Console.Write(Messages.newEntryIE);
            string userInput = UserInput();
            userInput = FormatValidation.DocumentPontuationCleaner(userInput);
            bool isValidIE = FormatValidation.IsInscricaoEstadual(userInput);
            if (isValidIE)
            {
                return userInput;
            }
            Console.WriteLine(Messages.invalidInput);
            return NewInscricaoEstadual();

        }

        private static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age = age - 1;

            return age;
        }

        static string UserInput()
        {
            string userInput = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(userInput))
            {
                return userInput.Trim();
            }
            Console.WriteLine(Messages.invalidNullInput);
            return UserInput();
        }

        private static void EndProgram()
        {
            Console.WriteLine(Messages.endThanks);
            Console.WriteLine();
            Console.WriteLine(Messages.endEntryKey);
            Console.ReadKey();
            return;
        }

        private static void ReturnProgram(ContractArchive contractsArchive)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(Messages.returnEntryKey);
            Console.ReadKey();
            MenuSelection(contractsArchive);
            return;
        }

    }
}
