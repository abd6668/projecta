using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassV
    {
        private InterfaceVC _c;
        public ClassV(InterfaceVC c)
        {
            _c = c;
        }
        public void Method2()
        {
            //ClassC c = new ClassC();
            _c.Method1();
        }
    }
}
