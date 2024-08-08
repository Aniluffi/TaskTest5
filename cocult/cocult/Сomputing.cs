using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
     static class Computing
    {
        /// <summary>
        /// Вычисляет квадрат расстояния между двумя точками.
        /// </summary>
        /// <param name="x1">Координата X первой точки.</param>
        /// <param name="y1">Координата Y первой точки.</param>
        /// <param name="x2">Координата X второй точки.</param>
        /// <param name="y2">Координата Y второй точки.</param>
        /// <returns>Квадрат расстояния между двумя точками.</returns>
        public static double DistanceSquared(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}
