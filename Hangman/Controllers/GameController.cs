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
       if(Array.IndexOf(theWord, letter) < 0)
       {
         playing.Guesses = playing.Guesses+1;
       }
       while(Array.IndexOf(theWord, letter) >= 0)
       {
         playing.SetGuessed(Array.IndexOf(theWord, letter), letter);
         theWord[Array.IndexOf(theWord,letter)] = '_';
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

      if(Game.GetAll().Count > 0)
      {
        List<Game> allCategories = Game.GetAll();
        Game toPlay = Game.Find(1);
        return View(toPlay);
      }else
      {
        return RedirectToAction("Index", "Home");
      }

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
      if(Game.GetAll().Count > 0)
      {
        return RedirectToAction("Play");
      }else
      {
        return RedirectToAction("Index", "Home");
      }
    }

  }
}
