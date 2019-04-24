using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  class MainClass
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to add a list item? [y]es, [n]o, or [v]iew list");
      string userResponse = Console.ReadLine().ToLower();
      if (userResponse == "y")
      {
        Console.WriteLine("Ay ay ay. You wan a list?");
        string userAddItem = Console.ReadLine();
        Item newUserListItem = new Item(userAddItem);
        Main();
      }
      else if (userResponse == "n")
      {

      }
      else if (userResponse == "v")
      {
        //foreach loop
        // Console.WriteLine(newUserListItem.GetDescription());
      }
      else
      {}






      // LeetSpeak testLeetSpeak = new LeetSpeak();
      // Console.WriteLine("3nt3r 73x7 7o 1337 7ha7 sh17");
      // string userInput = Console.ReadLine();
      // // char[] testArray = {'a', 'b', ' ', 'c'};
      // string result = testLeetSpeak.LeetSpeakConverter(userInput);
      // Console.WriteLine(result);
    }
  }
}
