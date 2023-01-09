// 2. Реализуйте класс WordString, который будет иметь следующие методы: метод ReverseString(), переворачивающий строку, метод UpperFirst(), возвращающий строку, где первая буква заглавная и метод UpperEvery(), который делает заглавной первую букву каждого слова этой строки.
// 3. У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех положительных чисел. Проверки.
// 4. УвасестьклассFibonacci.Создатьвнемфункциюдлявыводарядафибоначчи. Необходимо добавить проверки.
// 5. Реализуйте класс Validator. У него будет метод IsEmail параметром принимает строку и проверяет, является ли она корректным емейлом или нет. Если является - возвращает true, если не является - то false.
// 6. Дополнить 5 задание. Добавить метод IsURL для проверки на url.
// 7. Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
// 8. Дополнить5задание.ДобавитьметодIsPhoneдляпроверкинаномертелефона.
using Task_OOP_1.MyClasses;

namespace Task_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer name = new Singer();
            System.Console.WriteLine(name.GetАutograph());


            WordString use = new WordString();
            System.Console.WriteLine(use.ReverseString());
            System.Console.WriteLine(use.UpperFirst());
            System.Console.WriteLine(use.UpperEvery());


            MathCalculation number = new MathCalculation();
            number.Calculation();


            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Fib();


            Validator validator = new Validator(Console.ReadLine());
            System.Console.WriteLine(validator.CheckEmail( validator));
            System.Console.WriteLine(validator.IsPhone());
        }
    }
}