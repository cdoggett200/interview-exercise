// Pre-Interview Exercise for
// Craig Doggett

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Enter a comma seperated list of groceries.");

            string stillData = Console.ReadLine();      // get data from user
            total = computeTotal(stillData);            // compute total of the order

            Console.WriteLine("$" + total);             // output to the screen the total
        }

        static double computeTotal(string itemsList)
        {
            double total = 0;
            int orangeCount = 0;
            int appleCount = 0;
            string groceryItem;

            string[] items = itemsList.Split(',');      // split comma delimited sctring into array

            foreach(var item in items)                  // traverse each items in array
            {
                groceryItem = item.Trim();
                if (groceryItem.Equals("Orange"))       // items is an Orange
                {
                    orangeCount++;
                } else                                  // item is an Apple
                {
                    appleCount++;
                }
            }

            total = (appleCount * 0.60) + (orangeCount * 0.25);     // compute the total
            return total; 
        }
    }
}
