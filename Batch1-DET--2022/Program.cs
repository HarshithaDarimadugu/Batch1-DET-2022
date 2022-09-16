// See https://aka.ms/new-console-template for more information

class Myclass
{
    enum Grade { Pass = 60, Distinction = 85};
    public static void Main()
    {
int empid;
int mark;

Console.WriteLine("Whats your empid?");
empid = int.Parse(Console.ReadLine());
Console.WriteLine("Hello World!");
Console.WriteLine($"thanks for giving your empid {empid}");

Console.WriteLine("Enter your TSQL mark?");
mark = Convert.ToInt32(Console.ReadLine());
if (mark>=(int) Grade.Distinction)
    {
            Console.WriteLine("You are in Distinction grade");

    }
else if(mark>=(int)Grade.Pass)
        {
            Console.WriteLine("You are in pass grade");

        }
else
        {
            Console.WriteLine("sorry, your grade is FAIL");
        }
    }
}

