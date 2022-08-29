using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampleoops
{
    internal class CompanyManager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Print()
        {
            return $"Name={Name},Surname={Surname},Phone={Phone}";
        }
    }
}
