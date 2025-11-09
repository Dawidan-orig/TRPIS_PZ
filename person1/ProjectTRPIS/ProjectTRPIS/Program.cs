public class Program 
{
    public static void Main(string[] args) 
    {
        int first = 10;
        int sec = 2;
        Console.WriteLine(Sum(first, sec));
        Console.WriteLine(Divide(first, sec));
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Divide(int a, int b) 
    {
        return a / b;
    }

    public static string Generation() => "Gimme the docs! attempt 5";
}