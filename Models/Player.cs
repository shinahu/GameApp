namespace GameApp.models
{
    public class Player
    {
        public string PlayerChoice { get; set; }
        public string UserName { get; set; }
        public void SetPlayerChoice(string playerchoice, string username)
        {
            this.PlayerChoice = playerchoice;
            this.UserName = username;
        }

        
    }
}