namespace IfAndElseNesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bleh");

            int number = Convert.ToInt32(Console.ReadLine()); // <-- ise tehtud

            //string numberInt = Console.ReadLine(); // <-- tunnis tehtud
            //int number = int.Parse(numberInt); // <-- tunnis tehtud

            //konsool loeb ainult string adnmetüüpe
            //muudame stringi int andmetüübiks ja kasutame Parset

            if (number == 52)
            {
                Console.WriteLine("Number võrdub" + number);
            }
            else if (number > 60)
            {
                if (number == 61)
                {
                    Console.WriteLine("Number võrdub 61");
                }
                else
                {
                    Console.WriteLine("Number on " + number);
                    Console.WriteLine("Number on suurem kui 61");
                }
            }
            else
            {
                Console.WriteLine("Number on " + number);
                Console.WriteLine("Number on väiksem kui 61");
            }
        }
    }
}