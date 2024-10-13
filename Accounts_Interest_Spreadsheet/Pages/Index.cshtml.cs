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

        public List<BankAccountData> DisplayData { get; set; }

        public void OnGet() 
        {
            // Initialize DisplayData to avoid null reference exceptions
            DisplayData = BankAccountData.GenerateDummyData();
        }



        //public void OnPost()
        //{
        //    //Create a new BankAccountData object based on user input.Save this for later...

        //   var accountData = new BankAccountData
        //   {
        //       Date = DateTime.Today,
        //       CurrentAmount = Input.CurrentAmount,
        //       InterestRate = Input.InterestRate,
        //       TransactionsIn = Input.TransactionsIn,
        //       TransactionsOut = Input.TransactionsOut
        //   };

        //   // Add the new data to DisplayData
        //   DisplayData = new List<BankAccountData> { accountData };
            
        //}
    }
}
