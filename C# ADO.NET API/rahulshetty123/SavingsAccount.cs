using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingsAccount : CustomerInfo
    {
        private long accountNo;
        private double amount;
        private string branchname;
        private long ifsc_code;

        public SavingsAccount
            (int cust_id, string name, int age, string address, long accountNo, double amount, string branchname, long ifsc_code)
            : base(cust_id, name, age, address)
        {
            this.AccountNo = accountNo;
            this.Amount = amount;
            this.Branchname = branchname;
            this.Ifsc_code = ifsc_code;
        }

        public long AccountNo { get => accountNo; set => accountNo = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Branchname { get => branchname; set => branchname = value; }
        public long Ifsc_code { get => ifsc_code; set => ifsc_code = value; }

        public override void Display()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine(Cust_id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Address);
            Console.WriteLine("Savings Details");
            Console.WriteLine(AccountNo);
            Console.WriteLine(Amount);
            Console.WriteLine(Branchname);
            Console.WriteLine(Ifsc_code);
        }

    }
}
