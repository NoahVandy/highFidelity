//this is my own work
//Noah Vandervelden
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace highFidelity
{
    public partial class Form1 : Form
    {
        int idCounter = 0;
        List<inventoryItem> itemList = new List<inventoryItem>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //idk why I need a try catch but it is in there just in case
            try
            {
                //making the parameters for the class equal to what are in the text boxes
                string id = idCounter.ToString();
                string size = txtbx_size.Text;
                string stock = txtbx_stock.Text;
                string color = txtbx_color.Text;
                string model = txtbx_model.Text;

                //actually making the item using the parameters that were created fromt the boxes
                inventoryItem item = new inventoryItem(id, size, stock, color, model);
                //addin it to the List
                itemList.Add(item);
                //adding it to list box
                lstbx_items.Items.Add(item.ToString());
                //making the id auto incriment
                idCounter++;

            }
            catch
            {

            }

            //resetting the text boxes back to blank
            txtbx_size.Text = "";
            txtbx_stock.Text = "";
            txtbx_color.Text = "";
            txtbx_model.Text = "";

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //getting the index of the selected item from the list box
            lstbx_items.GetSelected(lstbx_items.SelectedIndex);
            //assigning the index of the list box to i
            int i = lstbx_items.SelectedIndex;
            //using i as the index of the List and setting the text boxes to what the values are
            //from the selected index in the array
            txtbx_size.Text = itemList[i].size;
            txtbx_stock.Text = itemList[i].stock;
            txtbx_color.Text = itemList[i].color;
            txtbx_model.Text = itemList[i].model;

            //after I get the values i need to set them to what are in the text boxes

            itemList[i].size = txtbx_size.Text;
            itemList[i].stock = txtbx_stock.Text;
            itemList[i].color = txtbx_color.Text;
            itemList[i].model = txtbx_size.Text;

        }
    }
}
