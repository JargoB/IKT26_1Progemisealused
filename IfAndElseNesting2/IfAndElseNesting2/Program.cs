namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bleh");

            int number = 67;

            if (number > 67)
            {
                Console.WriteLine("Number on 67");
            }
            else if (number > 77)
            {
                if(number == 82)
                {
                    Console.WriteLine("Number võrdub 82");
                }
                else
                {
                    Console.WriteLine("Number on teises bahemikus");
                }
            }
            else
            {
                Console.WriteLine("Vastus oli 67");
            }
        }
    }
}
