using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Spline
    {
        // диаметр внутренний
        public double d_in { get; set; } = 20;
        // наружный диаметр
        public double D_out { get; set; } = 28;
        // количество шлицев
        public int z { get; set; } = 6;
        // ширина шлица
        public double b { get; set; } = 4;
        // размер фаски
        public double f { get; set; } = 0.6;
        // рабочая длина шлица
        public double l { get; set; } = 30;
        // высота поверхности контакта
        public double h => (D_out - d_in) / 2.0 - 2.0 * f;
        // радиус контакта
        public double r => (D_out + d_in) / 4.0;
        // 𝜎=𝑇/(0,75 𝑧ℎ𝑙 𝑟)
        public double sigma(double T)
        {
            double res = T / (0.75 * z*h*l*r);
            return res;
        }
    }
}
