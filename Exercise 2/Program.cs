namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Không được nhập kí tự cho mảng số");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Không được nhập giá trị nằm ngoài miền");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi vượt quá phạm vi của mảng");
            }

            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);
        }
    }
}