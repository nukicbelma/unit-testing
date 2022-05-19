using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparky
{
    public class BankAccount
    {
        public int balance { get; set; }
        public readonly ILogBook _logbook;
        public BankAccount(ILogBook logbook)
        {
            balance = 0;
            _logbook = logbook;
        }
        public bool Deposit(int amount)
        {
            _logbook.Message("Deposit invoked.");
            _logbook.Message("Test");
            _logbook.LogSeverity = 101;
            var Temp = _logbook.LogSeverity;
            //_logbook.Message(""); //false
            balance += amount;
            return true;

        }
        public bool Withdraw(int amount)
        {
            if (amount <= balance)
            {
                _logbook.LogToDb("Withdrawl Amount: " + amount.ToString());
                balance -= amount;
                return _logbook.LogBalanceAfterWithdrawl(balance);
            }
            return _logbook.LogBalanceAfterWithdrawl(balance-amount);
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
