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
     [HttpPost]
      public Game PlayGame(Player Homer){
          //set player results in game
          this.game.PlayerSelection(Homer.PlayerChoice, Homer.UserName);

          this.game.CpuRandomChoice();
          //set CPU choice
          this.game.GameResults(game.playerChoice, game.cpuChoice);
          //commit results
         return game;
      } 

    }
}

