using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        
        string playerChoice;
        string computerChoice;
        Random random = new Random();
        bool playAgain = true;
        int gameNum = 1;

        while (playAgain)
        {
            playerChoice = "";
            computerChoice = "";

            int randomNum = random.Next(1, 4);

            while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
            {
                Console.WriteLine("ROCK PAPER SCISSORS?");
                playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToUpper();
            }

            switch (randomNum)
            {
                case 1:
                    computerChoice = "ROCK";
                    break;

                case 2:
                    computerChoice = "PAPER";
                    break;

                case 3:
                    computerChoice = "SCISSORS";
                    break;
            }

            Console.WriteLine("PLAYER: " + playerChoice);
            Console.WriteLine("COMPUTER: " + computerChoice);

            switch (playerChoice)
            {
                case "ROCK":
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("DRAW");                
                    }

                    else if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS");
                    }

                    else
                    {
                        Console.WriteLine("PLAYER WINS");
                    }
                    break;

                case "PAPER":
                    if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("DRAW");
                    }

                    else if (computerChoice == "SCISSORS")
                    {
                        Console.WriteLine("COMPUTER WINS");
                    }

                    else
                    {
                        Console.WriteLine("PLAYER WINS");
                    }
                    break;

                case "SCISSORS":
                    if (computerChoice == "SCISSORS")
                    {
                        Console.WriteLine("DRAW");
                    }

                    else if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS");
                    }

                    else
                    {
                        Console.WriteLine("PLAYER WINS");
                    }
                    break;
            }

            Console.WriteLine("PLAY AGAIN? Y/N");
            string playerResponse = Console.ReadLine().ToUpper();

            if (playerResponse == "N")
            {
                playAgain = false;
                Console.WriteLine("THANKS FOR PLAYING");
                Console.WriteLine($"YOU HAVE PLAYED {gameNum} TIME(S)");
                gameNum = 0;
            } 

            else
            {
                gameNum++;
            }
        }


        Console.ReadKey(); 
    }
}
