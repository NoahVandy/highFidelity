//This is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highFidelity
{
    public class inventoryItem
    {
        public string id;
        public string size;
        public int stock;
        public string color;
        public string model;
        public double cost;

        //constructor
        public inventoryItem(string id, string size, int stock, string color, string model, double cost)
        {
            this.id = id;
            this.size = size;
            this.stock = stock;
            this.color = color;
            this.model = model;
            this.cost = cost;
        }

        override
        public string ToString()
        {
            string newString = this.id + "," + this.size + "," + this.stock + "," + this.color + "," + this.model + "," + this.cost;
            return newString;
        }

        



    }
}
