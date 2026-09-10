using System.Xml.Linq;

namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid

            Console.WriteLine("Sisesta number:");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Sisestasid numbri : {number}");
            }
            else
            {
                Console.WriteLine("ERROR.Numbrit ei sisestanud");

                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}