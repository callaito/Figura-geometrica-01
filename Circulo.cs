using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

   
    public class Circulo : FiguraGeometrica
    {
        
        public double Radio { get; set; }
    

        public override double CalcularArea()
        {
            return 3.14 * Radio*2;
        }
        public override double CalcularPerimetro()
        {
            return 2*3.14*Radio;
        }   
        
    }
}
