// +Реализуйте класс WordString, который будет иметь следующие методы: метод
// +ReverseString(), переворачивающий строку, метод +UpperFirst(), возвращающий
// строку, где первая буква заглавная и метод +UpperEvery(), который делает
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
            if (string.IsNullOrEmpty(text))
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
            string[] array = text.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToLower();
            }
            text = string.Join(' ', array);
            text.Trim();
            text.ToLower();
            text = char.ToUpper(text[0]) + text.Remove(0, 1);
            return text;
        }
        public string UpperEvery()
        {
            string result = "";
            string[] array = text.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                result += char.ToUpper(array[i][0]);
                result += array[i].Remove(0, 1) + " ";

            }
            return result;

            // string[] array = text.Split(' ');
            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = array[i].ToLower();
            //     string[] arrays = array[i].Split("");
            //     for (int j = 0; j< arrays.Length; j++)
            //     {
            //         arrays[0] = arrays[0].ToUpper();
            //     }
            //     array[i] = string.Join("", arrays);
            // }
            // text = string.Join(' ', array);
            // return text;
        }
    }
}