using System;

namespace Task_OOP_1.MyClasses // Note: actual namespace depends on the project name.
{
    // 1.Реализуйте класс Singer, который будет иметь следующие свойства: name, surname.
    // Также класс должен иметь метод GetАutograph (), который будет выводить “{Name} {Surname),
    // с наилучшими пожеланиями”.
    public class Singer
    {
        public string GetАutograph(string name, string surname)
        {
            return $"{name} {surname},с наилучшими пожеланиями";
        }
    }
}