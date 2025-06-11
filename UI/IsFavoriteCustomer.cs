


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
    public partial class IsFavoriteCustomer : Form
        
    {
       IBl Bl;
        public IsFavoriteCustomer()
        {
            InitializeComponent();
            Bl = Factory.Get;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonFindCus_Click(object sender, EventArgs e)
        {
          Customer customer= Bl.Customer.Read(int.Parse(textBoxIdCus.Text.ToString()));
            //SalerForm salerForm=new SalerForm((DO.Customer)customer.);
            bool isFavorite = customer != null?true:false;
            SalerForm salerForm = new SalerForm(isFavorite);
            salerForm.ShowDialog();
        }
    }
}
