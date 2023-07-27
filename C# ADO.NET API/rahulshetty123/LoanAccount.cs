using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class LoanAccount : CustomerInfo
    {
        private long loanAccountNo;
        private double loanAmount;
        private int tenure_In_Years;

        public LoanAccount
            (int cust_id, string name, int age, string address,long loanAccountNo,double loanAmount,int tenure_In_Years)
            :base(cust_id,name,age,address) 
        {
            this.LoanAccountNo = loanAccountNo;
            this.LoanAmount = loanAmount;
            this.Tenure_In_Years= tenure_In_Years;

        }

        public long LoanAccountNo { get => loanAccountNo; set => loanAccountNo = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public int Tenure_In_Years { get => tenure_In_Years; set => tenure_In_Years = value; }

        public override void Display()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine(Cust_id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Address);
            Console.WriteLine("\nLoan Details");
            Console.WriteLine(LoanAccountNo);
            Console.WriteLine(LoanAmount);
            Console.WriteLine(Tenure_In_Years);
            
        }
    }
}
