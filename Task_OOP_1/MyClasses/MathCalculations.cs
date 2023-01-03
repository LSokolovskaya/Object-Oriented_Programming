// У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
// положительных чисел. Проверки

namespace Task_OOP_1.MyClasses
{
    public class MathCalculation
    {
        public int number;

        public void Calculation()
        {
            System.Console.WriteLine("Введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int result = 0;
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    System.Console.WriteLine("Введите элемент массива");
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] > 0)
                    {
                        result += numbers[i];
                    }
                    else
                    {
                        System.Console.WriteLine("Error");
                    }
                }
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }
    }
}