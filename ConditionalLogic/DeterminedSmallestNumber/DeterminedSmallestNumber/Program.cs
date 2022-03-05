namespace SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter 1st Number");
            string inputFNumber = System.Console.ReadLine();
            int a = int.Parse(inputFNumber);

            System.Console.Write("Enter 2nd Number");
            string inputSNumber = System.Console.ReadLine();
            int b = int.Parse(inputSNumber);

            System.Console.Write("Enter 3rd Number");
            string inputTNumber = System.Console.ReadLine();
            int c = int.Parse(inputTNumber);

            System.Console.Write("Enter 4th Number");
            string inputFourthNumber = System.Console.ReadLine();
            int d = int.Parse(inputFourthNumber);

            System.Console.Write("Enter 5th Number");
            string inputFifthNumber = System.Console.ReadLine();
            int e = int.Parse(inputFifthNumber);

            if ((a < b) && (a < c) && (a < d) && (a < e))
            {
                System.Console.Write(a + "is the smallest number");
            }
            else if ((b < c) && (b < a) && (b < d) && (b < e))
            {
                System.Console.Write(a + " Is the smallest number");
            }
            else if ((c < a) && (c < b) && (c < e) && (c < a))
            {
                System.Console.Write(c + " Is the smallest number");
            }
            else if ((d < a) && (d < b) && (d < c) && (d < e))
            {
                System.Console.Write(d + " Is the smallest number.");
            }
            else if ((e < a) && (e < b) && (e < c) && (e < a))
            {
                System.Console.Write(e + " Is the smallest number");
            }
        }
    }
}
