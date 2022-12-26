// 2. Реализуйте класс ValidatorEmail. Класс содержит 1 метод валидации,
//  называемый Middleware, в котором происходит проверка на почту.
//  Вывести true, если провека успешна

namespace SOLIDValidator
{
    public class ValidatorEmail
    {
        public bool Middleware(string mail)
        {
            string[] arrays = mail.Split('@');// test@test.test
            return arrays.Length == 2 && arrays[1].Split('.').Length == 2 && !arrays[1].EndsWith('.');
        }
    }
}