namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Try to guess my favorite number between 1 and 1000!!");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low, better luck next time!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high, better luck next time!");
            }
            else
            {
                Console.WriteLine($"Correct! My favorite number is {favNumber}!");
            }


        }
    }
}
