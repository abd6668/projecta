using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassO
    {
        private InterfaceOT _t;
        public ClassO(InterfaceOT t)
        {
            _t = t;
        }
        public void Method2()
        {
            //ClassT t = new ClassT(new ClassE());
            _t.Method2();
        }
    }
}
