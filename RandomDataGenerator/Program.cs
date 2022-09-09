using RandomDataGenerator;


public class Program 
{
    private static Random random = new Random();
    private static Person person;
    //private static Phone phone = new Phone();
    private static List<Person> list = new List<Person>();
    static void Main(String[] args)
    {
        //Console.WriteLine(phone);
        
        Menu();
    }


    /// <summary>
    /// Menu method to display the menu of options to the user
    /// and calculate the correct output
    /// </summary>
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
                    Console.Clear();
                    Console.WriteLine("How many people would you like to create?: ");
                    int max = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < max; i++)
                    {
                        person = new Person();
                        list.Add(person);
                        Console.WriteLine("Person created!");
                    }
                    
                    MoveOn();
                    break;
                    
                case "2":
                    break;

                case "3":
                    Console.Clear();
                    foreach(var persons in list)
                    {
                        Console.WriteLine(persons);
                    }
                    MoveOn();
                    break;

                case "4":
                    Console.Clear();
                    GetLastName();
                    Console.WriteLine();
                    MoveOn();
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

    /// <summary>
    /// a helper method to help readability for the user.
    /// </summary>
    private static void MoveOn()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }

    /// <summary>
    /// Gets a random last name from the LastName enum
    /// </summary>
    private static void GetLastName()
    {
        Type type = typeof(LastName);
        Array values = type.GetEnumValues();

        LastName last = (LastName)random.Next(values.Length);

        Console.WriteLine(last);
    }

}


