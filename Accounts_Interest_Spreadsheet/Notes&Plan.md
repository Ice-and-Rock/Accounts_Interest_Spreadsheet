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
    - TransactionData.cs

- Write a scaleable Services class
    - IAccountServices.cs (interface)
    - DummyAccountService.cs (dummy data service)
    - AccountService.cs (for real API calls)

- Inject Services class into Startup.cs/Program.cs
    - use boolean statement to switch between DummyData or services from API
    - this boolean can be later changed in Environment or config files (changed in Git branch?)

