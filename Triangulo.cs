using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Triangulo : FiguraGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public double LadoC { get; set; }

        public override double CalcularArea()
        {
            return (LadoA + LadoB)/2;
        }
        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
