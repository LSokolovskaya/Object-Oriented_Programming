// Создать класс Person, который содержит:+
// Свойства FullName, Age;+
// методы Move() и Talk(), в которых просто вывести на консоль сообщение -"Такой-то {FullName} говорит".+
// Добавьте два конструктора - Person() и Person(fullName, age). Создайте два объекта этого класса. 
// Один объект инициализируется конструктором Person(), другой - Person(fullName, age).


namespace Task_OOP_2.MyClasses;
public class Person
{
    public string FullName { get; set; } = "No name";
    public string Age { get; set; } = "...";

    public Person()
    {

    }

    public Person(string fullName, string age)
    {
        FullName = fullName;
        Age = age;
    }

    public void Move()
    {
        System.Console.WriteLine($"Такой-то {FullName} идет");
    }
    public void Talk()
    {
        System.Console.WriteLine($"Такой-то {FullName} говорит");
    }
}