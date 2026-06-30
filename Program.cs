using System;
// Corrected DecideWinner logic
class Program
{
    static void Main(string[] args)
    {
        var user = args.Length > 0 ? args[0] : "Rock";
        var computer = args.Length > 1 ? args[1] : "Rock";

        Console.WriteLine(DecideWinner(user, computer));
    }

    // Now corrected
    static string DecideWinner(string user, string computer)
    {
        if (user == computer) return "Draw";
        if ((user == "Rock" && computer == "Scissors") ||
            (user == "Paper" && computer == "Rock") ||
            (user == "Scissors" && computer == "Paper"))
            return "Win";

        return "Lose";
    }
}
