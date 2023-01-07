namespace OOP.MyClasses // Note: actual namespace depends on the project name.
{
    public class CustomArray
    {
        private int[] Items;
        public int Length => Items.Length;
        public CustomArray()
        {
            Items = new int[0];
        }
        public CustomArray(int length)
        {
            Items = new int[length];
        }

        public CustomArray(int[] array)
        {
            Items = array;
        }

        public void Print()
        {
            System.Console.WriteLine(this);
        }


        public void InicializationArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = rnd.Next(-1000, 1000);
            }
        }

        public int AddItem(params int[] values)
        {
            int[] array = new int[values.Length + Items.Length];
            Array.Copy(Items, array, Items.Length);
            for (int i = Items.Length; i < array.Length; i++)
            {
                array[i] = values[i - Items.Length];
            }

            Items = array;
            return Items.Length;
        }

        public void AddItem(int value, int index)
        {
            if (index < 0 || index >= Items.Length)
            {
                System.Console.WriteLine("Неверный индекс");
                return;
            }
            Items[index] = value;
        }
        public int? GetItem(int index)
        {
            if (index < 0 || index >= Items.Length)
            {
                System.Console.WriteLine("Неверный индекс");
                return null;
            }
            return Items[index];
        }
        public int SumArray()
        {
            int result = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                result += Items[i];
            }
            return result;
        }
        public int DiffArray()
        {
            int result = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                result -= Items[i];
            }
            return result;
        }

        public override string ToString()
        {
            return string.Join(", ", Items);
        }
        public static void Information()
        {
            System.Console.WriteLine("MyClasses includes Array");
        }
    }
    public class CustomCalculator
    {
        public int SumNumbers(int x, int y)
        {
            return x + y;
        }
        public double SumNumbers(double x, double y)
        {
            return x + y;
        }
    }
}