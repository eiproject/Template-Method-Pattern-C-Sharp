using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Models;

namespace TemplateMethodPattern {
  class Program {
    static void Main(string[] args) {
      Beverage coffee = new Coffee();
      coffee.Prepare();

      Beverage tea = new Tea();
      tea.Prepare();
      Console.ReadKey();
    }
  }
}
