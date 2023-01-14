using Session_05;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        ProgramOne programOne = new ProgramOne();



        String choice;

        DisplayMenu();
        choice = Console.ReadLine();

        while(choice != "6")
        {
            switch(choice)
            {
                case "1":
                    Console.WriteLine(programOne.ReverseName());
                    Console.WriteLine("Press Enter to Go Back!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    break;

                default:
                    {
                        Console.WriteLine("Invalid entry. Please press Enter to go back to main menu!");
                        Console.ReadLine();
                        DisplayMenu();
                        break;
                    }
            }

            Console.Clear();
            DisplayMenu();
            choice = Console.ReadLine(); 
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Session 5 EXERCISE");
        Console.WriteLine();
        Console.WriteLine("1. Reverses a given string.");
        Console.WriteLine("2. Sum and Product of an integer.");
        Console.WriteLine("3. Finds all the prime numbers of an integer.");
        Console.WriteLine("4. Multiplication Arrays.");
        Console.WriteLine("5. Sort a given array of integers from the lowest to the highest number.");
        Console.WriteLine("6. Exit");
        Console.WriteLine();

        Console.WriteLine("Enter Choice: ");
    }

}