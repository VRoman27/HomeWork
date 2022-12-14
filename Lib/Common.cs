namespace Common;

public static class EnteringData
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

}

public static class MultiDigitNumbers
{
    public static int InvertDigitPosition(int number, int numDigit)
    {
        int newNumber = 0;
        for (int i = numDigit - 1; i >= 0; i--)
        {
            newNumber = newNumber + (number % 10) * (int)Math.Pow(10, (double)i);
            number /= 10;
        }
        return newNumber;

    }
    public static void ItsPalindrome(int x)
    {
        if (x == InvertDigitPosition(x, 5))
        {
            Console.WriteLine("Это полиндром");
        }
        else
        {
            Console.WriteLine("Это не полиндром");
        }
    }
}

public static class Calculation
{
    public static double Length2D(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    public static double Length3D(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }
    public static double Pow(double num, int degree)
    {
        double result = 0;
        if (degree == 0)
        {
            result = 1;
        }
        else if (degree >= 1)
        {
            result = num;
            for (int i = 1; i < degree; i++)
            {
                result *= num;
            }
        }
        else if (degree <= -1)
        {
            result = 1 / num;
            for (int i = -1; i > degree; i--)
            {
                result /= num;
            }
        }
        else
        {
            return -1;
        }


        return result;
    }
    public static int SumDigitInNumber(int number)
    {
        int sum = 0;
        if (number < 0) number *= -1;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}

public static class GetArray
{
    public static void PrintTable(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[{str}]");
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
    public static int[] PowTableElemetsInt(int[] array, int degree) //Возведение в степень каждого элемента массива
    {

        for (int i = 1; i <= array.Length; i++)
        {
            array[i - 1] = (int)Math.Pow((double)i, degree);
        }

        return array;
    }
    public static double[] PowTableElemetsDouble(double[] array, int degree)  //Возведение в степень каждого элемента массива
    {

        for (int i = 1; i <= array.Length; i++)
        {
            array[i - 1] = Math.Pow((double)i, degree);
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

    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]<0) return -1;
            if(array[i]%2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    public static int SumNotEvenIndexElement(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i+=2)
        {
            sum+=array[i];
        }
        return sum;
    }
}