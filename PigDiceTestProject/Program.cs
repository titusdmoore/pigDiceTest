using System;

namespace PigDiceTestProject {
    class Program {
        static void Main(string[] args) {
            Random roll = new Random();
            int rollInt = 0;
            bool play = true;
            int total = 0;

            do {
                string playString = null;
                Console.WriteLine($"Do you wish to play the game?{Environment.NewLine}[Y] for Yes{Environment.NewLine}[N] for No");
                playString = Convert.ToString(Console.ReadKey());
                playString = playString.ToUpper();
                Console.Clear();

                // For future debugging, right now we are not geting the string 'Y' 
                Console.WriteLine(playString);
                if (playString == "Y") {
                    play = true;
                }else {
                    play = false;
                }

                do {
                    rollInt = roll.Next(1, 6);

                    total += rollInt;
                } while (rollInt != 1);
            } while (play);

            Console.WriteLine($"Your score is {total}");
        }
    }
}
