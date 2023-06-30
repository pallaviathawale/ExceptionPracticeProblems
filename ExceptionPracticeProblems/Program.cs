namespace ExceptionPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            DetermineAge determineAge = new DetermineAge();
            determineAge.GetCategory(age);
        }
    }
}