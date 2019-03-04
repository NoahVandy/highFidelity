using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highFidelity
{
    class inventoryItem
    {
        private string id { get; set; }
        private string size { get; set; }
        private string stock { get; set; }
        private string color { get; set; }
        private string name { get; set; }

        public inventoryItem(string id, string size, string stock, string color, string name)
        {
            this.id = id;
            this.size = size;
            this.stock = stock;
            this.color = color;
            this.name = name;
        }

        



        override
        public string ToString()
        {
            string newString = "id: " + this.id + " size: " + this.size + " stock: " + this.stock + " color: " + this.color + " name: " + this.name;


            return newString;
        }

    }
}
