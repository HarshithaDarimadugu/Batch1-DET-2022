
namespace MyClassLib
{
    public class employee1
    {
        int id;
        string name;
        string dept;
        double sal;
        public DateTime doj { get; set; }

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public employee1(int id, string name, DateTime doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public employee1()
        {
            id = -1; name = "no name";
        }
        public employee1(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public virtual string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }

    }
    internal interface ICar
    {
        int GetPrice(string name);
    }
    class Hyundai : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 1300000;
            else if (name == "x7")
                return 960000;
            else
                return 100000;
        }
    }
}
