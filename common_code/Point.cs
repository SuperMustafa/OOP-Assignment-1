using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common_code
{
    public struct point
    {
        public int x;
        public int y;

      public point()
        {
            x = 10;
            y = 10;

        }

        public point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public point(int z)
        {
            this.x = z;
            this.y = z;
        }

    }
}
