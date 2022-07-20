using FigureArea.Common;
using FigureArea.Figures;
using FigureArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Implementations
{
    /// <summary>
    /// Площадь круга
    /// </summary>
    public class CircleArea : IFigureAreaManager<Circle>
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <param name="figure">круг</param>
        /// <returns></returns>
        public double GetArea(Circle figure)
        {
            var area = Constants.PI * Math.Pow(figure.Radius, 2);
            return Math.Round(area, 2);
        }
    }
}
