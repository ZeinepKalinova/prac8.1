using System;

class RangeOfArray
{
    private int[] array;
    private int lowerBound;
    private int upperBound;

    public RangeOfArray(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
        {
            throw new ArgumentException("Нижний предел должен быть меньше или равен верхнему пределу.");
        }

        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        array = new int[upperBound - lowerBound + 1];
    }

    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index - lowerBound];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс находится вне установленного диапазона.");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index - lowerBound] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс находится вне установленного диапазона.");
            }
        }
    }

    private bool IsIndexValid(int index)
    {
        return index >= lowerBound && index <= upperBound;
    }
}

class Program
{
    static void Main()
    {
        // Создаем экземпляр класса RangeOfArray с диапазоном от -9 до 15
        RangeOfArray array = new RangeOfArray(-9, 15);

        // Устанавливаем и получаем значения в этом диапазоне
        array[-9] = 1;
        array[0] = 2;
        array[15] = 3;

        // Выводим значения
        Console.WriteLine(array[-9]);  // Выведет 1
        Console.WriteLine(array[0]);   // Выведет 2
        Console.WriteLine(array[15]);  // Выведет 3
    }
}
