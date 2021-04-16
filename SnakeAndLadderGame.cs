using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{  /* UC7:- Play the game with 2 Player. In this case if a Player gets a Ladder then plays again.
            Finally report which Player won the game
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
            int[] Player = new int[2] { 0, 0 };
            int Dice_Count = 0;
            int Chance = 0;
            while (Player[Chance] < winning_position)
            {
                Random random = new Random(); //Generate random integers in range 0 to 6
                int Die = random.Next(1, 6);    // Random Value Generate 1 to 6
                int Option = random.Next(0, 3); // Random generate 0 to 3 value
                Dice_Count++; //Count the Dice
                Console.WriteLine($"Report the number of times the dice was played to win {Dice_Count}");


                switch (Option) // use switch casw for option Random value
                {
                    case NoPlay:
                        Console.WriteLine("No Play, Pass the chance"); // Print  
                        break;
                    case Ladder:
                        if(Player[Chance]+Die<=winning_position);
                        {
                            Player[Chance] += Die;

                        }
                        Console.WriteLine("You got Ladder \n Player position = " + Chance+"--->"+"Position"+" "+Player[Chance]); // Print player value random genrate
                        break;
                    case Snakle:
                        if(Player[Chance] - Die<START_POSITION)
                        {
                            Player[Chance] = START_POSITION;
                        }
                        else //(Player < START_POSITION) //Check Lessthan Start Position
                        {
                            Player[Chance] -= Die; // Player value = Start Value
                        }
                        Console.WriteLine("You gotSnake \n player = "+Chance+ "---> position "+" " + Player[Chance]);

                        break;
                    default:
                        break;
                }
                if(Option==NoPlay||Option==Snakle)
                {
                    if(Chance==0)
                    {
                        Chance = 1;
                    }
                    else
                    {
                        Chance = 0;
                    }
                }

            }
            Console.WriteLine($"Total number of Times Dice role {Dice_Count}"); //Print Dice 
                                                                               // Console.WriteLine(" Player Die Roll Position :- " + Die);                   //Print Random value
                                                                               // Console.WriteLine(" Single Player Start_Position:- " + START_POSITION);     //Print Start Position
            
        }
        static void Main(string[] args)//Main method
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder(); // Calling Method
            StartPlay.PlayGame();//method PlaGame

        }
    }
}