using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassQ : InterfaceZQ
    {
        private InterfaceQJ _j;
        public ClassQ(InterfaceQJ j)
        {
            _j = j;
        }
        public void Method3()
        {
            //ClassJ j = new ClassJ();
            _j.Method1();
        }
    }
}
