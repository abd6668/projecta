using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassW
    {
        private IInterfaceSomething _something;
        private InterfaceY _y;
        public ClassW(IInterfaceSomething something, InterfaceY y)
        {
            _something = something;
            _y = y;
        }

        public int Method2()
        {
            return _y.Method2();
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }
    }
}
