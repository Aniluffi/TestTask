﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с кругом
    /// </summary>
    class Circle :Figure
    {
        /// <summary>
        /// поле хранящее радиус круга
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="radius">ввод радиуса круга</param>
        public Circle(double radius)
        {
            R = radius;
        }

        /// <summary>
        /// метод для вычисления площади круга
        /// </summary>
        /// <returns>возращает площадь</returns>
        public double S()
        {
            return Math.PI * Math.Pow( R,2);
        }

        /// <summary>
        /// метод для вычисления периметра круга
        /// </summary>
        /// <returns>возращает периметр</returns>
        public double P()
        {
            return 2 * Math.PI * R;
        }

        /// <summary>
        /// метод для вывода информации о прямоугольнике
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Круг R = {R};");
        }
    }
}
