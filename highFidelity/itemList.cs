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
    class itemList
    {
        private List<inventoryItem> theList { get; set; }



        public itemList()
        {
            this.theList = new List<inventoryItem>();
        }

        override
        public string ToString()
        {
            string newString = this.theList.ToString();
            return newString;
        }
    }
}
