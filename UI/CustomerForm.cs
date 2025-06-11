using BlApi;
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
    public partial class CustomerForm : Form
    {
        IBl _ibl;
        public CustomerForm()
        {
            InitializeComponent();
            _ibl = Factory.Get;
            ShowAllDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowAllDataGridView.MultiSelect = false;
            this.Controls.Add(AddCustomerPanel);
            this.Controls.Add(ShowAllPanel);
            this.Controls.Add(DeleteItemPanel);
            this.Controls.Add(panelShowOneProduct);
            ClearForm();
        }
        private void ClearForm()
        {
            AddCustomerPanel.Visible = false;
            ShowAllPanel.Visible = false;
            DeleteItemPanel.Visible = false;
            panelShowOneProduct.Visible = false;
        }
        private void ShowOneItemBtn_Click(object sender, EventArgs e)
        {
            //AddCustomerPanel.Visible = false;
            //ShowAllPanel.Visible = false;
            //DeleteItemPanel.Visible = false;
            ClearForm();
            panelShowOneProduct.Visible = true;

        }
        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxProductId.Text);
            //dataGridView1ShowProduct.DataSource = bl.Product.Read(id);
            var c = _ibl.Customer.Read(id);
            dataGridView1ShowProduct.DataSource = new List<Customer> { c };


        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            //AddPanel.Visible = false;
            //panelShowOneProduct.Visible = false;
            //ShowAllPanel.Visible = false;
            //AddCustomerPanel.Visible = false;
            dataGridViewShowToDelete.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShowToDelete.MultiSelect = false;
            DeleteItemPanel.Visible = true;
            dataGridViewShowToDelete.DataSource = _ibl.Customer.ReadAll();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            _ibl.Customer.Delete(int.Parse(dataGridViewShowToDelete.CurrentRow.Cells[0].Value.ToString()));

        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            //panelShowOneProduct.Visible = false;
            //AddPanel.Visible = false;
            // DeleteItemPanel.Visible = false;
            // panelShowOneProduct.Visible = false;
            // AddCustomerPanel.Visible = false;
            ClearForm();
            ShowAllPanel.Visible = true;
            if (ShowAllPanel.Parent != null)
            {
                Console.WriteLine("הפאנל בתוך: " + ShowAllPanel.Parent.Name);
                Console.WriteLine("האם הפאנל ההורה גלוי? " + ShowAllPanel.Parent.Visible);
            }
            else
            {
                Console.WriteLine("הפאנל לא בתוך שום פאנל אחר");
            }
            ShowAllDataGridView.DataSource = _ibl.Customer.ReadAll();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Func<Customer, bool> myFilter = (c) => c.name == textBoxChoose.Text; // דוגמה לסינון על פי מחיר
            ShowAllDataGridView.DataSource = _ibl.Customer.ReadAll(myFilter);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            //panelShowOneProduct.Visible = false;
            //AddPanel.Visible = false;
            //DeleteItemPanel.Visible = false;
            //ShowAllPanel.Visible = false;
            //panelShowOneProduct.Visible = false;
            ClearForm();
            AddCustomerPanel.Visible = true;
            addCustomerBtn.Visible = true;
            UpdateCustomerBtn.Visible = false;
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            _ibl.Customer.Create(new Customer(int.Parse(CustomerIdNum.Value.ToString()), NameTxt.Text, PhoneTxt.Text, AdressTxt.Text));
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {

            _ibl.Customer.Update(new Customer(int.Parse(CustomerIdNum.Value.ToString()), NameTxt.Text, PhoneTxt.Text, AdressTxt.Text));
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //DeleteItemPanel.Visible = false;
            //ShowAllPanel.Visible = false;
            //panelShowOneProduct.Visible = false;
            ClearForm();
            addCustomerBtn.Visible = false;
            UpdateCustomerBtn.Visible = true;
            AddCustomerPanel.Visible = true;
        }

        private void ConfirmAddBtn_Click(object sender, EventArgs e)
        {
            _ibl.Customer.Create(new Customer(int.Parse(CustomerIdNum.Value.ToString()), NameTxt.Text, PhoneTxt.Text, AdressTxt.Text));

        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            _ibl.Customer.Update(new Customer(int.Parse(CustomerIdNum.Value.ToString()), NameTxt.Text, PhoneTxt.Text, AdressTxt.Text));

        }
    }
}
