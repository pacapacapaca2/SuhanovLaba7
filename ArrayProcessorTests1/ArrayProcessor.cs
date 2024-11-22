using System;

public class ArrayProcessor
{
    // Метод для сортировки массива
    public int[] SortArray(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не может быть null");

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }

    // Метод для нахождения максимального числа
    public int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или null");

        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
                max = num;
        }

        return max;
    }

    // Метод для вычисления среднего арифметического
    public double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или null");

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}
