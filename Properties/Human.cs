using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Human : Player // (IS A TYPE OF)
    {        

        public Human (string name, string gesture, int score)
        {
            this.name = name;
            this.gesture = gesture;
            this.score = score;

        }

        public Human()
        {
        }

       public override string GetPlayerChoice()
        {
            Console.WriteLine(" Please choose between Paper, Rock, Sissors, Lizard, Spock ");
            gesture = Console.ReadLine().ToLower();
            if (gesture == "paper")
            {
                return "paper";
            }
            else if (gesture == "rock")
            {
                return "rock";
            }
            else if (gesture == "sissors")
            {
                return "sissors";
            }
            else if (gesture == "lizard")
            {
                return "lizard";
            }
            else if (gesture == "spock")
            {
                return "spock";
            }
            else
            {
                return GetPlayerChoice();                
            }


        }
    }
}
