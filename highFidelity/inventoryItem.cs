//This is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highFidelity
{
    class inventoryItem
    {
        public string id { get; set; }
        public string size { get; set; }
        public string stock { get; set; }
        public string color { get; set; }
        public string model { get; set; }

        //constructor
        public inventoryItem(string id, string size, string stock, string color, string model)
        {
            this.id = id;
            this.size = size;
            this.stock = stock;
            this.color = color;
            this.model = model;
        }


        override
        public string ToString()
        {
            string newString = "id: " + this.id + " size: " + this.size + " stock: " + this.stock + " color: " + this.color + " model: " + this.model;
            return newString;
        }

        public string getSize()
        {
            string newSize = this.size;
            return newSize;
        }

    }
}
