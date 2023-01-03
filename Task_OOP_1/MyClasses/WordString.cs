// Реализуйте класс WordString, который будет иметь следующие методы: метод
// ReverseString(), переворачивающий строку, метод UpperFirst(), возвращающий
// строку, где первая буква заглавная и метод UpperEvery(), который делает
// заглавной первую букву каждого слова этой строки.
namespace Task_OOP_1.MyClasses
{
    public class WordString
    {
        public string? text;

        public WordString()
        {
            System.Console.WriteLine("введите строку");
            text = Convert.ToString(Console.ReadLine());
            if(string.IsNullOrEmpty(text))
            {
                System.Console.WriteLine("ERROR");
            }
        }
        public string ReverseString()
        {
            string timeText = "";
            for (int i = text.Length - 1; i > -1; i--)
            {
                timeText += text[i];
            }
            return timeText;
        }
        public string UpperFirst()
        {
            text.Trim();
            text = char.ToUpper(text[0]) + text.Remove(0, 1);
            return text;
        }
        public string UpperEvery()
        {
            text.Trim();

            string[] array = text.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.ToUpper(array[i][0]) + array[i].Remove(0, 1);
            }
            text = string.Join(" ", array);
            return text;
        }
    }
}