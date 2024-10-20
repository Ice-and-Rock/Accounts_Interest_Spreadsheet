
<h2>DATA SCTRUCTURE</h2>
- InterestPaymentSchedule is basic. Only three fieilds currently exist. More can be added using switch case (or TimeDate).

*SCALEBAILITY*
- Think about interest payments based on frequency
    + take in the frequency and calculate the expected interest payments dynamically based on the current day
- Centralise Transactions IN/OUT in a seperate file
    + this will help mock the API calls required when selecting Account by UUID
- Think about a Service Layer to handle API fetch data from API's (TransactionService)
    + I should be able to swap between mock data and API data without changing core logic and functions(?)
- Dynamically support data being brought in using the TransactionService
    + specifically, calculated interest payments


<h2>BANKING API RESEARCH<h2>

Endpoints such as:
- ```/accounts/{accountId}```
```
{
    "accountId": "12345",
    "accountType": "savings",
    "currency": "USD",
    "balance": 10000.00,
    "interestRate": 1.5,
    "nextInterestPaymentDate": "2024-11-01"
    "nextInterestPaymentTime": ""
}
```

- ```/accounts/{accountId}/transactions```
```
{
    "transactions": [
        {
            "transactionId": "tx1",
            "date": "2024-10-10",
            "amount": 100.00,
            "description": "Deposit",
            "direction": "credit"
        },
        {
            "transactionId": "tx2",
            "date": "2024-10-12",
            "amount": 50.00,
            "description": "Withdrawal",
            "direction": "debit"
        }
    ]
}
```

- 