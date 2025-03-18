namespace Csharp7and8features_outtypepatterndemo
{
    internal class Program
    {
        public static void swap(out int x, out int y)
        {

            //what to swap so provide values here so 
            x = 10;
            y = 20;
            Console.WriteLine("\nBefore swapping");
            Console.WriteLine($"X={x} \n Y={y}");
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            // here press enter two times to see the result 
            int x, y;// as out variables cannot be initlazed as  u are sending them as out in 
                     // function call ..
                     //  int x = 10; int y = 20; 
                     //Console.WriteLine("\nBefore swapping");
                     //Console.WriteLine($"X={x} \n Y={y}");
            Program.swap(out x, out y);
            Console.WriteLine("\nafter swapping");
            Console.ReadLine();
            Console.WriteLine($"X={x} \n Y={y}");
            Console.ReadLine();
        }
    }
}
