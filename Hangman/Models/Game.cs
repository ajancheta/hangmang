using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Game
  {
    private int _guesses;
    private int _id;
    private string _theWord;
    private char[] _guessed;
    private static List<Game> _instances = new List<Game> {};
    private static char[] _letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private bool _win = false;
    private string _initial;


    public Game (string description)
    {
      _theWord = description.ToLower();
      _instances.Add(this);
      _id = _instances.Count;
      _initial = description;
      _guesses = 0;
      _guessed = new char[_theWord.Length];
      for(int i = 0;i<_guessed.Length;i++)
      {
        _guessed[i] = '_';
      }
    }
    public int Guesses { get => _guesses; set => _guesses = value; }
    public string TheWord { get => _theWord; set => _theWord = value; }
     public string InitialWord { get => _initial; set => _initial = value; }

    public int GetId()
    {
      return _id;
    }

    public void ReduceId()
    {
      _id--;
    }

    public void Winner()
    {
      _win = true;
    }

    public bool GetWinner()
    {
      return _win;
    }

    public static List<Game> GetAll()
    {
      return _instances;
    }

    public static char[] GetLetters()
    {
      return _letters;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Game Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public char[] GetGuessed()
    {
      return _guessed;
    }

    public void SetGuessed(int ind, char letter)
    {
      _guessed[ind] = letter;
    }

    public static void ResetLetters()
    {
      _letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    }

    public static void RemoveLetter(char letter)
    {
      _letters[Array.IndexOf(_letters, letter)] = '_';
    }
  }
}
