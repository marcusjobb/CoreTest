namespace CoreTest.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class BankAccountController
    {
        int balance = 0;

        public int Balance { get { return balance; } }


        [HttpGet(Name = "Deposit/{a}")]
        public int Deposit(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            balance += amount;
            return Balance;
        }

        [HttpGet(Name = "Withdraw/{a}")]
        public int Withdraw(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            balance -= amount;
            return Balance;
        }

    }
}
