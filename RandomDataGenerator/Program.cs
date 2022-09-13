using RandomDataGenerator;


public class Program 
{
    private static Random random = new Random();
    private static Person? person;
    private static Phone? phone;
    private static SSN ssn;
    private static Dependant? dependant;
    private static List<Person> list = new List<Person>();
    static void Main(String[] args)
    {
       
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

            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("How many people would you like to create?: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < max; i++)
                        {
                            person = new Person();
                            list.Add(person);
                            Console.WriteLine("Person created!");
                        }
                        MoveOn();
                        break;

                    case "2":
                        Console.Clear();
                        if(list.Count == 0)
                        {
                            Console.WriteLine("You have not created a person.");
                            MoveOn();
                            menu = true;
                        }
                        Console.Write("Enter the index of the person you would like removed: ");
                        int index = Int32.Parse(Console.ReadLine());
                        if (index == 1)
                        {
                            index = 0;
                        }

                        if(index == list.Count)
                        {
                            index = list.Count - 1;
                        }

                        if(index > list.Count)
                        {
                            Console.WriteLine("There are not that many people in the list...");
                            MoveOn();
                            continue;
                        }

                        list.RemoveAt(index);
                        Console.WriteLine("A person has been removed.");
                        MoveOn();
                        break;

                    case "3":
                        Console.Clear();
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List empty... Creating a person.");
                            person = new Person();
                            list.Add(person);
                        }
                        foreach (var persons in list)
                        {
                            Console.WriteLine(persons + "\n");
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
                        Console.Clear();
                        ssn = new SSN();
                        Console.WriteLine(ssn.ToString());
                        MoveOn();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("What seperator would you like to use?: ");
                        char sep = Convert.ToChar(Console.ReadLine());
                        phone = new Phone();
                        Console.WriteLine(phone.Format(sep));
                        MoveOn();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Thank you for using Random Data Generator!");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a number between 1 and 7...");
                        menu = true;
                        break;
                }
            } catch(Exception e)
            {
                Console.WriteLine("Something went wrong... \n" + e);
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


