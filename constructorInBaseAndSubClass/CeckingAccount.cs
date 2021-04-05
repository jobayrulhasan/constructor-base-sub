using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorInBaseAndSubClass
{
    class CeckingAccount: BankAccount
    {
        public CeckingAccount(string accountNo, string customerName, double serviceCharge) : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public double ServiceCharge { get; set; }
    }
}
