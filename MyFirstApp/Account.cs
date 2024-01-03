using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank{
    internal class Account{
        private float balance;
        public Account(float balance)
        {
            this.balance=balance;
        }
        public void SetBalance(float balance)
        {
            this.balance=balance;
        }
        public void Deposit(float amount){
            balance+=amount;
        }
        public void withdraw(float amount){
            balance-=amount;
        }
    }
}