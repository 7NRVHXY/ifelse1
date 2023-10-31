namespace ifelse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            int filmLimitAge = 12;
            if (age >filmLimitAge)
            {
                Console.WriteLine("is allowed");
            }
            else
            {
                Console.WriteLine("not allowed");
            }
        }
    }
}