using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(0, 100);
            int check = 1;
            int difficultyNum = 0;
            while (check == 1)
            {
                Console.WriteLine("Choose a difficulty: Easy, Medium or Hard!  (or Cheater)");
                string difficulty = Console.ReadLine();

                if (difficulty.ToLower() == "easy")
                {
                    difficultyNum = 8;
                    check = 0;
                }
                else if (difficulty.ToLower() == "medium")
                {
                    difficultyNum = 6;
                    check = 0;
                }
                else if (difficulty.ToLower() == "hard")
                {
                    difficultyNum = 4;
                    check = 0;
                }
                else if (difficulty.ToLower() == "cheater")
                {
                    difficultyNum = 10000000;
                    check = 0;
                }
                else
                {
                    Console.WriteLine("Please input a correct diffculty!");
                }
            }

            for (int i = 1; i <= difficultyNum; i++)
            {

                Console.WriteLine("Guess the secret number! Guess: " + i + " of " + difficultyNum);
                string number = Console.ReadLine();



                if (secretNumber == int.Parse(number))
                {

                    Console.WriteLine("You guessed it right!");


                    Console.Beep(480, 200);

                    Console.Beep(1568, 200);

                    Console.Beep(1568, 200);

                    Console.Beep(1568, 200);



                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);


                    Console.Beep(369, 200);

                    Console.Beep(392, 200);

                    Console.Beep(369, 200);

                    Console.Beep(392, 200);

                    Console.Beep(392, 400);

                    Console.Beep(196, 400);



                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(83, 200);

                    Console.Beep(880, 200);

                    Console.Beep(830, 200);

                    Console.Beep(880, 200);

                    Console.Beep(987, 400);


                    Console.Beep(880, 200);

                    Console.Beep(783, 200);

                    Console.Beep(698, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(880, 200);

                    Console.Beep(830, 200);

                    Console.Beep(880, 200);

                    Console.Beep(987, 400);


                    Console.Beep(1108, 10);
                    Console.Beep(1174, 200);
                    Console.Beep(1480, 10);
                    Console.Beep(1568, 200);



                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(783, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(880, 200);

                    Console.Beep(830, 200);

                    Console.Beep(880, 200);

                    Console.Beep(987, 400);


                    Console.Beep(880, 200);

                    Console.Beep(783, 200);

                    Console.Beep(698, 200);


                    Console.Beep(659, 200);

                    Console.Beep(698, 200);

                    Console.Beep(784, 200);

                    Console.Beep(880, 400);

                    Console.Beep(784, 200);

                    Console.Beep(698, 200);

                    Console.Beep(659, 200);



                    Console.Beep(587, 200);

                    Console.Beep(659, 200);

                    Console.Beep(698, 200);

                    Console.Beep(784, 400);

                    Console.Beep(698, 200);

                    Console.Beep(659, 200);

                    Console.Beep(587, 200);



                    Console.Beep(523, 200);

                    Console.Beep(587, 200);

                    Console.Beep(659, 200);

                    Console.Beep(698, 400);

                    Console.Beep(659, 200);

                    Console.Beep(587, 200);

                    Console.Beep(493, 200);

                    Console.Beep(523, 200);



                    Console.Beep(349, 400);

                    Console.Beep(392, 200);

                    Console.Beep(329, 200);

                    Console.Beep(523, 200);

                    Console.Beep(493, 200);

                    Console.Beep(466, 200);



                    Console.Beep(440, 200);

                    Console.Beep(493, 200);

                    Console.Beep(523, 200);

                    Console.Beep(880, 200);

                    Console.Beep(493, 200);

                    Console.Beep(880, 200);

                    Console.Beep(1760, 200);

                    Console.Beep(440, 200);



                    Console.Beep(392, 200);

                    Console.Beep(440, 200);

                    Console.Beep(493, 200);

                    Console.Beep(783, 200);

                    Console.Beep(440, 200);

                    Console.Beep(783, 200);

                    Console.Beep(1568, 200);

                    Console.Beep(392, 200);



                    Console.Beep(349, 200);

                    Console.Beep(392, 200);

                    Console.Beep(440, 200);

                    Console.Beep(698, 200);

                    Console.Beep(415, 200);

                    Console.Beep(698, 200);

                    Console.Beep(1396, 200);

                    Console.Beep(349, 200);



                    Console.Beep(329, 200);

                    Console.Beep(311, 200);

                    Console.Beep(329, 200);

                    Console.Beep(659, 200);

                    Console.Beep(698, 400);

                    Console.Beep(783, 400);



                    Console.Beep(440, 200);

                    Console.Beep(493, 200);

                    Console.Beep(523, 200);

                    Console.Beep(880, 200);

                    Console.Beep(493, 200);

                    Console.Beep(880, 200);

                    Console.Beep(1760, 200);

                    Console.Beep(440, 200);



                    Console.Beep(392, 200);

                    Console.Beep(440, 200);

                    Console.Beep(493, 200);

                    Console.Beep(783, 200);

                    Console.Beep(440, 200);

                    Console.Beep(783, 200);

                    Console.Beep(1568, 200);

                    Console.Beep(392, 200);



                    Console.Beep(349, 200);

                    Console.Beep(392, 200);

                    Console.Beep(440, 200);

                    Console.Beep(698, 200);

                    Console.Beep(659, 200);

                    Console.Beep(698, 200);

                    Console.Beep(739, 200);

                    Console.Beep(783, 200);

                    Console.Beep(392, 200);

                    Console.Beep(392, 200);

                    Console.Beep(392, 200);

                    Console.Beep(392, 200);

                    Console.Beep(196, 200);

                    Console.Beep(196, 200);

                    Console.Beep(196, 200);



                    Console.Beep(185, 200);

                    Console.Beep(196, 200);

                    Console.Beep(185, 200);

                    Console.Beep(196, 200);

                    Console.Beep(207, 200);

                    Console.Beep(220, 200);

                    Console.Beep(233, 200);

                    Console.Beep(247, 200);

                    i = 100000000;
                }
                else if (int.Parse(number) < secretNumber)
                {


                    Console.WriteLine("You guessed too low!");

                }
                else if (int.Parse(number) > secretNumber)
                {

                    Console.WriteLine("You guessed too high!");

                }
            }
        }
    }
}
