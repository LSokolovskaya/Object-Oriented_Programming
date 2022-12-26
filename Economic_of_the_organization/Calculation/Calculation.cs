// See https://aka.ms/new-console-template for more information
using System;

namespace Calculation // Note: actual namespace depends on the project name.
{
    internal class Economic
    {
        public double Dk;
        public double Dvih;
        public double Tcm;
        public double Dsokr;
        public double Tsokr;
        public double aob;
        public double S;
        public double ap;
        public double Tob;

        public void Proizvodstvennie() //Производственные расчеты
        {
            double fnom = (Dk - Dvih) * Tcm - Dsokr * Tsokr;
            System.Console.WriteLine($"номинальный фонд времени Fном: {fnom:N3}");
            double fdob = fnom * (1 - aob / 100) * S;
            System.Console.WriteLine($"Действительный фонд времени работы оборудования Fд.об.: {fdob:N3}");
            double fdr = fnom * (1 - ap / 100);
            System.Console.WriteLine($"Действительный годовой фонд времени работника: {fdr:N3}");
            double kzagr = Tob / (fdob * 60);
            System.Console.WriteLine($"Коэффициент загрузки оборудования (рабочего места): {kzagr:N3}");
        }
    }
}
