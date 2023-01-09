// 5. Реализуйте класс Validator. У него будет метод IsEmail параметром принимает
// строку и проверяет, является ли она корректным емейлом или нет. Если является
// - возвращает true, если не является - то false.
// 6. Дополнить 5 задание. Добавить метод IsURL для проверки на url.
// 7. Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
// 8. Дополнить 5 задание. Добавить метод IsPhone для проверки на номер телефона.

namespace Task_OOP_1.MyClasses;

public class Validator
{
    public string Email;

    public Validator(string email)
    {
        Email = email;
    }

    public bool CheckEmail(string mail)
    {
        string[] arrays = mail.Split('@');
        return arrays.Length == 2 && arrays[1].Split('.').Length == 2 && !arrays[1].EndsWith('.');
    }

    public bool IsURL()
    {
        bool result = Email.Contains("http") ? true : false;
        return result;
    }

    public bool IsDate()
    {
        bool result = false;
        if (Email.Contains("-") || Email.Contains("."))
        {
            result = true;
        }
        return result;
    }

    public bool IsPhone()
    {
        bool result = false;

        if (Email.StartsWith("+37529") || Email.StartsWith("+37533") || Email.StartsWith("+37517"))
        {
            result = true;
        }
        return result;
    }
}