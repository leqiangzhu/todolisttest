using System.Collections;
using System.Collections.Generic;
// using ToDoList.Models;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private  int _id;
  //  private string _name;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
    //  _name = name;
      _instances.Add(this);
      _id =_instances.Count;
    }
    // public string GetName()
    // {
    //   return _name;
    // }
    //
    // public void SetName(string newName)
    // {
    //   _name = newName;
    // }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
   {
     return _id;
   }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    // public void Save()
    // {
    //    _instances.Add(this);
    // }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
   {
     return _instances[searchId-1];//value for list
   }

  }
}

// class Program
// {
//   public static void Main()
//   {
//     Console.WriteLine("Would you like to add an item or view your list? (Add/View/Quit)");
//     string input = Console.ReadLine();
//     while(input == "Add" || input == "add")
//     {
//       Console.WriteLine("Enter your item");
//       string description = Console.ReadLine();
//       Item newItem = new Item(description);
//       newItem.Save();
//       Console.WriteLine("Would you like to add an item or view your list? (Add/View/Quit)");
//       input = Console.ReadLine();
//     }
//     if(input == "View" || input == "view")
//     {
//       List<Item> viewList = Item.GetAll();
//         int number = 1;
//         foreach (Item todo in viewList)
//         {
//           Console.WriteLine(number + ". " + todo.GetDescription());
//           number++;
//         }
//         Main();
//     }
//     else
//     {
//       Console.WriteLine("Byee");
//     }
//
//   }
//
// }
