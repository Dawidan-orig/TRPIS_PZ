public class Program 
{
    public static void Main(string[] args) 
    {
        int toSumFirst = 10;
        int toSumSec = 1;
        Console.WriteLine(Sum(toSumFirst, toSumSec));
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}