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

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idCounter.ToString();
                string size = txtbx_size.Text;
                string stock = txtbx_stock.Text;
                string color = txtbx_color.Text;
                string model = txtbx_model.Text;

                inventoryItem item = new inventoryItem(id, size, stock, color, model);

                lstbx_items.Items.Add(item.ToString() + "\n");
                idCounter++;
            }
            catch
            {

            }
            txtbx_size.Text = "";
            txtbx_stock.Text = "";
            txtbx_color.Text = "";
            txtbx_model.Text = "";

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //lstbx_items.GetSelected();
        }
    }
}
