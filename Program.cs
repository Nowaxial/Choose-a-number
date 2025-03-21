namespace chooseANumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this game! Can you find the winning number?");
        Console.Write("Choose a number between 1-10: ");

        string? userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out int number) || number < 1 || number > 10)

        {

            Console.WriteLine("That's not a valid number! Choose a number between 1-10.");
            Console.ReadLine();

        }
        else if (number == 7)
        {

            Console.WriteLine("Congrats! You won the honor of choosing the right number!");
            Console.ReadLine();

        }
        else
        {

            Console.WriteLine("Sorry, you loose!");
            Console.ReadLine();
            
        }


    }
}

