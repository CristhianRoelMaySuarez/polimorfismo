using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.PolimorfismoDeInclusion
{
    public class ClaseDerivada : ClaseBase
    {
        public override void Metodo1()
        {
            Console.WriteLine("Metodo1() en ClaseDerivada");
        }
        public new void Metodo2() 
        {
            Console.WriteLine("Metodo2() en ClaseDerivada");
        }
    }

}
