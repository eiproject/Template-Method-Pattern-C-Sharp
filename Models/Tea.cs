using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models {
  class Tea : Beverage {
    internal Tea() {
      Console.WriteLine("Making Delicious Tea.");
    }
    internal override void Brew() {
      Console.WriteLine("Brewing Tea.");
    }
    internal override void AddCondiment() {
      Console.WriteLine("Adding lemon.");
    }
    internal override bool IsAddCondiment() {
      return UserInput();
    }
    bool UserInput() {
      Console.WriteLine("Do you want to add lemon? (y/n)");
      string userInput = Console.ReadLine();
      if (userInput != null && userInput!= "") {
        if (userInput.First().ToString().ToLower() == "y") {
          return true;
        }
        else {
          return false;
        }
      }
      else {
        return false;
      }
    }
  }
}
