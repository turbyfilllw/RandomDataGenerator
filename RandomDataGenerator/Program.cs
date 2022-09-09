using RandomDataGenerator;


public class Program 
{
    static Random random = new Random();
    static void Main(String[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        bool menu = true;
        Console.WriteLine("Welcome to CSCI 2910 Lab 3 by Logan Turbyfill");
        while (menu)
        {
            
            Console.WriteLine("1.) Create a Person");
            Console.WriteLine("2.) Remove a Person");
            Console.WriteLine("3.) View all Persons");
            Console.WriteLine("4.) Get a random last name");
            Console.WriteLine("5.) Get a random SSN");
            Console.WriteLine("6.) Get a random phone number");
            Console.WriteLine("7.) Quit");

            switch(Console.ReadLine())
            {
                case "1":
                    break;
                    
                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    GetLastName();
                    Console.WriteLine();
                    break;

                case "5":
                    break;

                case "6":
                    break;

                case "7":
                    menu = false;
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 7...");
                    menu = true;
                    break;
            }
        }
    }
    private static void GetLastName()
    {
        Type type = typeof(LastName);
        Array values = type.GetEnumValues();

        LastName last = (LastName)random.Next(values.Length);

        Console.WriteLine(last);
    }

}


