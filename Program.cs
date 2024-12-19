using System;

class Program
{
    // Сложная функция f(x, y)
    static double F(double x, double y)
    {
        return Math.Sin(x) - Math.Pow(y, 2) + x * y;
    }

    static void Main(string[] args)
    {
        // Вывод функции f(x, y)
        Console.WriteLine("Используемая функция: f(x, y) = sin(x) - y^2 + x * y\n");

        // Ввод данных пользователем: начальные условия, шаг и конечная точка
        Console.Write("Введите начальное значение x (x0): ");
        double x0 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите начальное значение y (y0): ");
        double y0 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение x (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nРезультаты:");
        Console.WriteLine("x\t\ty (Эйлер)");
        Console.WriteLine("--------------------");

        // Метод Эйлера
        double x = x0;
        double y = y0;

        while (x <= b)
        {
            // Вывод текущих значений
            Console.WriteLine($"{x:F6}	{y:F6}");

            // Вычисление следующего y методом Эйлера
            y = y + h * F(x, y);

            // Увеличение x на шаг h
            x = Math.Round(x + h, 10); // Избегаем ошибок с плавающей точкой
        }
    }
}


//using System;

//class Program
//{

//    static double F(double x, double y)
//    {
//        return Math.Sin(x) - Math.Pow(y, 2) + x * y;
//    }


//    static double AnalyticalSolution(double x)
//    {
//        return Math.Pow(x, 2);
//    }

//    static void Main(string[] args)
//    {
//        // Вывод функции f(x, y)
//        Console.WriteLine("Используемая функция: f(x, y) = sin(x) - y^2 + x * y\n");

//        Console.Write("Введите начальное значение x (x0): ");
//        double x0 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите начальное значение y (y0): ");
//        double y0 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите шаг (h): ");
//        double h = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите конечное значение x (b): ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Хотите использовать аналитическое решение (y/n)? ");
//        string useAnalyticalSolution = Console.ReadLine();

//        Console.WriteLine("\nРезультаты:");
//        Console.WriteLine("x\t\ty (Эйлер)");

//        // Метод Эйлера
//        double x = x0;
//        double y = y0;

//        while (x <= b)
//        {
//            if (useAnalyticalSolution.ToLower() == "y")
//            {
//                double analyticalY = AnalyticalSolution(x);
//                Console.WriteLine($"{x:F6}\t{y:F6}\t{analyticalY:F6}");
//            }
//            else
//            {
//                Console.WriteLine($"{x:F6}\t{y:F6}");
//            }


//            y = y + h * F(x, y);

//            // Увеличение x на шаг h
//            x = Math.Round(x + h, 10);
//        }
//    }
//}
