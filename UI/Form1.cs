namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            MianForm mianForm = new MianForm();
            mianForm.ShowDialog();
        }

        private void SalerBtn_Click(object sender, EventArgs e)
        {
            IsFavoriteCustomer isFavoriteCustomer = new IsFavoriteCustomer();
            isFavoriteCustomer.ShowDialog();
        }
    }
}