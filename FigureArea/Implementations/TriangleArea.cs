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
    /// Площадь треугольника
    /// </summary>
    public class TriangleArea : IFigureAreaManager<Triangle>
    {
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <param name="figure">треугольник</param>
        /// <returns></returns>
        public double GetArea(Triangle figure)
        {
            List<int> listSides = new List<int>() { figure.FirstSide, figure.SecondSide, figure.ThirdSide };
            listSides = listSides.OrderByDescending(x => x).ToList();
            var largestSide = listSides[0];
            var isRightTriangle = Math.Pow(largestSide, 2) == (Math.Pow(listSides[1], 2) + Math.Pow(listSides[2], 2));

            if (isRightTriangle)//проверка, что треугольник прямоугольный
                return listSides[1] * listSides[2] / 2;
            else
            {
                var p = listSides.Sum() / 2;
                var area = Math.Sqrt(p * (p - listSides[0]) * (p - listSides[1]) * (p - listSides[2]));
                return Math.Round(area, 2);
            }
        }
    }
}
