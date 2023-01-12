using Session_04;

internal class Program
{
    private static void Main(string[] args)
    {
        ProgramOne programOne = new ProgramOne();
        ProgramTwo programTwo = new ProgramTwo();
        ProgramThree programThree = new ProgramThree();
        ProgramFour programFour = new ProgramFour();
        ProgramFive programFive = new ProgramFive();




        Console.WriteLine("Session 4 EXERCISE");
        Console.WriteLine();
        Console.WriteLine("Question 1:");
        Console.WriteLine(programOne.HelloName());
        Console.WriteLine();
        Console.WriteLine("Question 2:");
        Console.WriteLine(programTwo.Sum());
        Console.WriteLine(programTwo.Division());
        Console.WriteLine();
        Console.WriteLine("Question 3:");
        Console.WriteLine("A: " + programThree.operationOne());
        Console.WriteLine(programThree.operationTwo());
        Console.WriteLine(programThree.operationThree());
        Console.WriteLine(programThree.operationFour());
        Console.WriteLine(programThree.operationFive());
        Console.WriteLine();
        Console.WriteLine("Question 4:");
        Console.WriteLine(programFour.GenderAge());
        Console.WriteLine();
        Console.WriteLine("Question 5:");
        Console.WriteLine(programFive.MinutesCalculation());
        Console.WriteLine(programFive.HoursCalculation());
        Console.WriteLine(programFive.DaysCalculation());
        Console.WriteLine(programFive.YearsCalculation());


        Console.ReadLine(); 
    }
}