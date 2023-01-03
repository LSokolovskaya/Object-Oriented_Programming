namespace Task_OOP_1.MyClasses
{
    // 1.Реализуйте класс Singer, который будет иметь следующие свойства: name, surname.
    // Также класс должен иметь метод GetАutograph (), который будет выводить “{Name} {Surname),
    // с наилучшими пожеланиями”.
    public class Singer
    {
        public string GetАutograph()
        {
            System.Console.WriteLine("Введите имя");
            string? name = Console.ReadLine();
            System.Console.WriteLine("Введите фамилию");
            string? surname = Console.ReadLine();
            return $"{name} {surname},с наилучшими пожеланиями";
        }
    }
}