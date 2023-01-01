// Реализуйте класс ServerById. Обязательными методами считаются методы Middleware, Controller, Service, Repository. 
// Цепочка взаимодействия между методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с этим массивом осуществляется только в Repository. 
// Массив находится в приложении
// Задание:
// на вход подается параметр id
// Необходимо вывести в консоль найденный элемент массива по id если таковой имеется. В противном случае бросить исключение. 
// Добавить проверки


// Id : 1, Name : “Yesenia", Age : 22,
// Id : 2, Name : “Hanna", Age : 22,
// Id : 3, Name : "Stanislau", Age : 25,
// Id : 4, Name : "German", Age : 18

using UserOBD;

namespace ServerID
{

    public class ServerById
    {

        private User[] User;

        public ServerById()
        {
            User = new User[4];

            User[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
            User[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
            User[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
            User[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
        }


        public User[] Controller()
        {
            return Middleware();
        }

        public User[] Middleware()
        {
            User[] user = Service();
            if (Convert.ToInt32(user) > 4 && Convert.ToInt32(user) < 1)
            {
                System.Console.WriteLine("Error");
            }
            return user;
        }

        public User[] Service()
        {
            User[] user = Repository();
            if (user == null)
            {
                System.Console.WriteLine("Empty");
            }
            return user;
        }

        public User[] Repository()
        {
            return User;
        }

    }

}