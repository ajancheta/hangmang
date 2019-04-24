using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  class MainClass
  {
    public static void Main()
    {
      List<Item> newList = new List<Item>{};

      for (int i = 0; i <= 0; i--)
      {
        Console.WriteLine("Would you like to add a list item? [y]es, [v]iew list, or [e]xit?");
        string userResponse = Console.ReadLine().ToLower();

        if (userResponse == "y")
        {
          Console.WriteLine("Add an item!");
          string userAddItem = Console.ReadLine();
          Item newUserListItem = new Item(userAddItem);
          newList.Add(newUserListItem);
        }

        else if (userResponse == "v")
        {
          foreach (Item element in Item.GetAll())
          {
            Console.WriteLine(element.GetDescription());
          }
        }

        else
        {
          return;
        }

      }
    }
  }
}
