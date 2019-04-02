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
        //constructor
        public List<inventoryItem> theList { get; set; }



        public inventoryManager()
        {
            this.theList = new List<inventoryItem>();
        }

        public void Add(inventoryItem item)
        {
            this.theList.Add(item);
        }

        public bool removeItem(inventoryItem item)
        {
            return false;
        }

        public bool restock(int restock, inventoryItem item)
        {
            return false;
        }

        //public void displayAll()
        //{
        //    for(int i = 0; i < theList.Count; i++)
        //    {
        //        theList[i]; 
        //    }
        //}

        public inventoryItem findByID(string id)
        {
            inventoryItem result = null;

            for(int i =0; i < theList.Count(); i++)
            {
                //does this product have the same id as id?
                if(theList[i].id == id)
                {
                    result = theList[i];
                }
            }
            return result;
        }

        //public List<inventoryItem> findByPrice(double price)
        //{

        //}

        //public Array[] getAllItems()
        //{

        //}

        //override
        //public string ToString()
        //{

        //    string newString = "id: " + this.id + " size: " + this.size + " stock: " + this.stock + " color: " + this.color + " model: " + this.model + " cost: " + this.cost;
        //    return newString;
        //}
    }
}
