namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease guess a number from 1-100");
            int favNum = 99;
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            if (userInput < 99)
            {
                Console.WriteLine("Number to low");
            }
            else if (userInput > 99)
            {
                Console.WriteLine("Number too high");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            
            }
        }
    }
}
