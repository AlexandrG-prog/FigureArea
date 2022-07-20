using FigureArea.Figures;
using FigureArea.Implementations;
using FigureArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public static class FigureExtensions
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="figure">фигура</param>
        /// <returns></returns>
        public static double GetArea(this Base figure)
        {
            try
            {
                TypeInfo typeInfo = figure.GetType().GetTypeInfo();
                var figureAreaManagerType = typeof(IFigureAreaManager<>);
                var specificFigureAreaManagerType = figureAreaManagerType.MakeGenericType(typeInfo);
                var implementation = Assembly.GetAssembly(specificFigureAreaManagerType)
                           .GetTypes()
                           .First(type => specificFigureAreaManagerType.IsAssignableFrom(type));
                object classInstance = Activator.CreateInstance(implementation, null);
                dynamic result = specificFigureAreaManagerType.GetMethod("GetArea")?.Invoke(classInstance, new object[] { figure });

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
