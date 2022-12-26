// 3. Реализуйте класс ServerGetAll. Обязательными методами считаются методы Controller, Service, Repository. Цепочка взаимодействия между методами следующая:
// Controller -> Service -> Repository, где:
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с этим массивом осуществляется только в Repository. Массив находится в приложении
// Задание:
// Необходимо вывести в консоль весь массив

// Id : 1, Name : “Yesenia", Age : 22, 
// Id : 2, Name : “Hanna", Age : 22, 
// Id : 3, Name : "Stanislau", Age : 25, 
// Id : 4, Name : "German", Age : 18, 
// Id : 5, Name : "Maria", Age : 27

namespace ServerGetAll
{

    public class ServerGetAll
    {
        private User[] User;

        private ServerGetAll()
        {
            User = new User[4];
            User[0] = ()(Id = 1, Name = "Yesenia", Age = 22);
            User[1] = ()(Id = 2, Name = "Hanna", Age = 22);
            User[2] = ()(Id = 3, Name = "Stanislau", Age = 25);
            User[3] = ()(Id = 4, Name = "German", Age = 18);
            User[3] = ()(Id = 5, Name = "Maria", Age = 27);
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
                System.Console.WriteLine("Error");
            }
            return user;
        }

        private User[] Repository()
        {
            return User;
        }
    }
}