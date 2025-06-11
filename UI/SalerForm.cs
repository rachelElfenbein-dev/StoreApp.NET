using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;

namespace UI
{
    public partial class SalerForm : Form
    {
        IBl _ibl;
        Order order;
        List<ProductInOrder> productsInOrder = new List<ProductInOrder>();
        public SalerForm(bool IsFavorite)
        {
            _ibl = Factory.Get;
            InitializeComponent();
            dataGridViewShowAllProduct.DataSource = _ibl.Product.ReadAll();
            dataGridViewShowAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShowAllProduct.MultiSelect = false;
            order = new Order(IsFavorite, productsInOrder, 0);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            dataGridViewShowAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewRow selectedRow = dataGridViewShowAllProduct.CurrentRow;
            textBoxChooseItem.Text = selectedRow.Cells[0].Value.ToString();
            listProducts.Items.Add(selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[3].Value.ToString());
            List<SaleInProduct> sales = _ibl.Order.AddProductToOrder(order, int.Parse(selectedRow.Cells[0].Value.ToString()), 1);
            foreach (SaleInProduct s in sales)
            {
                listSales.Items.Add("קוד מבצע:" + s.id + " " + s.amountForSale + " " + " " + s.price);
            }
        }

        private void DoOrderBtn_Click(object sender, EventArgs e)
        {
            _ibl.Order.DoOrder(order);
        }
    }
}
    

