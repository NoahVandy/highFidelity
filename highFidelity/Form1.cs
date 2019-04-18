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
        public static System.IO.StreamWriter sw;
        public inventoryManager itemList = new inventoryManager();


        public Form1()
        {
            InitializeComponent();
            btn_update.Enabled = false;
            btn_edit.Enabled = false;
            MessageBox.Show(itemList.sizeOf() + "");
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //idk why I need a try catch but it is in there just in case
            try
            {
                //making the parameters for the class equal to what are in the text boxes
                string id = txtbx_id.Text;
                string size = txtbx_size.Text;
                int stock = int.Parse(txtbx_stock.Text);
                string color = txtbx_color.Text;
                string model = txtbx_model.Text;
                double cost;
                double.TryParse(txtbx_cost.Text, out cost);

                //actually making the item using the parameters that were created fromt the boxes
                inventoryItem item = new inventoryItem(id, size, stock, color, model, cost);
                //adding it to the List
                bool result = itemList.Add(item);
                
                if(result == true)
                {
                    MessageBox.Show("Added successfully");
                }
                else
                {
                    MessageBox.Show("Error adding");
                }


                




            }
            catch
            {

            }

            //resetting the text boxes back to blank
            txtbx_id.Text = "";
            txtbx_size.Text = "";
            txtbx_stock.Text = "";
            txtbx_color.Text = "";
            txtbx_model.Text = "";
            txtbx_cost.Text = "";

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //assigning the index of the list box to i 

            //using i as the index of the List and setting the text boxes to what the values are
            //from the selected index in the array

            int i = dgv_items.CurrentCell.RowIndex;

            inventoryItem target = itemList.getItemList()[i];

            txtbx_id.Text = target.id;
            txtbx_size.Text = target.size;
            txtbx_stock.Text = target.stock.ToString();
            txtbx_color.Text = target.color;
            txtbx_model.Text = target.model;
            txtbx_cost.Text = target.cost.ToString();

            //after I get the values i need to set them to what are in the text boxes

            target.id = txtbx_id.Text;
            target.size = txtbx_size.Text;
            target.stock = int.Parse(txtbx_stock.Text);
            target.color = txtbx_color.Text;
            target.model = txtbx_model.Text;
            target.cost = double.Parse(txtbx_cost.Text);
            btn_update.Enabled = true;
            btn_add.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //int i = lstbx_items.SelectedIndex;

            //inventoryItem target = itemList.findByID(i.ToString());

            ////filling the textboxes with the properties of the desired item
            //target.size = txtbx_size.Text;
            //target.stock = int.Parse(txtbx_stock.Text);
            //target.model = txtbx_model.Text;
            //target.size = txtbx_size.Text;
            //target.cost = txtbx_cost.Text;

            ////clearing the list box so that the old stuff doesn't stay in there
            //lstbx_items.Items.Clear();

            ////making the list box again with the array list so that the updated array list is displayed
            //for (int j = 0; j < itemList.getAllItems().Length; j++)
            //{
            //    //not sure if this one works
            //    lstbx_items.Items.Add(itemList.theList[j]);
            //}

            ////resetting the text boxes back to blank
            //txtbx_size.Text = "";
            //txtbx_stock.Text = "";
            //txtbx_color.Text = "";
            //txtbx_model.Text = "";
            //txtbx_cost.Text = "";
            //btn_add.Enabled = true;
            //btn_update.Enabled = false;
            //btn_edit.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //int i = lstbx_items.SelectedIndex;

            //inventoryItem target = lstbx_items.GetType();

            //itemList.removeItem(target);

            //lstbx_items.Items.Clear();

            //inventoryItem[] mirror = itemList.getAllItems();

            //for (int j = 0; j < itemList.theList.Count; j++)
            //{
            //    lstbx_items.Items.Add(itemList.theList[j]);
            //}

        }

        private void btn_refresh_Click(object sender, EventArgs e)

        {
            List<inventoryItem> mirror = itemList.getItemList();
            //MessageBox.Show("in refresh" + mirror.Count);
            this.dgv_items.DataSource = mirror;

            

        }
    }
}
