using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Accounts_Interest_Spreadsheet.Models;
using Accounts_Interest_Spreadsheet.Services;
using System;
using System.Collections.Generic;

namespace Accounts_Interest_Spreadsheet.Pages 
{
    public class IndexModel : PageModel
    {
        private readonly AccountService _accountService;
        [BindProperty]
        // The following lines are unued for data entry later on...
        //public BankAccountData Input { get; set; }

        //public List<BankAccountData> DisplayData { get; set; } //DummyData V1
        public List<AccountData> DisplayData { get; set; } //DummyData V2

        public IndexModel(AccountService accountService)
        {
            _accountService = accountService;
        }

        public void OnGet()
        {
            // Get dummy data
            DisplayData = _accountService.GetDummyData();
        }

        // REAL DATA Fetch here... 
        //public async Task OngetAsync()
        //{

        //    DisplayData = await _accountService.GetDummyData();
        //}

        // DummyData V1 **
        //public void OnGet() 
        //{
        //    // Initialize DisplayData to avoid null reference exceptions
        //    //DisplayData = BankAccountData.GenerateDummyData(); //DummyData V1
        //    DisplayData = AccountData.GenerateDummyData(); //DummyData V2
        //}

    }
}
