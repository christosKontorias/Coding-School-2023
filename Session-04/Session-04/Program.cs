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
        ProgramSix programSix = new ProgramSix();
        ProgramSeven programSeven = new ProgramSeven();



        Console.WriteLine("Session 4 EXERCISE");
        Console.WriteLine();
        Console.WriteLine("Question 1:");
        Console.WriteLine(programOne.HelloName());

        Console.WriteLine();

        Console.WriteLine("Question 2:");
        Console.WriteLine("The sum:" + " 8.5 " + "+ " + "1.5" + " = "+ programTwo.Sum());
        Console.WriteLine("The division:" + " 8.5 " + "/ " + "1.5" + " = " + programTwo.Division());

        Console.WriteLine();

        Console.WriteLine("Question 3:");
        Console.WriteLine("A: " + programThree.operationOne());
        Console.WriteLine("B: " + programThree.operationTwo());
        Console.WriteLine("C: " + programThree.operationThree());
        Console.WriteLine("D: " + programThree.operationFour());
        Console.WriteLine("E: " + programThree.operationFive());

        Console.WriteLine();

        Console.WriteLine("Question 4:");
        Console.WriteLine(programFour.GenderAge());

        Console.WriteLine();

        Console.WriteLine("Question 5:");
        Console.WriteLine("Minutes: " + programFive.MinutesCalculation());
        Console.WriteLine("Hours: " + programFive.HoursCalculation());
        Console.WriteLine("Days: " + programFive.DaysCalculation());
        Console.WriteLine("Years: " + programFive.YearsCalculation());

        Console.WriteLine();

        Console.WriteLine("Question 6:");
        Console.WriteLine("Minutes: " + programSix.MinutesTimeSpan());
        Console.WriteLine("Hours: " + programSix.HoursTimeSpan());
        Console.WriteLine("Days: " + programSix.DaysTimeSpan());
        Console.WriteLine("Years: " + programSix.YearsTimeSpan());

        Console.WriteLine();

        Console.WriteLine("Question 7:");
        Console.WriteLine("Celcius: 25.5");
        Console.WriteLine("Kelvin: " + programSeven.CelsiusToKelvin());
        Console.WriteLine("Fahrenheit: " + programSeven.CelsiusToFahrenheit());


        Console.ReadLine(); 
    }
}