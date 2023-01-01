// Task 3
// Создать класс Matrix. 
//Класс должен иметь следующие поля:
// двумерный массив чисел;
// количество строк и +столбцов в матрице.
// Класс должен иметь следующие методы:
// сложение с другой матрицей;
// умножение на число;
// вывод на печать;
// умножение матриц.
// Значения заполняются рандомными числами. Сложение и 
// умножение матриц возвращает новую матрицу.

namespace Task_OOP_2.MyClasses;
public class Matrix
{
    public int[,] Items;
    public int CountColumn;
    public int CountRow;

    public Matrix(int countColumn, int countRow)
    {
        CountColumn = countColumn;
        CountRow = countRow;
        Items = new int[CountRow, CountColumn];
    }
    public void InitMatrix()
    {
        Random rnd = new Random();
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                Items[i, j] = rnd.Next(-100, 100);
            }
        }
    }
    public static void SumMatrix(Matrix matrix1, Matrix matrix2)
    {

        if (matrix1.CountColumn == matrix2.CountColumn && matrix1.CountRow == matrix2.CountRow)
        {
            Matrix matrix = new Matrix(matrix1.CountColumn, matrix1.CountRow);
            for (int i = 0; i < matrix1.CountRow; i++)
            {
                for (int j = 0; j < matrix1.CountColumn; j++)
                {
                    matrix.Items[i, j] = matrix1.Items[i, j] + matrix2.Items[i, j];
                }
            }
            matrix.Print();

        }
    }
    public void Print()
    {
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                System.Console.Write($"{Items[i, j]} ");
            }
            System.Console.WriteLine();
        }

    }
}