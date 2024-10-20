using System;
using System.Collections.Generic;
using System.Net.Http;
using Accounts_Interest_Spreadsheet.Models; 

namespace Accounts_Interest_Spreadsheet.Services
{
	public class AccountService
	{
        public List<AccountData> GetDummyData()
        {
            return AccountData.GenerateDummyData();
        }

        //public async Task<List<AccountData>> FetchBankDataAsync(string apiUrl)
        //{
        //    try
        //    {
        //        // Make a GET request to the API endpoint.
           
        //        // Deserialize the response content into a List of AccountData.
          
        //    }
        //    catch ()
        //    {
        //        // Handle errors in calling the API
        //   }
        //}

    }
}

