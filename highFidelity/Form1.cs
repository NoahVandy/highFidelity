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




        public static System.IO.StreamReader sr;
        public static System.IO.StreamWriter sw; 
        public inventoryManager itemList = new inventoryManager();
        



        public Form1()
        {
            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            


            sr = new System.IO.StreamReader("inventoryManager.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] fileLine = line.Split(',');

                inventoryItem fileItem = new inventoryItem(fileLine[0], fileLine[1], int.Parse(fileLine[2]), fileLine[3], fileLine[4], double.Parse(fileLine[5]));

                itemList.Add(fileItem);
                
            }
            sr.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //idk why I need a try catch but it is in there just in case
            try
            {

                sw = new System.IO.StreamWriter("inventoryManager.txt");
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

                

                if (result == true)
                {
                    MessageBox.Show("Added successfully");

                    sw.WriteLine(item.ToString());

                }
                else
                {
                    MessageBox.Show("Error adding");
                }


                List<inventoryItem> mirror = itemList.getItemList();



                //foreach (inventoryItem i in mirror)
                //{
                //    sw.WriteLine(item.id + "," + item.size + ",", item.stock + "," + item.color + "," + item.model + "," + item.cost);
                //}


                sw.Close();







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
            btn_add.Enabled = false;
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = dgv_items.CurrentCell.RowIndex;

            inventoryItem target = itemList.getItemList()[i];

            itemList.removeItem(target);

        }

        private void btn_refresh_Click(object sender, EventArgs e)

        {
            List<inventoryItem> mirror = itemList.getItemList();
            this.dgv_items.DataSource = mirror;

            

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = txtbx_search.Text;
            List<inventoryItem> mirror = itemList.getItemList();

            List<inventoryItem> searchList = new List<inventoryItem>();
            

            //making the numbers of the item into strings
            int stock;
            int.TryParse(search, out stock);
            double cost;
            double.TryParse(search, out cost);


            //this is running throught the list with a copy
            for (int i = 0; i < mirror.Count; i++)
            {
                //this checks if any item in the list is equal to the string that was passed in to search
                if (mirror[i].id.Contains(search) || mirror[i].size.Contains(search) || mirror[i].stock.ToString().Contains(stock.ToString()) || mirror[i].color.Contains( search ) || mirror[i].model.Contains( search ) || mirror[i].cost.ToString().Contains( cost.ToString()))
                {

                    //this adds the item if its a match to the empty list
                    searchList.Add(mirror[i]);
                }

                


            }

            //this passes the list and search string into the second form
            searchForm searchForm = new searchForm(searchList, search);
            searchForm.ShowDialog();
        }

      

        


    }

}
