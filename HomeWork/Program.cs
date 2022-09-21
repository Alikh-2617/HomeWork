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
            Console.WriteLine("nu kom du till divition metoden.");
            Console.WriteLine("nu få du skriva två nummer för att dividera ihop  : ");
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
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("5- loga ut ");
                Console.WriteLine("6- avsluta .");
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
                    case 5:
                        identifiering();
                        break;
                    case 6:
                        runme = slutaEllerForstatta();
                        break;
                    default:
                        Console.WriteLine("du angav fel val ! ");
                        runme = slutaEllerForstatta();
                        break;


                }
            }

        }
        static List<string> users = new List<string>();
        static void skapaKonto()
        {
            bool runme = true;
            Console.Clear();
            Console.WriteLine("Hej du behöber ger en user name för att skapa konto !");
            while (runme)
            {
                Console.Write("user name : ");
                var username = Console.ReadLine();
                if (username is not null)
                {
                    users.Add(username);
                    Console.WriteLine("vi har skapat ett konto för dig .");
                    Console.WriteLine("tryck inter tills komma till kontot .");
                    Console.ReadLine();
                    menu();
                    runme=false;
                }
                else
                {
                    Console.WriteLine("Ej korekt form user name.");
                    runme = slutaEllerForstatta();
                }
            }

        }
        static void login()
        {
            Console.Write("skrev din user name : ");
            var username = Console.ReadLine();
            if (username is not null)
            {
                foreach (var item in users)
                {
                    if (item.Contains(username))
                    {
                        Console.WriteLine(item);
                        menu();
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("vi har inte hittat ditt konoto . ");
                Console.WriteLine("vill du skapa ett istället ? eller avsluta ");
                Console.WriteLine("1 skapa ett konto / 2 för avsluta .");
                var svar = Console.ReadLine();
                int svaret;
                if (int.TryParse(svar, out svaret))
                {
                    svaret = Convert.ToInt32(svar);
                    if(svaret ==1)
                    {
                        skapaKonto();
                        
                    }
                    else
                    {
                        Console.WriteLine("tryck inter för att avsluta programmet !");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("fel form försök igen.");
                    
                }

            }
            else
            {
                Console.WriteLine("fel user name form.");


            }
        }


        static void identifiering()
        {
            int svaret;
            bool rumme = true;
            while (rumme) {
                Console.Clear();
                Console.WriteLine("Hej du har kommit till kalkylator programmet .");
                Console.WriteLine("har du ett kalkylator konto ? eller om du inte har, vill du skapa ett  ? ");
                Console.WriteLine("1- jag har konoto och vill komma åt mitt konto.");
                Console.WriteLine("2- jag har inte konto och vill skapa ett. ");
                Console.WriteLine("3- avsluta . ");
                Console.Write("svar : ");
                var svar = Console.ReadLine();
                if (int.TryParse(svar, out svaret))
                {
                    svaret = Convert.ToInt32(svar);
                }
                switch (svaret)
                {
                    case 1:
                        login();
                        rumme = false;
                        break;
                    case 2:
                        skapaKonto();
                        rumme = false;
                        break;
                    case 3:
                        rumme= slutaEllerForstatta();
                        break;
                    default:
                        Console.WriteLine("fel input.");
                        rumme = slutaEllerForstatta();
                        break;
                }
            }

        }


        

        static void Main(string[] args)
        {
            identifiering();
        }
    }
}