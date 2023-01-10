// 3. Преобразовать строки двумерного массива в столбцы. 
// Класс будет содержать два метода: 
// один заполнит массив значениями, 
// второй произведет замену значений строк на значения столбцов.

namespace Incapsulation;

public class Matrix
{
    private int Column;
    private int Row;
    private int[,] ArrayMatrix { get; set; }

    public Matrix(int row, int column)
    {
        Column = column;
        Row = row;
        ArrayMatrix = new int[Row, Column];
    }
    public void SetData()
    {
        Random rnd = new Random();
        for (int i = 0; i < Row; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                ArrayMatrix[i, j] = rnd.Next(0, 100);
                Console.Write($"{ArrayMatrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    public void ReverseData()
    {
        int[,] matTemp = new int[Column, Row];
        for (int i = 0; i < Column; i++)
        {
            for (int j = 0; j < Row; j++)
            {
                matTemp[i, j] = ArrayMatrix[j, i];
                Console.Write($"{matTemp[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

