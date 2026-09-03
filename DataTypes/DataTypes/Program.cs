namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string e tähemärkide jada, mis on defineeritud andmetüübiga string
            //andmetüüp toetab ainult true ja false väärtusi
            //myString on muutuja, mis on defineeritud andmetüübiga string
            //saab sisestada kõike, mins on klaviatuuril

            string myString = "Hello, World!231";

            //kirjutage cw ja vajutage Tab, et genereerida Console.WriteLine

            Console.WriteLine(myString);

            string one = "1";
            string two = "2";
            string three = " ";

            Console.WriteLine(one + three + two + three + one);

            //int on täisarvuline andmetüüp, mis toetab ainult täisarve

            int myInt = 69;
            int secondInt = 67;

            Console.WriteLine(myInt);
            Console.WriteLine(myInt + secondInt);

            int oneint = 4206967;
            int twoint = 69;
            int threeint = 67;

            Console.WriteLine(oneint / twoint * threeint / myInt * secondInt);
            Console.WriteLine("");

            //kui kaks int tüüpi muutujat liita, siis liidetakse nende väärtused kokku


            Console.WriteLine("----Bool----");
            Console.WriteLine("");

            //see on andmetüüp mis toetab ainult ei või ja vastust

            bool myBool = true;

            Console.WriteLine(myBool);
            Console.WriteLine("");


            Console.WriteLine("----Ujukomaarvud----");
            Console.WriteLine("");

            //double on ujukomaarvuline adnmetüüp, mis toetab ainult ujukomaarve

            double myDouble = 67.69;
            double mySecondDouble = 69.67;
            
            //kui kas double tüüpi muutjuat liita, siis liidetakse nende väärtused kokku

            Console.WriteLine(myDouble);
            Console.WriteLine(myDouble * mySecondDouble);
            Console.WriteLine("");


            Console.WriteLine("----float----");
            Console.WriteLine("");

            //float on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve

            float myFloat = 67.69f;
            float mySecondFloat = 69.67f;

            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat * mySecondFloat);
            Console.WriteLine("");


            Console.WriteLine("----Decimal----");
            Console.WriteLine("");

            //decimal on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve

            decimal myDecimal = 67.67m;
            decimal mySecondDecimal = 69.69m;

            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal + mySecondDecimal);
            Console.WriteLine("");


            Console.WriteLine("----Byte----");
            Console.WriteLine("");

            //byte on täisarvuline andmetüüp, is toetab
            //ainult täisarve vahe´mikus 0 kuni 255
            //see on 8-bittine täisaruline andmetüüp

            byte myByte = 67;

            Console.WriteLine(myByte);
            Console.WriteLine("");


            Console.WriteLine("----Long----");
            Console.WriteLine("");

            //long on täisarvuline andmetüüp, mis toetab ainult täisarve
            //selle maksimaalne väärtus on 9,223,372,036,854,775,807
            //see on 64-bittine täisarvuline andmetüüp

            long myLong = 5897022101L;
            long mySecondLong = 190102925L;

            Console.WriteLine(myLong);
            Console.WriteLine(myLong * mySecondLong);
            Console.WriteLine("");


            Console.WriteLine("----Short----");

            //short on täisarvuline andmetüüp, mis toetab ainult täisarve
            //selle maksimaalne väärtus on 32,767
            //see on 16-bitine täisarvuline andmetüüp

            short myShort = 6767;
            short mySecondShort = 6969;

            Console.WriteLine(myShort);
            Console.WriteLine(myShort + mySecondShort);
            Console.WriteLine("");



        }
    }
}