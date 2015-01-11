using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassJ : InterfaceQJ, InterfaceZJ
    {
        private InterfaceJK _k;
        public ClassJ(InterfaceJK k)
        {
            _k = k;
        }
        public void Method1()
        {
            //ClassK k = new ClassK();
            _k.Method1();
        }
    }
}
