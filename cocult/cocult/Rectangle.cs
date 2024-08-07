using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с прямоугольником
    /// </summary>
    class Rectangle :Figure
    {  
        /// <summary>
        /// поле хранящее сторону 1 прямоугольника
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// поле хранящее сторону 2 прямоугольника
        /// </summary>
        public double B { get; set; }


        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="side1">ввод стороны 1 прямоугольника</param>
        /// <param name="side2">ввод стороны 2 прямоугольника</param>
        public Rectangle(double side1, double side2)
        {
            A = side1;
            B = side2;
        }

        /// <summary>
        /// метод для вычисления площади прямоугольника
        /// </summary>
        /// <returns>возращает площадь</returns>
        public double S()
        {
            return A * B;
        }

        /// <summary>
        /// метод для вычисления периметра прямоугольника
        /// </summary>
        /// <returns>возращает периметр</returns>
        public double P()
        {
            return A + B * 2;
        }

        /// <summary>
        /// метод для вывода информации о прямоугольнике
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Прямоугольник A = {A}; B = {B};");
        }
    }
}
