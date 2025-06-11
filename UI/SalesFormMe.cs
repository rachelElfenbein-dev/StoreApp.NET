using BlApi;
using BlImplementation;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SalesFormMe : Form
    {
        IBl bl;
        ISale Is = new SaleImplementation();
        public SalesFormMe()
        {
            InitializeComponent();
            bl = Factory.Get;
        }

        private void ShowOneItemBtn_Click(object sender, EventArgs e)
        {
            panelAddSale.Visible=false;
            ShowAllPanel.Visible = false;
            panelShowOneProduct.Visible = true;
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(textBoxProductId.Text);
            var sale = bl.Sale.Read(id);
            dataGridView1ShowProduct.DataSource = new List<Sale> { sale };
        }
        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            panelAddSale.Visible = false;
            panelShowOneProduct.Visible = false;
            ShowAllPanel.Visible = true;
            ShowAllDataGridView.DataSource = Is.ReadAll();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Func<Sale, bool> myFilter = (product) => product.productId == int.Parse(textBoxChoose.Text); // דוגמה לסינון על פי מחיר
            ShowAllDataGridView.DataSource = bl.Sale.ReadAll(myFilter);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            panelShowOneProduct.Visible = false;
            ShowAllPanel.Visible = false;
            panelAddSale.Visible = true;




        }
    }
}
