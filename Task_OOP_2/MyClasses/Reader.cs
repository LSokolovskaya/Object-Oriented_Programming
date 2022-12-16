// Task 4
//++ Определить класс Reader, хранящий такую информацию о 
//++пользователе библиотеки:
// ++ФИО+,
// ++номер читательского билета+,
// ++факультет+,
// ++дата рождения+,
// ++телефон+.
// ++Методы TakeBook(), ReturnBook().
// ++Перегрузить методы TakeBook (), ReturnBook ():
// ++- TakeBook, который будет принимать количество взятых книг. 
// Выводит на консоль сообщение "XXX взял Y книги".
// // +++- TakeBook, который будет принимать переменное количество названий книг. 
// Выводит на консоль сообщение "XXX взял книги: BooK1, BooK2, BooK3".
// // - TakeBook, который будет принимать переменное количество объектов класса 
// Book (создать новый класс, содержащий имя и автора книги). Выводит на консоль сообщение 
// " XXX взял книги: BooK1, BooK2, BooK3".
// // Аналогичным образом перегрузить метод ReturnBook (). +++Выводит на консоль сообщение 
// +++"XXX вернул книги: BooK1, BooK2, BooK3". Или +++" XXX вернул Y книги".
// Cоздается массив объектов данного класса.

namespace Task_OOP_2.MyClasses;

public class Reader
{
    public string Name { get; set; }
    public int NumberCard { get; set; }
    public int Facult { get; set; }
    public string BirthDay { get; set; }
    public string TelephoneNumber { get; set; }

    // Методы TakeBook(), ReturnBook().
    // Перегрузить методы TakeBook (), ReturnBook ():
    // - TakeBook, который будет принимать количество взятых
    // книг. 
    // Выводит на консоль сообщение "XXX взял Y книги".
    public void TakeBook(int countbook)
    {
        System.Console.WriteLine($"{Name} give {countbook} books");
    }
    public void ReturnBook(int countbook)
    {
        System.Console.WriteLine($"{Name} return {countbook} books");
    }

    public string TakeBook(params string[] array)
    {
        string result = $"{Name} give: ";
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i] + ", ";

        }
        return result.Remove(result.Length - 2, 2);
    }
    public string ReturnBook(params string[] array)
    {
        string result = $"{Name} return: ";
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i] + ", ";

        }
        return result.Remove(result.Length - 2, 2);
    }

}

// - TakeBook, который будет принимать переменное количество объектов класса 
// Book (создать новый класс, содержащий имя и автора книги). Выводит на консоль сообщение 
// " XXX взял книги: BooK1, BooK2, BooK3".