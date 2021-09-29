using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public string Length { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Price { get; set; }
    private static List<Item> _instances = new List<Item> { };

    public Item(string description, string length, string width, string height, string weight, string price)
    {
      Description = description;
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Price = price;
      _instances.Add(this);
    }

    //function
    public int PriceReturn(string length, string width, string height, string weight, string price)
    {
      //int resul = int.Parse(input);
      int intLength = int.Parse(length);
      int intWidth = int.Parse(width);
      int intHeight = int.Parse(height);
      int intWeight = int.Parse(weight);
      int sum = intLength + intWidth + intHeight + intWeight;
      Price = sum.ToString();
      return sum;
      //System.Console.WriteLine(intPrice);

      // if ((weight / (length * width * height)) <= 1)
      // {
      //   Price = "5 dollars";
      //   return Price;
      // }
      // else if ((weight / (length * width * height)) >= 5 && (weight / (length * width * height)) <= 15 )
      // {
      //   Price = "15 dollars";
      //   return Price;
      // }
      // else 
      // {
      //   Price = "50 dollars";
      //   return Price;
      // }

    }
    public static List<Item> GetAll()
    {
      return _instances;
    }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}
