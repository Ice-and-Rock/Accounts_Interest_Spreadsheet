using System;
using Accounts_Interest_Spreadsheet.Data;
using Accounts_Interest_Spreadsheet.Models;

namespace Accounts_Interest_Spreadsheet.Services
{
	public class TransactionService
	{
		public List<TransactionData> GetTransactionData(string accountId)
		{
			return GenerateDummyTransactionData.GetDummyTransactions(accountId);
		}
	}
}

