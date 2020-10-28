using ClassLibrary1.GameOjrcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int MyProperty { get; set; }
        private void ShowUI()
        {
            Console.WriteLine("Main Window!");
        }

        private void Method2()
        {
            Console.WriteLine("Test!");
        }

        private void ShowHero(Hero h)
        {
            Console.WriteLine($"{h.Health} {h.Strength}");
        }
    }
    
    public class Window
    {
        public void Show()
        {
            // showing...
        }
    }
}
