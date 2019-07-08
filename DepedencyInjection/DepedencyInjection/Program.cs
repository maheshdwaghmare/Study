using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using BusinessLayer;

namespace DepedencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {   
            BootStrapper.Init();
            Initiator initiator = DependencyInjector.Retrieve<Initiator>();
            string data = initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
