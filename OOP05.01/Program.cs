using MyClasses.Transport;
using MyClasses.Cars;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport obj = new Transport(34, "car");
            // obj.Moving();
            // obj.Stopping();
            Car bugatti = new Car("vasiliy", 22);
            // bugatti.Drift();
            Car lambo = new Car("artem");

            Transport[] array = new Transport[3] { obj, bugatti, lambo };

            foreach (Transport item in array)
            {
                if(item is Car car)
                {
                    System.Console.WriteLine("This is car");
                    car.Drift();
                }
                if(item is Transport)
                {
                    // System.Console.WriteLine("This is Transport");
                }

                item.Moving();
                item.Stopping();

            }
        }
    }
}
