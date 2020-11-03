namespace GameApp.models

{

 public class GameScore
    {
        public int ScorePlayer  { get; set; }
        public int ScoreCPU   { get; set; }
        public GameScore(int scorePlayer, int scoreCPU)
        {
            this.ScorePlayer  = scorePlayer;
            this.ScoreCPU  = scoreCPU;
        }

      //  public List<int> GameScored()
       // {
        //    this.ScorePlayer = 0;
        //    this.ScoreCPU = 0;        }

        
    }
}