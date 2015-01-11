using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA : InterfaceA
    {
         private InterfaceAS _s;
         private InterfaceY _y;
         public ClassA(InterfaceAS s, InterfaceY y)
        {
            _s = s;
            _y = y;
        }
        public void Method1()
        {

        }

        public void Method2()
        {
            //ClassS s = new ClassS();
            _s.Method3();
            _s.Method1();
        }

        public void Method3()
        {
            //ClassY y = new ClassY();
            _y.Method2();
        }
    }
}
