// +Реализуйте класс ServerById. Обязательными методами считаются методы Middleware, Controller, Service, Repository. 
// Цепочка взаимодействия между методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// +Middleware – метод валидатор
// +Controller – метод, принимающий данные. Принимает данные клиента
// +Service – метод проверки на то что с Repository вернулось значение
// +Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с этим массивом осуществляется только в Repository. 
// Массив находится в приложении
// Задание:
// на вход подается параметр id
// Необходимо вывести в консоль найденный элемент массива по id если таковой имеется. В противном случае бросить исключение. 
// Добавить проверки


using UserOBD;

namespace ServerID
{
    public class ServerById
    {
        private User[] user;
        private readonly User[] _user;

        public ServerById()
        {
            user = new User[4];

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
            foreach (User user in _user)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
    }
}