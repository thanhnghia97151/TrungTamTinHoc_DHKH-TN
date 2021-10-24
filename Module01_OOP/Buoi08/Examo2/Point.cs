using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examo2
{
    
    abstract class Point
    {
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        //auto properties
        public int Z { get; set; }

        //abstract class và class Ko có đa kế thừa (đơn kế thừa)
        //Java, C# (bỏ python)
    }
}
