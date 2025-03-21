namespace chooseANumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this game! Can you find the winning number?");

        bool validNumber = false;

        while (!validNumber)
        {
            Console.Write("Choose a number between 1-10: ");
            string? userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int number) || number < 1 || number > 10)
            {
                Console.WriteLine("That's not a valid number!");
                Console.Write("Do you want to try again? (yes/no): ");
                string? tryAgain = Console.ReadLine();

                if (tryAgain?.ToLower() != "yes")
                {
                    break;
                }
            }
            else
            {
                validNumber = true;

                if (number == 7)
                {
                    Console.WriteLine("Congrats! You won the honor of choosing the right number!");
                }
                else
                {
                    Console.WriteLine("Sorry, you loose!");
                }

                Console.ReadLine();
            }
        }
    }
}