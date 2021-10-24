using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examo2
{
    class Abc:IShape,IPerson
    {
        int a = 7;
        public int Area {
            get
            {
                return a;
            }
            set {
                a = value;
            } }
        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
