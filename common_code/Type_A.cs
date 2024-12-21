using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common_code
{
    public class Type_A
    {
        private int x = 10;
        public int y = 20;
        public Type_A() {
        
        Type_B type_B = new Type_B();
            type_B.Print_Name();
        
        }

       public void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
        
        
       
    }
}

