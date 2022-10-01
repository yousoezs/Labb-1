using static System.Console;

namespace Labb_2
{
    /*Skapa en konsollaplikation som skall agera som en enkel affär.
     När programmet körs så ska man få se någon form av meny där man ska kunna välja att registrera ny kund eller logga in. 
    Därefter ska ytterligare en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.
    Om man väljer att handla ska man få upp minst 3 olika produkter att köpa (t.ex. Korv, Dricka och Äpple). 
    Man ska se pris för varje produkt och kunna lägga till vara i kundvagn.
    Kundvagnen ska visa alla produkter man lagt i den, styckpriset, antalet och totalpriset samt totala kostnaden för hela kundvagnen. 
    Kundvagnen skall sparas i kund och finnas tillgänglig när man loggar in.
    När man ska Registrera en ny kund ska man ange Namn och lösenord. Dessa ska sparas och namnet ska inte gå att ändra.
    Väljer man Logga In så ska man skriva in namn och lösenord. 
    Om användaren inte finns registrerad ska programmet skriva ut att kunden inte finns och fråga ifall man vill registrera ny kund. 
    Om lösenordet inte stämmer så ska programmet skriva ut att lösenordet är fel och låta användaren försöka igen.
    Både kund och produkt ska vara separata klasser med Properties för information och metoder för att räkna ut totalpris och verifiera lösenord.
    I klassen Kund skall det finnas en ToString() som skriver ut Namn, lösenord och kundvagnen på ett snyggt sätt.

Exempel:

    public class Customer 
    {
        public string Name { get; private set; }

        private string Password { get; set }

        private List<Product> _cart;
        public List<Product> Cart { get { return _cart; } }

        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Product>();
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            string name = string.Empty, password = string.Empty;
            Customer newCustomer = new Customer(name, password);
            Customer customer1 = new Customer("Knatte", "123");
            Customer customer2 = new Customer("Fnatte", "321");
            Customer customer3 = new Customer("Tjatte", "213");
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);


            while (true)
            {
                WriteLine("Welcome!\n1.Login ---\n2.Register User ---");

                ConsoleKeyInfo key = ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            StreamReader sr = new StreamReader("C:\\Users\\Toni Skoro\\Documents\\GitHub\\Labb-2\\Labb 2\\Labb 2\\Info\\Konton.txt");
                            Clear();
                            WriteLine("Enter your Username:");
                            string userN = ReadLine();
                            if (userN.Equals(sr.ReadLine()))
                            {
                                WriteLine("Username exists, proceed...");
                            }
                            else
                            {
                                WriteLine("User does not exist, do you wish to register a user or try again?\n Press space to go back once and choose!");
                                
                                ReadKey();
                                Clear();
                                continue;
                            }
                            WriteLine("Now enter your password:");
                            string passW = ReadLine();
                            if (passW.Equals(sr.ReadLine()))
                            {
                                Clear();
                                Write("Nu funkar det!");
                                ReadKey();
                            }
                            else
                            {
                                WriteLine("Password was wrong, returning to menu again!");
                                break;
                            }
                            sr.Close();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            StreamWriter sw = new StreamWriter("C:\\Users\\Toni Skoro\\Documents\\GitHub\\Labb-2\\Labb 2\\Labb 2\\Info\\Konton.txt");
                            Clear();
                            WriteLine("Please enter your username:");
                            string userN = ReadLine();
                            sw.WriteLine(userN);
                            WriteLine("Thank you! Now enter your password: ");
                            string passW = ReadLine();
                            sw.WriteLine(passW);
                            WriteLine("Now verify your password...");
                            string verifyPass = ReadLine();
                            if (verifyPass == passW)
                            {
                                WriteLine("You have verified you password!");
                            }
                            else
                            {
                                WriteLine("You did not type the password correctly!");
                            }
                            newCustomer = new Customer(userN, passW);
                            customers.Add(newCustomer);
                            WriteLine("Thank you for the registration, now chose one of the following!\n");
                            sw.Close();
                            continue;
                        }
                    default:
                        WriteLine("Wrong key pressed, user 1 or 2.");
                        WriteLine("Press space!");
                        ReadKey();
                        break;
                }
                Clear();
            }
        }



        //public static Customer ReturnInfo(List<Customer> customers)
        //{
        //    StreamReader sr = new StreamReader("C:\\Users\\Toni Skoro\\Documents\\GitHub\\Labb-2\\Labb 2\\Labb 2\\Info\\Konton.txt");
        //    foreach (var s in customers)
        //    {
        //        switch (sr.ReadLine())
        //        {
        //            case s:
        //                customers.Exists(sr.ReadLine());
        //        }
        //    }
        //}
    }
}