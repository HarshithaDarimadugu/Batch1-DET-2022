using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public abstract string Sound();

    }
    public class Dog : Animal
    {
        public override string Sound()
        {
            return "BOW-BOW";
        }
    }

    public class Cat : Animal
    {
        public override string Sound()
        {
            return "MEOW-MEOW";
        }
    }

}