using System;

namespace Task_OOP_1.MyClasses // Note: actual namespace depends on the project name.
{
    // 1.Реализуйте класс Singer, который будет иметь следующие свойства: name, surname.
    // Также класс должен иметь метод GetАutograph (), который будет выводить “{Name} {Surname),
    // с наилучшими пожеланиями”.
    public class Singer
    {
        public string Name;
        public string Surname;
        public Singer(string name, string surname)
        {
            System.Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            System.Console.WriteLine("Введите фамилию");
            Surname = Console.ReadLine();
        }

        public void Print()
        {
            System.Console.WriteLine(this);
        }

        public string GetАutograph()
        {
            return ($"{Name} {Surname},с наилучшими пожеланиями");
        }
    }
}