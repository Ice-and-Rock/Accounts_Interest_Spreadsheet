using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts_Interest_Spreadsheet.Models;
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
        public BankAccountData Account { get; set; }

        public IActionResult OnGet(string bankName, int id)
        {
            // Fetch the account data based on the id
            var allAccounts = BankAccountData.GenerateDummyData();
            Account = allAccounts.FirstOrDefault(a => a.Id == id); 

            // does account exist? 
            if (Account == null)
            {
                // retrun 404 error. Build proper error page later***
                return NotFound(); 
            }

            return Page(); 
        }
    }
}
