using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Accounts_Interest_Spreadsheet.Models; 
using System;
using System.Collections.Generic;

namespace Accounts_Interest_Spreadsheet.Pages 
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        // The following lines are unued for data entry later on...
        //public BankAccountData Input { get; set; }

        //public List<BankAccountData> DisplayData { get; set; } //DummyData V1
        public List<AccountData> DisplayData { get; set; } //DummyData V2

        public void OnGet() 
        {
            // Initialize DisplayData to avoid null reference exceptions
            //DisplayData = BankAccountData.GenerateDummyData(); //DummyData V1
            DisplayData = AccountData.GenerateDummyData(); //DummyData V2
        }

    }
}
