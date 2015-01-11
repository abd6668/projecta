using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    class ClassF
    {
        private InterfaceA _a;
       
        public ClassF(InterfaceA a)
        {
            _a = a;
        }


        public void Method1()
        {
            _a.Method2();
            _a.Method3();
        }

        public void Method2()
        {
            _a.Method3();
        }

        public void Method3()
        {
            _a.Method1();
        }
    }
}
