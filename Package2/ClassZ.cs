using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassZ
    {
        private InterfaceZJ _j;
        private InterfaceZQ _q;
        public ClassZ(InterfaceZJ j, InterfaceZQ q)
        {
            _j = j;
            _q = q;
        }
        public void Method2()
        {
            //ClassJ j = new ClassJ();
            _j.Method1();

            //ClassQ q = new ClassQ();
            _q.Method3();
        }
    }
}
