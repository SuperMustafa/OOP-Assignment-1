using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common_code
{
    public class Type_B
    {
        string FName = "Mustafa";
        string LName = "Hamad";
    
        public Type_B() { }


       public void Print_Name()
        {
            Console.WriteLine(FName + " " + LName);
        }
    }
}
