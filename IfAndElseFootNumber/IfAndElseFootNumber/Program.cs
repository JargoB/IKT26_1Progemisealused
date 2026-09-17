namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta jalanumber");

            string numberInt= Console.ReadLine();
            int number = int.Parse(numberInt);

            if (number < 30)
            {
                Console.WriteLine("Jalg liiga väike!!");
            }
            else if (number < 34)   //sobib ka if (number >= 30 && number <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jalanumber 30 ja 33 vahel");
                Console.WriteLine("Jalanumber on " + number);
            }
            else if (number < 39)   //sobib ka if (number >= 34 && number <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Jalanumber 34 ja 38 vahel");
                Console.WriteLine("Jalanumber on " + number);
            }
            else if (number < 44)   //sobib ka if (number >= 39 && number <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jalanumber 39 ja 44 vahel");
                Console.WriteLine("Jalanumber on " + number);
            }
            else if (number < 49)   //sobib ka if (number >= 45 && number <= 48)
            {
                Console.WriteLine("Jalanumber 45 ja 48 vahel");
                Console.WriteLine("Jalanumber on " + number);
                Console.Beep(37,1000);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Jalg liiga suur!!");
            }
        }
    }
}
