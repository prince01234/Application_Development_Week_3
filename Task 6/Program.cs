namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var demo = new ExceptionDemo();

            demo.ConvertToInteger();
            Console.WriteLine();
            demo.CheckPassword();
        }
    }
}