using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;


namespace DepedencyInjection
{
    public static class BootStrapper
    {
        public static void Init()
        {   
            DependencyInjector.Register<IBL, BL>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
