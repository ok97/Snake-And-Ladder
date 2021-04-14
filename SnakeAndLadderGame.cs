using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{  /* UC5:- Ensure the player gets to exact winning position 100. - Note in case the player position go above
            100, the player stays in the same previous
            position till the player gets the exact number that adds to 100

    */
    class SnakeAndLadder
    {
        int START_POSITION = 0; // Declare integer start position in 0
        const int NoPlay = 0;  
        const int Ladder = 1;
        const int Snakle = 2;
        const int winning_position = 100; // Declare Winning Position 100
        public void PlayGame()
        {
            int Player = 0;
            while (Player < winning_position)
            {
                Random random = new Random(); //Generate random integers in range 0 to 6
                 int Die = random.Next(1, 6);    // Random Value Generate 1 to 6
                int Option = random.Next(0, 3); // Random generate 0 to 3 value


                switch (Option) // use switch casw for option Random value
                {
                    case NoPlay:
                        Console.WriteLine("No Play, Pass the chance"); // Print  
                        break;
                    case Ladder:
                        Player += Die; // 
                        Console.WriteLine("You got Ladder \n Player position = " + Player); // Print player value random genrate
                        break;
                    case Snakle:
                        Player -= Die;
                        if (Player < START_POSITION) //Check Lessthan Start Position
                        {
                            Player = START_POSITION; // Player value = Start Value
                        }
                        Console.WriteLine("You gotSnake \n player position = " + Player);

                        break;
                }

            }
          // Console.WriteLine(" Player Die Roll Position :- " + Die);                   //Print Random value
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION);     //Print Start Position
            Console.ReadLine();
        }
        static void Main(string[] args)//Main method
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder(); // Calling Method
            StartPlay.PlayGame();//method PlaGame

        }
    }
}
