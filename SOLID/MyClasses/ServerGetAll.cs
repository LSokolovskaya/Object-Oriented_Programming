// Реализуйте класс ServerGetAll. Обязательными методами считаются методы
// Controller, Service, Repository. Цепочка взаимодействия между методами 
// следующая:
// Controller -> Service -> Repository, где:
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с 
// этим массивом осуществляется только в Repository. Массив находится в 
// приложении
// Задание:
// Необходимо вывести в консоль весь массив

// Id : 1, Name : “Yesenia", Age : 22,
// Id : 2, Name : “Hanna", Age : 22,
// Id : 3, Name : "Stanislau", Age : 25,
// Id : 4, Name : "German", Age : 18

using UserOBD;
namespace Server;

public class ServerGetAll
{

    private User[] user;

    public ServerGetAll()
    {
        user = new User[4];

        user[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        user[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        user[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        user[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
    }

    public User[] Controller()
    {
        return Service();
    }

    private User[] Service()
    {
        User[] user = Repository();
        if (user == null)
        {
            System.Console.WriteLine("ERROR");
        }
        return user;
    }

    private User[] Repository()
    {
        return user;
    }
}