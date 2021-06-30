using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudioCh19
{
    public class MenuItems
    {
        //each menu item has a price and description, and category
        //1. item key
        //2. menu item
        //    2a. item name
        //    2b. item description
        //    2c. item category (string Array: appetizer, main course, dessert)
        //    2d. item price
        //3. is the menu item new? (New or Classic)
        //4.  when was the item updated (DateTime) 


        public int ItemKey { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCategory { get; set; }
        public double ItemPrice { get; set; }
        public string ItemNew { get; set; }


        public MenuItems
        (
          int itemKey,
          string itemName,
          string itemDescription,
          string itemCategory,
          double itemPrice,
          string itemNew

        )
        {
            ItemKey = itemKey;
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemCategory = itemCategory;
            ItemPrice = itemPrice;
            ItemNew = itemNew;

        }
    }
}
