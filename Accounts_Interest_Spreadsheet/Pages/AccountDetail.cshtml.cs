using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts_Interest_Spreadsheet.Models;
using Accounts_Interest_Spreadsheet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounts_Interest_Spreadsheet.Pages

// PLAN
    // Change data to include transactionsIn/TransactionsOut to be more detailed.
        // Research JSON formatting / LIST formatting to show transactions
    // change TransactionsIn to be monthly
    // change TransactionsOut to be monthly
    // Create a new table w/initial mock data
        // different colour from main details section


{
    public class AccountDetailModel : PageModel
    {
        public AccountData Account { get; set; }
        public List<TransactionData> Transactions { get; set; }

        private readonly TransactionService _transactionService;
        private readonly AccountService _accountService;

        public AccountDetailModel()
        {
            _transactionService = new TransactionService();
            _accountService = new AccountService(); // Assuming you have a service to fetch account data
        }

        public void OnGet(int id)
        {
            // Fetch the account based on ID (in this case 'id' would be the accountId)
            Account = _accountService.GetAccountById(id.ToString());
            

            // Fetch transactions for the account
            Transactions = _transactionService.GetTransactionData(id.ToString());
        }


// Below removed while I play with new Service design/page view **

        //public IActionResult OnGet(string bankName, int id)
        //{
        //    // Fetch the account data based on the id
        //    var allAccounts = BankAccountData.GenerateDummyData();
        //    Account = allAccounts.FirstOrDefault(a => a.Id == id); 

        //    // does account exist? 
        //    if (Account == null)
        //    {
        //        // retrun 404 error. Build proper error page later***
        //        return NotFound(); 
        //    }

        //    return Page(); 
        //}
    }
}
