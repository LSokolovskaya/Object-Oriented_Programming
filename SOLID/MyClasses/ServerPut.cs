// 6. +Реализуйте класс ServerPut. Обязательными методами считаются методы Middleware, Controller, Service, Repository.
// Цепочка взаимодействия между методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с этим массивом осуществляется только в Repository.
// Массив находится в приложении
// Задание:
// на вход подается параметры id, name, age
// Необходимо найти Id клиента в массиве БД. 
// Если совпадение есть, произвести обновление значений для соответствующих ключей.
// Если совпадения по Id нет – ошибка. Добавить проверки

using UserOBD;

namespace Post;

public class ServerPut
{
    private User[] user;
    private readonly User[] _user;

    public ServerPut()
    {
        user = new User[50];

        user[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        user[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        user[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        user[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
    }


    public User Controller(int age, string name, int id)
    {
        if (Middleware(age, name, id))
        {
            return Service(age, name, id);
        }
        else
        {
            Console.WriteLine("Error");
            return null;
        }
    }

    public bool Middleware(int age, string name, int id)
    {
        return age > 0 && age < 123 &&
        !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(Convert.ToString(age)) &&
        id > 0;
    }

    public User Service(int age, string name, int id)
    {
        User user = Repository(age, name, id);
        if (user == null)
        {
            Console.WriteLine("Not found data");
        }
        return user;
    }

    public User Repository(int age, string name, int id)
    {
        foreach (User user in _user)
        {
            if (user.Id != id)
            {
                System.Console.WriteLine("Error");
            }
            else
            {
                user = new User() { Id = 6, Name = "Test", Age = age };
            }
        }
        return null;
    }
}