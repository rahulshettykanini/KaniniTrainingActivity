
using Assignment2;

class program
{
    //Q1
    /*
    public static void Main(string[] args)
    {
        int[] animals = new int[3];
        Console.WriteLine("Enter the count of chickens");
        animals[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the count of cow");
        animals[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the count of pig");
        animals[2] = Convert.ToInt32(Console.ReadLine());

        Qstn1 qstn1= new Qstn1();
        Console.WriteLine(qstn1.calculate(animals[0], animals[1], animals[2]));
    }
    */
    //Q2
    /*
    public static void Main(string[] args)
    {
        int[] Football = new int[3];
        Console.WriteLine("Enter the count of Wins");
        Football[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the count of Draws");
        Football[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the count of Losses");
        Football[2] = Convert.ToInt32(Console.ReadLine());

        Qstn2 qstn2 = new Qstn2();
        Console.WriteLine(qstn2.calculate(Football[0], Football[1], Football[2]));
    }
    */
    //Q3
    /*
    public static void Main(string[] args)
    {
        double[] Game = new double[3];
        Console.WriteLine("Enter the count of Probability");
        Game[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the count of Prize");
        Game[1] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the count of Pay");
        Game[2] = Convert.ToDouble(Console.ReadLine());

        Qstn3 qstn3 = new Qstn3();
        Console.WriteLine(qstn3.calculate(Game[0], Game[1], Game[2]));
    }
    */

    //Q5
    /*
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the age");
        int age =  int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Break status");
        bool BreakStatus = bool.Parse(Console.ReadLine());

        Qstn5 qstn5 = new Qstn5();
        Console.WriteLine("\nShould Serve Drinks:" +qstn5.calculate(age, BreakStatus));
    }
    */

    //Q6
    /*
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter No Of Coffe Cups");
        int cups = int.Parse(Console.ReadLine());
        Qstn6 qstn6 = new Qstn6();
        Console.WriteLine("Total no of Coffe Cups:" +qstn6.calculate(cups));
    }
    */

    //Q4
    //
    /*
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the N value:");
        int n = int.Parse(Console.ReadLine());

        Qstn4 qstn4 = new Qstn4();
        Console.WriteLine("Total Number of cubes: " + qstn4.calculate(n));
    }
    */
    
    //Q7
    
    /*
    public static void Main(String[] args)
    {
        Qstn7 qstn7= new Qstn7();
        qstn7.calculate();
    }
    */

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of switches");
        Qstn8 qstn8 = new Qstn8();
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine( qstn8.calculate(s));
    }
}