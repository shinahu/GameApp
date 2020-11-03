using System;

namespace GameApp.models
{
    public class Game
    {
        public string playerChoice { get; set; } 
        public string cpuChoice { get; set; }
        public string gameResult { get; set; }

        public string userName { get; set; }

        //public static int ScorePlayer { get; set; }

        //public int ScoreCPU { get; set; }

        
        


        public void CpuRandomChoice()
        {
            // selecting random choice by setting array with possible values
            string[] ChoiceArray = { "Rock", "Paper", "Scissors" };
            //setting up rand
            Random random = new Random();
            //return variable from array with rand index
            this.cpuChoice = ChoiceArray[random.Next(0,3)];
        }


  public void PlayerSelection(string playerselection, string loginusername)
        {
            //Player player1 = new Player(playerselection, username);
            this.playerChoice = playerselection;
            this.userName = loginusername;
            
        }

        public void GameResults(string playerChoice, string cpuChoice )
        {
          
           //string CpuRandomChoice = this.PlayerChoice + this.CpuChoice;

          
        
            
            if (playerChoice == "Rock" && cpuChoice == "Scissors" || playerChoice == "Scissors" && cpuChoice == "Paper" || playerChoice == "Paper" && cpuChoice == "Rock")
            {
                this.gameResult = "You Win";
                //ScorePlayer++;
            }
            else if (playerChoice == "Rock" && cpuChoice == "Rock" || playerChoice == "Scissors" && cpuChoice == "Scissors" || playerChoice == "Paper" && cpuChoice == "Paper")
            {
                this.gameResult = "Its a Draw";
            }
            else 
            {
                this.gameResult = "You Lose";
                //ScoreCPU++;
            }
        }
    }
}
