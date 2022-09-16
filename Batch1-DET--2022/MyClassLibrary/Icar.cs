
namespace MyClassLibrary
{
    internal interface Icar
    {
        int GetPrice(string name);
    }  
    class Bmw : Icar
    {
      
        public int Getprice(string name)
        {
            if (name == "F2")
                return 13000000;

            else if (name == "T5")
                return 12000000;
            else
                return 1000000;
        }

        public int GetPrice(string name)
        {
            throw new NotImplementedException();
        }
    }

}