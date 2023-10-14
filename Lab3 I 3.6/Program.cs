//Viết chương trình C# minh họa việc sử dụng từ khóa ref, out:

namespace Lab3_I_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;   
            int b = 500;
            Console.WriteLine("Khi ko dung ref: ");
            Add(a);
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("Khi co dung ref: ");
            Add(ref a);
            Console.WriteLine("a = {0}",a);
            Console.WriteLine();
            Console.WriteLine("Khi chua dung out: ");
            Addd(a, b);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Khi co dung out: ");
            Addd(a, out b);
            Console.WriteLine("b = {0}", b);
        }

        public static int Add(int a)
        {
            return a = a + 10;
        }

        public static int Add(ref int a)
        {
            return a = a + 10;
        }

        public static int Addd(int a, int b)
        {
            return b = a + 100;
        }

        public static int Addd(int a,out int b)
        {
            return b = a + 100;
        }
    }
}