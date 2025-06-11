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
using BlImplementation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class ManagerForm : Form
    {
        IBl bl;

        IProduct Ip = new productImplementation();
        public ManagerForm()
        {
            InitializeComponent();
            bl = Factory.Get;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.MultiSelect = false;
            AddPanel.Visible = false;
            ShowAllPanel.Visible = false;
            panelShowOneProduct.Visible = false;
        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {




        }

        private void ShowAllDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            panelShowOneProduct.Visible = false;
            AddPanel.Visible = false;
            DeleteItemPanel.Visible = false;
            ShowAllPanel.Visible = true;
            ShowAllDataGridView.DataSource = Ip.ReadAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            ShowAllPanel.Visible = false;
            panelShowOneProduct.Visible = false;
            DeleteItemPanel.Visible = false;
            CodeLbl.Visible = false;
            dataGridViewProduct.Visible = true;
            IdTxt.Visible = false;
            ChooseItemBtn.Visible = false;
            dataGridViewProduct.Visible = false;
            categoryCOmboBox.DataSource = Enum.GetValues(typeof(BO.Categories));
        }

        private void ConfirmAddBtn_Click(object sender, EventArgs e)
        {
            Ip.Create(new Product(0, nameTxt.Text, (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryCOmboBox.Text), (double)(PriceNumericUpDown.Value), (int?)(quantityNumericUpDown.Value)));
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            CodeLbl.Visible = true;
            IdTxt.Visible = true;
            ChooseItemBtn.Visible = true;
            dataGridViewProduct.Visible = true;
            ShowAllPanel.Visible = false;
            ConfirmAddBtn.Visible = false;
            panelShowOneProduct.Visible = false;
            DeleteItemPanel.Visible = false;
            dataGridViewProduct.DataSource = Ip.ReadAll();
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewRow selectedRow = dataGridViewProduct.CurrentRow;

        }

        private void ChooseItemBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewProduct.CurrentRow;
            IdTxt.Text = selectedRow.Cells[0].Value.ToString();
            nameTxt.Text = selectedRow.Cells[1].Value.ToString();
            categoryCOmboBox.Text = selectedRow.Cells[2].Value.ToString();
            PriceNumericUpDown.Value = (int.Parse)(selectedRow.Cells[3].Value.ToString());
            quantityNumericUpDown.Value = int.Parse(selectedRow.Cells[4].Value.ToString());

        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            Ip.Update(new Product(int.Parse(IdTxt.Text), nameTxt.Text, (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryCOmboBox.Text), (double)(PriceNumericUpDown.Value), (int?)(quantityNumericUpDown.Value)));

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteItemPanel.Visible = true;
            AddPanel.Visible = false;
            ShowAllPanel.Visible = false;
            panelShowOneProduct.Visible = false;
            dataGridViewShowToDelete.DataSource = Ip.ReadAll();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            Ip.Delete(int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString()));
        }

        private void ShowOneItemBtn_Click(object sender, EventArgs e)
        {
            panelShowOneProduct.Visible = true;
            AddPanel.Visible = false;
            ShowAllPanel.Visible = false;
            DeleteItemPanel.Visible = false;

        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxProductId.Text);
            //dataGridView1ShowProduct.DataSource = bl.Product.Read(id);
            var product = bl.Product.Read(id);
            dataGridView1ShowProduct.DataSource = new List<Product> { product };


        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Func<Product, bool> myFilter = (product) => product.name == textBoxChoose.Text; // דוגמה לסינון על פי מחיר
            ShowAllDataGridView.DataSource = bl.Product.ReadAll(myFilter);
        }

        private void dataGridViewShowToDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
