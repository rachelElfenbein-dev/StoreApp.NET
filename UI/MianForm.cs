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
    public partial class MianForm : Form
    {
        public MianForm()
        {
            InitializeComponent();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.ShowDialog();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void SaleBtn_Click(object sender, EventArgs e)
        {
            SalesFormMe saleForm = new SalesFormMe();
            saleForm.ShowDialog();
        }
    }
}
