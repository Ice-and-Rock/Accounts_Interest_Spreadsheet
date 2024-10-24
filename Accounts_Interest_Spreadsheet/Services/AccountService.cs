using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using Accounts_Interest_Spreadsheet.Data;
using Accounts_Interest_Spreadsheet.Models; 

namespace Accounts_Interest_Spreadsheet.Services
{
	public class AccountService
    {
        // Initialize _accounts using the dummy data
        private List<AccountData> _accounts = GenerateDummyAccountData.GetDummyAccounts();

        // Fetch all account data
        public List<AccountData> GetAccountData()
        {
            return _accounts;
        }

        // Fetch account by ID
        public AccountData GetAccountById(string accountId)
        {
            // Ensure _accounts is populated
            return _accounts.FirstOrDefault(a => a.AccountId == accountId);
        }
    }
}
// STUDY THIS. Creating a Var to store the accounts objects then mapping through seemed to work!
