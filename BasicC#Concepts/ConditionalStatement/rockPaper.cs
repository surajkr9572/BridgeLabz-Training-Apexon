//Implement a simple rock, paper, scissors game in C#. Prompt the user to enter their choice, and use conditional statements
//to determine the winner based on the game rules (rock beats scissors, scissors beat paper, paper beats rock).


using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class rockPaper
    {
        public void rock(string input)
        {
            Random r=new Random();
            int comp=r.Next(3);
            string computerchoice = "";
            if (comp == 0)
            {
                computerchoice = "rock";
            }
            else if(comp == 1)
            {
                computerchoice = "paper";
            }
            else
            {
                computerchoice = "scissors";
            }
            if (input == computerchoice)
            {
                Console.WriteLine("Draw");
            }
            else if((input == "rock" && computerchoice== "scissors") || (input== "scissors" && computerchoice== "paper") || (input== "paper" && computerchoice== "rock"))
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Computer Win");
            }
        }
    }
}
