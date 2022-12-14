

using OOP.MyClasses;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            CustomArray arrayObj = new CustomArray(5);
            arrayObj.InicializationArray();
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-5, 5));
            arrayObj.Print();
            System.Console.WriteLine(arrayObj.AddItem(random.Next(-100, 100)));// => (1 значение в массив values)
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100));
            arrayObj.Print();
            System.Console.WriteLine(arrayObj.Length);
            System.Console.WriteLine(arrayObj.GetItem(random.Next(-5, arrayObj.Length)));
            System.Console.WriteLine(arrayObj); 
            System.Console.WriteLine(arrayObj.ToString());
            CustomArray.Information();
            // дописать метод сумма и метод разность массивов
            System.Console.WriteLine($"сумма массивов: {arrayObj.SumArray()}");
            System.Console.WriteLine($"разность: {arrayObj.DiffArray()}");
        }
    }
}