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
        inventoryManager itemList = new inventoryManager();


        public Form1()
        {
            InitializeComponent();
            btn_update.Enabled = false;
            btn_edit.Enabled = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //idk why I need a try catch but it is in there just in case
            try
            {
                //making the parameters for the class equal to what are in the text boxes
                string id = idCounter.ToString();
                string size = txtbx_size.Text;
                int stock = int.Parse(txtbx_stock.Text);
                string color = txtbx_color.Text;
                string model = txtbx_model.Text;
                string cost = txtbx_cost.Text;

                //actually making the item using the parameters that were created fromt the boxes
                inventoryItem item = new inventoryItem(id, size, stock, color, model, cost);
                //adding it to the List
                itemList.Add(item);
                //adding it to list box
                lstbx_items.Items.Add(item);
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
            //assigning the index of the list box to i 
            int i = lstbx_items.SelectedIndex;
            //using i as the index of the List and setting the text boxes to what the values are
            //from the selected index in the array

            inventoryItem target = itemList.findByID(i.ToString());

            txtbx_size.Text = target.size;
            txtbx_stock.Text = target.stock.ToString();
            txtbx_color.Text = target.color;
            txtbx_model.Text = target.model;
            txtbx_cost.Text = target.cost;

            //after I get the values i need to set them to what are in the text boxes

            target.size = txtbx_size.Text;
            target.stock = int.Parse(txtbx_stock.Text);
            target.color = txtbx_color.Text;
            target.model = txtbx_model.Text;
            target.cost = txtbx_cost.Text;
            btn_update.Enabled = true;
            btn_add.Enabled = false;
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            int i = lstbx_items.SelectedIndex;

            inventoryItem target = itemList.findByID(i.ToString());

            target.size = txtbx_size.Text;
            target.stock = int.Parse(txtbx_stock.Text);
            target.model = txtbx_model.Text;
            target.size = txtbx_size.Text;
            target.cost = txtbx_cost.Text;

            //clearing the list box so that the old stuff doesn't stay in there
            lstbx_items.Items.Clear();

            //making the list box again with the array list so that the updated array list is displayed
            for (int j = 0; j < itemList.getAllItems().Length; j++)
            {
                //not sure if this one works
                lstbx_items.Items.Add(target);
            }

            //resetting the text boxes back to blank
            txtbx_size.Text = "";
            txtbx_stock.Text = "";
            txtbx_color.Text = "";
            txtbx_model.Text = "";
            txtbx_cost.Text = "";
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //itemList.RemoveAt(lstbx_items.SelectedIndex);

            //lstbx_items.Items.Clear();

            //for (int i = 0; i < itemList.Count; i++)
            //{
            //    lstbx_items.Items.Add(itemList[i]);
            //}

            //this was my attempt at having the id increment at the next id after one was deleted
            //idCounter = (int.Parse(itemList[itemList.Count - 1].getID()) + 1);

        }

        private void lstbx_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_edit.Enabled = true;
        }
    }
}
