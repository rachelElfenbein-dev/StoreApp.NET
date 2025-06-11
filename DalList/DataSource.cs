
namespace Dal;

using DO;
static internal class DataSource
{
    internal class Config
    {   
        internal const int RUNNING_NUM_PRODUCT=1000;
        internal const int RUNNING_NUM_SALE = 200;
        static private int running_num_product = RUNNING_NUM_PRODUCT;
        static private int running_num_sale = RUNNING_NUM_SALE;
        static public int GetRunning_num_product => running_num_product += 100;
       static public int GetRunning_num_sale=> running_num_sale+=10;
    }
    static internal List<Product?>products= new List<Product?> ();
    static internal List<Customer?> customers = new List<Customer?>();
    static internal List<Sale?> sales = new List<Sale?>();
}
