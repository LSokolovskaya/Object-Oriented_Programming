// 2. Определить класс Children, который содержит такие поля (члены класса): 
// закрытые – имя ребенка, фамилию и возраст, 
// публичные – методы ввода данных и отображения их на экран. 
// Объявить два объекта класса, внести данные и показать их.

namespace Incapsulation;

public class Children
{
    private string Name;
    private string Surname;
    private string Age;

    public void GetName()
    {
        System.Console.WriteLine(Name);
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetSurname(string surname)
    {
        Surname = surname;
    }

    public void GetSurname()
    {
        System.Console.WriteLine(Surname); 
    }

    public void SetAge(string age)
    {
        Age = age;
    }
    public void GetAge()
    {
        System.Console.WriteLine(Age);;
    }
}