namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;

            try
            {
                value = AnExceptionFuction(10);
                Console.WriteLine("Value: " + value);
                AnExceptionFuction(0);
                Console.WriteLine("Value: " + value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught an exception " + ex + ". Continue");
            }
            Console.WriteLine("Done");
        }

        static int AnExceptionFuction(int value)
        {
            if (value == 0)
                throw new DivideByZeroException("Divide by 0 error!");
            int x = 20;
            return x;
        }
    }
}