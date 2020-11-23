using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameApp.models;

namespace GameApp.Controller

{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
    
     Game  game = new Game();

     public List<Game> GRrounds = new List<Game>();

     /*[HttpPost]
      public Game PlayGame(Player Homer){
          //set player results in game
          this.game.PlayerSelection(Homer.PlayerChoice, Homer.UserName);

          this.game.CpuRandomChoice();
          //set CPU choice
          this.game.GameResults(game.playerChoice, game.cpuChoice);

          this.game.RoundSelection(game.numRoundPicked, Homer.UserName);
          //commit results
         return game;
      } 
      */
      [HttpPost("rounds")]
 
     public List<Game> RoundResults(Player[] player){
     int i = 0;
     foreach (var pl in player)
     {
      this.game = new Game();
      this.game.PlayerSelection(player[i].PlayerChoice, player[i].UserName,player[i].currentRound, player[i].maxRounds);
      this.game.Results();
 
      GRrounds.Add(game);
        i++; 
     }
 
        foreach (var fr in GRrounds)
    { 
        if(fr.GameResult =="Win"){
        this.game.userscore++;
    }
        else if (fr.GameResult == "Lose"){
        this.game.comscore++;
    }
    }
        this.game.GenerateFinalGameResult();
 
        return GRrounds;
    }

    }
}

