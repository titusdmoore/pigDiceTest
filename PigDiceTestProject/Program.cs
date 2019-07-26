using System;

namespace PigDiceTestProject {
    class Program {
        static void Main(string[] args) {
            Random roll = new Random();
            int rollInt = 0;
            bool play = true;
            int total = 0;
            int highScore = 0;
            int autoIdx = 0;
            bool auto = false;

            do {
                string playString = null;
                char playChar = 'c';
                Console.WriteLine($"Do you wish to play the game?{Environment.NewLine}[Y] for Yes{Environment.NewLine}[N] for No" +
                    $"{Environment.NewLine}[A] for Running Auto for 100 times{Environment.NewLine}[G] if you have time and want to go for Gregs Record");

                if (total != 0) {
                    Console.WriteLine($"{Environment.NewLine}Your Last Score was {total}{Environment.NewLine}" +
                        $"The Highest Score this run was {highScore}");
                }

                playChar = Console.ReadKey(true).KeyChar;
                playString = Convert.ToString(playChar).ToUpper();
                Console.WriteLine(playString);
                Console.Clear();

                switch (playString) {
                    case "Y":
                        play = true;
                        total = 0;
                        Console.Clear();
                        break;
                    case "A":
                        auto = true;
                        autoIdx = 0;
                        total = 0;
                        break;
                    case "G":
                        auto = true;
                        autoIdx = 0;
                        total = 0;
                        break;
                    default:
                        play = false;
                        Console.Clear();
                        break;
                }

                do {
                    rollInt = roll.Next(1, 6);
                    total += rollInt;
                    if (highScore < total) {
                        highScore = total;
                    }
                } while (rollInt != 1 && !auto);


                //Runs for case "A"
                while (auto && autoIdx < 101) {
                    rollInt = roll.Next(1, 6);
                    total += rollInt;
                    if (highScore < total) {
                        highScore = total;
                    }
                    autoIdx++;
                }

                //Runs for Case "G"
                while (auto && autoIdx < 10000001) {
                    rollInt = roll.Next(1, 6);
                    total += rollInt;
                    if (highScore < total) {
                        highScore = total;
                    }
                    autoIdx++;
                }

            } while (play);
            Console.WriteLine("Thanks for playing!");
        }
    }
}
