using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassT : InterfaceOT
    {
        private IInterfaceE _ie;
        private InterfaceTX _x;
        public ClassT(IInterfaceE ie, InterfaceTX x)
        {
            _ie = ie;
            _x = x;
        }

        public void Method2()
        {
            //ClassX x = new ClassX();
            _x.Method1();

            _ie.Method5();
        }
    }
}
