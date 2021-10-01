using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam05
{
    abstract class Person
    { 
        public void DoSomeThing()
        {
            
        }
        //Phương thức trừu tượng
        //Ko cấn cài đặt nó
        //Lớp con kế thừa phải overide lại hàm này
        public abstract void DoThat();// Đây là phương thức trừu tượng, ko cần code cài đặt trong hàm, lớp con phải overide, (nếu lỗi phải có thêm public)

        //privite chỉ lớp đó nhìn thấy
        // protected -> để cho lớp con thấy biến ở lớp cha, sử base mới hiểu
        //internal tường tự public
        //abstact là 1 lóp trừu tượng, lớp con kế thừa phải overide
        //virtual dùng dể override

        //Delegate + Inheritant (dồn 2 hàm giống nhau lại)

        public double[] DosomeThing(double[] x, Func<double,double> func)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = func.Invoke(x[i]);
            }
            return y;
        }

        public virtual double[] Transform(double[] x) 
        {
            return DosomeThing(x, Calculate);
        }
        public abstract double Calculate(double v);
        
    }
}
