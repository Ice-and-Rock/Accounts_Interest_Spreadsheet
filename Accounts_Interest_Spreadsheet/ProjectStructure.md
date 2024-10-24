<h2>Quick re-cap file to show what different classes do...</h2>


<h3>Index.cshtml.cs</h3>

Defines...
AccountData.cs - defines the model of the account data

Calls...
AccountService.cs - calls the account services to request data


<h3>AccountService.cs</h3>

Creates a function called GetAccountData()

    > this produces a List using the <AccountData> model

    > returns GetDummyAccountData class 


<h3>GetDummyAccountData.cs</h3>

Creates a function called GetDummyAccounts()

    > this produces a List using the <AccountData> model

    > returns our mock data in a List format
