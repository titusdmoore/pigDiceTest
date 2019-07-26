using System;

namespace PigDiceTestProject {
    class Program {
        static void Main(string[] args) {

        }
    }
    class PigDice {
        public static int[] singleRun() {
            Random roll = new Random();
            int rollInt = roll.Next(1, 6);
            int highScore = 0;
            int total = 0;

            do {
                total += rollInt;
                if (highScore < total) {
                    highScore = total;
                }
            } while (rollInt != 1);

            int[] returnValues = { total, highScore };
            return returnValues;
        }
    }
}
