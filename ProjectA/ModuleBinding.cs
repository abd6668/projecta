using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package3;


namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterfaceSomething>().To<ClassM>();
            Bind<InterfaceAS>().To<ClassS>();
            Bind<InterfaceY>().To<ClassY>();
            Bind<InterfaceTX>().To<ClassX>();
            Bind<InterfaceXR>().To<ClassR>();
            Bind<InterfaceJK>().To<ClassK>();
            Bind<InterfaceOT>().To<ClassT>();
            Bind<InterfaceQJ>().To<ClassJ>();
            Bind<InterfaceVC>().To<ClassC>();
            Bind<InterfaceZJ>().To<ClassJ>();
            Bind<InterfaceZQ>().To<ClassQ>();
            Bind<InterfaceHG>().To<ClassNewG>();
            Bind<InterfaceA>().To<ClassA>();
            Bind<IInterfaceP>().To<ClassP>();
            Bind<IInterfaceE>().To<ClassE>();


        }
    }
}
