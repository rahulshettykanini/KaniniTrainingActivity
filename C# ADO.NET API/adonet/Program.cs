using loan;
using System.Data.SqlClient;
class Program
{
    public static void Main(string[] args)
    {
        DB dB = new DB();
        dB.opening();


        Console.WriteLine("1.Customer\n2.Admin");
        int choice1 = Convert.ToInt32(Console.ReadLine());

        if (choice1 == 1)
        {
            //customer

            Console.WriteLine("1.New Customer\n2.Existing Customer");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1)
            {
                bool apply1 = true;
                while(apply1) 
                {

                    Console.WriteLine("1.Register\n2.Apply for loan \n3.See my applied loans\n4.Update my applied loans\n5.Delete the loan application ");
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    switch (choice3) 
                {
                        case 1: dB.insert1();
                            break;
                        case 2: dB.insert2();
                            break;
                        case 3: dB.select1();
                            break;
                        case 4: dB.update1();
                            break;
                        case 5:   dB.delete();
                            break;
                    }


                    Console.WriteLine("1.Continue \n 2.exit");
                    int cho = Convert.ToInt32(Console.ReadLine());
                    if (cho == 1)
                    {
                        apply1 = true;
                    }
                    if (cho == 2)
                    {
                        apply1 = false;
                    }
                }


            }
            else if (choice2 == 2) 
            {
                bool apply2 = true;
                while (apply2)
                {

                    Console.WriteLine("1.Apply for loan \n2.See my applied loans\n3.Update my applied loans\n4.Delete the loan application ");
                    int choice4 = Convert.ToInt32(Console.ReadLine());
                    switch (choice4)
                    {
                        
                        case 1:
                            dB.insert2();
                            break;
                        case 2:
                            dB.select1();
                            break;
                        case 3:
                            dB.update1();
                            break;
                        case 4:
                            dB.delete();
                            break;
                    }


                    Console.WriteLine("1.Continue \n 2.exit");
                    int choi = Convert.ToInt32(Console.ReadLine());
                    if (choi == 1)
                    {
                        apply2 = true;
                    }
                    if (choi == 2)
                    {
                        apply2 = false;
                    }
                }

            }


        }
        else if (choice1 == 2)
        {
            //admin

            Console.WriteLine("Enter the Admin Id");
            int adminId = Convert.ToInt32(Console.ReadLine());
            if (adminId == 3935)
            {
                bool choice = true;
                while (choice)
                {
                    Console.WriteLine("1.See all the loan applications\n2.See the pending applications\n3.Accept or Reject the application");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            dB.select2();
                            break;
                        case 2:
                            dB.select3();
                            break;
                        case 3:
                            dB.update2();
                            break;

                    }

                    Console.WriteLine("1.Continue \n 2.exit");
                    int cho = Convert.ToInt32(Console.ReadLine());
                    if (cho == 1)
                    {
                        choice = true;
                    }
                    if (cho == 2)
                    {
                        choice = false;
                    }
                }
            }
            else 
            {
                Console.WriteLine("Enter correct admin Id");
            }
        }
        else
        {
            return;
        }    


        dB.closing();

    }
}

