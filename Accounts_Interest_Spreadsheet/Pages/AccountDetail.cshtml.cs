using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts_Interest_Spreadsheet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounts_Interest_Spreadsheet.Pages
{
    public class AccountDetailModel : PageModel
    {
        public BankAccountData Account { get; set; }

        public void OnGet(int id)
        {
            // Fetch the account data based on the id
            var allAccounts = BankAccountData.GenerateDummyData();
            Account = allAccounts.FirstOrDefault(a => a.Id == id); // Assuming you have Id property
        }
        private BankAccountData GetAccountById(int id)
        {
            // Logic to retrieve the account data based on the id from your data source
            return new BankAccountData { /* initialize as needed */ };
        }
    }
}