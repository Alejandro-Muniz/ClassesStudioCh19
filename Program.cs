using System;
using System.Collections.Generic;

/*
  Chapter 19 Studio: Restaurant Menu
  In Visual Studio, create a new project, RestaurantMenu. Add the Menu and MenuItem classes and code the design that you created above. Be sure to add getters and setters as appropriate.
*/


/*
static void DisplayItem()
{
    Console.WriteLine("reporting from the the DisplayItem method");
    //foreach (item i in currentItem) ConsoleWrite($"{i}, ");
    //Console.WriteLine();

}
*/

namespace ClassesStudioCh19
{
    /*
        Starting with pen and paper (or your favorite notes application on your laptop), sketch out the design for two classes, Menu and MenuItem. List the fields that each should have, along with the data type and access level for each. Also consider what constructors the classes might need.
    */
        
    class Program
    {

        static void DisplayItem()
        {
            Console.WriteLine("reporting from the the DisplayItem method");
            //foreach (item i in currentItem) ConsoleWrite($"{i}, ");
            //Console.WriteLine();
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hello World! breakfast cafe");

            Console.WriteLine("                         M  E  N  U  :");

            //MenuItems: Key, Name, Descpription, Category(appetizer, main course, dessert), Price, New||Classic)
            MenuItems item0 = new MenuItems(0, "Eggs and Pancakes", "daily special", "main course", 3.00, "Classic");
            MenuItems item1 = new MenuItems(1, "Pecan Pie", "made every morning", "dessert", 1.00, "Classic");
            MenuItems item2 = new MenuItems(2, "Bread Sticks", "unlimited", "appetizer", 1.00, "Classic");
            MenuItems item3 = new MenuItems(3, "Honey Ham", "3 hearty slices", "main course", 3.00, "Classic");
            MenuItems item4 = new MenuItems(4, "Ice Cream", "2 scoops of vanilla or chocolate", "dessert", 2.00, "Classic");
            MenuItems item5 = new MenuItems(5, "Oatmeal cookies", "6 homemade cookies", "dessert", 2.00, "Classic");
            MenuItems item6 = new MenuItems(6, "Breakfast Tacos", "3 savory tacos", "main course", 3.00, "Classic");
            MenuItems item7 = new MenuItems(7, "Hashbrowns", "golden brown", "appetizer", 1.00, "New");
            MenuItems item8 = new MenuItems(8, "Steak and eggs", "fan favorite", "main course", 5.00, "New");
            MenuItems item9 = new MenuItems(9, "Fruit Salad", "fresh tropical fruit", "main course", 4.00, "New");
            //the ItemKey will not be displayed on the menu.  It's only purpose is to avoid duplicates. sequential according to when added.


            //this block needs to be in a loop inside a method (DisplayItem())
            Console.WriteLine($"    {item0.ItemName}, {item0.ItemDescription}, {item0.ItemCategory}, ${item0.ItemPrice}, {item0.ItemNew} \n");
            Console.WriteLine($"    {item1.ItemName}, {item1.ItemDescription}, {item1.ItemCategory}, ${item1.ItemPrice}, {item1.ItemNew} \n");
            Console.WriteLine($"    {item2.ItemName}, {item2.ItemDescription}, {item2.ItemCategory}, ${item2.ItemPrice}, {item2.ItemNew} \n");
            Console.WriteLine($"    {item3.ItemName}, {item3.ItemDescription}, {item3.ItemCategory}, ${item3.ItemPrice}, {item3.ItemNew} \n");
            Console.WriteLine($"    {item4.ItemName}, {item4.ItemDescription}, {item4.ItemCategory}, ${item4.ItemPrice}, {item4.ItemNew} \n");
            Console.WriteLine($"    {item5.ItemName}, {item5.ItemDescription}, {item5.ItemCategory}, ${item5.ItemPrice}, {item5.ItemNew} \n");
            Console.WriteLine($"    {item6.ItemName}, {item6.ItemDescription}, {item6.ItemCategory}, ${item6.ItemPrice}, {item6.ItemNew} \n");
            Console.WriteLine($"    {item7.ItemName}, {item7.ItemDescription}, {item7.ItemCategory}, ${item7.ItemPrice}, {item7.ItemNew} \n");
            Console.WriteLine($"    {item8.ItemName}, {item8.ItemDescription}, {item8.ItemCategory}, ${item8.ItemPrice}, {item8.ItemNew} \n");
            Console.WriteLine($"    {item9.ItemName}, {item9.ItemDescription}, {item9.ItemCategory}, ${item9.ItemPrice}, {item9.ItemNew} \n");

            /* 
             *  30 June 2021:  Still need to create and populate a "Menu" class.
             *  It will take and break down the menu according to category.
             *  i.e. Menu-all_items, Menu-main_course, Menu-appetizers, Menu-desserts.
             *  
             *  lastItemKey = 9;
             *  for (int item = 0; item <= lastItemKey; item++)
             *  {
             *  magicLogic
             *  Menu Appetizers = new Menu(currentItem.ItemCategory);
             *  Menu MainCourse = new Menu(currentItem.ItemCategory);
             *  Menu Dessert    = New Menu(currentItem.ItemCategory);
             *  }
             */  

            DisplayItem();
            //Console.WriteLine("is this thing on?");
        }
    }
}






