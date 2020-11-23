namespace GameApp.models
{
    public class Player
    {
        public string PlayerChoice { get; set; }
        public string UserName { get; set; }

        public int currentRound { get; set; }

        public int maxRounds { get; set; }

        public Player(string playerChoice, string username, int currentround, int maxrounds)
        {
            this.PlayerChoice = playerChoice;
            this.UserName = username;
            this.currentRound = currentround;
            this.maxRounds = maxrounds;
        }

        public Player()
        {
            this.PlayerChoice = null;
        }

        
    }

}