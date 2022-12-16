using Task_OOP_2.MyClasses;

namespace TaskOOP2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Phone phone1 = new Phone();
            // System.Console.WriteLine(phone1); 
            // phone1.ReceiveCall("LoL");
            // System.Console.WriteLine(phone1.GetNumber());
            // System.Console.WriteLine();

            // Phone phone2 = new Phone();
            // System.Console.WriteLine(phone2);
            // phone2.Number = "+375-29-111-11-11";
            // phone2.Model = "Samsung";
            // phone2.Weight = "1000";
            // phone2.ReceiveCall("KeK");
            // System.Console.WriteLine(phone2.GetNumber());
            // System.Console.WriteLine();

            // Phone phone3 = new Phone()
            // {
            //     Model = "Iphone",
            //     Weight = "100",
            //     Number = "+375-29-777-77-77"
            // };
            // System.Console.WriteLine(phone3);
            // phone3.ReceiveCall("Cucumber Rick");
            // System.Console.WriteLine(phone3.GetNumber());
            // System.Console.WriteLine();


            // 
            // Phone phone1 = new Phone();
            // System.Console.WriteLine(phone1);
            // phone1.ReceiveCall("LoL");
            // System.Console.WriteLine(phone1.GetNumber());
            // System.Console.WriteLine();

            // Phone phone2 = new Phone("+375-29-111-11-11", "Samsung");
            // System.Console.WriteLine(phone2);
            // phone2.ReceiveCall("KeK");
            // System.Console.WriteLine(phone2.GetNumber());
            // System.Console.WriteLine();

            // Phone phone3 = new Phone(model: "Iphone", weight: "100", number: "+375-29-777-77-77");
            // System.Console.WriteLine(phone3);
            // phone3.ReceiveCall("Cucumber Rick", "+375-29-111-11-11");
            // System.Console.WriteLine(phone3.GetNumber());
            // System.Console.WriteLine();
            // Phone.SendMessage("hello", "+375-29-111-11-11","+375-29-111-33-11","+375-29-333-11-11");
            //-------------------------
            // Person person1 = new Person();
            // person1.Move();
            // person1.Talk();
            // Person person2 = new Person("Igor", "34");
            // person2.Move();
            // person2.Talk();
            //-------------------------
            // Matrix matrix = new Matrix(3, 3);
            // matrix.InitMatrix();
            // matrix.Print();

            // System.Console.WriteLine();

            // Matrix matrix1 = new Matrix(3, 3);
            // matrix1.InitMatrix();
            // matrix1.Print();
            // System.Console.WriteLine();

            // Matrix.SumMatrix(matrix, matrix1);
            //-------------------------
            // Reader reader1 = new Reader();
            // reader1.TakeBook();
            // reader1.ReturnBook();
            Reader[] array = new Reader[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Reader() { Name = $"Reader{i + 1}" };
                Random rnd = new Random();
                array[i].TakeBook(rnd.Next(1, 10));
                array[i].ReturnBook(rnd.Next(1, 10));
                System.Console.WriteLine(array[i].TakeBook("Books1", "Books2"));
                System.Console.WriteLine(array[i].ReturnBook("Books3", "Books5"));
            }

        }
    }
}