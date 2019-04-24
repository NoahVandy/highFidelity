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
    public partial class searchForm : Form
    {
        public searchForm(List<inventoryItem> searchList, string search)
        {
            InitializeComponent();

            //this sets the label on this form to the string that was passed in from the other form
            lbl_searchResults.Text = "Search results for: " + search;
            //this sets the dgv to the list that was passed in from the other form
            dgv_search.DataSource = searchList; 
        }



    }
}
