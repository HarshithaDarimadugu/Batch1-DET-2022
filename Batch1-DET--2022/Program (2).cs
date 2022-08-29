using ConsoleAppDemo;
using Exampleoops;

class MyClass
{
    enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    public static string GetGrade(int mark) //IN parameter
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "PASS";
        else
            return "FAIL";
    }
    public static void Main()
    {
        Manager m = new Manager(4671, "Karthika", new DateTime (2005, 5, 10), "techtrng", 10);  //default constructor
        Console.WriteLine(m.Print());

        Manager m1 = new Manager(2345, "Jeeva", new DateTime (2010, 1, 14), "PEMS", 450);
        Console.WriteLine(m1.Print());

        Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
        Console.WriteLine(e1.Print());

        Console.WriteLine("Enter the emp id");
        int  empid = Convert.ToInt32(Console.ReadLine());
        if (empid < 1001 || empid > 2500)
            throw  new InvalidEmpIdException("Entered empid is not in range...");

        Console.WriteLine("Enter the emp name");
        string name = Console.ReadLine();
       
        Console.WriteLine("Enter doj");
        DateTime doj = DateTime.Parse(Console.ReadLine());

        Emp e2 = new(empid, name, doj);



    }
}

