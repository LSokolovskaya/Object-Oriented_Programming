// 4. У вас есть класс Fibonacci. Создать в нем функцию для вывода ряда фибоначчи.
// Необходимо добавить проверки.
namespace Task_OOP_1.MyClasses;

public class Fibonacci
{
    public void MethodFib()
    {
        System.Console.WriteLine("Введите номер последнего элемента");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 1)
        {
            System.Console.WriteLine(0);
        }
        if (number == 2 || number == 3)
        {
            System.Console.WriteLine(1); ;
        }
        System.Console.WriteLine((number - 1) + (number - 2));
    }
}