using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examo2
{
    interface IShape
    {
        //Ko có fileds
        // int a;
        //Có thể dùng đia kế thừa
        //Có properties trừu tượng
        //Ko phải là auto Properties => properties trừu tượng

        public int Area { get; set; }
        void DoSomeThing();
    }
}
