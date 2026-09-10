namespace IfAndElse
{
    //projekt nimetusega IfAndElse, mille sees asub class nimega Program.
    //See klass sisaldab Main  meetodit, mis on programmi sisenemispunkt
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Sisesta enda nimi:");

            //muutuja nimega name,
            //kuhu salvestatakse kasutaja sisestatud tekst
            string name = Console.ReadLine();

            //! tähendab "ei ole" ja == tähendb "on võrdne"
            if (name != "")
            {
                //Kui kasutaja siestab midagi, siis muudetakse taustavärvi
                Console.BackgroundColor =ConsoleColor.DarkRed;

                Console.WriteLine("Sisestasid enda nime");

                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("ERROR.Nime ei sisestanud");
                
                //Kui kasutaja ei sisesta midagi, siis kostab 2 piiksu

                Console.Beep();
                //ja oodetakse 2 sekundit enne programmi lõppu
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}
