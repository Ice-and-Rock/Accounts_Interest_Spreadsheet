<h1>PAGES PLAN</h1> 

*Home page - Bank accounts overview

Display: table

- date
- bank name
- current amount
- interest rate (current and projected. Maybe different colours?)
- daily interest (to nearest two decimal place)
- tomorrow projected amount
- end of month projected amount


*Account page - Specific account information

Display: account information at top, specific transactions in a table below.
    + include the UUID and data.bankName in the URL

- bank name
- current amount
- interest rate
- time of interest payment
- day of next interest payment
*different colour
- transactions IN 
- transactions OUT 



<h2>GOAL for 20/10/24</h2>
- refactor data set into two files to emulate "real world" data
    - AccountData.cs
        + sort out the currency type to fit with the type given in data >DONE
        + new daily/weekly/mponthly interest projections are now in View (not data Model) >DONE
        + This file should NOT contain logic for calculations >DONE
        + Move DummyData into a new file >DONE
    - TransactionData.cs

- Write a scaleable Services class
    - IAccountServices.cs (interface) >CHANGE
    - DummyAccountService.cs (dummy data service) >CHANGE
    - AccountService.cs (for real API calls) >DONE, using DummyData 

- Inject Services class into Startup.cs/Program.cs
    - use boolean statement to switch between DummyData or services from API
    - this boolean can be later changed in Environment or config files (changed in Git branch?)


