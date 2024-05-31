using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.ConceptosBasicos
{
    public class ClaseDerivada : ClaseBase
    {
        public new void Metodo1()
        {
            Console.WriteLine("Metodo1() en ClaseDerivada");
        }
        public new void Metodo2() 
        {
            Console.WriteLine("Metodo 2() en ClaseDerivada");
        }
    }
}
