using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea.Entities
{
    abstract class Shape
    {
        public Color Color { get; private set; }
        public abstract double Area();
    }
}
