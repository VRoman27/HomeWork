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

public static class Сalculation
{
    public static double Length2D(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    public static double Length3D(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }
    public static double Pow(double num, double degree)
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
            //Для дробных степеней. Не знаю как работает, нашёл в интернете.
            long i = BitConverter.DoubleToInt64Bits(num);
            i = (long)(4606853616395542500L + degree * (i - 4606853616395542500L));
            result = BitConverter.Int64BitsToDouble(i);
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
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    public static int[] GenElementsInOrder(int length)
    {
        int[] array = new int[length];
        for (int i = 1; i < length; i++)
        {
            array[i - 1] = i;
        }
        return array;
    }
    public static int[] PowTableElemetsInt(int[] array, int degree)
    {

        for (int i = 1; i <= array.Length; i++)
        {
            array[i - 1] = (int)Math.Pow((double)i, degree);
        }

        return array;
    }
    public static double[] PowTableElemetsDouble(double[] array, int degree)
    {

        for (int i = 1; i <= array.Length; i++)
        {
            array[i - 1] = Math.Pow((double)i, degree);
        }

        return array;
    }
}