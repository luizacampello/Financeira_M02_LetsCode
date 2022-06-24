using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMCFinanceira
{
	public static class Messages
	{
		public const string MainSelectionMenu = @"******** LMC Financeira ********
1 - Novo Contrato
2 - Exibir Contratos
3 - Buscar Contrato
4 - Encerrar
";

		public const string NewContractHeaderMenu = @"
******** Novo Contrato ********";

		public const string NewPFContractHeaderMenu = @"
******** Novo Contrato Pessoa Física ********";

		public const string NewPJContractHeaderMenu = @"
******** Novo Contrato Pessoa Jurídica ********";

		public const string displayContractHeaderMenu = @"
******** Exibir Contratos ********";

		public const string searchHeaderMenu = @"
******** Buscar Contrato ********";

		public const string searchPFHeaderMenu = @"
******** Busca Contrato Pessoa Física ********";

		public const string searchPJHeaderMenu = @"
******** Busca Contrato Pessoa Jurídica ********";

		public const string contractTypeSelection = @"
1 - Pessoa Física
2 - Pessoa Jurídica
3 - Retornar ao menu anterior
";

		public const string PFContractSearchTypeSelection = @"
1 - Nome contratante
2 - CPF
3 - Retornar ao menu anterior
";

		public const string PJContractSearchTypeSelection = @"
1 - Nome contratante
2 - CNPJ
3 - Retornar ao menu anterior
";

		public const string invalidOption = @"
Opção Inválida! Tente Novamente.
";

		public const string invalidNullInput = @"
Não é possível inserir um valor em branco. Tente Novamente.
";

		public const string invalidInput = @"
O valor inserido é inválido! Tente Novamente.
";

		public const string invalidAge = @"
A idade do contratante deve ser maior que 18. 
Cadastre novo contratante.
";

		public const string sucessfullContract = @"
Contrato criado com sucesso!
";
		public const string newEntryContratante = "Insira nome do contratante: ";
		public const string newEntryBirthDate = "Insira data de nascimento do contratante (Formato 01/01/2020): ";
		public const string newEntryIE = "Insira número da Inscrição Estadual: ";
		public const string newEntryCPF = "Insira número de CPF: ";
		public const string newEntryCNPJ = "Insira número do CNPJ: ";
		public const string newEntryPrazo = "Insira o prazo de pagamento (meses): ";
		public const string newEntryValor = "Insira o valor do contrato: ";

		public const string emptyPFContractsList = "Não existem contratos de Pessoa Física cadastrados.";
		public const string emptyPJContractsList = "Não existem contratos de Pessoa Jurídica cadastrados.";

		public const string contratanteNotInContractsList = "Não existem contratos cadastrados para esse contratante.";
		public const string CPFNotInContractsList = "Não existem contratos cadastrados para esse CPF.";
		public const string CNPJNotInContractsList = "Não existem contratos cadastrados para esse CNPJ.";

		public const string endThanks = "Obrigado por utilizar a LMC Financeira!";
		public const string endEntryKey = "Digite qualquer tecla para encerrar...";

		public const string returnEntryKey = "Digite qualquer tecla para retornar ao menu inicial     ";



	}
}
