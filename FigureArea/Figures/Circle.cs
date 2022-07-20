using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Base
    {
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">радиус</param>
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public int Radius { get; private set; }
    }
}
