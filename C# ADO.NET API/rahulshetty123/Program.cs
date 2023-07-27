
using Assignment3;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Customer Details\nEnter the Customer Id:");
        int cust_id = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Enter the customer name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Address");
        string address = Console.ReadLine();
        int Opinion = 3;
        while (Opinion != 0) { 
            Console.WriteLine("Enter 1 For Loan Account \nEnter 2 For Savings Account\nEnter 0 for exit");
            Opinion = Convert.ToInt32( Console.ReadLine());
            if (Opinion == 1) {
                Console.WriteLine("Enter the Loan Account");
                long loanAccountNo = Convert.ToInt64( Console.ReadLine());
                Console.WriteLine("Enter the Loan Amount");
                double loanAmount = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Enter the Loan Tenure In Years");
                int tenure_In_Years = Convert.ToInt32(Console.ReadLine());
                LoanAccount loanAccount = new LoanAccount(cust_id, name, age, address, loanAccountNo, loanAmount, tenure_In_Years);
                loanAccount.Display();
            }
            else if(Opinion == 2)
            {

                Console.WriteLine("Enter the Account number");
                long accountNo = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Account balance");
                double amount = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Branch name");
                string branchname = Console.ReadLine();
                Console.WriteLine("Enter the IFSC code");
                long ifsc_code = Convert.ToInt64(Console.ReadLine());
                SavingsAccount savingsAccount = new SavingsAccount(cust_id, name, age, address, accountNo, amount,  branchname,  ifsc_code);
                savingsAccount.Display();
            }

            else if (Opinion == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter the Correct Choice");
                continue;
            }

        }

    }
}