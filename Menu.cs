using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudioCh19
{
    public class Menu
    {
        //This class needs to store the date it was updated

        // required fields:
        //1. today's date
        //2. date menu was last updated

        //DateTime dateToday = new DateTime();            //not sure how it will be used but I think I will
        //DateTime dateLastUpdated = new DateTime();      //date of the most recent menu update
        public Dictionary<int, MenuItems> DictOfMenuItmes = new Dictionary<int, MenuItems>();
    }
}
