//This is my own work
//Noah Vandervelden
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highFidelity
{
    public class inventoryManager
    {
        private List<inventoryItem> theList { get; set; }



        public inventoryManager()
        {
            theList = new List<inventoryItem>();

            inventoryItem item1 = new inventoryItem("124e", "5", 70, "Blue", "Classics", 10.99);
            theList.Add(item1);
            inventoryItem item2 = new inventoryItem("125e", "6", 71, "Orange", "Classics", 15.99);
            theList.Add(item2);
            inventoryItem item3 = new inventoryItem("126e", "7", 99, "Red", "Lows", 49.99);
            theList.Add(item3);

        }

        public bool Add(inventoryItem item)
        {

            if (theList.Contains(item))
            {
                return false;
            }
            else
            {
                this.theList.Add(item);
                return true;
            }

        }

        public int sizeOf() { return theList.Count; }


        public bool removeItem(inventoryItem item)
        {
            if (theList.Contains(item))
            {
                theList.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void restock(inventoryItem item, int restock)
        {
            item.stock = restock;

        }

        //public void displayAll()
        //{
        //    for (int i = 0; i < theList.Count; i++)
        //    {
        //        theList[i];
        //    }
        //}

        public inventoryItem findByID(string search)
        {
            inventoryItem result = null;

            for (int i = 0; i < theList.Count(); i++)
            {
                //does this product have the same id as id?
                if (theList[i].id.Equals(search))
                {
                    result = theList[i];
                    return result;
                }
            }
            return null;
        }

        public inventoryItem findByModel(string search)
        {
            inventoryItem result = null;
            for (int i = 0; i < theList.Count(); i++)
            {
                if (theList[i].model.Equals(search))
                {
                    result = theList[i];
                    return result;
                }

            }


            return result;
        }

        public List<inventoryItem> getItemList()
        {
            List<inventoryItem> mirror = new List<inventoryItem>(theList.Count); 

            foreach(inventoryItem i in theList)
            {
                inventoryItem item = i;
                mirror.Add(item);
            }
            return mirror;


        }

    }
}
