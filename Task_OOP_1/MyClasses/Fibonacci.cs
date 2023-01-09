// 4. У вас есть класс Fibonacci. Создать в нем функцию для вывода ряда фибоначчи.
// Необходимо добавить проверки.
namespace Task_OOP_1.MyClasses;

public class Fibonacci
{
    public void Fib()
    {
        int? number = int.Parse(Console.ReadLine());
        System.Console.WriteLine(MethodFib(number));
    }
    public int MethodFib(int? number)
    {
        if (number >= 0)
        {
            if (number == 1)
            {
                return 0;
            }
            if (number == 2 || number == 3)
            {
                return 1;
            }
        }
        return MethodFib(number - 1) + MethodFib(number - 2);
    }
}