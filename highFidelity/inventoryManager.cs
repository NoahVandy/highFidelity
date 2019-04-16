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
    class inventoryManager
    {
        private List<inventoryItem> theList;



        public inventoryManager()
        {
            theList = new List<inventoryItem>();
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


        //public List<inventoryItem> findByPrice(double price)
        //{

        //}

        public inventoryItem[] getAllItems()
        {
            inventoryItem[] mirror = theList.ToArray();

            return mirror;
        }

        public List<inventoryItem> getItemList()
        {
            List<inventoryItem> mirror = new List<inventoryItem>();

            foreach(inventoryItem i in theList)
            {
                inventoryItem item = i;
                mirror.Add(item);
            }
            return mirror;


        }

    }
}
