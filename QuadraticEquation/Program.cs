internal class Program
{
    private static double AskValue()
    {
        double value;
        bool isValueCorrect = false;

        do
        {
            isValueCorrect = double.TryParse(Console.ReadLine(), out value);
            if (!isValueCorrect)
            {
                Console.WriteLine("Неправильне значення. Спробуйте знову");
            }
        } while (!isValueCorrect);

        return value;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть значення a, b, c для рівняння ax^2 + bx + c = 0");
        Console.WriteLine("Значення a: ");
        double a = AskValue();
        Console.WriteLine("Значення b: ");
        double b = AskValue();
        Console.WriteLine("Значення c: ");
        double c = AskValue();
        Console.WriteLine($"\n{a}x^2 + {b}x + {c} = 0");

        double d = Math.Pow(b, 2) - 4 * a * c;

        if (a == 0)
            Console.WriteLine("Вираз не є квадратним рівнянням");
        else
        {
            switch (d)
            {
                case > 0:
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Значення x1 = {x1}\nЗначення x2 = {x2}");
                    break;
                case 0:
                    double x = -b / (2 * a);
                    Console.WriteLine($"Значення x = {x}");
                    break;
                case < 0:
                    Console.WriteLine("Рівняння не має розв'язку");
                    break;
            }
        }
        
    }
}