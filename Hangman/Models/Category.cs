// using System.Collections.Generic;
//
// namespace Hangman.Models
// {
//   public class Category
//   {
//     private static List<Category> _instances = new List<Category> {};
//     private string _word;
//     private int _id;
//     private List<Game> _items;
//
//     public Category(string categoryName)
//     {
//       _word = categoryName;
//       _instances.Add(this);
//       _id = _instances.Count;
//       _items = new List<Game>{};
//     }
//
//     public Word { get => _word; set => _word = value; }
//
//     public int GetId()
//     {
//       return _id;
//     }
//
//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }
//
//     public static List<Category> GetAll()
//     {
//       return _instances;
//     }
//
//     public static Category Find(int searchId)
//     {
//       return _instances[searchId-1];
//     }
//
//     public List<Item> GetItems()
//     {
//       return _items;
//     }
//
//     public void AddItem(Item item)
//     {
//       _items.Add(item);
//     }
//   }
// }
