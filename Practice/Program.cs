namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int.Parse(s);
                Console.WriteLine("You entered a valid Int32 number " + s);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big to fit in Inte32!");
            }
        }
    }
}