using System;
using System.Collections.Generic;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu breakfastMenu = new PancakeHouseMenu();
            Iterator iterator = breakfastMenu.createIterator();

            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.WriteLine(menuItem.getName());
                Console.WriteLine(menuItem.getPrice());
                Console.WriteLine(menuItem.getDescription());
            }

            DinnerMenu dinnerMenu = new DinnerMenu();
            Iterator lunchItems = dinnerMenu.createIterator();

            while (lunchItems.hasNext())
            {
                MenuItem menuItem = (MenuItem)lunchItems.next();
                Console.WriteLine(menuItem.getName());
                Console.WriteLine(menuItem.getPrice());
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}