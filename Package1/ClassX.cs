using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassX : InterfaceTX
    {
        private InterfaceXR _r;

        public ClassX(InterfaceXR r)
        {
            _r = r;
        }
        public void Method1()
        {
            //ClassR r = new ClassR();
            _r.Method1();
        }
    }
}
