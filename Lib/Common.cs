namespace Common;

public static class InputData
{
    public static int IntData(string text)
    {
        bool isParsed = false;
        int number = 0;

        while (!isParsed)
        {
            Console.Write(text);
            isParsed = int.TryParse(Console.ReadLine(), out number);
        }
        return number;
    }

    public static double DoubleData(string text)
    {
        bool isParsed = false;
        double number = 0;

        while (!isParsed)
        {
            Console.Write(text);
            isParsed = double.TryParse(Console.ReadLine(), out number);
        }
        return number;
    }
    public static int[] IntArrayData()
    {
        int length = IntData("Введите количество элементов: ");
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = IntData($"Введите элемент №{i}: ");
        }

        return array;
    }

    public static double[] DoubleArrayData()
    {
        int length = IntData("Введите количество элементов: ");
        double[] array = new double[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = DoubleData($"Введите элемент №{i}: ");
        }

        return array;
    }
}

public static class GetArray
{
    public static void PrintTableInt(int[] array)
    {
        string str = string.Join("; ", array);
        Console.WriteLine($"[{str}]");
    }

    public static void PrintTableDouble(double[] array)
    {
        string str = string.Join("; ", array);
        Console.WriteLine($"[{str}]");
    }

    public static void Print2DArrayInt(int[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void Print2DArrayDouble(double[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[] GenElementsInOrder(int length)  //Создаёт массив по возрастанию
    {
        int[] array = new int[length];
        for (int i = 1; i < length; i++)
        {
            array[i - 1] = i;
        }
        return array;
    }


    public static int[] CreateRandomArrayInt(int size, int start, int end)
    {
        int[] randomNumbers = new int[size];
        Random rand = new Random();
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = rand.Next(start, end);
        }
        return randomNumbers;
    }

    public static double[,] CreateRandom2DArrayDouble(int countLine, int countColumn)
    {
        double[,] array = new double[countLine, countColumn];

        Random random = new Random();

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * 100, 2);
            }
        }

        return array;
    }
    public static int[,] CreateRandom2DArrayInt(int countLine, int countColumn, int start, int end)
    {
        int[,] array = new int[countLine, countColumn];

        Random random = new Random();

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(start, end);
            }
        }

        return array;
    }

    public static (double min, double max) FindMinAndMaxElement(double[] array)
    {
        double min = array[0];
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }

        }
        return (min, max);
    }
}