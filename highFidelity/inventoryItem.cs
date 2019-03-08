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
        private string id;
        private string size;
        private string stock;
        private string color;
        private string model;

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
        public void setSize(String newSize)
        {
            this.size = newSize;
        }

        public string getStock()
        {
            string newString = this.stock;
            return newString;
        }
        public void setStock(String newString)
        {
            this.stock = newString;
        }

        public string getColor()
        {
            string newString = this.color;
            return newString;
        }
        public void setColor(String newString)
        {
            this.color = newString;
        }

        public string getModel()
        {
            string newString = this.model;
            return newString;
        }
        public void setModel(String newString)
        {
            this.model = newString;
        }


    }
}
