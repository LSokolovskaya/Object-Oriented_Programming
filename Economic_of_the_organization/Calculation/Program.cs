using Calculation;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Economic economic = new Economic();


            economic.Dk = 108; //количество календарных дней в году
            economic.Dvih = 110; //выходные и праздничные
            economic.Tcm = 8; //продолжительность смены
            economic.Dsokr = 3; //сокращенные дни
            economic.Tsokr = 1; //время сокращения
            economic.aob = 5.7; //потеря времени на ремонт
            economic.S = 1; //число смен
            economic.ap = 0.051; //планируемый процент потерь времени, связанный с невыходом на работу
            economic.Tob = 71; //трудоемкость наладочных работ


            economic.Proizvodstvennie(); //calculation
        }
    }
}