using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.PolimorfismoDeInclusion
{
    public class ClaseBase
    {
        public virtual void Metodo1()
        {
            Console.WriteLine("Metodo1() en ClaseBase");
        }
        public void Metodo2() 
        {
            Console.WriteLine("Metodo2() en ClaseBase");
        }
    }
}
