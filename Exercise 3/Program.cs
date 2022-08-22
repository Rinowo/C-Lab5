namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter a number: ");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }

            catch (InvalidInput invalid)
            {
                Console.WriteLine(invalid);
            }

            catch (FormatException format)
            {
                Console.WriteLine(format);
            }
            finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intCnt * intNum);
                    }
                }
            }
            Console.ReadLine();
        }

        class InvalidInput : ApplicationException
        {
            public InvalidInput()
                : base("Enter a number greater than Zero") { }
        }
    }
}