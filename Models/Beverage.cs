using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models {
  abstract class Beverage {
    internal void Prepare() {
      BoilWater();
      Brew();
      PourInCup();
      if (IsAddCondiment()) {
        AddCondiment();
      }
      Done();
    }
    internal void BoilWater() {
      Console.WriteLine("Boiling water...");
    }
    internal void PourInCup() {
      Console.WriteLine("Pouring into cup...");
    }
    internal void Done() {
      Console.WriteLine("Your beverage ready.\n");
    }
    internal abstract void Brew();
    internal abstract void AddCondiment();
    
    // hook method
    internal virtual bool IsAddCondiment() {
      return true;
    }
  }
}
