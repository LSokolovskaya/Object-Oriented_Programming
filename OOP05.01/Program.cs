using MyClasses.Transport;
using MyClasses.Cars;
using Figurs;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Transport obj = new Transport(34, "car");
            // // obj.Moving();
            // // obj.Stopping();
            // Car bugatti = new Car("vasiliy", 22);
            // // bugatti.Drift();
            // Car lambo = new Car("artem");

            // Transport[] array = new Transport[3] { obj, bugatti, lambo };

            // foreach (Transport item in array)
            // {
            //     if(item is Car car)
            //     {
            //         System.Console.WriteLine("This is car");
            //         car.Drift();
            //     }
            //     if(item is Transport)
            //     {
            //         // System.Console.WriteLine("This is Transport");
            //     }

            //     item.Moving();
            //     item.Stopping();

            // }

            // Transport transport = new Transport(10,"dfgh");
            // System.Console.WriteLine(transport.Name);
            // transport.Moving();

            // Car car = new Car("dfgh", 12);
            // System.Console.WriteLine(car.Name);
            // car.Moving();

            // Transport transportCar = new Car("zxcv", 12);
            // System.Console.WriteLine(transportCar.Name);
            // transportCar.Moving();

            Figura[] array = new Figura[3];
            
                array[0] = new Rectangle("rectangle", 5, 10);

                array[1] = new Triangle("triangle", 3, 4, 5);

                array[2] = new Cicle("circle", 2);

            int i = 0;
            while (i < array.Length)
            {
                array[i].Square();
                i++;
            }
        }
    }
}
