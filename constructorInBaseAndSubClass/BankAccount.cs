using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorInBaseAndSubClass
{
    class BankAccount
    {
        public BankAccount(string accountNo, string customerName) : this() //Next constructor should be call
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }
        public BankAccount()
        {
            Balance = 0;
        }

        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Diposited";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }
    }
}
