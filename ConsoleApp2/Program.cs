using System;
using static ConsoleApp2.Class1;
using static ConsoleApp2.Class8;
using static ConsoleApp2.Class2;
using static ConsoleApp2.Class3;
using static ConsoleApp2.Class4;
using static ConsoleApp2.Class5;
using static ConsoleApp2.Class9;
using static ConsoleApp2.Class10;
using static ConsoleApp2.Class6;
using static ConsoleApp2.Class7;

namespace EngineeringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение (+)");
                Console.WriteLine("2. Вычитание (-)");
                Console.WriteLine("3. Умножение (*)");
                Console.WriteLine("4. Деление (/)");
                Console.WriteLine("5. Синус (sin)");
                Console.WriteLine("6. Косинус (cos)");
                Console.WriteLine("7. Тангенс (tan)");
                Console.WriteLine("8. Котангенс (cot)");
                Console.WriteLine("9. Возведение в степень (^)");
                Console.WriteLine("10. Квадратный корень (√)");
                Console.WriteLine("11. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation(Addition.Perform);
                        break;
                    case "2":
                        PerformOperation(Subtraction.Perform);
                        break;
                    case "3":
                        PerformOperation(Multiplication.Perform);
                        break;
                    case "4":
                        PerformOperation(Division.Perform);
                        break;
                    case "5":
                        PerformTrigonometricOperation(Sine, "синус");
                        break;
                    case "6":
                        PerformTrigonometricOperation(Cosine, "косинус");
                        break;
                    case "7":
                        PerformTrigonometricOperation(Tangent, "тангенс");
                        break;
                    case "8":
                        PerformTrigonometricOperation(Cotangent, "котангенс");
                        break;
                    case "9":
                        PerformExponentiation();
                        break;
                    case "10":
                        PerformSquareRoot();
                        break;
                    case "11":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверная операция. Попробуйте снова.");
                        break;
                }
            }
        }
        static void PerformOperation(Func<double, double, double> operation)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {operation(num1, num2)}");
        }

        static void PerformTrigonometricOperation(Func<double, double> operation, string operationName)
        {
            Console.WriteLine("Введите угол в градусах:");
            double angleDegrees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат {operationName} угла {angleDegrees} градусов: {operation(angleDegrees)}");
        }

        static void PerformExponentiation()
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            double exponent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {Exponentiation.Perform(num, exponent)}");
        }

        static void PerformSquareRoot()
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат квадратного корня из {num}: {SquareRoot.Perform(num)}");
        }
    }
}
