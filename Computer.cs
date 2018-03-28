using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
     public class Computer : Player
    {
            
    public Computer(string name, string gesture, int score)
    {
        this.name = name;
        this.gesture = gesture;
        this.score = score;

    }
        public Computer()
        {

        }
       public override string GetPlayerChoice()
        {

            Random computerChoice = new Random();
            int computerRandomInteger = computerChoice.Next(1, 6);
            if (computerRandomInteger == 1)
            {
                gesture = "rock";
                return "paper";
            }
            else if (computerRandomInteger == 2)
            {
                return "paper";
            }
            else if (computerRandomInteger == 3)
            {
                return "sissors";
            }
            else if (computerRandomInteger == 4)
            {
                return "lizard";
            }
            else
            {
                return "spock";
            }
        }
    }
    }


