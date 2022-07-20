using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Base
    {
        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">первая сторона</param>
        /// <param name="secondSide">вторая сторона</param>
        /// <param name="thirdSide">третья сторона</param>
        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public int FirstSide { get; private set; }
        public int SecondSide { get; private set; }
        public int ThirdSide { get; private set; }
    }
}
