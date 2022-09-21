using System.ComponentModel;
using System.Linq.Expressions;

namespace HomeWork
{
    internal class Program
    {

        static int addition()
        {
            int m;
            int m2;
            Console.Clear();
            Console.WriteLine("nu kom du till addition metoden.");
            Console.WriteLine("nu få du skriva två nummer för att addera ihop : ");
            Console.Write("första nummer : ");
            var number1 = Console.ReadLine();
            if (int.TryParse(number1, out m))
            {
                m = Convert.ToInt32(number1);
            }
            Console.Write("andra nummer : ");
            var number2 = Console.ReadLine();
            if (int.TryParse(number1, out m2))
            {
                m2 = Convert.ToInt32(number2);
            }
            return (m + m2);
        }
        static int subtraktion()
        {
            int m;
            int m2;
            Console.Clear();
            Console.WriteLine("nu kom du till subtraktion metoden.");
            Console.WriteLine("nu få du skriva två nummer för att subtrahera ihop : ");
            Console.Write("första nummer : ");
            var number1 = Console.ReadLine();
            if (int.TryParse(number1, out m))
            {
                m = Convert.ToInt32(number1);
            }
            Console.Write("andra nummer : ");
            var number2 = Console.ReadLine();
            if (int.TryParse(number1, out m2))
            {
                m2 = Convert.ToInt32(number2);
            }
            return (m - m2);
        }
        static int multiplikation()
        {
            int m;
            int m2;
            Console.Clear();
            Console.WriteLine("nu kom du till multiplikation metoden.");
            Console.WriteLine("nu få du skriva två nummer för att gånga ihop  : ");
            Console.Write("första nummer : ");
            var number1 = Console.ReadLine();
            if (int.TryParse(number1, out m))
            {
                m = Convert.ToInt32(number1);
            }
            Console.Write("andra nummer : ");
            var number2 = Console.ReadLine();
            if (int.TryParse(number1, out m2))
            {
                m2 = Convert.ToInt32(number2);
            }
            return (m * m2);
        }
        static int divition ()
        {
            int resultat ;
            int m;
            int m2;
            Console.Clear();
            Console.WriteLine("nu kom du till divition dividera ihop.");
            Console.WriteLine("nu få du skriva två nummer för att subtrahera  : ");
            Console.Write("första nummer : ");
            var number1 = Console.ReadLine();
            if (int.TryParse(number1, out m))
            {
                m = Convert.ToInt32(number1);
            }
            Console.Write("andra nummer : ");
            var number2 = Console.ReadLine();
            if (int.TryParse(number1, out m2))
            {
                m2 = Convert.ToInt32(number2);
            }
            try
            {
                resultat = m / m2;
            }
            catch(DivideByZeroException)
            {
                return 0 ;
            }
            catch (Exception)
            {
                return 0;
            }
            return (resultat);
        }
        static void svar (int svar)
        {
            Console.Write("svart är :");
            Console.WriteLine(svar);
        }
        static bool slutaEllerForstatta()
        {
            int m;
            Console.WriteLine("vill du fortsätta ?");
            Console.Write("1 ja / 2 nej : ");

            var svaret = Console.ReadLine();

            if (int.TryParse(svaret, out m))
            {
                m = Convert.ToInt32(svaret);
            }


            if (m == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void menu()
        {
            
            bool runme = true;
            while (runme)
            {
                Console.Clear();
                Console.WriteLine("Hej till kalkylator .");
                Console.WriteLine("välja vilken operator vill du använda ? ");
                Console.WriteLine("1- for Addition .");
                Console.WriteLine("2- for Subtraktion .");
                Console.WriteLine("3- for Multiplikation .");
                Console.WriteLine("4- for Divition .");
                Console.Write("vilken operator : ");
                var operators = Console.ReadLine();
                int koretkt; 
                if (int.TryParse(operators, out koretkt))
                {
                    koretkt = Convert.ToInt32(operators);
                }
                

                switch (koretkt)
                {
                    case 1:
                        svar(addition());
                        runme = slutaEllerForstatta();
                        break;
                    case 2:
                        svar(subtraktion());
                        runme = slutaEllerForstatta();
                        break;
                    case 3:
                        svar(multiplikation());
                        runme = slutaEllerForstatta();
                        break;
                    case 4:
                        svar(divition());
                        runme = slutaEllerForstatta();
                        break;
                    default:
                        Console.WriteLine("du angav fel val ! ");
                        runme = slutaEllerForstatta();
                        break;


                }
            }

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}