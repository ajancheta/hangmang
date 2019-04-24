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

      //give thks a class

      if (userResponse == "y")
      {
        Console.WriteLine("Ay ay ay. You wan a list?");
        string userAddItem = Console.ReadLine();
        Item newUserListItem = new Item(userAddItem);
        Main();
        Console.WriteLine(newUserListItem.GetDescription());
      }

      else if (userResponse == "n")
      {
        Console.WriteLine("HELLO");
        return;
      }

      else if (userResponse == "v")
      {
        //foreach loop
        // Console.WriteLine(newUserListItem.GetDescription());
      }

      else
      {
      }

        // End class
    }
  }
}
