// +7. Реализуйте класс ServerDelete.
// +Обязательными методами считаются методы Middleware, Controller, Service, Repository. 
// Цепочка взаимодействия между методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// +Middleware – метод валидатор
// +Controller – метод, принимающий данные. Принимает данные клиента
// +Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. 
// Взаимодействие с этим массивом осуществляется только в Repository. 
// Массив находится в приложении
// Задание:
// на вход подается параметр id
// Необходимо осуществить удаление по Id. Если совпадения нет – ошибка. Добавить проверки

using UserOBD;

namespace Delete;

public class ServerDelete
{
    private User[] user;
    private readonly User[] _user;

    public ServerDelete()
    {
        user = new User[50];

        user[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        user[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        user[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        user[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
    }

    public User Controller(int id)
    {
        if (Middleware(id))
        {
            return Service(id);
        }
        else
        {
            Console.WriteLine("Error");
            return null;
        }
    }

    public bool Middleware(int id)
    {
        return id > 0;
    }

    public User Service(int id)
    {
        User user = Repository(id);
        if (user == null)
        {
            Console.WriteLine("Not found data");
        }
        return user;
    }

    public User Repository(int id)
    {
        for (int i = 0; i < user.Length; i++)
        {
            if (user[i].Id == id)
            {
                user[i].Name = default;
                user[i].Age = default;
                return user[i];
            }
        }
        return null;
    }
}