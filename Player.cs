using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Player
    {
        public string name;
        public string gesture;
        public int score;
        List<string> gestures = new List<string>() { "Rock", "Paper", "Sissors", "Lizard", "Spock" };
        public Player() 
        {


        }
        public void diplayPlayerName()
        {
            Console.WriteLine(" {0} Welcome go the game", name);
        }
        private void displayRules()
        {
         Console.WriteLine("Rules:\n 1.There will be three rounds. \n 2.You can play against other player or against computer. \n 3. Here is the list of winner based on the option that you choose:\n Paper wins against Rock and Spock. \n Rock wins against Scissors or Spock. \n Scissors wins against Paper or Lizard. \n Spock wins against Scissors or Rock. \n Lizard wins against Spock and Paper.");
         Console.ReadLine();
        }

        public virtual string GetPlayerChoice()
        {
            return "";
        }
    }
}

        
  
  
        
    
   



