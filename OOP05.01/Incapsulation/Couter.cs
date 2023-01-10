//  Описать класс, реализующий десятичный счетчик, который может увеличивать
// или уменьшать свое значение на единицу в заданном диапазоне. Предусмотреть
// инициализацию счетчика значениями по умолчанию и произвольными
// значениями. Счетчик имеет два метода: увеличения и уменьшения, — и свойство,
// позволяющее получить его текущее состояние. Написать программу,
// демонстрирующую все возможности класса. 

namespace Incapsulation;

public class Counter
{
    public int Num { get; private set; }
    private int Min;
    private int Max;

    public Counter(int num = 5, int min = 0, int max = 100)
    {
        Num = num;
        Min = min;
        Max = max;
        if (min > max)
        {
            Console.WriteLine("error min max value");
        }
        if (num < min || num > max)
        {
            Console.WriteLine("error counter");
        }
    }

    public void Incriment()
    {
        if (Num < Max)
        {
            Num++;
        }
    }
    public void Decrement()
    {
        if (Num > Min)
        {
            Num--;
        }
    }
    public override string ToString()
    {
        return $"{Num}";
    }
}