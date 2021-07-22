using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models {
  class Coffee : Beverage {
    internal Coffee() {
      Console.WriteLine("Making Nice Coffee.");
    }
    internal override void Brew() {
      Console.WriteLine("Brewing coffee.");
    }
    internal override void AddCondiment() {
      Console.WriteLine("Adding sugar.");
    }
    internal override bool IsAddCondiment() {
      return UserInput();
    }
    bool UserInput(){
      Console.WriteLine("Do you want to add sugar? (y/n)");
      string userInput = Console.ReadLine();
      if (userInput != null && userInput != "") {
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
