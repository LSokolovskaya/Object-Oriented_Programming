
namespace Cost //Расчет издержек производства
{
    internal class Cost
    {
        public double M;
        public double FZP;
        public double Osf;
        public double Sse;
        public double Sopr;
        public double Nnedv;
        public double Kpr;
        public double Snal;
        public double Tsht;
        public double Ri;
        public double Schi;
        public double Fdr;
        public double Kzagr;

        public void ProductionFunds()
        {
            double c = M + FZP + Osf + Sse + Sopr + Nnedv;
            System.Console.WriteLine($"Сумма годовых издержек производства при выполнении наладочных работ: {c}");
            double ZPosnnal = (Snal * Tsht) * Kpr;
            System.Console.WriteLine($"{ZPosnnal} ");
            double ZPiosn = Ri * Schi * Fdr * Kzagr;
            System.Console.WriteLine($"{ZPiosn} ");
        }
    }
}