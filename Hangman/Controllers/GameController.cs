using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Controllers
{
  public class GameController : Controller
  {

    [HttpPost("/game/play/{letter}")]
    public ActionResult New(char letter)
    {
       Game playing = Game.Find(1);

       char[] theWord = playing.TheWord.ToCharArray();
       Console.WriteLine(new string(theWord));
       if(Array.IndexOf(theWord, letter) < 0)
       {
         playing.Guesses = playing.Guesses+1;
       }
       while(Array.IndexOf(theWord, letter) >= 0)
       {
         playing.SetGuessed(Array.IndexOf(theWord, letter), letter);
         theWord[Array.IndexOf(theWord,letter)] = '_';
        Console.WriteLine(new string(theWord));
       }
       Game.RemoveLetter(letter);
       playing.TheWord = new string(theWord);
       if(Array.IndexOf(playing.GetGuessed(),'_') < 0)
       {
         playing.Winner();
       }
       return RedirectToAction("Play");
    }

    [HttpGet("/game/play")]
    public ActionResult Play()
    {
      List<Game> allCategories = Game.GetAll();
      Game toPlay = Game.Find(1);
      Console.WriteLine(toPlay.TheWord);

      return View(toPlay);
    }

    //
    [HttpPost("/game/play/again")]
    public ActionResult Replay()
    {
      Game.ResetLetters();
      Game.GetAll().RemoveAt(0);
      foreach(Game game in Game.GetAll())
      {
        game.ReduceId();
      }
      return RedirectToAction("Play");
    }

  }
}
