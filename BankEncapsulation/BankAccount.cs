using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        public BankAccount()
        {

        }

        private double _balence = 0;

        public double Deposit(double amount)
        {
            return _balence += amount;
        }
        public double Withdraw(double amount)
        {
            return _balence -= amount;
        }
        public double GetBalance()
        {
            return _balence;
        }







    }
    
}
