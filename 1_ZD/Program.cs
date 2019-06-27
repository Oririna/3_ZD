using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ZD
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok=true;
            double x, y;
            bool t1, t2, res;
            do
            {
                Console.WriteLine("Введите X: ");
                x = TakeNumber();
            } while (!ok);

            do
            {
                Console.WriteLine("Введите Y: ");
                y = TakeNumber();
            } while (!ok);

            t1 = ((x >= -1 && x <= - 0.5) || (x >= 0.5 && x <= 1));
            t2 = ((y >= -1 && y <= - 0.5) || (y >= 0.5 && y <= 1));
            res = t1 || t2;

            if (res)
                Console.WriteLine("Точка принадлежит данной области");
            else
                Console.WriteLine("Точка не принадлежит данной области");
        }

        static double TakeNumber()
        {
            double n = 0;
            bool ok = true;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out n);
                if (!ok) Console.WriteLine("Не вверный ввод данных! Введите еще раз: ");
            } while (!ok);
            return n;
        }
    }
}