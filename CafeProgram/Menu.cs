using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Menu
    {
        private static Menu instance;
        private List<string> beverages;

        private Menu()
        {
            beverages = new List<string> { "Tea", "Smoothie", "Coffee" };
        }

        public static Menu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Menu();
                }
                return instance;
            }
        }

        public void SortMenu()
        {
            for (int i = 0; i < beverages.Count - 1; i++)
            {
                for (int j = 0; j < beverages.Count - 1 - i; j++)
                {
                    if (string.Compare(beverages[j], beverages[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        
                        string temp = beverages[j];
                        beverages[j] = beverages[j + 1];
                        beverages[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var beverage in beverages)
            {
                Console.WriteLine(beverage);
            }
        }
    }

}
