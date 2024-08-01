using System;
namespace Iterator {
    public class Waitress {
        Menu pancakeHouseMenu;
        Menu dinnerMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinnerMenu) {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinnerMenu = dinnerMenu;
        }

        public void printMenu() {
            Iterator<MenuItem> pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator<MenuItem> dinnerIterator = dinnerMenu.createIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            printMenu(dinnerIterator);
        }

        private void printMenu(Iterator iterator) {
            while (iterator.hasNext()) {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}