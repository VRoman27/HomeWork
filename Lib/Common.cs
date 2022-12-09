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
