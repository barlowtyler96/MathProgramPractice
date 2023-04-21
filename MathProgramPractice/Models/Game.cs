namespace MathProgramPractice.Models;

internal class Game
{
    internal int Score;

    //auto implemented properties(compiler automatically makes private fields)
    public DateTime Date { get; set; }
    
    public GameType Type { get; set; }
}
internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}
