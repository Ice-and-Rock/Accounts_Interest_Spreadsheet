using System;

namespace Accounts_Interest_Spreadsheet.Models
{
    public class BankAccountData
    {
        public int Id { get; set; } // Unique identifier for the account!!
        public DateTime Date { get; set; }
        public string BankName { get; set; } = string.Empty; // initialises so it's not null
        public string BankLocation { get; set; } = string.Empty;
        public decimal CurrentAmount { get; set; }
        public decimal InterestRate { get; set;}
        public decimal TransactionsIn { get; set;}
        public decimal TransactionsOut {get; set; }

        // timeZoneInfo below finds the information! amazing.
        public TimeZoneInfo BankTimeZone { get; set; }

        //fields for interst payment schedule
        public DateTime NextInterestPaymentDate { get; set;}
        public TimeSpan NextInterestPaymentTime { get; set; } = TimeSpan.FromHours(24);


        // Calculated properties **CHECK
        public decimal DailyInterest => CalculateDailyInterest();
        public decimal TomorrowAmount => CalculateTomorrowAmount();
        public decimal EndOfMonthAmount => CalculateEndOfMonthAmount();  // CHECK, need a method?**

        private decimal CalculateDailyInterest()
        {
            // Daily interest calculation to two decimalls
            return Math.Round(CurrentAmount * (InterestRate / 100) / 365, 2); 
        }

        private decimal CalculateTomorrowAmount()
        {
            // returns the calculation rounding to two decimals for tomorrow's amount
                // This function must eventually:
                    // chasnge colour depending on Account.InterestPaymentSchedule (to show projected/actual amount)
                    // open a "Tooltip" box to show which days interest is paid (switch case) 
            return Math.Round(CurrentAmount + TransactionsIn - TransactionsOut + DailyInterest, 2);
        }

        public decimal CalculateEndOfMonthAmount()
        {
            // returns the projected end of month amount, based on current amount/interest/number of days in month
            return Math.Round(CurrentAmount + DailyInterest * 30); 
        }

        // Method to calculate the next interest payment date based on a given time/day set
        // CHECK these calculations are correct ⚠️
        private DateTime CalculateNextInterestPaymentDate(string paymentFrequency)
        {
            DateTime today = DateTime.Today;

            return paymentFrequency.ToLower() switch
            {
                "daily" => today.AddDays(1), 
                "threetimesaweek" => CalculateThreeTimesAWeek(today),
                "weekly" => today.AddDays(7), 
                _ => today.AddDays(1), // Default to daily if no valid option. Change colour of this in futuer?**
            };
        }

        // Function to calculate "three times a week" payment dat. 
        private DateTime CalculateThreeTimesAWeek(DateTime today)
        {
            // Assuming interest payments are on Monday, Wednesday, and Friday
            var dayOfWeek = today.DayOfWeek;

            return dayOfWeek switch
            {
                DayOfWeek.Monday => today.AddDays(2),   // Wednesday
                DayOfWeek.Wednesday => today.AddDays(2), // Friday
                DayOfWeek.Friday => today.AddDays(3),   // Next Monday
                _ => today.AddDays(1) // If the day is not Mon/Wed/Fri, default to next day
            };
        }






        // DUMMY DATA... basic version*
        // To be ammended to use variable integers from API fetch requests
        public static List<BankAccountData> GenerateDummyData()
        {
            return new List<BankAccountData>
{
new BankAccountData
        {
            Id = 1,
            BankName = "Bank A",
            BankLocation = "New York, USA",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 10000m,
            InterestRate = 2.5m,
            TransactionsIn = 0m,
            TransactionsOut = 1000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 2,
            BankName = "Bank B",
            BankLocation = "London, UK",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 20000m,
            InterestRate = 2.5m,
            TransactionsIn = 0m,
            TransactionsOut = 1000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        }
};

        }
        }
    }
