using System;

namespace GameApp.models
{
    public class Game
    {
        public string PlayerChoice { get; set; } 
        public string ComChoice { get; set; }
        public string GameResult { get; set; }

        public string UserName { get; set; }

        public int MaxRounds { get; set; }

        public int CurrentRound { get; set; }

        public string FinalGameResult { get; set; }


        public string noRound;

        public int userscore;

        public int comscore;

       



        public void CpuRandomChoice()
        {
            // selecting random choice by setting array with possible values
            string[] ArrayChoice = { "Rock", "Paper", "Scissors" };
            //setting up rand
            Random random = new Random();
            //return variable from array with rand index
            this.ComChoice = ArrayChoice[random.Next(0,3)];
        }


  public void PlayerSelection(string playerselection, string username, int currentround, int maxrounds)
        {
            //Player player1 = new Player(playerselection, username);
            this.PlayerChoice = playerselection;
            this.UserName = username;
            this.CurrentRound = currentround;
            this.MaxRounds = maxrounds;
            
        }
    


        
 /* public void RoundSelection(string numRound,string loginusername)
        {
            
            this.numberofRounds = numRound;
            this.userName = loginusername;
            
            
        }*/

        public void Results()
        {
          this.CpuRandomChoice();
          string combineSelections = this.PlayerChoice + this.ComChoice;      
        
            
            if (combineSelections == "RockScissors" || combineSelections == "PaperRock"|| combineSelections == "ScissorsPaper")
            {
                this.GameResult = "You Win";
                userscore++;
            }
            else if (combineSelections == "RockPaper" || combineSelections == "ScissorsRock" || combineSelections == "PaperScissors")
            {
                this.GameResult = "You Loose!";
                comscore++;
            }
            else 
            {
                this.GameResult = "Draw";
                
            }
        }

    

        public void GenerateFinalGameResult(){
        if(this.userscore > this.comscore)
        {
            this.FinalGameResult = "A Winning Champ!";
        } 
         else if (this.userscore < this.comscore)
         {
           this.FinalGameResult = "A Big Loser!";
         }
         else
        {
             this.FinalGameResult = "An Uninteresting Draw!";
        }
          }
}
}
