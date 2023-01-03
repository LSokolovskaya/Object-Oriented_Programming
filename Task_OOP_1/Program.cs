using Task_OOP_1.MyClasses;

namespace Task_OOP_1  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singer name = new Singer();
            // System.Console.WriteLine(name.GetАutograph());


            // WordString use = new WordString();
            // System.Console.WriteLine(use.ReverseString());
            // System.Console.WriteLine(use.UpperFirst());
            // System.Console.WriteLine(use.UpperEvery());


            // MathCalculation number = new MathCalculation();
            // number.Calculation();


            Fibonacci numberFib = new Fibonacci();
            numberFib.MethodFib();


            // Validator validator=new Validator(Console.ReadLine());
            // System.Console.WriteLine(validator.CheckEmail());
            // System.Console.WriteLine(validator.IsPhone());
        }
    }
}