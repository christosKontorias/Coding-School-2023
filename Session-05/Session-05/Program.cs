using Session_05;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        ProgramOne programOne = new ProgramOne();
        ProgramTwo programTwo = new ProgramTwo();


        ProgramFive programFive = new ProgramFive();



        String choice, questionTwochoice;

        DisplayMainMenu();
        choice = Console.ReadLine();

        while (choice != "6")
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
                    do
                    {
                        DisplayQuestionTwoMenu();

                        questionTwochoice = Console.ReadLine().ToUpper();

                        if (questionTwochoice == "A")
                        {
                            Console.WriteLine("The Sum is: " + programTwo.Sum() + ".");
                            Console.WriteLine("Press Enter to Go Back!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (questionTwochoice == "B")
                        {
                            Console.WriteLine("The Product is: " + programTwo.Product() + ".");
                            Console.WriteLine("Press Enter to Go Back!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (questionTwochoice == "C")
                        {
                            break;                        }
                        else
                        {
                            Console.WriteLine("Invalid entry. Please press Enter to go back to question two menu!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (true);


                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Go Back!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    {
                        Console.WriteLine("Invalid entry. Please press Enter to go back to main menu!");
                        Console.ReadLine();
                        DisplayMainMenu();
                        break;
                    }
            }

            Console.Clear();
            DisplayMainMenu();
            choice = Console.ReadLine(); 
        }
    }

    static void DisplayMainMenu()
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
    static void DisplayQuestionTwoMenu()
    {
        Console.WriteLine("Question 2");
        Console.WriteLine();
        Console.WriteLine("A. Calculates the sum of an integer from 1 to n.");
        Console.WriteLine("B. Calculates the product of an integer from 1 to n.");
        Console.WriteLine("C. Exit");
        Console.WriteLine();

        Console.WriteLine("Enter Choice: ");
    }


}