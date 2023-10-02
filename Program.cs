using System;

namespace l1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readLine;
            Console.WriteLine("Введите значение X (вещественное число):");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Некорректный ввод числа!");
                return;
            }

            Console.WriteLine("Введите значение Y (вещественное число):");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Некорректный ввод числа!");
                return;
            }

            if (CheekPoint_inArea(x, y))
            {
                Console.WriteLine("ВВеденое значение В области!");
            }
            else
            {
                Console.WriteLine("ВВеденное значение ВНЕ области!");
            }

            Console.ReadLine();
        }

        static bool CheekPoint_inArea(double x, double y)
        {
            if (y <= 2 && y >= -6 && x <= 6 && x >= -2)
            {
                double distance = Math.Sqrt(x * x + y * y);
                if (distance < 2 && (distance > 4 && distance < 6 && x < 6 && x > 4 && y < 0 && y > 6))
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
