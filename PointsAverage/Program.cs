internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть оцінки студента за 100 бальною шкалою:");
        float grade = 0;
        float sumOfGrades = 0;
        for (int i = 0; i < 5; i++)
        {
            do
            {
                Console.Write($"Оцінка №{i + 1}: ");
                grade = float.Parse(Console.ReadLine());
            } while (grade < 0 || grade > 100);
            sumOfGrades += grade;

        }
        sumOfGrades = sumOfGrades / 5;
        if (sumOfGrades < 50)
        {
            Console.WriteLine($"\nСередня оцінка студента: {sumOfGrades}\nСтудент не допущений до екзамену");
        }
        else
        {
            Console.WriteLine($"\nСередня оцінка студента: {sumOfGrades}\nСтудент допущений до екзамену");
        }

    }
}