using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassH : InterfaceHG
    {
        private InterfaceHG _g;
        public ClassH(InterfaceHG g)
        {
            _g = g;
        }
        public void Method2()
        {
            //ClassG g = new ClassG();
            _g.Method1();
        }

        public void Method1()
        {
            Method2();
        }
    }
}
