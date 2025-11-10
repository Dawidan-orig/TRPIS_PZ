namespace TRPIS
{
    /// <summary>
    /// Главная программа
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Главная функция!
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int first = 10;
            int sec = 2;
            Console.WriteLine(Sum(first, sec));
            Console.WriteLine(Divide(first, sec));
        }

        /// <summary>
        /// Сумма!
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Уделение...
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Просто текст
        /// </summary>
        /// <returns></returns>
        public static string Generation() => "Gimme the docs! attempt 12";
    }
}