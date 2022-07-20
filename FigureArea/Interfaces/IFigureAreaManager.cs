using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Interfaces
{
    /// <summary>
    /// Интерфейс для нахождения площади фигуры
    /// </summary>
    /// <typeparam name="T">фигура</typeparam>
    internal interface IFigureAreaManager<T> where T : class
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="figure">фигура</param>
        /// <returns></returns>
        double GetArea(T figure);
    }
}
