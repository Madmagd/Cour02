internal class Program
{
    private static void Main(string[] args)
    {
        int enteredNum = 0;
        bool isInt = true;
        do
        {
            do
            {
                Console.Write("Введіть число від 0 до 9: ");
                isInt = int.TryParse(Console.ReadLine(), out enteredNum);
                if (!isInt)
                {
                    Console.WriteLine("Неправильне значення");
                }
            } while (!isInt);
            switch (enteredNum)
            {
                case 0:
                    Console.WriteLine($"{enteredNum} - нуль");
                    break;
                case 1:
                    Console.WriteLine($"{enteredNum} - один");
                    break;
                case 2:
                    Console.WriteLine($"{enteredNum} - два");
                    break;
                case 3:
                    Console.WriteLine($"{enteredNum} - три");
                    break;
                case 4:
                    Console.WriteLine($"{enteredNum} - чотири");
                    break;
                case 5:
                    Console.WriteLine($"{enteredNum} - п'ять");
                    break;
                case 6:
                    Console.WriteLine($"{enteredNum} - шість");
                    break;
                case 7:
                    Console.WriteLine($"{enteredNum} - сім");
                    break;
                case 8:
                    Console.WriteLine($"{enteredNum} - вісім");
                    break;
                case 9:
                    Console.WriteLine($"{enteredNum} - дев'ять");
                    break;
                default:
                    Console.WriteLine("Неправильне значення");
                    break;

            }
        } while (true);
    }
}