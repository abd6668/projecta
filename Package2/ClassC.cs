using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassC : InterfaceVC
    {
        internal void Method1()
        {
            
        }


        void InterfaceVC.Method1()
        {
            Method1();
        }
    }
}
