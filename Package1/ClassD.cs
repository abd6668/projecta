using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassD
    {
        private InterfaceA _a;

        public ClassD(InterfaceA a)
        {
            _a = a;
        }

        public void Method1()
        {
            _a.Method3();
        }
    }
}
