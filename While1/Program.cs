internal class Program
{
    private static void Main(string[] args)
    {
        bool isNum = true;
        int enteredNum = 0;
        Console.WriteLine("a = -(1 / 3) + (1 / 5) + ... + -1^n / (2n + 1)");
        Console.WriteLine("b = (1 + 1 / 1^2) + (1 + 1 / 2^2) + ... + (1 + 1 / n^2)");
        Console.WriteLine("c = 1! + 2! + 3! + ... + n!");
        do
        {
            Console.Write("Введіть значення числа n: ");
            isNum = int.TryParse(Console.ReadLine(), out enteredNum);
        } while (!isNum);
        ExpressionA(ref enteredNum);
        ExpressionB(ref enteredNum);
        ExpressionC(ref enteredNum);
    }

    private static void ExpressionA(ref int enteredNum)
    {
        double a = 0;
        int n = 0;
        while (n < enteredNum)
        {
            n++;
            a += Math.Pow(-1, n) / (2 * n + 1);
        }
        Console.WriteLine("\nа = {0}", a);
    }

    private static void ExpressionB(ref int enteredNum)
    {
        double b = 0;
        int n = 0;
        while (n < enteredNum)
        {
            n++;
            b += 1 + 1 / Math.Pow(n, 2);
        }
        Console.WriteLine("b = {0}", b);
    }

    private static void ExpressionC(ref int enteredNum)
    {
        double c = 0;
        int n = 0;
        while (n < enteredNum)
        {
            n++;
            c += n!;
        }
        Console.WriteLine("c = {0}", c);
    }
}