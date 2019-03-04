using System;
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
                string color = txtbx_stock.Text;
                string name = txtbx_name.Text;

                inventoryItem item = new inventoryItem(id, size, stock, color, name);

                lstbx_items.Items.Add(item.ToString() + "\n");
                idCounter++;
            }
            catch
            {

            }
        }
    }
}
