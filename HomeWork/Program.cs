using System.ComponentModel;

namespace HomeWork
{
    internal class Program
    {

        static int addition()
        {
            Console.Clear();
            Console.WriteLine("nu kom du till addition metoden.");
            Console.WriteLine("nu få du skriva två nummer för att addera ihop : ");
            Console.Write("första nummer : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("andra nummer : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            return (m + m2);
        }
        static int subtraktion()
        {
            Console.Clear();
            Console.WriteLine("nu kom du till subtraktion metoden.");
            Console.WriteLine("nu få du skriva två nummer för att subtrahera ihop : ");
            Console.Write("första nummer : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("andra nummer : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            return (m - m2);
        }
        static int multiplikation()
        {
            Console.Clear();
            Console.WriteLine("nu kom du till multiplikation metoden.");
            Console.WriteLine("nu få du skriva två nummer för att gånga ihop  : ");
            Console.Write("första nummer : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("andra nummer : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            return (m * m2);
        }
        static int divition ()
        {
            Console.Clear();
            Console.WriteLine("nu kom du till divition dividera ihop.");
            Console.WriteLine("nu få du skriva två nummer för att subtrahera  : ");
            Console.Write("första nummer : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("andra nummer : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            return (m / m2);
        }
        static void svar (int svar)
        {
            Console.Write("svart är :");
            Console.WriteLine(svar);
        }
        static bool slutaEllerForstatta()
        {
            Console.WriteLine("vill du fortsätta ?");
            Console.Write("1 ja / 2 nej : ");
            int svaret = Convert.ToInt32(Console.ReadLine());
            if (svaret == 1)
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
                int operators = Convert.ToInt32(Console.ReadLine());

                switch (operators)
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