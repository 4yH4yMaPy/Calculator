namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Сложить 2 числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал числа");
                Console.WriteLine("9. Выйти из программы");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nВведите первое число: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат сложения: {a + b}");
                        break;
                    case 2:
                        Console.Write("\nВведите первое число: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат вычитания: {c - d}");
                        break;
                    case 3:
                        Console.Write("\nВведите первое число: ");
                        double e = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double f = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат умножения: {e * f}");
                        break;
                    case 4:
                        Console.Write("\nВведите первое число: ");
                        double g = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double h = double.Parse(Console.ReadLine());
                        if (h != 0)
                        {
                            Console.WriteLine($"Результат деления: {g / h}");
                        }
                        else
                        {
                            Console.WriteLine("Делить на ноль нельзя");
                        }
                        break;
                    case 5:
                        Console.Write("\nВведите число: ");
                        double v = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень, в которую вознести: ");
                        int power = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат возведения в степень: {Math.Pow(v, power)}");
                        break;
                    case 6:
                        Console.Write("\nВведите число: ");
                        double sqrt = double.Parse(Console.ReadLine());
                        if (sqrt >= 0)
                        {
                            Console.WriteLine($"Результат : {Math.Sqrt(sqrt)}");
                        }
                        else
                        {
                            Console.WriteLine("Извлечение квадратного корня из отрицательного числа невозможно!");
                        }
                        break;
                    case 7:


                        Console.Write("\nВведите число: ");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine($"один процент от числа: {h / 100}");
                        break;
                    case 8:
                        Console.Write("\nВведите число: ");
                        int n = int.Parse(Console.ReadLine());
                        int fact = 1;
                        for (int i = 2; i <= n; i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine($"Факториал числа равен: {fact}");
                        break;
                    case 9:
                        Console.WriteLine("Выход успешен!");
                        return;
                    default:
                        Console.WriteLine("Неправильный выбор.");
                        break;

                }
            }
        }
    }
}


