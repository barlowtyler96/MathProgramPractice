namespace MathProgramPractice
{
    internal class Menu
    {
        GameEngine GameEngine = new();
        internal void MainMenu(string name, DateTime date)
        {
            var isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"Hey {name.ToUpper()}, today is {date.DayOfWeek}. This is a math game. It's great that your practicing your skills!");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine(@$"What game type would you like to play? Choose from the options below:
                            A - Addition
                            S - Subtraction
                            M - Multiplication
                            D - Division
                            V - View Previous Games
                            Q - Quit game");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                var gameType = Console.ReadLine();

                switch (gameType.Trim().ToLower())
                {
                    case "a":
                        GameEngine.AdditionGame("Addition Game!");
                        break;
                    case "s":
                        GameEngine.SubtractionGame("Subtraction Game!");
                        break;
                    case "m":
                        GameEngine.MultiplicationGame("Multiplication Game!");
                        break;
                    case "d":
                        GameEngine.DivisionGame("Division Game!");
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "q":
                        Console.WriteLine("You quit the game. Goodbye!");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
