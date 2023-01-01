//  1. Реализуйте класс Calculator, который будет содержать 4 метода:
//  DoPlus, DoMinus, DoMultiply, DoDivide. Каждый метод принимает 
//  неопределнное количество параметров

using NewCalculator;

namespace NewCalculator;

public class Calculator
{

    public int DoPlus(params int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    public int DoMinus(params int[] array)
    {
        int result = 0;
        foreach (int item in array)
        {
            result -= item;
        }
        return result;
    }

    public int DoMultiply(params int[] array)
    {
        int result = 0;
        int i = 0;
        while (i < array.Length)
        {
            result *= array[i++];
        }
        return result;
    }

    public int DoDivide(params int[] array)
    {
        int result = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            result /= array[i];
        }
        return result;
    }
}
