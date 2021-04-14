using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{  /* UC2 :- The Player rolls the die to get a number between 1 to 6. - Use ((RANDOM)) to get the number between 1 to 6
     */
    class SnakeAndLadder
    {
        int START_POSITION = 0; // Declare integer start position in 0
        public void PlayGame()
        {
            Random random = new Random();
            int Die = random.Next(1, 6);    //Random Value Generate 1 to 6
            Console.WriteLine(" Player Die Roll Position :-" + Die);        //Print Random value
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION); //Print Start Position
            Console.ReadLine();
        }
        static void Main(string[] args)//Main method
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder(); // Calling Method
            StartPlay.PlayGame();//method PlaGame

        }
    }
}
