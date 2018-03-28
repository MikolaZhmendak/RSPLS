using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Game
    {
        // member variables (HAS A)
        // Computervshuman
        public string yesOrNo;
        string userSelection;
        Player playerOne = new Human();
        Player playerTwo = new Human();
        Player playerThree = new Computer();
        

        public Game()
        {
            RunMyGame();
        }

        public void RunMyGame()
        {

            Console.WriteLine("Do you want to play the RPSLS game: Enter yes or no.");
            yesOrNo = Console.ReadLine().ToLower();

            while (yesOrNo != "yes" && yesOrNo != "no")
            {
                Console.WriteLine("Please enter either 'yes' or 'no' option");
                yesOrNo = Console.ReadLine();
            }


            if (yesOrNo == "yes")
            {
                Console.WriteLine("Do you want to play versus other human or versus computer? \n Type human or computer");
                userSelection = Console.ReadLine();
            }

            if (userSelection == "human")
            {
                roundWinner();
            }
            else if (userSelection == "computer")
            {
                roundWinner();
            }

            else if (yesOrNo == "no")
            {
                Console.WriteLine("Really !!! After all of this hard work you do not want to play my game.");
                Console.ReadLine();
                Environment.Exit(0);

            }
        }




        public void roundWinner() {

            Console.WriteLine("Player one select you hand:");

            playerOne.GetPlayerChoice();
          //  checkCorrectUserHandInput();
            Console.WriteLine("Player two select you hand:");

            playerTwo.GetPlayerChoice();
        //    checkCorrectUserHandInput();

            if ((playerOne.gesture == "rock" && playerTwo.gesture == "sissors") || (playerOne.gesture == "rock" && playerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player one wins");
                playerOne.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
            else if ((playerOne.gesture == "rock" && playerTwo.gesture == "paper") || (playerOne.gesture == "rock" && playerTwo.gesture == "spock"))
            {
                Console.WriteLine("Player two wins");
                playerTwo.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}" ,playerOne.score, playerTwo.score);
                
            }
           

            if ((playerOne.gesture == "paper" && playerTwo.gesture == "rock") || (playerOne.gesture == "paper" && playerTwo.gesture == "spock"))
            {
                Console.WriteLine("Player one wins");
                playerOne.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
            else if ((playerOne.gesture == "paper" && playerTwo.gesture == "sissors") || (playerOne.gesture == "paper" && playerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player two wins");
                playerTwo.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
         

            if ((playerOne.gesture == "sissors" && playerTwo.gesture == "paper") || (playerOne.gesture == "sissors" && playerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player one wins");
                playerOne.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
            else if ((playerOne.gesture == "sissors" && playerTwo.gesture == "rock") || (playerOne.gesture == "sissors" && playerTwo.gesture == "spock"))
            {
                Console.WriteLine("Player two wins");
                playerTwo.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
           

            if ((playerOne.gesture == "spock" && playerTwo.gesture == "sissors") || (playerOne.gesture == "spock" && playerTwo.gesture == "rock"))
            {
                Console.WriteLine("Player one wins");
                playerOne.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
            else if ((playerOne.gesture == "spock" && playerTwo.gesture == "paper") || (playerOne.gesture == "spock" && playerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player two wins");
                playerTwo.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);




            }
            if ((playerOne.gesture == "lizard" && playerTwo.gesture == "paper") || (playerOne.gesture == "lizard" && playerTwo.gesture == "spock"))
            {
                Console.WriteLine("Player one wins");
                playerOne.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);
            }
            else if ((playerOne.gesture == "lizard" && playerTwo.gesture == "rock") || (playerOne.gesture == "lizard" && playerTwo.gesture == "sissors"))
            {
                Console.WriteLine("Player two wins");
                playerTwo.score++;
                Console.WriteLine(" The score is: \n Player 1: {0} \n Player 2: {1}", playerOne.score, playerTwo.score);

            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "rock" || playerOne.gesture == "paper" && playerTwo.gesture == "paper" || playerOne.gesture == "sissors" && playerTwo.gesture == "sissors" || playerOne.gesture == "spock" && playerTwo.gesture == "spock" || playerOne.gesture == "lizard" && playerTwo.gesture == "lizard")
            {
                Console.WriteLine("It is a tie");
            
            }
            bestOutOfThree();
            playAnotherGame();
        }
        public void bestOutOfThree()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                roundWinner();
            }
        }



        public void playerVsComputer()
        {


            Console.WriteLine("Player select you hand:");
            playerOne.GetPlayerChoice();
            playerThree.GetPlayerChoice();
            Console.WriteLine("Computer selected " + playerThree.GetPlayerChoice());
            roundWinner();
        }




        public void playAnotherGame()
        {
            Console.WriteLine("Do you want to play again (yes or no)");
            string toPlayAgain = Console.ReadLine();
            if (toPlayAgain == "yes")
            {
                playerOne.score = 0;
                playerTwo.score = 0;
                roundWinner();
            }
            else if (toPlayAgain == "no")
            {
                Console.WriteLine("Thank you for playing");
                Environment.Exit(0);
            }
        }





       //public void checkCorrectUserHandInput()
       // {

       //     if (playerOne.gesture != "rock" && playerOne.gesture != "paper" && playerOne.gesture != "sissors" && playerOne.gesture != "lizard" && playerOne.gesture != "spock")
       //     {
       //         Console.WriteLine("Player one. Invalid input. Try again.");
       //     }
       //     else if (playerTwo.gesture != "rock" && playerTwo.gesture != "paper" && playerTwo.gesture != "sissors" && playerTwo.gesture != "lizard" && playerTwo.gesture != "spock")
       //     {
       //         Console.WriteLine("Player two. Invalid input. Try again.");
       //     }
       //     else if (playerThree.gesture != "rock" && playerThree.gesture != "paper" && playerThree.gesture != "sissors" && playerThree.gesture != "lizard" && playerThree.gesture != "spock")
       //     {
       //         Console.WriteLine("Player three. Invalid input. Try again.");
       //             }
                //  }

            }
}

